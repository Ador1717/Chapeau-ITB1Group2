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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeName_Login = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_UiControl = new System.Windows.Forms.TabControl();
            this.tab_Table = new System.Windows.Forms.TabPage();
            this.pnlTableOverView = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTableOverview = new System.Windows.Forms.Label();
            this.pnlTableDetail = new System.Windows.Forms.Panel();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lbl_CurrentWaitTime = new System.Windows.Forms.Label();
            this.btnOrder_Served = new System.Windows.Forms.Button();
            this.lbltxtWaiting_Time = new System.Windows.Forms.Label();
            this.rbOccupied = new System.Windows.Forms.RadioButton();
            this.rbFree = new System.Windows.Forms.RadioButton();
            this.txtTableNr = new System.Windows.Forms.TextBox();
            this.btnRetrun_TableOverView = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.lblTableDetail = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_UiControl.SuspendLayout();
            this.tab_Table.SuspendLayout();
            this.pnlTableOverView.SuspendLayout();
            this.pnlTableDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEmployeName_Login);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblEmployeName_Login
            // 
            this.lblEmployeName_Login.AutoSize = true;
            this.lblEmployeName_Login.Location = new System.Drawing.Point(334, 12);
            this.lblEmployeName_Login.Name = "lblEmployeName_Login";
            this.lblEmployeName_Login.Size = new System.Drawing.Size(0, 25);
            this.lblEmployeName_Login.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Orange;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(278, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 42);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chapeau.Properties.Resources.chapaue1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tab_UiControl
            // 
            this.tab_UiControl.Controls.Add(this.tab_Table);
            this.tab_UiControl.Controls.Add(this.tabPage2);
            this.tab_UiControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_UiControl.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tab_UiControl.Location = new System.Drawing.Point(0, 77);
            this.tab_UiControl.Name = "tab_UiControl";
            this.tab_UiControl.SelectedIndex = 0;
            this.tab_UiControl.Size = new System.Drawing.Size(414, 659);
            this.tab_UiControl.TabIndex = 1;
            this.tab_UiControl.SelectedIndexChanged += new System.EventHandler(this.SelectedTabChanged);
            // 
            // tab_Table
            // 
            this.tab_Table.Controls.Add(this.pnlTableDetail);
            this.tab_Table.Controls.Add(this.pnlTableOverView);
            this.tab_Table.Location = new System.Drawing.Point(4, 32);
            this.tab_Table.Name = "tab_Table";
            this.tab_Table.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Table.Size = new System.Drawing.Size(406, 623);
            this.tab_Table.TabIndex = 0;
            this.tab_Table.Text = "Table Overview";
            this.tab_Table.UseVisualStyleBackColor = true;
            // 
            // pnlTableOverView
            // 
            this.pnlTableOverView.Controls.Add(this.label3);
            this.pnlTableOverView.Controls.Add(this.label2);
            this.pnlTableOverView.Controls.Add(this.textBox3);
            this.pnlTableOverView.Controls.Add(this.textBox2);
            this.pnlTableOverView.Controls.Add(this.lblTableOverview);
            this.pnlTableOverView.Location = new System.Drawing.Point(10, 6);
            this.pnlTableOverView.Name = "pnlTableOverView";
            this.pnlTableOverView.Size = new System.Drawing.Size(390, 621);
            this.pnlTableOverView.TabIndex = 17;
            this.pnlTableOverView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableOverView_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 589);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "label2";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Red;
            this.textBox3.Location = new System.Drawing.Point(215, 579);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(35, 32);
            this.textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(39, 580);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(34, 32);
            this.textBox2.TabIndex = 16;
            // 
            // lblTableOverview
            // 
            this.lblTableOverview.AutoSize = true;
            this.lblTableOverview.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableOverview.Location = new System.Drawing.Point(39, 16);
            this.lblTableOverview.Name = "lblTableOverview";
            this.lblTableOverview.Size = new System.Drawing.Size(295, 43);
            this.lblTableOverview.TabIndex = 15;
            this.lblTableOverview.Text = "Table OverView";
            // 
            // pnlTableDetail
            // 
            this.pnlTableDetail.Controls.Add(this.lblOrderStatus);
            this.pnlTableDetail.Controls.Add(this.lbl_CurrentWaitTime);
            this.pnlTableDetail.Controls.Add(this.btnOrder_Served);
            this.pnlTableDetail.Controls.Add(this.lbltxtWaiting_Time);
            this.pnlTableDetail.Controls.Add(this.rbOccupied);
            this.pnlTableDetail.Controls.Add(this.rbFree);
            this.pnlTableDetail.Controls.Add(this.txtTableNr);
            this.pnlTableDetail.Controls.Add(this.btnRetrun_TableOverView);
            this.pnlTableDetail.Controls.Add(this.btnTakeOrder);
            this.pnlTableDetail.Controls.Add(this.lblTableDetail);
            this.pnlTableDetail.Location = new System.Drawing.Point(8, 8);
            this.pnlTableDetail.Name = "pnlTableDetail";
            this.pnlTableDetail.Size = new System.Drawing.Size(398, 616);
            this.pnlTableDetail.TabIndex = 18;
            this.pnlTableDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTableDetail_Paint);
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Location = new System.Drawing.Point(123, 381);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(0, 23);
            this.lblOrderStatus.TabIndex = 28;
            // 
            // lbl_CurrentWaitTime
            // 
            this.lbl_CurrentWaitTime.AutoSize = true;
            this.lbl_CurrentWaitTime.Location = new System.Drawing.Point(193, 418);
            this.lbl_CurrentWaitTime.Name = "lbl_CurrentWaitTime";
            this.lbl_CurrentWaitTime.Size = new System.Drawing.Size(0, 23);
            this.lbl_CurrentWaitTime.TabIndex = 27;
            // 
            // btnOrder_Served
            // 
            this.btnOrder_Served.BackColor = System.Drawing.Color.White;
            this.btnOrder_Served.Location = new System.Drawing.Point(76, 461);
            this.btnOrder_Served.Name = "btnOrder_Served";
            this.btnOrder_Served.Size = new System.Drawing.Size(150, 34);
            this.btnOrder_Served.TabIndex = 26;
            this.btnOrder_Served.Text = "Serve Food";
            this.btnOrder_Served.UseVisualStyleBackColor = false;
            this.btnOrder_Served.Click += new System.EventHandler(this.btnOrder_Served_Click);
            // 
            // lbltxtWaiting_Time
            // 
            this.lbltxtWaiting_Time.AutoSize = true;
            this.lbltxtWaiting_Time.Location = new System.Drawing.Point(23, 417);
            this.lbltxtWaiting_Time.Name = "lbltxtWaiting_Time";
            this.lbltxtWaiting_Time.Size = new System.Drawing.Size(137, 23);
            this.lbltxtWaiting_Time.TabIndex = 25;
            this.lbltxtWaiting_Time.Text = "Waiting time:";
            // 
            // rbOccupied
            // 
            this.rbOccupied.AutoSize = true;
            this.rbOccupied.Location = new System.Drawing.Point(212, 143);
            this.rbOccupied.Name = "rbOccupied";
            this.rbOccupied.Size = new System.Drawing.Size(134, 27);
            this.rbOccupied.TabIndex = 24;
            this.rbOccupied.TabStop = true;
            this.rbOccupied.Text = "Occupied";
            this.rbOccupied.UseVisualStyleBackColor = true;
            this.rbOccupied.CheckedChanged += new System.EventHandler(this.rbOccupied_CheckedChanged);
            // 
            // rbFree
            // 
            this.rbFree.AutoSize = true;
            this.rbFree.Location = new System.Drawing.Point(56, 143);
            this.rbFree.Name = "rbFree";
            this.rbFree.Size = new System.Drawing.Size(77, 27);
            this.rbFree.TabIndex = 23;
            this.rbFree.TabStop = true;
            this.rbFree.Text = "Free";
            this.rbFree.UseVisualStyleBackColor = true;
            this.rbFree.CheckedChanged += new System.EventHandler(this.rbFree_CheckedChanged);
            // 
            // txtTableNr
            // 
            this.txtTableNr.Location = new System.Drawing.Point(142, 72);
            this.txtTableNr.Name = "txtTableNr";
            this.txtTableNr.Size = new System.Drawing.Size(84, 32);
            this.txtTableNr.TabIndex = 22;
            // 
            // btnRetrun_TableOverView
            // 
            this.btnRetrun_TableOverView.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRetrun_TableOverView.Location = new System.Drawing.Point(5, 550);
            this.btnRetrun_TableOverView.Name = "btnRetrun_TableOverView";
            this.btnRetrun_TableOverView.Size = new System.Drawing.Size(112, 34);
            this.btnRetrun_TableOverView.TabIndex = 20;
            this.btnRetrun_TableOverView.Text = "Back";
            this.btnRetrun_TableOverView.UseVisualStyleBackColor = false;
            this.btnRetrun_TableOverView.Click += new System.EventHandler(this.btnRetrun_TableOverView_Click);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.BackColor = System.Drawing.Color.White;
            this.btnTakeOrder.Location = new System.Drawing.Point(69, 206);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(245, 55);
            this.btnTakeOrder.TabIndex = 19;
            this.btnTakeOrder.Text = "Go to table";
            this.btnTakeOrder.UseVisualStyleBackColor = false;
            this.btnTakeOrder.Click += new System.EventHandler(this.btnTakeOrder_Click);
            // 
            // lblTableDetail
            // 
            this.lblTableDetail.AutoSize = true;
            this.lblTableDetail.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTableDetail.Location = new System.Drawing.Point(80, 13);
            this.lblTableDetail.Name = "lblTableDetail";
            this.lblTableDetail.Size = new System.Drawing.Size(251, 43);
            this.lblTableDetail.TabIndex = 16;
            this.lblTableDetail.Text = "Table Details ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(406, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabelOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 736);
            this.Controls.Add(this.tab_UiControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TabelOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderView";
            this.Load += new System.EventHandler(this.TabelOverview_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_UiControl.ResumeLayout(false);
            this.tab_Table.ResumeLayout(false);
            this.pnlTableOverView.ResumeLayout(false);
            this.pnlTableOverView.PerformLayout();
            this.pnlTableDetail.ResumeLayout(false);
            this.pnlTableDetail.PerformLayout();
            this.ResumeLayout(false);

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
    }
}