namespace ChepueUI
{
    partial class KitchenView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenView));
            label1 = new Label();
            listViewKitchen = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listViewStatus = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            preperationBtn = new Button();
            prepearedBtn = new Button();
            servedBtn = new Button();
            label3 = new Label();
            tableNum = new Label();
            label2 = new Label();
            BarView = new Panel();
            barTableNum = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            barButtonServed = new Button();
            barButtonPrepared = new Button();
            barButtonPrepare = new Button();
            pictureBox2 = new PictureBox();
            bartenderStatusView = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            bartenderView = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            BarView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 128, 0);
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(249, 70);
            label1.Name = "label1";
            label1.Size = new Size(336, 72);
            label1.TabIndex = 0;
            label1.Text = "Kitchen View";
            // 
            // listViewKitchen
            // 
            listViewKitchen.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewKitchen.FullRowSelect = true;
            listViewKitchen.GridLines = true;
            listViewKitchen.Location = new Point(12, 148);
            listViewKitchen.Name = "listViewKitchen";
            listViewKitchen.Size = new Size(441, 211);
            listViewKitchen.TabIndex = 1;
            listViewKitchen.UseCompatibleStateImageBehavior = false;
            listViewKitchen.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Order ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order number";
            columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Count";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Description";
            columnHeader4.Width = 115;
            // 
            // listViewStatus
            // 
            listViewStatus.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            listViewStatus.GridLines = true;
            listViewStatus.Location = new Point(459, 204);
            listViewStatus.Name = "listViewStatus";
            listViewStatus.Size = new Size(329, 155);
            listViewStatus.TabIndex = 2;
            listViewStatus.UseCompatibleStateImageBehavior = false;
            listViewStatus.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Order ID";
            columnHeader5.Width = 175;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Status";
            columnHeader6.Width = 150;
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
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 70);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(776, 72);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // preperationBtn
            // 
            preperationBtn.Location = new Point(459, 169);
            preperationBtn.Name = "preperationBtn";
            preperationBtn.Size = new Size(115, 29);
            preperationBtn.TabIndex = 16;
            preperationBtn.Text = "In preperation";
            preperationBtn.UseVisualStyleBackColor = true;
            preperationBtn.Click += btnPreperation_Click;
            // 
            // prepearedBtn
            // 
            prepearedBtn.Location = new Point(580, 169);
            prepearedBtn.Name = "prepearedBtn";
            prepearedBtn.Size = new Size(91, 29);
            prepearedBtn.TabIndex = 17;
            prepearedBtn.Text = "Prepeared";
            prepearedBtn.UseVisualStyleBackColor = true;
            prepearedBtn.Click += prepearedBtn_Click;
            // 
            // servedBtn
            // 
            servedBtn.Location = new Point(677, 169);
            servedBtn.Name = "servedBtn";
            servedBtn.Size = new Size(111, 29);
            servedBtn.TabIndex = 18;
            servedBtn.Text = "Served";
            servedBtn.UseVisualStyleBackColor = true;
            servedBtn.Click += servedBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 146);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 19;
            label3.Text = "Change order status";
            // 
            // tableNum
            // 
            tableNum.AutoSize = true;
            tableNum.Location = new Point(249, 44);
            tableNum.Name = "tableNum";
            tableNum.Size = new Size(0, 20);
            tableNum.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 44);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 22;
            label2.Text = "Table number:";
            // 
            // BarView
            // 
            BarView.Controls.Add(comboBox1);
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
            BarView.Location = new Point(6, 1);
            BarView.Name = "BarView";
            BarView.Size = new Size(793, 447);
            BarView.TabIndex = 23;
            // 
            // barTableNum
            // 
            barTableNum.AutoSize = true;
            barTableNum.Location = new Point(250, 49);
            barTableNum.Name = "barTableNum";
            barTableNum.Size = new Size(0, 20);
            barTableNum.TabIndex = 35;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 46);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 33;
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
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 62);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
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
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 72);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(776, 72);
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(631, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 36;
            // 
            // KitchenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BarView);
            Controls.Add(label2);
            Controls.Add(tableNum);
            Controls.Add(servedBtn);
            Controls.Add(prepearedBtn);
            Controls.Add(label3);
            Controls.Add(listViewStatus);
            Controls.Add(listViewKitchen);
            Controls.Add(label1);
            Controls.Add(preperationBtn);
            Controls.Add(pictureBox3);
            Name = "KitchenView";
            Text = "Kitchen View/Bar View";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            BarView.ResumeLayout(false);
            BarView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listViewKitchen;
        private ListView listViewStatus;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button preperationBtn;
        private Button prepearedBtn;
        private Button servedBtn;
        private Label label3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label tableNum;
        private Label label2;
        private Panel BarView;
        private Label label4;
        private Label label5;
        private Label label7;
        private Button barButtonServed;
        private Button barButtonPrepared;
        private Button barButtonPrepare;
        private PictureBox pictureBox2;
        private ListView bartenderStatusView;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ListView bartenderView;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label label8;
        private PictureBox pictureBox4;
        private Label barTableNum;
        private ComboBox comboBox1;
    }
}