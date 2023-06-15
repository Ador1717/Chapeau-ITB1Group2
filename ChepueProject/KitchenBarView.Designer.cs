namespace ChepueUI
{
    partial class KitchenBarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarView));
            tableNum = new Label();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            bartenderView = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            bartenderStatusView = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            barButtonPrepare = new Button();
            barButtonPrepared = new Button();
            barButtonServed = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            barTableNum = new Label();
            BarView = new Panel();
            orderHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarView.SuspendLayout();
            SuspendLayout();
            // 
            // tableNum
            // 
            tableNum.AutoSize = true;
            tableNum.Location = new Point(249, 44);
            tableNum.Name = "tableNum";
            tableNum.Size = new Size(0, 20);
            tableNum.TabIndex = 21;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 72);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(776, 72);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(255, 128, 0);
            label8.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(249, 72);
            label8.Name = "label8";
            label8.Size = new Size(236, 72);
            label8.TabIndex = 23;
            label8.Text = "Bar View";
            // 
            // bartenderView
            // 
            bartenderView.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            bartenderView.FullRowSelect = true;
            bartenderView.GridLines = true;
            bartenderView.Location = new Point(12, 150);
            bartenderView.Name = "bartenderView";
            bartenderView.Size = new Size(441, 211);
            bartenderView.TabIndex = 24;
            bartenderView.UseCompatibleStateImageBehavior = false;
            bartenderView.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Order ID";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Order number";
            columnHeader10.Width = 125;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Count";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Description";
            columnHeader12.Width = 115;
            // 
            // bartenderStatusView
            // 
            bartenderStatusView.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8 });
            bartenderStatusView.GridLines = true;
            bartenderStatusView.Location = new Point(459, 206);
            bartenderStatusView.Name = "bartenderStatusView";
            bartenderStatusView.Size = new Size(329, 155);
            bartenderStatusView.TabIndex = 25;
            bartenderStatusView.UseCompatibleStateImageBehavior = false;
            bartenderStatusView.View = View.Details;
            bartenderStatusView.SelectedIndexChanged += bartenderStatusView_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Order ID";
            columnHeader7.Width = 175;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Status";
            columnHeader8.Width = 150;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 62);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 62);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // barButtonPrepare
            // 
            barButtonPrepare.Location = new Point(459, 171);
            barButtonPrepare.Name = "barButtonPrepare";
            barButtonPrepare.Size = new Size(115, 29);
            barButtonPrepare.TabIndex = 28;
            barButtonPrepare.Text = "In preperation";
            barButtonPrepare.UseVisualStyleBackColor = true;
            barButtonPrepare.Click += barButtonPrepare_Click;
            // 
            // barButtonPrepared
            // 
            barButtonPrepared.Location = new Point(580, 171);
            barButtonPrepared.Name = "barButtonPrepared";
            barButtonPrepared.Size = new Size(91, 29);
            barButtonPrepared.TabIndex = 29;
            barButtonPrepared.Text = "Prepeared";
            barButtonPrepared.UseVisualStyleBackColor = true;
            barButtonPrepared.Click += barButtonPrepared_Click;
            // 
            // barButtonServed
            // 
            barButtonServed.Location = new Point(677, 171);
            barButtonServed.Name = "barButtonServed";
            barButtonServed.Size = new Size(111, 29);
            barButtonServed.TabIndex = 30;
            barButtonServed.Text = "Served";
            barButtonServed.UseVisualStyleBackColor = true;
            barButtonServed.Click += barButtonServed_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(552, 148);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 31;
            label7.Text = "Change order status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 46);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 46);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 34;
            label4.Text = "Table number:";
            // 
            // barTableNum
            // 
            barTableNum.AutoSize = true;
            barTableNum.Location = new Point(250, 49);
            barTableNum.Name = "barTableNum";
            barTableNum.Size = new Size(0, 20);
            barTableNum.TabIndex = 35;
            // 
            // BarView
            // 
            BarView.Controls.Add(orderHistory);
            BarView.Controls.Add(barTableNum);
            BarView.Controls.Add(label4);
            BarView.Controls.Add(label5);
            BarView.Controls.Add(label7);
            BarView.Controls.Add(barButtonServed);
            BarView.Controls.Add(barButtonPrepared);
            BarView.Controls.Add(barButtonPrepare);
            BarView.Controls.Add(pictureBox1);
            BarView.Controls.Add(pictureBox2);
            BarView.Controls.Add(bartenderStatusView);
            BarView.Controls.Add(bartenderView);
            BarView.Controls.Add(label8);
            BarView.Controls.Add(pictureBox4);
            BarView.Location = new Point(2, -1);
            BarView.Name = "BarView";
            BarView.Size = new Size(797, 449);
            BarView.TabIndex = 23;
            // 
            // orderHistory
            // 
            orderHistory.Location = new Point(26, 387);
            orderHistory.Name = "orderHistory";
            orderHistory.Size = new Size(160, 29);
            orderHistory.TabIndex = 36;
            orderHistory.Text = "Order History";
            orderHistory.UseVisualStyleBackColor = true;
            orderHistory.Click += orderHistory_Click;
            // 
            // KitchenBarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableNum);
            Controls.Add(BarView);
            Name = "KitchenBarView";
            Text = "Kitchen View/Bar View";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarView.ResumeLayout(false);
            BarView.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tableNum;
        private PictureBox pictureBox4;
        private Label label8;
        private ListView bartenderView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView bartenderStatusView;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button barButtonPrepare;
        private Button barButtonPrepared;
        private Button barButtonServed;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label barTableNum;
        private Panel BarView;
        private Button orderHistory;
    }
}