using ChepueModel;
using ChepueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChepueUI
{
    public partial class KitchenView : Form
    {
        private List<OrderItem> GetOrders()
        {
            BarService barService = new BarService();
            List<OrderItem> orders = barService.GetOrders();
            return orders;
        }

        private void DisplayBars()
        {
            List<OrderItem> orders = GetOrders();

            listViewKitchen.Items.Clear();

            foreach (OrderItem order in orders)
            {
                if (order.OrderItemId > 9)
                {
                    ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                    li.Tag = order;

                    li.SubItems.Add(order.OrderItemId.ToString());
                    li.SubItems.Add(order.Quantity.ToString());
                    li.SubItems.Add(order.Comment.ToString());

                    listViewKitchen.Items.Add(li);
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

        private void DisplayKitchenDetails(OrderItem order)
        {
            listViewStatus.Items.Clear();

            ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
            li.SubItems.Add(order.Status.ToString());
            listViewStatus.Items.Add(li);

            tableNum.Text = $"{order.Order.Table.TableNumber}";

        }

        private void DisplayBarDetails(OrderItem order)
        {
            bartenderStatusView.Items.Clear();

            ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
            li.SubItems.Add(order.Status.ToString());
            bartenderStatusView.Items.Add(li);

            barTableNum.Text = $"{order.Order.Table.TableNumber}";
        }


        private void listKitchenView_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderItem selectedRow = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
            DisplayKitchenDetails(selectedRow);
        }
        private void bartenderStatusView_SelectedIndexChanged(object sender, EventArgs e)
        {

            OrderItem selectedRow = (OrderItem)bartenderView.SelectedItems[0].Tag;
            DisplayBarDetails(selectedRow);
        }


        public KitchenView()
        {
            InitializeComponent();
            DisplayBars();
            listViewKitchen.SelectedIndexChanged += listKitchenView_SelectedIndexChanged;
            bartenderView.SelectedIndexChanged += bartenderStatusView_SelectedIndexChanged;
        }

        private void btnPreperation_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
            selectedBar.Status = Status.InPreparation;
            UpdateStatusInDatabase(selectedBar);
            DisplayKitchenDetails(selectedBar); ;
        }

        private void prepearedBtn_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
            selectedBar.Status = Status.Ready;
            UpdateStatusInDatabase(selectedBar);
            DisplayKitchenDetails(selectedBar); ;
        }

        private void servedBtn_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
            selectedBar.Status = Status.Delivered;
            UpdateStatusInDatabase(selectedBar);
            DisplayKitchenDetails(selectedBar); ;
        }

        private void UpdateStatusInDatabase(OrderItem bar)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ChepueDatabase"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE Order_Item SET Status = @Status WHERE OrderItemId = @OrderItemId";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Status", bar.Status.ToString());
                    command.Parameters.AddWithValue("@OrderItemId", bar.OrderItemId);
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
            DisplayBarDetails(selectedBar); ;
        }

        private void barButtonPrepared_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)bartenderView.SelectedItems[0].Tag;
            selectedBar.Status = Status.Ready;
            UpdateStatusInDatabase(selectedBar);
            DisplayBarDetails(selectedBar); ;
        }

        private void barButtonServed_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)bartenderView.SelectedItems[0].Tag;
            selectedBar.Status = Status.Delivered;
            UpdateStatusInDatabase(selectedBar);
            DisplayKitchenDetails(selectedBar); ;
        }

    }
}
