using ChepueDAL;
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
    public partial class KitchenBarView : Form
    {
        private List<OrderItem> GetOrders()
        {
            BarService barService = new BarService();
            List<OrderItem> orders = barService.GetOrders();
            return orders;
        }

        private Employee currentEmployee;

        OrderDao orderDao = new OrderDao();

        private void DisplayBars()
        {
            List<OrderItem> orders = GetOrders();

            foreach (OrderItem order in orders)
            {
                if (currentEmployee.Role == "Chef" && (Category.Desert == order.Category || Category.Starter == order.Category || Category.Main == order.Category) && order.Status != Status.Delivered)
                {
                    ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                    li.Tag = order;

                    li.SubItems.Add(order.OrderItemId.ToString());
                    li.SubItems.Add(order.Quantity.ToString());
                    li.SubItems.Add(order.Comment.ToString());

                    bartenderKitchenView.Items.Add(li);
                }
                else if (currentEmployee.Role == "Bartender" && (Category.Desert != order.Category || Category.Starter != order.Category || Category.Main != order.Category) && order.Status != Status.Delivered)
                {
                    ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                    li.Tag = order;

                    li.SubItems.Add(order.OrderItemId.ToString());
                    li.SubItems.Add(order.Quantity.ToString());
                    li.SubItems.Add(order.Comment.ToString());

                    bartenderKitchenView.Items.Add(li);
                }
            }
        }

        private void UpdateOrderListView(List<OrderItem> orders)
        {
            bartenderKitchenView.Items.Clear();

            foreach (OrderItem order in orders)
            {
                if (order.Status != Status.Delivered)
                {
                    if (currentEmployee.Role == "Chef" && (Category.Desert == order.Category || Category.Starter == order.Category || Category.Main == order.Category))
                    {
                        ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                        li.Tag = order;

                        li.SubItems.Add(order.OrderItemId.ToString());
                        li.SubItems.Add(order.Quantity.ToString());
                        li.SubItems.Add(order.Comment.ToString());

                        bartenderKitchenView.Items.Add(li);
                    }
                    else if (currentEmployee.Role == "Bartender")
                    {
                        ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                        li.Tag = order;

                        li.SubItems.Add(order.OrderItemId.ToString());
                        li.SubItems.Add(order.Quantity.ToString());
                        li.SubItems.Add(order.Comment.ToString());

                        bartenderKitchenView.Items.Add(li);
                    }


                }
            }
        }


        private void DisplayBarDetails(OrderItem order)
        {
            barKitchenStatusView.Items.Clear();

            ListViewItem li = new ListViewItem(order.ItemName.ToString());
            li.SubItems.Add(order.Status.ToString());
            li.SubItems.Add(order.OrderItemId.ToString());

            TimeSpan preparationTime;

            if (order.Status == Status.InPreperation)
            {
                preparationTime = DateTime.Now - order.Order.OrderTime;
            }
            else if (order.Status == Status.Ready || order.Status == Status.Delivered)
            {
                preparationTime = order.Order.OrderEndTime - order.Order.OrderTime;
            }
            else
            {
                preparationTime = TimeSpan.Zero;
            }

            double totalHours = preparationTime.TotalHours;
            int hoursPart = (int)totalHours;
            double minutesPart = (totalHours - hoursPart) * 60;
            string formattedTime = $"{hoursPart} hours {minutesPart:0.##} minutes";

            li.SubItems.Add(formattedTime); // Adding the formatted time to the ListView item

            barKitchenStatusView.Items.Add(li);

            barTableNum.Text = order.Table.TableId.ToString();
        }




        private void bartenderStatusView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bartenderKitchenView.SelectedItems.Count > 0)
            {
                OrderItem selectedRow = (OrderItem)bartenderKitchenView.SelectedItems[0].Tag;
                DisplayBarDetails(selectedRow);
            }
        }


        public KitchenBarView(Employee employee)
        {
            InitializeComponent();
            currentEmployee = employee;

            if (currentEmployee.Role == "Chef")
            {
                barKitchenLabel.Text = "Kitchen View";
            }
            else if (currentEmployee.Role == "Bartender")
            {
                barKitchenLabel.Text = "Bar View";
            }
            DisplayBars();
            bartenderKitchenView.SelectedIndexChanged += bartenderStatusView_SelectedIndexChanged;
        }

        private void barButtonPrepare_Click(object sender, EventArgs e)
        {
            OrderItem selectedBar = (OrderItem)bartenderKitchenView.SelectedItems[0].Tag;
            selectedBar.Status = Status.InPreperation;
            orderDao.UpdateStatusInDatabase(selectedBar);
            DisplayBarDetails(selectedBar); ;
        }

        private void barButtonPrepared_Click(object sender, EventArgs e)
        {

                OrderItem selectedBar = (OrderItem)bartenderKitchenView.SelectedItems[0].Tag;
            selectedBar.Status = Status.Ready;
            orderDao.UpdateStatusInDatabase(selectedBar);
            DisplayBarDetails(selectedBar); 
        }

        private void barButtonServed_Click(object sender, EventArgs e)
        {
            if (bartenderKitchenView.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = bartenderKitchenView.SelectedItems[0];
                OrderItem selectedBar = (OrderItem)selectedRow.Tag;
                selectedBar.Status = Status.Delivered;
                selectedBar.Order.OrderEndTime = DateTime.Now;
                orderDao.UpdateOrderEndTime(selectedBar.Order.OrderID);
                orderDao.UpdateStatusInDatabase(selectedBar);
                DisplayBarDetails(selectedBar);

                bartenderKitchenView.Items.Remove(selectedRow);
            }
        }



        private void orderHistory_Click(object sender, EventArgs e)
        {
            listViewHistory.Items.Clear();

            List<OrderItem> orders = GetOrders();
            List<OrderItem> filteredOrders = new List<OrderItem>();

            foreach (OrderItem order in orders)
            {
                if (currentEmployee.Role == "Chef" &&
                   (order.Category == Category.Desert || order.Category == Category.Starter || order.Category == Category.Main))
                {
                    filteredOrders.Add(order);
                }
                else if (currentEmployee.Role == "Bartender" &&
                        !(order.Category == Category.Desert || order.Category == Category.Starter || order.Category == Category.Main))
                {
                    filteredOrders.Add(order);
                }
            }

            foreach (OrderItem order in filteredOrders)
            {
                ListViewItem li = new ListViewItem(order.Order.OrderID.ToString());
                li.Tag = order;

                li.SubItems.Add(order.ItemName);

                li.SubItems.Add(order.Order.OrderTime.ToString());

                if (order.Order.OrderEndTime > DateTime.MinValue)
                {
                    li.SubItems.Add(order.Order.OrderEndTime.ToString());

                    TimeSpan totalTime = order.Order.OrderEndTime - order.Order.OrderTime;
                    li.SubItems.Add($"{totalTime.Hours} hours , {totalTime.Minutes} minutes");
                }
                else
                {
                    li.SubItems.Add("Not ended yet");
                    li.SubItems.Add("N/A");
                }

                listViewHistory.Items.Add(li);
            }

            BarView.Hide();
            panelOrderHistory.Show();
        }


        private void backHistoryBtn_Click(object sender, EventArgs e)
        {
            panelOrderHistory.Hide();
            BarView.Show();
        }

        private List<OrderItem> SortOrdersByItemNumber(List<OrderItem> orders)
        {
            OrderItem temp;

            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < orders.Count - 1; j++)
                {
                    if (orders[j].OrderItemId > orders[j + 1].OrderItemId)
                    {
                        temp = orders[j + 1];
                        orders[j + 1] = orders[j];
                        orders[j] = temp;
                    }
                }
            }

            return orders;
        }

        private List<OrderItem> SortOrdersByStatus(List<OrderItem> orders)
        {
            OrderItem temp;

            for (int i = 0; i < orders.Count; i++)
            {
                for (int j = 0; j < orders.Count - 1; j++)
                {
                    if ((int)orders[j].Status > (int)orders[j + 1].Status)
                    {
                        temp = orders[j + 1];
                        orders[j + 1] = orders[j];
                        orders[j] = temp;
                    }
                }
            }

            return orders;
        }

        List<OrderItem> lastSortedOrders = new List<OrderItem>();
        string lastSortOption = string.Empty;


        private void sortButton_Click(object sender, EventArgs e)
        {
            // Get the selected sorting option from the ComboBox
            string selectedSortOption = sortBox.SelectedItem.ToString();

            // Initialize the sortedOrders list
            List<OrderItem> sortedOrders = new List<OrderItem>();

            if (selectedSortOption == lastSortOption)
            {
                // If the selected option is the same as the last one, simply reverse the list
                sortedOrders = lastSortedOrders.AsEnumerable().Reverse().ToList();
            }
            else
            {
                // Sort the orders based on the selected option
                if (selectedSortOption == "Item number")
                {
                    sortedOrders = SortOrdersByItemNumber(GetOrders());
                }
                else if (selectedSortOption == "Status")
                {
                    sortedOrders = SortOrdersByStatus(GetOrders());
                }
                else
                {
                    sortedOrders = GetOrders();
                }
            }

            UpdateOrderListView(sortedOrders);

            lastSortedOrders = sortedOrders;
            lastSortOption = selectedSortOption;
        }
    }
}
