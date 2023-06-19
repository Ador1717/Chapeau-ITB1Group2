using ChapeauUI.Components;
using ChepueModel;
using ChepueService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChepueUI
{
    public partial class OrderView : Form
    {
        // Services
        MenuService menuService;
        OrderService orderService;
        TableService tableService;
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


        private void btnDinner_Click(object sender, EventArgs e)
        {
            //Request the dinner menu
            if (currentCategory != MenuCategory.Dinner)
            {
                // Set new current category
                currentCategory = MenuCategory.Dinner;

                // Display menu
                DisplayMenu(MenuCategory.Dinner);
            }
        }

        private void btnLunch_Click(object sender, EventArgs e)
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

        private void btnDrinks_Click(object sender, EventArgs e)
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

        private void DinnerMenuBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
