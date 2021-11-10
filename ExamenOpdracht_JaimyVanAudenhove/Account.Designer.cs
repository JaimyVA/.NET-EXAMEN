namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class Account
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
            this.dateTimePickerGeboortedatumAccount = new System.Windows.Forms.DateTimePicker();
            this.lbGeboortedatumAccount = new System.Windows.Forms.Label();
            this.btnChangeAccount = new System.Windows.Forms.Button();
            this.lbPasswordAccount = new System.Windows.Forms.Label();
            this.tbPasswordAccount = new System.Windows.Forms.TextBox();
            this.lbUserNameAccount = new System.Windows.Forms.Label();
            this.tbUserNameAccount = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbStrikesAccount = new System.Windows.Forms.Label();
            this.movieStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terugNaarHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerGeboortedatumAccount
            // 
            this.dateTimePickerGeboortedatumAccount.Location = new System.Drawing.Point(46, 157);
            this.dateTimePickerGeboortedatumAccount.Name = "dateTimePickerGeboortedatumAccount";
            this.dateTimePickerGeboortedatumAccount.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGeboortedatumAccount.TabIndex = 21;
            this.dateTimePickerGeboortedatumAccount.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // lbGeboortedatumAccount
            // 
            this.lbGeboortedatumAccount.AutoSize = true;
            this.lbGeboortedatumAccount.Location = new System.Drawing.Point(97, 141);
            this.lbGeboortedatumAccount.Name = "lbGeboortedatumAccount";
            this.lbGeboortedatumAccount.Size = new System.Drawing.Size(80, 13);
            this.lbGeboortedatumAccount.TabIndex = 20;
            this.lbGeboortedatumAccount.Text = "Geboortedatum";
            // 
            // btnChangeAccount
            // 
            this.btnChangeAccount.Location = new System.Drawing.Point(83, 183);
            this.btnChangeAccount.Name = "btnChangeAccount";
            this.btnChangeAccount.Size = new System.Drawing.Size(124, 23);
            this.btnChangeAccount.TabIndex = 19;
            this.btnChangeAccount.Text = "Verander gegevens";
            this.btnChangeAccount.UseVisualStyleBackColor = true;
            this.btnChangeAccount.Click += new System.EventHandler(this.btnChangeAccount_Click);
            // 
            // lbPasswordAccount
            // 
            this.lbPasswordAccount.AutoSize = true;
            this.lbPasswordAccount.Location = new System.Drawing.Point(111, 90);
            this.lbPasswordAccount.Name = "lbPasswordAccount";
            this.lbPasswordAccount.Size = new System.Drawing.Size(53, 13);
            this.lbPasswordAccount.TabIndex = 17;
            this.lbPasswordAccount.Text = "Password";
            // 
            // tbPasswordAccount
            // 
            this.tbPasswordAccount.Location = new System.Drawing.Point(76, 106);
            this.tbPasswordAccount.Name = "tbPasswordAccount";
            this.tbPasswordAccount.PasswordChar = '*';
            this.tbPasswordAccount.Size = new System.Drawing.Size(131, 20);
            this.tbPasswordAccount.TabIndex = 16;
            // 
            // lbUserNameAccount
            // 
            this.lbUserNameAccount.AutoSize = true;
            this.lbUserNameAccount.Location = new System.Drawing.Point(111, 38);
            this.lbUserNameAccount.Name = "lbUserNameAccount";
            this.lbUserNameAccount.Size = new System.Drawing.Size(55, 13);
            this.lbUserNameAccount.TabIndex = 15;
            this.lbUserNameAccount.Text = "Username";
            // 
            // tbUserNameAccount
            // 
            this.tbUserNameAccount.Location = new System.Drawing.Point(76, 54);
            this.tbUserNameAccount.Name = "tbUserNameAccount";
            this.tbUserNameAccount.Size = new System.Drawing.Size(131, 20);
            this.tbUserNameAccount.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(285, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbStrikesAccount
            // 
            this.lbStrikesAccount.AutoSize = true;
            this.lbStrikesAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStrikesAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStrikesAccount.Location = new System.Drawing.Point(0, 242);
            this.lbStrikesAccount.Name = "lbStrikesAccount";
            this.lbStrikesAccount.Size = new System.Drawing.Size(46, 17);
            this.lbStrikesAccount.TabIndex = 23;
            this.lbStrikesAccount.Text = "label1";
            this.lbStrikesAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // movieStoreToolStripMenuItem
            // 
            this.movieStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terugNaarHomeToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
            this.movieStoreToolStripMenuItem.Name = "movieStoreToolStripMenuItem";
            this.movieStoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuItem.Text = "MovieStore";
            // 
            // terugNaarHomeToolStripMenuItem
            // 
            this.terugNaarHomeToolStripMenuItem.Name = "terugNaarHomeToolStripMenuItem";
            this.terugNaarHomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.terugNaarHomeToolStripMenuItem.Text = "Terug naar Home";
            this.terugNaarHomeToolStripMenuItem.Click += new System.EventHandler(this.terugNaarHomeToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 259);
            this.Controls.Add(this.lbStrikesAccount);
            this.Controls.Add(this.dateTimePickerGeboortedatumAccount);
            this.Controls.Add(this.lbGeboortedatumAccount);
            this.Controls.Add(this.btnChangeAccount);
            this.Controls.Add(this.lbPasswordAccount);
            this.Controls.Add(this.tbPasswordAccount);
            this.Controls.Add(this.lbUserNameAccount);
            this.Controls.Add(this.tbUserNameAccount);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Account";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerGeboortedatumAccount;
        private System.Windows.Forms.Label lbGeboortedatumAccount;
        private System.Windows.Forms.Button btnChangeAccount;
        private System.Windows.Forms.Label lbPasswordAccount;
        private System.Windows.Forms.TextBox tbPasswordAccount;
        private System.Windows.Forms.Label lbUserNameAccount;
        private System.Windows.Forms.TextBox tbUserNameAccount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbStrikesAccount;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terugNaarHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
    }
}