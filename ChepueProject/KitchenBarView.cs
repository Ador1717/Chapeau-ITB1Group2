using ChepueModel;
using ChepueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ChepueUI
{
    public partial class KitchenBarView : Form
    {
        private Dictionary<OrderItem, Stopwatch> orderStopwatches = new Dictionary<OrderItem, Stopwatch>(); // I should use the order was enterd and subrtract with the current time so it can show the waiting time

        private List<OrderItem> GetOrders()
        {
            BarService barService = new BarService();
            List<OrderItem> orders = barService.GetBars();
            return orders;
        }

        private void DisplayBars()
        {
            List<OrderItem> orders = GetOrders();

            foreach (OrderItem order in orders)
            {
                if (order.Status == Status.Delivered)
                {
                    AddToHistory(order);
                }
                else if (order.OrderItemId > 9)
                {
                    ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                    li.Tag = order;

                    li.SubItems.Add(order.OrderItemId.ToString());
                    li.SubItems.Add(order.Quantity.ToString());
                    li.SubItems.Add(order.Comment.ToString());

                }
                else
                {
                    ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                    li.Tag = order;

                    li.SubItems.Add(order.OrderItemId.ToString());
                    li.SubItems.Add(order.Quantity.ToString());
                    li.SubItems.Add(order.Comment.ToString());

                    bartenderView.Items.Add(li);
                }
            }
        }




        private void DisplayBarDetails(OrderItem order)
        {
            bartenderStatusView.Items.Clear();

            ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
            li.SubItems.Add(order.Status.ToString());

            if (order.Status == Status.InPreparation && orderStopwatches.ContainsKey(order))
            {
                Stopwatch stopwatch = orderStopwatches[order];
                string elapsed = String.Format("{0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                li.SubItems.Add(elapsed);
            }
            else
            {
                li.SubItems.Add(String.Empty);
            }

            bartenderStatusView.Items.Add(li);

            barTableNum.Text = order.Table.TableId.ToString();
        }


        private void bartenderStatusView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bartenderView.SelectedItems.Count > 0)
            {
                OrderItem selectedRow = (OrderItem)bartenderView.SelectedItems[0].Tag;
                DisplayBarDetails(selectedRow);
            }
        }

        public KitchenBarView()
        {
            InitializeComponent();
            DisplayBars();
            bartenderView.SelectedIndexChanged += bartenderStatusView_SelectedIndexChanged;

        }


        private void UpdateStatusInDatabase(OrderItem bar, TimeSpan? cookTime = null)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ChepueDatabase"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Order_Item SET Status = @Status";

                // If a cooking time is provided, update it in the CookTime column
                if (cookTime != null)
                {
                    sql += ", CookTime = @CookTime";
                }

                sql += " WHERE OrderItemId = @OrderItemId";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Status", bar.Status.ToString());
                    command.Parameters.AddWithValue("@OrderItemId", bar.OrderItemId);

                    if (cookTime != null)
                    {
                        command.Parameters.AddWithValue("@CookTime", cookTime.Value.TotalSeconds);
                    }

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        private void barButtonPrepare_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)bartenderView.SelectedItems[0].Tag;
            selectedBar.Status = Status.InPreparation;
            UpdateStatusInDatabase(selectedBar);
            DisplayBarDetails(selectedBar);

            Stopwatch stopwatch = new Stopwatch();
            orderStopwatches[selectedBar] = stopwatch;
            stopwatch.Start();
        }

        private void barButtonPrepared_Click(object sender, EventArgs e)
        {
            if (bartenderView.SelectedItems.Count == 0)
                return;

            OrderItem selectedBar = (OrderItem)bartenderView.SelectedItems[0].Tag;
            selectedBar.Status = Status.Ready;

            // Stop stopwatch, calculate elapsed time and remove the stopwatch from the dictionary
            if (orderStopwatches.TryGetValue(selectedBar, out Stopwatch stopwatch))
            {
                stopwatch.Stop();
                TimeSpan elapsed = stopwatch.Elapsed;
                orderStopwatches.Remove(selectedBar);

                // Update database with the status and cooktime
                UpdateStatusInDatabase(selectedBar, elapsed);
            }

            DisplayBarDetails(selectedBar);
        }


        private void barButtonServed_Click(object sender, EventArgs e)
        {
            if (bartenderView.SelectedItems.Count == 0)
                return;

            OrderItem selectedBar = (OrderItem)bartenderView.SelectedItems[0].Tag;
            selectedBar.Status = Status.Delivered;

            // Get stopwatch and stop it
            if (orderStopwatches.TryGetValue(selectedBar, out Stopwatch stopwatch))
            {
                stopwatch.Stop();
                orderStopwatches.Remove(selectedBar);
            }

            UpdateStatusInDatabase(selectedBar);
            DisplayBarDetails(selectedBar);

            // Remove item from bartenderView
            ListViewItem selectedListViewItem = bartenderView.SelectedItems[0];
            bartenderView.Items.Remove(selectedListViewItem);

            // Add to history
            AddToHistory(selectedBar);
        }

        private void orderHistoryBtn_Click(object sender, EventArgs e)
        {
            BarView.Hide();
            orderHistory.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            orderHistory.Hide();
            BarView.Show();
        }

        private void AddToHistory(OrderItem order)
        {
            ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
            li.SubItems.Add(order.Status.ToString());
            li.SubItems.Add(order.Table.TableId.ToString());

            if (orderStopwatches.TryGetValue(order, out Stopwatch stopwatch))
            {
                string elapsed = stopwatch.Elapsed.ToString(@"hh\:mm\:ss");
                li.SubItems.Add(elapsed);
            }
            else
            {
                li.SubItems.Add(string.Empty);
            }

            listViewHistory.Items.Add(li);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
