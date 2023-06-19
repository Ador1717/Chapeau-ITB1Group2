
using Chapeau;
using ChepueModel;
using ChepueUI;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class Component_MenuItem : UserControl
    {
        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#4682B4";

        // Form_Chapeau object
        OrderView orderView;

        // MenuItem object
        public MenuItem menuItem;

        public TabelOverview TabelOverview { get; }

        // Constructor
        public Component_MenuItem(OrderView form, MenuItem item)
        {
            InitializeComponent();

            // Set reference to main form
            orderView = form;

            // Set MenuItem
            menuItem = item;

            // Set and display product information
            lbl_ItemName.Text = menuItem.FullName;
        }

        public Component_MenuItem(TabelOverview tabelOverview, MenuItem menuItem)
        {
            TabelOverview = tabelOverview;
            this.menuItem = menuItem;
        }

        // Click event
        private async void AddItem_Click(object sender, EventArgs e)
        {
            // Add new item
            orderView.AddNewOrderItem(menuItem);

            // Color changing event with delay to simulate button click
            this.BackColor = ColorTranslator.FromHtml(hexColorDark);
            await Task.Delay(10);
            this.BackColor = ColorTranslator.FromHtml(hexColorBright);

            // Set focus to this control's label
            this.ActiveControl = lbl_ItemName;
        }
    }
}
