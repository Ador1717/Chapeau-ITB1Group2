namespace Chapeau
{
    partial class Form1
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.BtnSignin = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtBoxRole = new System.Windows.Forms.TextBox();
            this.txtBoxNewPassword = new System.Windows.Forms.TextBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            this.pnlRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.BtnSignin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtBoxPassword);
            this.pnlLogin.Controls.Add(this.txtBoxUserName);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblUserName);
            this.pnlLogin.Location = new System.Drawing.Point(9, 257);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(379, 411);
            this.pnlLogin.TabIndex = 1;
            // 
            // BtnSignin
            // 
            this.BtnSignin.BackColor = System.Drawing.Color.Aqua;
            this.BtnSignin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.BtnSignin.Location = new System.Drawing.Point(65, 291);
            this.BtnSignin.Name = "BtnSignin";
            this.BtnSignin.Size = new System.Drawing.Size(180, 37);
            this.BtnSignin.TabIndex = 5;
            this.BtnSignin.Text = "Create a new account";
            this.BtnSignin.UseVisualStyleBackColor = false;
            this.BtnSignin.Click += new System.EventHandler(this.BtnSignin_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Chartreuse;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogin.Location = new System.Drawing.Point(66, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(179, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.Location = new System.Drawing.Point(153, 162);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.PlaceholderText = "Enter your password";
            this.txtBoxPassword.Size = new System.Drawing.Size(179, 31);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUserName.Location = new System.Drawing.Point(153, 89);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.PlaceholderText = "Enter your User Name";
            this.txtBoxUserName.Size = new System.Drawing.Size(179, 31);
            this.txtBoxUserName.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(10, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(118, 30);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(10, 89);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(133, 30);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.BackColor = System.Drawing.Color.White;
            this.pnlRegistration.Controls.Add(this.lblNewPassword);
            this.pnlRegistration.Controls.Add(this.lblRole);
            this.pnlRegistration.Controls.Add(this.txtBoxRole);
            this.pnlRegistration.Controls.Add(this.txtBoxNewPassword);
            this.pnlRegistration.Controls.Add(this.BtnRegister);
            this.pnlRegistration.Controls.Add(this.txtBoxName);
            this.pnlRegistration.Controls.Add(this.lblName);
            this.pnlRegistration.Location = new System.Drawing.Point(9, 262);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(379, 378);
            this.pnlRegistration.TabIndex = 5;
            this.pnlRegistration.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegistration_Paint);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewPassword.Location = new System.Drawing.Point(28, 178);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(118, 30);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRole.Location = new System.Drawing.Point(28, 118);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(63, 30);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role:";
            // 
            // txtBoxRole
            // 
            this.txtBoxRole.Location = new System.Drawing.Point(164, 115);
            this.txtBoxRole.Name = "txtBoxRole";
            this.txtBoxRole.PlaceholderText = "Chef/Waiter";
            this.txtBoxRole.Size = new System.Drawing.Size(183, 31);
            this.txtBoxRole.TabIndex = 5;
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(164, 172);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.PlaceholderText = "Enter your password";
            this.txtBoxNewPassword.Size = new System.Drawing.Size(183, 31);
            this.txtBoxNewPassword.TabIndex = 3;
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.Lime;
            this.BtnRegister.Location = new System.Drawing.Point(107, 256);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(148, 40);
            this.BtnRegister.TabIndex = 2;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(164, 58);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PlaceholderText = "Enter your username";
            this.txtBoxName.Size = new System.Drawing.Size(183, 31);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(28, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(123, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chapeau.Properties.Resources.chapaue1;
            this.pictureBox1.Location = new System.Drawing.Point(48, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel pnlLogin;
        private Button btnLogin;
        private TextBox txtBoxPassword;
        private TextBox txtBoxUserName;
        private Label lblPassword;
        private Label lblUserName;
        private Panel pnlRegistration;
        private Label lblNewPassword;
        private Label lblRole;
        private TextBox txtBoxRole;
        private TextBox txtBoxNewPassword;
        private Button BtnRegister;
        private TextBox txtBoxName;
        private Label lblName;
        private Button BtnSignin;
        private PictureBox pictureBox1;
    }
}