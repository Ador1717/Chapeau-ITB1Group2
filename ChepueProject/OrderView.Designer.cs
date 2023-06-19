namespace ChepueUI
{
    partial class OrderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LunchMenuBtn = new Button();
            DinnerMenuBtn = new Button();
            DrinksMenuBtn = new Button();
            confirm_order_button = new Button();
            delete_order_btn = new Button();
            flowMenu = new FlowLayoutPanel();
            flowOrder = new FlowLayoutPanel();
            lbl_TotalPrice = new Label();
            Bill_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(210, 23);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 0;
            label1.Text = "Order table 1";
            // 
            // LunchMenuBtn
            // 
            LunchMenuBtn.BackColor = Color.MidnightBlue;
            LunchMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LunchMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            LunchMenuBtn.Location = new Point(27, 66);
            LunchMenuBtn.Name = "LunchMenuBtn";
            LunchMenuBtn.Size = new Size(121, 52);
            LunchMenuBtn.TabIndex = 1;
            LunchMenuBtn.Text = "Lunch";
            LunchMenuBtn.UseVisualStyleBackColor = false;
            // 
            // DinnerMenuBtn
            // 
            DinnerMenuBtn.BackColor = Color.MidnightBlue;
            DinnerMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DinnerMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            DinnerMenuBtn.Location = new Point(221, 66);
            DinnerMenuBtn.Name = "DinnerMenuBtn";
            DinnerMenuBtn.Size = new Size(121, 52);
            DinnerMenuBtn.TabIndex = 2;
            DinnerMenuBtn.Text = "Dinner";
            DinnerMenuBtn.UseVisualStyleBackColor = false;
            DinnerMenuBtn.Click += DinnerMenuBtn_Click;
            // 
            // DrinksMenuBtn
            // 
            DrinksMenuBtn.BackColor = Color.MidnightBlue;
            DrinksMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DrinksMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            DrinksMenuBtn.Location = new Point(404, 66);
            DrinksMenuBtn.Name = "DrinksMenuBtn";
            DrinksMenuBtn.Size = new Size(121, 52);
            DrinksMenuBtn.TabIndex = 3;
            DrinksMenuBtn.Text = "Drinks";
            DrinksMenuBtn.UseVisualStyleBackColor = false;
            // 
            // confirm_order_button
            // 
            confirm_order_button.BackColor = Color.FromArgb(0, 192, 0);
            confirm_order_button.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            confirm_order_button.Location = new Point(286, 661);
            confirm_order_button.Name = "confirm_order_button";
            confirm_order_button.Size = new Size(278, 38);
            confirm_order_button.TabIndex = 4;
            confirm_order_button.Text = "Confirm order";
            confirm_order_button.UseVisualStyleBackColor = false;
            // 
            // delete_order_btn
            // 
            delete_order_btn.BackColor = Color.Red;
            delete_order_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            delete_order_btn.Location = new Point(286, 749);
            delete_order_btn.Name = "delete_order_btn";
            delete_order_btn.Size = new Size(278, 38);
            delete_order_btn.TabIndex = 20;
            delete_order_btn.Text = "Delete order";
            delete_order_btn.UseVisualStyleBackColor = false;
            // 
            // flowMenu
            // 
            flowMenu.Location = new Point(-1, 124);
            flowMenu.Name = "flowMenu";
            flowMenu.Size = new Size(288, 663);
            flowMenu.TabIndex = 21;
            // 
            // flowOrder
            // 
            flowOrder.BackColor = Color.LightSteelBlue;
            flowOrder.Location = new Point(286, 124);
            flowOrder.Name = "flowOrder";
            flowOrder.Size = new Size(278, 500);
            flowOrder.TabIndex = 22;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalPrice.Location = new Point(341, 627);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(184, 31);
            lbl_TotalPrice.TabIndex = 0;
            lbl_TotalPrice.Text = "Total price: €0.00";
            // 
            // Bill_btn
            // 
            Bill_btn.BackColor = Color.FromArgb(255, 128, 0);
            Bill_btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Bill_btn.Location = new Point(286, 705);
            Bill_btn.Name = "Bill_btn";
            Bill_btn.Size = new Size(278, 38);
            Bill_btn.TabIndex = 24;
            Bill_btn.Text = "Checkout";
            Bill_btn.UseVisualStyleBackColor = false;
            // 
            // OrderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(757, 796);
            Controls.Add(lbl_TotalPrice);
            Controls.Add(Bill_btn);
            Controls.Add(delete_order_btn);
            Controls.Add(flowMenu);
            Controls.Add(confirm_order_button);
            Controls.Add(DrinksMenuBtn);
            Controls.Add(DinnerMenuBtn);
            Controls.Add(LunchMenuBtn);
            Controls.Add(label1);
            Controls.Add(flowOrder);
            Name = "OrderView";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button LunchMenuBtn;
        private Button DinnerMenuBtn;
        private Button DrinksMenuBtn;
        private Button confirm_order_button;
        private Button delete_order_btn;
        private FlowLayoutPanel flowMenu;
        private FlowLayoutPanel flowOrder;
        private Label lbl_TotalPrice;
        private Button Bill_btn;
    }
}