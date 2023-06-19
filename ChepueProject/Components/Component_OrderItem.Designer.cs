namespace ChapeauUI.Components
{
    partial class Component_OrderItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_Main = new Panel();
            txtBox_Comment = new TextBox();
            pnl_ProductInfo = new Panel();
            pnl_ProductName = new Panel();
            lbl_ProductName = new Label();
            pnl_ProductControls = new Panel();
            lbl_Count = new Label();
            label_TotalPrice = new Label();
            btn_RemoveItem = new Button();
            btn_AddItem = new Button();
            pnl_Bottom = new Panel();
            splitter = new Splitter();
            pnl_Main.SuspendLayout();
            pnl_ProductInfo.SuspendLayout();
            pnl_ProductName.SuspendLayout();
            pnl_ProductControls.SuspendLayout();
            pnl_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Main
            // 
            pnl_Main.AutoSize = true;
            pnl_Main.Controls.Add(txtBox_Comment);
            pnl_Main.Controls.Add(pnl_ProductInfo);
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            pnl_Main.ForeColor = Color.White;
            pnl_Main.Location = new Point(1, 0);
            pnl_Main.Margin = new Padding(2);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.Size = new Size(310, 103);
            pnl_Main.TabIndex = 0;
            // 
            // txtBox_Comment
            // 
            txtBox_Comment.BackColor = Color.FromArgb(152, 151, 169);
            txtBox_Comment.Dock = DockStyle.Bottom;
            txtBox_Comment.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtBox_Comment.ForeColor = Color.White;
            txtBox_Comment.Location = new Point(0, 67);
            txtBox_Comment.Margin = new Padding(0);
            txtBox_Comment.MaxLength = 64;
            txtBox_Comment.Name = "txtBox_Comment";
            txtBox_Comment.PlaceholderText = "Comment...";
            txtBox_Comment.Size = new Size(310, 36);
            txtBox_Comment.TabIndex = 0;
            txtBox_Comment.Leave += AddComment;
            // 
            // pnl_ProductInfo
            // 
            pnl_ProductInfo.AutoSize = true;
            pnl_ProductInfo.Controls.Add(pnl_ProductName);
            pnl_ProductInfo.Controls.Add(pnl_ProductControls);
            pnl_ProductInfo.Dock = DockStyle.Top;
            pnl_ProductInfo.Location = new Point(0, 0);
            pnl_ProductInfo.Margin = new Padding(0);
            pnl_ProductInfo.MinimumSize = new Size(0, 67);
            pnl_ProductInfo.Name = "pnl_ProductInfo";
            pnl_ProductInfo.Size = new Size(310, 67);
            pnl_ProductInfo.TabIndex = 6;
            // 
            // pnl_ProductName
            // 
            pnl_ProductName.AutoSize = true;
            pnl_ProductName.Controls.Add(lbl_ProductName);
            pnl_ProductName.Dock = DockStyle.Top;
            pnl_ProductName.Location = new Point(0, 0);
            pnl_ProductName.Margin = new Padding(0);
            pnl_ProductName.MinimumSize = new Size(167, 0);
            pnl_ProductName.Name = "pnl_ProductName";
            pnl_ProductName.Size = new Size(208, 29);
            pnl_ProductName.TabIndex = 6;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Dock = DockStyle.Fill;
            lbl_ProductName.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ProductName.Location = new Point(0, 0);
            lbl_ProductName.Margin = new Padding(0);
            lbl_ProductName.MaximumSize = new Size(167, 0);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(119, 29);
            lbl_ProductName.TabIndex = 4;
            lbl_ProductName.Text = "Item name";
            // 
            // pnl_ProductControls
            // 
            pnl_ProductControls.AutoSize = true;
            pnl_ProductControls.Controls.Add(lbl_Count);
            pnl_ProductControls.Controls.Add(label_TotalPrice);
            pnl_ProductControls.Controls.Add(btn_RemoveItem);
            pnl_ProductControls.Controls.Add(btn_AddItem);
            pnl_ProductControls.Dock = DockStyle.Right;
            pnl_ProductControls.Location = new Point(208, 0);
            pnl_ProductControls.Margin = new Padding(0);
            pnl_ProductControls.Name = "pnl_ProductControls";
            pnl_ProductControls.Size = new Size(102, 67);
            pnl_ProductControls.TabIndex = 5;
            // 
            // lbl_Count
            // 
            lbl_Count.Location = new Point(32, 4);
            lbl_Count.Margin = new Padding(2, 0, 2, 0);
            lbl_Count.Name = "lbl_Count";
            lbl_Count.Size = new Size(38, 32);
            lbl_Count.TabIndex = 3;
            lbl_Count.Text = "1";
            lbl_Count.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Count.UseCompatibleTextRendering = true;
            // 
            // label_TotalPrice
            // 
            label_TotalPrice.Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_TotalPrice.Location = new Point(0, 33);
            label_TotalPrice.Margin = new Padding(0);
            label_TotalPrice.Name = "label_TotalPrice";
            label_TotalPrice.Size = new Size(100, 29);
            label_TotalPrice.TabIndex = 5;
            label_TotalPrice.Text = "€ 0,00";
            label_TotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_RemoveItem
            // 
            btn_RemoveItem.BackColor = Color.FromArgb(254, 64, 64);
            btn_RemoveItem.FlatAppearance.BorderSize = 0;
            btn_RemoveItem.FlatStyle = FlatStyle.Flat;
            btn_RemoveItem.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RemoveItem.Location = new Point(71, 4);
            btn_RemoveItem.Margin = new Padding(2);
            btn_RemoveItem.Name = "btn_RemoveItem";
            btn_RemoveItem.Size = new Size(29, 29);
            btn_RemoveItem.TabIndex = 2;
            btn_RemoveItem.Text = "-";
            btn_RemoveItem.UseCompatibleTextRendering = true;
            btn_RemoveItem.UseVisualStyleBackColor = false;
            // 
            // btn_AddItem
            // 
            btn_AddItem.BackColor = Color.FromArgb(254, 64, 64);
            btn_AddItem.FlatAppearance.BorderSize = 0;
            btn_AddItem.FlatStyle = FlatStyle.Flat;
            btn_AddItem.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddItem.Location = new Point(0, 4);
            btn_AddItem.Margin = new Padding(2);
            btn_AddItem.Name = "btn_AddItem";
            btn_AddItem.Size = new Size(29, 29);
            btn_AddItem.TabIndex = 1;
            btn_AddItem.Text = "+";
            btn_AddItem.UseCompatibleTextRendering = true;
            btn_AddItem.UseVisualStyleBackColor = false;
            btn_AddItem.Click += btn_AddItem_Click;
            // 
            // pnl_Bottom
            // 
            pnl_Bottom.Controls.Add(splitter);
            pnl_Bottom.Dock = DockStyle.Bottom;
            pnl_Bottom.Location = new Point(1, 103);
            pnl_Bottom.Margin = new Padding(0);
            pnl_Bottom.Name = "pnl_Bottom";
            pnl_Bottom.Size = new Size(310, 12);
            pnl_Bottom.TabIndex = 0;
            // 
            // splitter
            // 
            splitter.BackColor = Color.FromArgb(106, 105, 123);
            splitter.Dock = DockStyle.Bottom;
            splitter.Enabled = false;
            splitter.Location = new Point(0, 10);
            splitter.Margin = new Padding(2);
            splitter.Name = "splitter";
            splitter.Size = new Size(310, 2);
            splitter.TabIndex = 0;
            splitter.TabStop = false;
            // 
            // Component_OrderItem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(28, 27, 45);
            Controls.Add(pnl_Main);
            Controls.Add(pnl_Bottom);
            DoubleBuffered = true;
            Margin = new Padding(0);
            MaximumSize = new Size(311, 0);
            MinimumSize = new Size(311, 114);
            Name = "Component_OrderItem";
            Padding = new Padding(1, 0, 0, 0);
            Size = new Size(311, 115);
            pnl_Main.ResumeLayout(false);
            pnl_Main.PerformLayout();
            pnl_ProductInfo.ResumeLayout(false);
            pnl_ProductInfo.PerformLayout();
            pnl_ProductName.ResumeLayout(false);
            pnl_ProductName.PerformLayout();
            pnl_ProductControls.ResumeLayout(false);
            pnl_Bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Main;
        private Panel pnl_Bottom;
        private Splitter splitter;
        private TextBox txtBox_Comment;
        private Label lbl_Count;
        private Button btn_AddItem;
        private Button btn_RemoveItem;
        private Label lbl_ProductName;
        private Label label_TotalPrice;
        private Panel pnl_ProductControls;
        private Panel pnl_ProductName;
        private Panel pnl_ProductInfo;
    }
}
