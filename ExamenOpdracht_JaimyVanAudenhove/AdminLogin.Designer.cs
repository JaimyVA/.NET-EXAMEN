namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class AdminLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbPasswordLogin = new System.Windows.Forms.Label();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.lbUserNameLogin = new System.Windows.Forms.Label();
            this.tbUserNameLogin = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 130);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbPasswordLogin
            // 
            this.lbPasswordLogin.AutoSize = true;
            this.lbPasswordLogin.Location = new System.Drawing.Point(108, 88);
            this.lbPasswordLogin.Name = "lbPasswordLogin";
            this.lbPasswordLogin.Size = new System.Drawing.Size(53, 13);
            this.lbPasswordLogin.TabIndex = 9;
            this.lbPasswordLogin.Text = "Password";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(73, 104);
            this.tbPasswordLogin.MaxLength = 50;
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(131, 20);
            this.tbPasswordLogin.TabIndex = 8;
            // 
            // lbUserNameLogin
            // 
            this.lbUserNameLogin.AutoSize = true;
            this.lbUserNameLogin.Location = new System.Drawing.Point(108, 36);
            this.lbUserNameLogin.Name = "lbUserNameLogin";
            this.lbUserNameLogin.Size = new System.Drawing.Size(55, 13);
            this.lbUserNameLogin.TabIndex = 7;
            this.lbUserNameLogin.Text = "Username";
            // 
            // tbUserNameLogin
            // 
            this.tbUserNameLogin.Location = new System.Drawing.Point(73, 52);
            this.tbUserNameLogin.MaxLength = 50;
            this.tbUserNameLogin.Name = "tbUserNameLogin";
            this.tbUserNameLogin.Size = new System.Drawing.Size(131, 20);
            this.tbUserNameLogin.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.loginToolStripMenuItem.Text = "Login als gewone gebruiker";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // AdminLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 187);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbPasswordLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.lbUserNameLogin);
            this.Controls.Add(this.tbUserNameLogin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.Text = "Admin Login";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbPasswordLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Label lbUserNameLogin;
        private System.Windows.Forms.TextBox tbUserNameLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    }
}