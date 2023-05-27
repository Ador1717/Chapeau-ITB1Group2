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
            name = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            pictureBox1.Location = new Point(12, 2);
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
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(738, 44);
            name.Name = "name";
            name.Size = new Size(50, 20);
            name.TabIndex = 20;
            name.Text = "label2";
            // 
            // KitchenView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(servedBtn);
            Controls.Add(prepearedBtn);
            Controls.Add(preperationBtn);
            Controls.Add(pictureBox1);
            Controls.Add(listViewStatus);
            Controls.Add(listViewKitchen);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Name = "KitchenView";
            Text = "Kitchen View";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label name;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}