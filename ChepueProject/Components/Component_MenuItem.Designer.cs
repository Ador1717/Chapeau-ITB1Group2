namespace ChapeauUI.Components
{
    partial class Component_MenuItem
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
            lbl_ItemName = new Label();
            pnl_Main = new Panel();
            splitter = new Splitter();
            pnl_Bottom = new Panel();
            pnl_Main.SuspendLayout();
            pnl_Bottom.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ItemName
            // 
            lbl_ItemName.AutoSize = true;
            lbl_ItemName.Dock = DockStyle.Top;
            lbl_ItemName.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ItemName.Location = new Point(0, 0);
            lbl_ItemName.Margin = new Padding(0);
            lbl_ItemName.MaximumSize = new Size(310, 0);
            lbl_ItemName.Name = "lbl_ItemName";
            lbl_ItemName.Padding = new Padding(8, 8, 0, 0);
            lbl_ItemName.Size = new Size(79, 47);
            lbl_ItemName.TabIndex = 0;
            lbl_ItemName.Text = "Steak";
            lbl_ItemName.UseCompatibleTextRendering = true;
            lbl_ItemName.Click += AddItem_Click;
            // 
            // pnl_Main
            // 
            pnl_Main.AutoSize = true;
            pnl_Main.BackColor = Color.SteelBlue;
            pnl_Main.Controls.Add(lbl_ItemName);
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.Location = new Point(0, 0);
            pnl_Main.Margin = new Padding(0);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.Size = new Size(333, 52);
            pnl_Main.TabIndex = 3;
            pnl_Main.Click += AddItem_Click;
            // 
            // splitter
            // 
            splitter.BackColor = Color.FromArgb(106, 105, 123);
            splitter.Dock = DockStyle.Bottom;
            splitter.Enabled = false;
            splitter.Location = new Point(12, 0);
            splitter.Margin = new Padding(0);
            splitter.Name = "splitter";
            splitter.Size = new Size(309, 2);
            splitter.TabIndex = 4;
            splitter.TabStop = false;
            // 
            // pnl_Bottom
            // 
            pnl_Bottom.Controls.Add(splitter);
            pnl_Bottom.Dock = DockStyle.Bottom;
            pnl_Bottom.Location = new Point(0, 52);
            pnl_Bottom.Margin = new Padding(2);
            pnl_Bottom.Name = "pnl_Bottom";
            pnl_Bottom.Padding = new Padding(12, 0, 12, 0);
            pnl_Bottom.Size = new Size(333, 2);
            pnl_Bottom.TabIndex = 3;
            // 
            // Component_MenuItem
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(60, 60, 78);
            Controls.Add(pnl_Main);
            Controls.Add(pnl_Bottom);
            DoubleBuffered = true;
            Font = new Font("Calibri", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(0);
            MaximumSize = new Size(333, 0);
            MinimumSize = new Size(333, 54);
            Name = "Component_MenuItem";
            Size = new Size(333, 54);
            Click += AddItem_Click;
            pnl_Main.ResumeLayout(false);
            pnl_Main.PerformLayout();
            pnl_Bottom.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ItemName;
        private Panel pnl_Main;
        private Splitter splitter;
        private Panel pnl_Bottom;
    }
}
