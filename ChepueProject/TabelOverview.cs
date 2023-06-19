using Chapeau.Properties;
using ChepueModel;
using ChepueService;
using ChepueModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapeauUI.Components;

namespace Chapeau
{
    public partial class TabelOverview : Form
    {
        TableService tableService;
        private int tableNumber = 1;
        Employee employee;
        private List<Tuple<Button, Table>> tables = new List<Tuple<Button, Table>>();
        public TabelOverview(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            tableService = new TableService();
            List<Table> allTables = tableService.GetAllTables();

            int buttonWidth = 115;
            int buttonHeight = 75;
            int padding = 20;

            // Variables to store the x and y coordinates for each button.
            int x = 50;
            int y = 100;

            // Variables to keep track of the current row and column.
            int row = 0;
            int column = 0;

            // Maximum number of buttons per row.
            int buttonsPerRow = 2;

            // List<Table> allTables = tableService.GetAllTables();

            foreach (Table table in allTables)
            {
                Button btn = new Button();
                btn.Text = $"Table {table.TableId}";
                btn.Tag = table;
                btn.Click += new EventHandler(btnTb2_Click);
                btn.Width = buttonWidth;
                btn.Height = buttonHeight;
                btn.Left = x + (column * (buttonWidth + padding));
                btn.Top = y + (row * (buttonHeight + padding));

                pnlTableOverView.Controls.Add(btn);
                tables.Add(new Tuple<Button, Table>(btn, table));

                // Increment the column counter.
                column++;

                // If the maximum number of buttons per row has been added, reset the column counter and increment the row counter.
                if (column >= buttonsPerRow)
                {
                    column = 0;
                    row++;
                }
            }
        }
        private void UpdateTableStatuses()
        {
            //List<bool> tableStatuses = tableService.TableOccupied(1, tables.Count);
            for (int i = 0; i < tables.Count; i++)
            {
                if (tableService.TableOccupied(i + 1))
                {
                    tables[i].Item1.BackColor = Color.Red;
                    tables[i].Item2.Is_Occupied = true;
                }
                //   tables[i].Item2.OrderStatus = Service.GetOrderStatus(i + 1);
                else
                {
                    tables[i].Item1.BackColor = Color.Green;
                    tables[i].Item2.Is_Occupied = false;
                }
            }
        }
        private void TabelOverview_Load(object sender, EventArgs e)
        {
            tab_UiControl.SelectedTab = tab_Table;

            UpdateTableStatuses();
        }
        private void OpenTableDetailPanel(int tableNumber)
        {
            // Update the table number label on the table detail panel
            txtTableNr.Text = "Table " + tableNumber;

            bool isOccupied = tableService.TableOccupied(tableNumber);

            rbOccupied.Checked = isOccupied;
            rbFree.Checked = !isOccupied;
            pnlTableOverView.Visible = false;
            pnlTableDetail.Visible = true;

            /*DateTime startTime = orderService.GetOrderStartTime(tableNumber);
            if (startTime != DateTime.MinValue) // if there is a start time
            {
                TimeSpan waitingTime = DateTime.Now - startTime;
                lbl_CurrentWaitTime.Text = $"Waiting time: {waitingTime.Minutes} minutes";
            }
            else
            {
                lbl_CurrentWaitTime.Text = string.Empty;
            }*/
        }


        private void btnRetrun_TableOverView_Click(object sender, EventArgs e)
        {
            pnlTableOverView.Visible = true;
            pnlTableDetail.Visible = false;
        }

        private void rbFree_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFree.Checked)
            {
                tables[tableNumber - 1].Item2.Is_Occupied = false;
                tableService.SetTableFree(tableNumber);
                tables[tableNumber - 1].Item1.BackColor = Color.Green;
            }
        }

        private void rbOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOccupied.Checked)
            {
                tables[tableNumber - 1].Item2.Is_Occupied = true;
                tableService.SetTableOccupied(tableNumber);
                tables[tableNumber - 1].Item1.BackColor = Color.Red;
            }
        }

        private void btnTakeOrder_Click(object sender, EventArgs e)
        {
            if (tables[tableNumber - 1].Item2.Is_Occupied)
            {
                tabPage2.Show();
            }
            else
            {
                MessageBox.Show("You can't take order from a free table.");
            }
        }
        private void btnTb2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Table table = (Table)btn.Tag;
            if (btn.Tag == null)
            {
                // Log error or show message box, then return
                MessageBox.Show("No table associated with this button.");
                return;
            }
            tableNumber = table.TableId;
            OpenTableDetailPanel(tableNumber);

            //lblOrderStatus.Text = "Order status: " + table.OrderStatus;
        }

        private void pnlTableOverView_Paint(object sender, PaintEventArgs e)
        {

        }


        private void SelectedTabChanged(object sender, EventArgs e)
        {
            switch (tab_UiControl.SelectedIndex)
            {
                case 0:
                    {
                        UpdateTableStatuses();
                    }
                    break;
                case 1:
                    {

                    }
                    break;

            }
        }

        private void pnlTableDetail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrder_Served_Click(object sender, EventArgs e)
        {
            //tableService.SetOrderServed(tableNumber);

            // Update the table status in the database
            tableService.SetTableFree(tableNumber);

            // Update the order status and table status on the form
            // tables[tableNumber - 1].Item2.OrderStatus = "Served";
            tables[tableNumber - 1].Item2.Is_Occupied = false;
            tables[tableNumber - 1].Item1.BackColor = Color.Green; // Assuming green indicates a free table

            lblOrderStatus.Text = "Order status: Served";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            TabelOverview tabelOverview = new TabelOverview(employee);
            tabelOverview.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
            Hide();

        }
        //LUCAS PART
        private void LunchMenuBtn_Click(object sender, EventArgs e)
        {
            // Request the lunch menu
            if (currentCategory != MenuCategory.Lunch)
            {
                // Set new current category 
                currentCategory = MenuCategory.Lunch;

                // Display menu
                DisplayMenu(MenuCategory.Lunch);
            }
        }

        private void DinnerMenuBtn_Click(object sender, EventArgs e)
        {
            if (currentCategory != MenuCategory.Dinner)
            {
                // Set new current category
                currentCategory = MenuCategory.Dinner;

                // Display menu
                DisplayMenu(MenuCategory.Dinner);
            }
        }

        private void DrinksMenuBtn_Click(object sender, EventArgs e)
        {
            // Request the drinks menu
            if (currentCategory != MenuCategory.Drinks)
            {
                // Set new current category
                currentCategory = MenuCategory.Drinks;

                // Display menu
                DisplayMenu(MenuCategory.Drinks);
            }
        }

        MenuService menuService;
        OrderService orderService;
        Random rnd;

        // Variables Order Overview
        private MenuCategory currentCategory = MenuCategory.Lunch;
        private double totalOrderPrice = 0.00;

        // Menus
        public List<MenuItem> lunchMenu;
        public List<MenuItem> dinnerMenu;
        public List<MenuItem> drinksMenu;

        // Order items and display component
        public List<Tuple<OrderItem, Component_OrderItem>> orderItems;

        private void DisplayMenu(MenuCategory menuCategory)
        {
            // Clear previous menu before loading new menu
            flowMenu.Controls.Clear();

            // Create new list of menuItems to display
            List<MenuItem> menuItems;

            // Fill list with items
            if (menuCategory == MenuCategory.Lunch) { menuItems = lunchMenu; }
            else if (menuCategory == MenuCategory.Dinner) { menuItems = dinnerMenu; }
            else { menuItems = drinksMenu; }

            // Display menu items and sub category titles
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == 0 || (menuItems[i].SubCategory != menuItems[i - 1].SubCategory))
                {
                    // Add sub category title
                    Component_MenuItem_Category categoryTitle = new Component_MenuItem_Category(menuItems[i].SubCategory);
                    flowMenu.Controls.Add(categoryTitle);
                }

                // Add menu item
                Component_MenuItem c_MenuItem = new Component_MenuItem(this, menuItems[i]);
                flowMenu.Controls.Add(c_MenuItem);
            }
        }


        //ORDER VIEW
        private void LoadMenu()
        {
            // Initialize orderItems
            orderItems = new List<Tuple<OrderItem, Component_OrderItem>>();

            // Reload when opening order view in case of management changing product information
            // Fill menus with items
            try
            {
                lunchMenu = menuService.GetMenuItems(MenuCategory.Lunch);
                dinnerMenu = menuService.GetMenuItems(MenuCategory.Dinner);
                drinksMenu = menuService.GetMenuItems(MenuCategory.Drinks);
            }
            catch (Exception ex)
            {
                // Log error and display message
                //DisplayError(ex);
            }

            // Load menu diplay
            DisplayMenu(MenuCategory.Lunch);
        }




        //Add Quantity
        public void AddToOrderQuantity(int itemID)
        {
            // Check if item already exists in order list
            foreach (Tuple<OrderItem, Component_OrderItem> item in orderItems)
            {
                if (item.Item1.ItemID == itemID)
                {
                    // Add to quantity
                    item.Item1.Quantity++;
                    item.Item2.Quantity++;

                    // Update display
                    item.Item2.UpdateInfo();

                    // Add to total price
                    UpdateTotalPrice(item.Item1.Price);
                    return;
                }
            }
        }

        //Remove Queantity
        public void RemoveFromOrderQuantity(int itemID)
        {
            // Check what item has the ID
            for (int i = orderItems.Count - 1; i >= 0; i--)
            {
                if (orderItems[i].Item1.ItemID == itemID)
                {
                    // Remove one from the quantity
                    orderItems[i].Item1.Quantity--;
                    orderItems[i].Item2.Quantity--;

                    // Update the display information
                    orderItems[i].Item2.UpdateInfo();

                    // Remove from the total price
                    UpdateTotalPrice(-orderItems[i].Item1.Price);
                }

                // If the quantity is 0
                if (orderItems[i].Item1.Quantity == 0)
                {
                    // Remove from orderItems
                    orderItems.RemoveAt(i);



                    return;
                }

            }
        }

        public void AddNewOrderItem(MenuItem menuItem)
        {
            bool itemExists = false;

            // Check if item already exists in order list
            foreach (Tuple<OrderItem, Component_OrderItem> item in orderItems)
            {
                // If the item has already been added...
                if (item.Item1.ItemID == menuItem.ItemID)
                {
                    itemExists = true;
                    break;
                }
            }

            // If item doesn't exist, create a new orderItem
            if (!itemExists)
            {
                // Create new orderItem object with the ID
                OrderItem orderItem = new OrderItem(menuItem.ItemID, menuItem.Price);

                // Create new OrderItem component 
                // Requires first to get the MenuItem object with the ID 
                Component_OrderItem orderDisplayItem = new Component_OrderItem(this, menuItem.ItemID, menuItem.FullName, menuItem.Price);

                // Add new Tuple with OrderItem object and C_Order_OrderItem component to list
                orderItems.Add(new Tuple<OrderItem, Component_OrderItem>(orderItem, orderDisplayItem));

                // Add component to order list
                flowOrder.Controls.Add(orderDisplayItem);

                // Add to total price
                UpdateTotalPrice(orderItem.Price);


            }

            else
            {
                AddToOrderQuantity(menuItem.ItemID);
            }
        }


        //UPDATE FINAL PRICE
        private void UpdateTotalPrice(double price)
        {
            // Adjust total price
            totalOrderPrice = totalOrderPrice + price;

            // Update display
            lbl_TotalPrice.Text = $"Total: €{totalOrderPrice:F2}";
        }

        //ADD COMMENT
        public void AddOrderComment(int itemID, string comment)
        {
            // Check for item location
            foreach (Tuple<OrderItem, Component_OrderItem> item in orderItems)
            {
                // If the item has already been added
                if (item.Item1.ItemID == itemID)
                {
                    // Add comment to item
                    item.Item1.Comment = comment;
                    return;
                }
            }
        }

        private void orderViewPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
