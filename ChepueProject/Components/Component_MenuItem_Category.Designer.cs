namespace ChapeauUI.Components
{
    partial class Component_MenuItem_Category
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
            lbl_Category = new Label();
            splitter = new Splitter();
            pnl_Main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Main
            // 
            pnl_Main.BackColor = Color.SteelBlue;
            pnl_Main.Controls.Add(lbl_Category);
            pnl_Main.Controls.Add(splitter);
            pnl_Main.Dock = DockStyle.Fill;
            pnl_Main.Location = new Point(0, 0);
            pnl_Main.Margin = new Padding(2);
            pnl_Main.Name = "pnl_Main";
            pnl_Main.Size = new Size(333, 42);
            pnl_Main.TabIndex = 0;
            // 
            // lbl_Category
            // 
            lbl_Category.AutoSize = true;
            lbl_Category.Dock = DockStyle.Bottom;
            lbl_Category.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Category.Location = new Point(0, 3);
            lbl_Category.Margin = new Padding(0);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(126, 37);
            lbl_Category.TabIndex = 1;
            lbl_Category.Text = "Category";
            // 
            // splitter
            // 
            splitter.BackColor = Color.FromArgb(152, 151, 169);
            splitter.Dock = DockStyle.Bottom;
            splitter.Enabled = false;
            splitter.Location = new Point(0, 40);
            splitter.Margin = new Padding(0);
            splitter.Name = "splitter";
            splitter.Size = new Size(333, 2);
            splitter.TabIndex = 0;
            splitter.TabStop = false;
            // 
            // Component_MenuItem_Category
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(60, 60, 78);
            Controls.Add(pnl_Main);
            DoubleBuffered = true;
            Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(0);
            MaximumSize = new Size(333, 0);
            MinimumSize = new Size(333, 42);
            Name = "Component_MenuItem_Category";
            Size = new Size(333, 42);
            pnl_Main.ResumeLayout(false);
            pnl_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Main;
        private Label lbl_Category;
        private Splitter splitter;
    }
}
