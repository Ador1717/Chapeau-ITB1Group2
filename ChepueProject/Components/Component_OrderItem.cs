
using Chapeau;
using ChepueUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class Component_OrderItem : UserControl
    {
        // OrderView object
        private OrderView orderView;

        // Automatic Properties
        public int ItemID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public TabelOverview TabelOverview { get; }
        public string FullName { get; }

        // Constructor
        public Component_OrderItem(OrderView form, int itemID, string itemName, double price)
        {
            InitializeComponent();

            // Set reference to main form
            orderView = form;

            // Set variables
            ItemID = itemID;
            Price = price;
            Quantity = 1;

            // Set display element text
            lbl_ProductName.Text = itemName;
            UpdateInfo();
        }

        public Component_OrderItem(TabelOverview tabelOverview, int itemID, string fullName, double price)
        {
            TabelOverview = tabelOverview;
            ItemID = itemID;
            FullName = fullName;
            Price = price;
        }

        private void delete_order_btn(object sender, EventArgs e)
        {
            // Remove from item
            orderView.RemoveFromOrderQuantity(ItemID);
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            // Add to item
            orderView.AddToOrderQuantity(ItemID);
        }

        private void AddComment(object sender, EventArgs e)
        {
            // If textbox contains text
            if (!string.IsNullOrEmpty(txtBox_Comment.Text))
            {
                // Add comment to item
                orderView.AddOrderComment(ItemID, txtBox_Comment.Text);
            }
        }

        public void UpdateInfo()
        {
            // If there is an item to display
            if (Quantity != 0)
            {
                // Update display information
                lbl_Count.Text = Quantity.ToString();
                label_TotalPrice.Text = $"€ {Price * Quantity:F2}";
            }
            else
            {
                // Delete self
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
