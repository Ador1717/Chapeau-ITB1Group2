using Chapeau.Properties;
using ChepueModel;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
