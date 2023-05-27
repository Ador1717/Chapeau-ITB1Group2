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
        private List<OrderItem> GetKitchenOrders()
        {
            BarService barService = new BarService();
            List<OrderItem> bars = barService.GetBars();
            return bars;
        }

        private void DisplayBars()
        {
            List<OrderItem> bars = GetKitchenOrders();

            // Clearing the list before displaying
            listViewKitchen.Items.Clear();

            foreach (OrderItem bar in bars)
            {
                ListViewItem li = new ListViewItem(bar.OrderId.ToString());
                li.Tag = bar;

                li.SubItems.Add(bar.OrderItemId.ToString());
                li.SubItems.Add(bar.Quantity.ToString());
                li.SubItems.Add(bar.Comment.ToString());

                listViewKitchen.Items.Add(li);
            }
        }

        private void DisplayOrderDetails(OrderItem bar)
        {
            listViewStatus.Items.Clear();

            ListViewItem li = new ListViewItem(bar.OrderId.ToString());
            li.SubItems.Add(bar.Status.ToString());
            listViewStatus.Items.Add(li);
        }


        private void listKitchenView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewKitchen.SelectedItems.Count > 0)
            {
                OrderItem selectedRow = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
                DisplayOrderDetails(selectedRow);
            }
        }
        public KitchenView()
        {
            InitializeComponent();
            DisplayBars();
            listViewKitchen.SelectedIndexChanged += listKitchenView_SelectedIndexChanged;
        }

        private void btnPreperation_Click(object sender, EventArgs e)
        {
            if (listViewKitchen.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
                selectedBar.Status = Status.InPreparation;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar); ;
            }
        }

        private void prepearedBtn_Click(object sender, EventArgs e)
        {
            if (listViewKitchen.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
                selectedBar.Status = Status.Ready;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar); ;
            }
        }

        private void servedBtn_Click(object sender, EventArgs e)
        {
            if (listViewKitchen.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listViewKitchen.SelectedItems[0].Tag;
                selectedBar.Status = Status.Delivered;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar); ;
            }
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
    }
}
