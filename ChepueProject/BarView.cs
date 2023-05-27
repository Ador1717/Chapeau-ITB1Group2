using ChepueModel;
using ChepueService;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ChepueProject
{
    public partial class BarView : Form
    {
        private List<OrderItem> GetBars()
        {
            BarService barService = new BarService();
            List<OrderItem> bars = barService.GetBars();
            return bars;
        }

        private void DisplayBars()
        {
            List<OrderItem> bars = GetBars();

            // Clearing the list before displaying
            listBarView.Items.Clear();

            foreach (OrderItem bar in bars)
            {
                ListViewItem li = new ListViewItem(bar.OrderId.ToString());
                li.Tag = bar;

                li.SubItems.Add(bar.OrderItemId.ToString());
                li.SubItems.Add(bar.Quantity.ToString());
                li.SubItems.Add(bar.Comment.ToString());

                listBarView.Items.Add(li);
            }
        }

        private void DisplayOrderDetails(OrderItem bar)
        {
            listStatusView.Items.Clear();

            ListViewItem li = new ListViewItem(bar.OrderId.ToString());
            li.SubItems.Add(bar.Status.ToString());
            listStatusView.Items.Add(li);
        }


        private void listBarView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBarView.SelectedItems.Count > 0)
            {
                OrderItem selectedRow = (OrderItem)listBarView.SelectedItems[0].Tag;
                DisplayOrderDetails(selectedRow);
            }
        }

        public BarView()
        {
            InitializeComponent();
            DisplayBars();
            listBarView.SelectedIndexChanged += listBarView_SelectedIndexChanged;
        }

        private void preperationBtn_Click(object sender, EventArgs e)
        {
            if (listBarView.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listBarView.SelectedItems[0].Tag;
                selectedBar.Status = Status.InPreparation;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar); ;
            }
        }

        private void preparedBtn_Click(object sender, EventArgs e)
        {
            if (listBarView.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listBarView.SelectedItems[0].Tag;
                selectedBar.Status = Status.Ready;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar);
            }
        }

        private void servedBtn_Click(object sender, EventArgs e)
        {
            if (listBarView.SelectedItems.Count > 0)
            {
                OrderItem selectedBar = (OrderItem)listBarView.SelectedItems[0].Tag;
                selectedBar.Status = Status.Delivered;
                UpdateStatusInDatabase(selectedBar);
                DisplayOrderDetails(selectedBar);
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
