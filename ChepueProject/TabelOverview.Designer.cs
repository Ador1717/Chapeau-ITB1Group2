namespace Chapeau
{
    partial class TabelOverview
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
            panel1 = new Panel();
            lblEmployeName_Login = new Label();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            tab_UiControl = new TabControl();
            tab_Table = new TabPage();
            pnlTableDetail = new Panel();
            lblOrderStatus = new Label();
            lbl_CurrentWaitTime = new Label();
            btnOrder_Served = new Button();
            lbltxtWaiting_Time = new Label();
            rbOccupied = new RadioButton();
            rbFree = new RadioButton();
            txtTableNr = new TextBox();
            btnRetrun_TableOverView = new Button();
            btnTakeOrder = new Button();
            lblTableDetail = new Label();
            pnlTableOverView = new Panel();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            lblTableOverview = new Label();
            tabPage2 = new TabPage();
            orderViewPanel = new Panel();
            lbl_TotalPrice = new Label();
            flowOrder = new FlowLayoutPanel();
            flowMenu = new FlowLayoutPanel();
            label1 = new Label();
            DrinksMenuBtn = new Button();
            DinnerMenuBtn = new Button();
            LunchMenuBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tab_UiControl.SuspendLayout();
            tab_Table.SuspendLayout();
            pnlTableDetail.SuspendLayout();
            pnlTableOverView.SuspendLayout();
            tabPage2.SuspendLayout();
            orderViewPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblEmployeName_Login);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 62);
            panel1.TabIndex = 0;
            // 
            // lblEmployeName_Login
            // 
            lblEmployeName_Login.AutoSize = true;
            lblEmployeName_Login.Location = new Point(267, 10);
            lblEmployeName_Login.Margin = new Padding(2, 0, 2, 0);
            lblEmployeName_Login.Name = "lblEmployeName_Login";
            lblEmployeName_Login.Size = new Size(0, 20);
            lblEmployeName_Login.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Orange;
            btnLogout.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.Location = new Point(222, 15);
            btnLogout.Margin = new Padding(2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(99, 34);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tab_UiControl
            // 
            tab_UiControl.Controls.Add(tab_Table);
            tab_UiControl.Controls.Add(tabPage2);
            tab_UiControl.Dock = DockStyle.Fill;
            tab_UiControl.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            tab_UiControl.Location = new Point(0, 62);
            tab_UiControl.Margin = new Padding(2);
            tab_UiControl.Name = "tab_UiControl";
            tab_UiControl.SelectedIndex = 0;
            tab_UiControl.Size = new Size(331, 527);
            tab_UiControl.TabIndex = 1;
            tab_UiControl.SelectedIndexChanged += SelectedTabChanged;
            // 
            // tab_Table
            // 
            tab_Table.Controls.Add(pnlTableDetail);
            tab_Table.Controls.Add(pnlTableOverView);
            tab_Table.Location = new Point(4, 28);
            tab_Table.Margin = new Padding(2);
            tab_Table.Name = "tab_Table";
            tab_Table.Padding = new Padding(2);
            tab_Table.Size = new Size(323, 495);
            tab_Table.TabIndex = 0;
            tab_Table.Text = "Table Overview";
            tab_Table.UseVisualStyleBackColor = true;
            // 
            // pnlTableDetail
            // 
            pnlTableDetail.Controls.Add(lblOrderStatus);
            pnlTableDetail.Controls.Add(lbl_CurrentWaitTime);
            pnlTableDetail.Controls.Add(btnOrder_Served);
            pnlTableDetail.Controls.Add(lbltxtWaiting_Time);
            pnlTableDetail.Controls.Add(rbOccupied);
            pnlTableDetail.Controls.Add(rbFree);
            pnlTableDetail.Controls.Add(txtTableNr);
            pnlTableDetail.Controls.Add(btnRetrun_TableOverView);
            pnlTableDetail.Controls.Add(btnTakeOrder);
            pnlTableDetail.Controls.Add(lblTableDetail);
            pnlTableDetail.Location = new Point(6, 6);
            pnlTableDetail.Margin = new Padding(2);
            pnlTableDetail.Name = "pnlTableDetail";
            pnlTableDetail.Size = new Size(318, 493);
            pnlTableDetail.TabIndex = 18;
            pnlTableDetail.Paint += pnlTableDetail_Paint;
            // 
            // lblOrderStatus
            // 
            lblOrderStatus.AutoSize = true;
            lblOrderStatus.Location = new Point(98, 305);
            lblOrderStatus.Margin = new Padding(2, 0, 2, 0);
            lblOrderStatus.Name = "lblOrderStatus";
            lblOrderStatus.Size = new Size(0, 19);
            lblOrderStatus.TabIndex = 28;
            // 
            // lbl_CurrentWaitTime
            // 
            lbl_CurrentWaitTime.AutoSize = true;
            lbl_CurrentWaitTime.Location = new Point(154, 334);
            lbl_CurrentWaitTime.Margin = new Padding(2, 0, 2, 0);
            lbl_CurrentWaitTime.Name = "lbl_CurrentWaitTime";
            lbl_CurrentWaitTime.Size = new Size(0, 19);
            lbl_CurrentWaitTime.TabIndex = 27;
            // 
            // btnOrder_Served
            // 
            btnOrder_Served.BackColor = Color.White;
            btnOrder_Served.Location = new Point(61, 369);
            btnOrder_Served.Margin = new Padding(2);
            btnOrder_Served.Name = "btnOrder_Served";
            btnOrder_Served.Size = new Size(120, 27);
            btnOrder_Served.TabIndex = 26;
            btnOrder_Served.Text = "Serve Food";
            btnOrder_Served.UseVisualStyleBackColor = false;
            btnOrder_Served.Click += btnOrder_Served_Click;
            // 
            // lbltxtWaiting_Time
            // 
            lbltxtWaiting_Time.AutoSize = true;
            lbltxtWaiting_Time.Location = new Point(18, 334);
            lbltxtWaiting_Time.Margin = new Padding(2, 0, 2, 0);
            lbltxtWaiting_Time.Name = "lbltxtWaiting_Time";
            lbltxtWaiting_Time.Size = new Size(113, 19);
            lbltxtWaiting_Time.TabIndex = 25;
            lbltxtWaiting_Time.Text = "Waiting time:";
            // 
            // rbOccupied
            // 
            rbOccupied.AutoSize = true;
            rbOccupied.Location = new Point(170, 114);
            rbOccupied.Margin = new Padding(2);
            rbOccupied.Name = "rbOccupied";
            rbOccupied.Size = new Size(113, 23);
            rbOccupied.TabIndex = 24;
            rbOccupied.TabStop = true;
            rbOccupied.Text = "Occupied";
            rbOccupied.UseVisualStyleBackColor = true;
            rbOccupied.CheckedChanged += rbOccupied_CheckedChanged;
            // 
            // rbFree
            // 
            rbFree.AutoSize = true;
            rbFree.Location = new Point(45, 114);
            rbFree.Margin = new Padding(2);
            rbFree.Name = "rbFree";
            rbFree.Size = new Size(65, 23);
            rbFree.TabIndex = 23;
            rbFree.TabStop = true;
            rbFree.Text = "Free";
            rbFree.UseVisualStyleBackColor = true;
            rbFree.CheckedChanged += rbFree_CheckedChanged;
            // 
            // txtTableNr
            // 
            txtTableNr.Location = new Point(114, 58);
            txtTableNr.Margin = new Padding(2);
            txtTableNr.Name = "txtTableNr";
            txtTableNr.Size = new Size(68, 28);
            txtTableNr.TabIndex = 22;
            // 
            // btnRetrun_TableOverView
            // 
            btnRetrun_TableOverView.BackColor = Color.DarkOrange;
            btnRetrun_TableOverView.Location = new Point(4, 440);
            btnRetrun_TableOverView.Margin = new Padding(2);
            btnRetrun_TableOverView.Name = "btnRetrun_TableOverView";
            btnRetrun_TableOverView.Size = new Size(90, 27);
            btnRetrun_TableOverView.TabIndex = 20;
            btnRetrun_TableOverView.Text = "Back";
            btnRetrun_TableOverView.UseVisualStyleBackColor = false;
            btnRetrun_TableOverView.Click += btnRetrun_TableOverView_Click;
            // 
            // btnTakeOrder
            // 
            btnTakeOrder.BackColor = Color.White;
            btnTakeOrder.Location = new Point(55, 165);
            btnTakeOrder.Margin = new Padding(2);
            btnTakeOrder.Name = "btnTakeOrder";
            btnTakeOrder.Size = new Size(196, 44);
            btnTakeOrder.TabIndex = 19;
            btnTakeOrder.Text = "Go to table";
            btnTakeOrder.UseVisualStyleBackColor = false;
            btnTakeOrder.Click += btnTakeOrder_Click;
            // 
            // lblTableDetail
            // 
            lblTableDetail.AutoSize = true;
            lblTableDetail.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableDetail.Location = new Point(64, 10);
            lblTableDetail.Margin = new Padding(2, 0, 2, 0);
            lblTableDetail.Name = "lblTableDetail";
            lblTableDetail.Size = new Size(208, 37);
            lblTableDetail.TabIndex = 16;
            lblTableDetail.Text = "Table Details ";
            // 
            // pnlTableOverView
            // 
            pnlTableOverView.Controls.Add(label3);
            pnlTableOverView.Controls.Add(label2);
            pnlTableOverView.Controls.Add(textBox3);
            pnlTableOverView.Controls.Add(textBox2);
            pnlTableOverView.Controls.Add(lblTableOverview);
            pnlTableOverView.Location = new Point(8, 5);
            pnlTableOverView.Margin = new Padding(2);
            pnlTableOverView.Name = "pnlTableOverView";
            pnlTableOverView.Size = new Size(312, 497);
            pnlTableOverView.TabIndex = 17;
            pnlTableOverView.Paint += pnlTableOverView_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 471);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 19;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 471);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 19);
            label2.TabIndex = 18;
            label2.Text = "label2";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Red;
            textBox3.Location = new Point(172, 463);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(29, 28);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Lime;
            textBox2.Location = new Point(31, 464);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(28, 28);
            textBox2.TabIndex = 16;
            // 
            // lblTableOverview
            // 
            lblTableOverview.AutoSize = true;
            lblTableOverview.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTableOverview.Location = new Point(31, 13);
            lblTableOverview.Margin = new Padding(2, 0, 2, 0);
            lblTableOverview.Name = "lblTableOverview";
            lblTableOverview.Size = new Size(246, 37);
            lblTableOverview.TabIndex = 15;
            lblTableOverview.Text = "Table OverView";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(orderViewPanel);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(323, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Orders";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // orderViewPanel
            // 
            orderViewPanel.Controls.Add(lbl_TotalPrice);
            orderViewPanel.Controls.Add(flowOrder);
            orderViewPanel.Controls.Add(flowMenu);
            orderViewPanel.Controls.Add(label1);
            orderViewPanel.Controls.Add(DrinksMenuBtn);
            orderViewPanel.Controls.Add(DinnerMenuBtn);
            orderViewPanel.Controls.Add(LunchMenuBtn);
            orderViewPanel.Location = new Point(0, 0);
            orderViewPanel.Name = "orderViewPanel";
            orderViewPanel.Size = new Size(323, 499);
            orderViewPanel.TabIndex = 0;
            orderViewPanel.Paint += orderViewPanel_Paint;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalPrice.Location = new Point(131, 430);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(184, 31);
            lbl_TotalPrice.TabIndex = 24;
            lbl_TotalPrice.Text = "Total price: €0.00";
            // 
            // flowOrder
            // 
            flowOrder.BackColor = Color.LightSteelBlue;
            flowOrder.Location = new Point(160, 87);
            flowOrder.Name = "flowOrder";
            flowOrder.Size = new Size(155, 325);
            flowOrder.TabIndex = 23;
            // 
            // flowMenu
            // 
            flowMenu.BackColor = Color.DeepSkyBlue;
            flowMenu.ForeColor = SystemColors.ControlText;
            flowMenu.Location = new Point(8, 87);
            flowMenu.Name = "flowMenu";
            flowMenu.Size = new Size(137, 325);
            flowMenu.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 5);
            label1.Name = "label1";
            label1.Size = new Size(154, 31);
            label1.TabIndex = 5;
            label1.Text = "Order table 1";
            // 
            // DrinksMenuBtn
            // 
            DrinksMenuBtn.BackColor = Color.MidnightBlue;
            DrinksMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DrinksMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            DrinksMenuBtn.Location = new Point(216, 39);
            DrinksMenuBtn.Name = "DrinksMenuBtn";
            DrinksMenuBtn.Size = new Size(104, 42);
            DrinksMenuBtn.TabIndex = 4;
            DrinksMenuBtn.Text = "Drinks";
            DrinksMenuBtn.UseVisualStyleBackColor = false;
            DrinksMenuBtn.Click += DrinksMenuBtn_Click;
            // 
            // DinnerMenuBtn
            // 
            DinnerMenuBtn.BackColor = Color.MidnightBlue;
            DinnerMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DinnerMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            DinnerMenuBtn.Location = new Point(116, 39);
            DinnerMenuBtn.Name = "DinnerMenuBtn";
            DinnerMenuBtn.Size = new Size(96, 42);
            DinnerMenuBtn.TabIndex = 3;
            DinnerMenuBtn.Text = "Dinner";
            DinnerMenuBtn.UseVisualStyleBackColor = false;
            DinnerMenuBtn.Click += DinnerMenuBtn_Click;
            // 
            // LunchMenuBtn
            // 
            LunchMenuBtn.BackColor = Color.MidnightBlue;
            LunchMenuBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LunchMenuBtn.ForeColor = SystemColors.ButtonHighlight;
            LunchMenuBtn.Location = new Point(5, 39);
            LunchMenuBtn.Name = "LunchMenuBtn";
            LunchMenuBtn.Size = new Size(105, 42);
            LunchMenuBtn.TabIndex = 2;
            LunchMenuBtn.Text = "Lunch";
            LunchMenuBtn.UseVisualStyleBackColor = false;
            LunchMenuBtn.Click += LunchMenuBtn_Click;
            // 
            // TabelOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 589);
            Controls.Add(tab_UiControl);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "TabelOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderView";
            Load += TabelOverview_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tab_UiControl.ResumeLayout(false);
            tab_Table.ResumeLayout(false);
            pnlTableDetail.ResumeLayout(false);
            pnlTableDetail.PerformLayout();
            pnlTableOverView.ResumeLayout(false);
            pnlTableOverView.PerformLayout();
            tabPage2.ResumeLayout(false);
            orderViewPanel.ResumeLayout(false);
            orderViewPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TabControl tab_UiControl;
        private TabPage tab_Table;
        private TabPage tabPage2;
        private Panel pnlTableDetail;
        private RadioButton rbOccupied;
        private RadioButton rbFree;
        private TextBox txtTableNr;
        private Button btnRetrun_TableOverView;
        private Button btnTakeOrder;
        private Label lblTableDetail;
        private Panel pnlTableOverView;
        private Label lblTableOverview;
        private Button btnOrder_Served;
        private Label lbltxtWaiting_Time;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label lblEmployeName_Login;
        private Button btnLogout;
        private Label lbl_CurrentWaitTime;
        private Label lblOrderStatus;
        private Panel orderViewPanel;
        private Button LunchMenuBtn;
        private Button DinnerMenuBtn;
        private Button DrinksMenuBtn;
        private Label label1;
        private FlowLayoutPanel flowMenu;
        private FlowLayoutPanel flowOrder;
        private Label lbl_TotalPrice;
    }
}