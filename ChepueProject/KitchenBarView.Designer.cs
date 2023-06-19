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
            barKitchenLabel = new Label();
            bartenderKitchenView = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            barKitchenStatusView = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            buttonPrepare = new Button();
            buttonPrepared = new Button();
            buttonServed = new Button();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            barTableNum = new Label();
            orderHistory = new Button();
            BarView = new Panel();
            sortButton = new Button();
            label1 = new Label();
            sortBox = new ComboBox();
            panelOrderHistory = new Panel();
            listViewHistory = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            backHistoryBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            BarView.SuspendLayout();
            panelOrderHistory.SuspendLayout();
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
            pictureBox4.Size = new Size(833, 72);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // barKitchenLabel
            // 
            barKitchenLabel.AutoSize = true;
            barKitchenLabel.BackColor = Color.FromArgb(255, 128, 0);
            barKitchenLabel.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            barKitchenLabel.Location = new Point(249, 72);
            barKitchenLabel.Name = "barKitchenLabel";
            barKitchenLabel.Size = new Size(236, 72);
            barKitchenLabel.TabIndex = 23;
            barKitchenLabel.Text = "Bar View";
            // 
            // bartenderKitchenView
            // 
            bartenderKitchenView.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            bartenderKitchenView.FullRowSelect = true;
            bartenderKitchenView.GridLines = true;
            bartenderKitchenView.Location = new Point(12, 150);
            bartenderKitchenView.MultiSelect = false;
            bartenderKitchenView.Name = "bartenderKitchenView";
            bartenderKitchenView.Size = new Size(441, 211);
            bartenderKitchenView.TabIndex = 24;
            bartenderKitchenView.UseCompatibleStateImageBehavior = false;
            bartenderKitchenView.View = View.Details;
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
            // barKitchenStatusView
            // 
            barKitchenStatusView.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader1, columnHeader2 });
            barKitchenStatusView.GridLines = true;
            barKitchenStatusView.Location = new Point(457, 206);
            barKitchenStatusView.Name = "barKitchenStatusView";
            barKitchenStatusView.Size = new Size(388, 155);
            barKitchenStatusView.TabIndex = 25;
            barKitchenStatusView.UseCompatibleStateImageBehavior = false;
            barKitchenStatusView.View = View.Details;
            barKitchenStatusView.SelectedIndexChanged += bartenderStatusView_SelectedIndexChanged;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Item";
            columnHeader7.Width = 125;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Status";
            columnHeader8.Width = 75;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order number";
            columnHeader1.Width = 125;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Time";
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
            // buttonPrepare
            // 
            buttonPrepare.Location = new Point(459, 171);
            buttonPrepare.Name = "buttonPrepare";
            buttonPrepare.Size = new Size(115, 29);
            buttonPrepare.TabIndex = 28;
            buttonPrepare.Text = "In preperation";
            buttonPrepare.UseVisualStyleBackColor = true;
            buttonPrepare.Click += barButtonPrepare_Click;
            // 
            // buttonPrepared
            // 
            buttonPrepared.Location = new Point(580, 171);
            buttonPrepared.Name = "buttonPrepared";
            buttonPrepared.Size = new Size(148, 29);
            buttonPrepared.TabIndex = 29;
            buttonPrepared.Text = "Prepeared";
            buttonPrepared.UseVisualStyleBackColor = true;
            buttonPrepared.Click += barButtonPrepared_Click;
            // 
            // buttonServed
            // 
            buttonServed.Location = new Point(734, 171);
            buttonServed.Name = "buttonServed";
            buttonServed.Size = new Size(111, 29);
            buttonServed.TabIndex = 30;
            buttonServed.Text = "Served";
            buttonServed.UseVisualStyleBackColor = true;
            buttonServed.Click += barButtonServed_Click;
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
            // orderHistory
            // 
            orderHistory.Location = new Point(12, 398);
            orderHistory.Name = "orderHistory";
            orderHistory.Size = new Size(160, 29);
            orderHistory.TabIndex = 36;
            orderHistory.Text = "Order History";
            orderHistory.UseVisualStyleBackColor = true;
            orderHistory.Click += orderHistory_Click;
            // 
            // BarView
            // 
            BarView.Controls.Add(sortButton);
            BarView.Controls.Add(label1);
            BarView.Controls.Add(sortBox);
            BarView.Controls.Add(orderHistory);
            BarView.Controls.Add(barTableNum);
            BarView.Controls.Add(label4);
            BarView.Controls.Add(label5);
            BarView.Controls.Add(label7);
            BarView.Controls.Add(buttonServed);
            BarView.Controls.Add(buttonPrepared);
            BarView.Controls.Add(buttonPrepare);
            BarView.Controls.Add(pictureBox1);
            BarView.Controls.Add(pictureBox2);
            BarView.Controls.Add(barKitchenStatusView);
            BarView.Controls.Add(bartenderKitchenView);
            BarView.Controls.Add(barKitchenLabel);
            BarView.Controls.Add(pictureBox4);
            BarView.Location = new Point(0, 1);
            BarView.Name = "BarView";
            BarView.Size = new Size(854, 451);
            BarView.TabIndex = 23;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(694, 42);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(151, 29);
            sortButton.TabIndex = 40;
            sortButton.Text = "Sort!";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(631, 14);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 39;
            label1.Text = "sort by:";
            // 
            // sortBox
            // 
            sortBox.DropDownStyle = ComboBoxStyle.DropDownList;
            sortBox.FormattingEnabled = true;
            sortBox.Items.AddRange(new object[] { "Item number", "Status" });
            sortBox.Location = new Point(694, 11);
            sortBox.Name = "sortBox";
            sortBox.Size = new Size(151, 28);
            sortBox.TabIndex = 38;
            // 
            // panelOrderHistory
            // 
            panelOrderHistory.Controls.Add(listViewHistory);
            panelOrderHistory.Controls.Add(backHistoryBtn);
            panelOrderHistory.Location = new Point(3, 1);
            panelOrderHistory.Name = "panelOrderHistory";
            panelOrderHistory.Size = new Size(848, 451);
            panelOrderHistory.TabIndex = 37;
            // 
            // listViewHistory
            // 
            listViewHistory.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader13 });
            listViewHistory.Location = new Point(78, 72);
            listViewHistory.Name = "listViewHistory";
            listViewHistory.Size = new Size(612, 289);
            listViewHistory.TabIndex = 1;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Order ID";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Item";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Start Time";
            columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "End time";
            columnHeader6.Width = 125;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Total time";
            columnHeader13.Width = 140;
            // 
            // backHistoryBtn
            // 
            backHistoryBtn.Location = new Point(23, 387);
            backHistoryBtn.Name = "backHistoryBtn";
            backHistoryBtn.Size = new Size(94, 29);
            backHistoryBtn.TabIndex = 0;
            backHistoryBtn.Text = "back";
            backHistoryBtn.UseVisualStyleBackColor = true;
            backHistoryBtn.Click += backHistoryBtn_Click;
            // 
            // KitchenBarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(tableNum);
            Controls.Add(BarView);
            Controls.Add(panelOrderHistory);
            Name = "KitchenBarView";
            Text = "Kitchen View/Bar View";
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            BarView.ResumeLayout(false);
            BarView.PerformLayout();
            panelOrderHistory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label tableNum;
        private PictureBox pictureBox4;
        private Label barKitchenLabel;
        private ListView bartenderKitchenView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ListView barKitchenStatusView;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button buttonPrepare;
        private Button buttonPrepared;
        private Button buttonServed;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label barTableNum;
        private Button orderHistory;
        private Panel BarView;
        private Panel panelOrderHistory;
        private ListView listViewHistory;
        private Button backHistoryBtn;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader13;
        private Button sortButton;
        private Label label1;
        private ComboBox sortBox;
    }
}