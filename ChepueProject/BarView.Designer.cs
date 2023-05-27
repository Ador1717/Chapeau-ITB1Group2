namespace ChepueProject
{
    partial class BarView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarView));
            listBarView = new ListView();
            orderID = new ColumnHeader();
            orderNumber = new ColumnHeader();
            count = new ColumnHeader();
            description = new ColumnHeader();
            listStatusView = new ListView();
            orderIDone = new ColumnHeader();
            status = new ColumnHeader();
            servedBtn = new Button();
            preparedBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            name = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            preperationBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBarView
            // 
            listBarView.Columns.AddRange(new ColumnHeader[] { orderID, orderNumber, count, description });
            listBarView.FullRowSelect = true;
            listBarView.GridLines = true;
            listBarView.Location = new Point(12, 149);
            listBarView.Name = "listBarView";
            listBarView.Size = new Size(439, 231);
            listBarView.TabIndex = 11;
            listBarView.UseCompatibleStateImageBehavior = false;
            listBarView.View = View.Details;
            // 
            // orderID
            // 
            orderID.Text = "Order ID";
            orderID.Width = 75;
            // 
            // orderNumber
            // 
            orderNumber.Text = "Order number";
            orderNumber.Width = 150;
            // 
            // count
            // 
            count.Text = "Count";
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 150;
            // 
            // listStatusView
            // 
            listStatusView.Columns.AddRange(new ColumnHeader[] { orderIDone, status });
            listStatusView.GridLines = true;
            listStatusView.Location = new Point(457, 207);
            listStatusView.Name = "listStatusView";
            listStatusView.Size = new Size(324, 173);
            listStatusView.TabIndex = 19;
            listStatusView.UseCompatibleStateImageBehavior = false;
            listStatusView.View = View.Details;
            // 
            // orderIDone
            // 
            orderIDone.Text = "Order ID";
            orderIDone.Width = 165;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 165;
            // 
            // servedBtn
            // 
            servedBtn.Location = new Point(687, 172);
            servedBtn.Name = "servedBtn";
            servedBtn.Size = new Size(94, 29);
            servedBtn.TabIndex = 18;
            servedBtn.Text = "Served";
            servedBtn.UseVisualStyleBackColor = true;
            servedBtn.Click += servedBtn_Click;
            // 
            // preparedBtn
            // 
            preparedBtn.Location = new Point(587, 172);
            preparedBtn.Name = "preparedBtn";
            preparedBtn.Size = new Size(94, 29);
            preparedBtn.TabIndex = 17;
            preparedBtn.Text = "Prepared";
            preparedBtn.UseVisualStyleBackColor = true;
            preparedBtn.Click += preparedBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 149);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 16;
            label3.Text = "Change order status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(253, 154, 39);
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(313, 89);
            label2.Name = "label2";
            label2.Size = new Size(211, 54);
            label2.TabIndex = 15;
            label2.Text = "Bar Orders";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(459, 54);
            name.Name = "name";
            name.Size = new Size(329, 20);
            name.TabIndex = 14;
            name.Text = "someone that will get the name from the system";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 62);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 81);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(769, 62);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // preperationBtn
            // 
            preperationBtn.Location = new Point(457, 172);
            preperationBtn.Name = "preperationBtn";
            preperationBtn.Size = new Size(124, 29);
            preperationBtn.TabIndex = 20;
            preperationBtn.Text = "In preparation";
            preperationBtn.UseVisualStyleBackColor = true;
            preperationBtn.Click += preperationBtn_Click;
            // 
            // BarView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBarView);
            Controls.Add(listStatusView);
            Controls.Add(servedBtn);
            Controls.Add(preparedBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(preperationBtn);
            Name = "BarView";
            Text = "Bar view";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListView listBarView;
        private ColumnHeader orderID;
        private ColumnHeader orderNumber;
        private ColumnHeader count;
        private ColumnHeader description;
        private ListView listStatusView;
        private ColumnHeader orderIDone;
        private ColumnHeader status;
        private Button servedBtn;
        private Button preparedBtn;
        private Label label3;
        private Label label2;
        private Label name;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button preperationBtn;
    }
}