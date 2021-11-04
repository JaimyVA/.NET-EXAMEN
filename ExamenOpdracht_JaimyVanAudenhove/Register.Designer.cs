namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbLoginInstead = new System.Windows.Forms.Label();
            this.lbPasswordRegister = new System.Windows.Forms.Label();
            this.tbPasswordRegister = new System.Windows.Forms.TextBox();
            this.lbUserNameRegister = new System.Windows.Forms.Label();
            this.tbUserNameRegister = new System.Windows.Forms.TextBox();
            this.lbGeboortedatumRegister = new System.Windows.Forms.Label();
            this.dateTimePickerGeboortedatumRegister = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(93, 167);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbLoginInstead
            // 
            this.lbLoginInstead.AutoSize = true;
            this.lbLoginInstead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginInstead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLoginInstead.Location = new System.Drawing.Point(98, 196);
            this.lbLoginInstead.Name = "lbLoginInstead";
            this.lbLoginInstead.Size = new System.Drawing.Size(70, 13);
            this.lbLoginInstead.TabIndex = 10;
            this.lbLoginInstead.Text = "Login instead";
            this.lbLoginInstead.Click += new System.EventHandler(this.lbLoginInstead_Click);
            // 
            // lbPasswordRegister
            // 
            this.lbPasswordRegister.AutoSize = true;
            this.lbPasswordRegister.Location = new System.Drawing.Point(104, 74);
            this.lbPasswordRegister.Name = "lbPasswordRegister";
            this.lbPasswordRegister.Size = new System.Drawing.Size(53, 13);
            this.lbPasswordRegister.TabIndex = 9;
            this.lbPasswordRegister.Text = "Password";
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.Location = new System.Drawing.Point(69, 90);
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.PasswordChar = '*';
            this.tbPasswordRegister.Size = new System.Drawing.Size(131, 20);
            this.tbPasswordRegister.TabIndex = 8;
            // 
            // lbUserNameRegister
            // 
            this.lbUserNameRegister.AutoSize = true;
            this.lbUserNameRegister.Location = new System.Drawing.Point(104, 22);
            this.lbUserNameRegister.Name = "lbUserNameRegister";
            this.lbUserNameRegister.Size = new System.Drawing.Size(55, 13);
            this.lbUserNameRegister.TabIndex = 7;
            this.lbUserNameRegister.Text = "Username";
            // 
            // tbUserNameRegister
            // 
            this.tbUserNameRegister.Location = new System.Drawing.Point(69, 38);
            this.tbUserNameRegister.Name = "tbUserNameRegister";
            this.tbUserNameRegister.Size = new System.Drawing.Size(131, 20);
            this.tbUserNameRegister.TabIndex = 6;
            // 
            // lbGeboortedatumRegister
            // 
            this.lbGeboortedatumRegister.AutoSize = true;
            this.lbGeboortedatumRegister.Location = new System.Drawing.Point(90, 125);
            this.lbGeboortedatumRegister.Name = "lbGeboortedatumRegister";
            this.lbGeboortedatumRegister.Size = new System.Drawing.Size(80, 13);
            this.lbGeboortedatumRegister.TabIndex = 12;
            this.lbGeboortedatumRegister.Text = "Geboortedatum";
            // 
            // dateTimePickerGeboortedatumRegister
            // 
            this.dateTimePickerGeboortedatumRegister.Location = new System.Drawing.Point(39, 141);
            this.dateTimePickerGeboortedatumRegister.Name = "dateTimePickerGeboortedatumRegister";
            this.dateTimePickerGeboortedatumRegister.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerGeboortedatumRegister.TabIndex = 13;
            this.dateTimePickerGeboortedatumRegister.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // MSRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 234);
            this.Controls.Add(this.dateTimePickerGeboortedatumRegister);
            this.Controls.Add(this.lbGeboortedatumRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lbLoginInstead);
            this.Controls.Add(this.lbPasswordRegister);
            this.Controls.Add(this.tbPasswordRegister);
            this.Controls.Add(this.lbUserNameRegister);
            this.Controls.Add(this.tbUserNameRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MSRegister";
            this.Text = "MovieStore Register";
            this.Load += new System.EventHandler(this.MSRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbLoginInstead;
        private System.Windows.Forms.Label lbPasswordRegister;
        private System.Windows.Forms.TextBox tbPasswordRegister;
        private System.Windows.Forms.Label lbUserNameRegister;
        private System.Windows.Forms.TextBox tbUserNameRegister;
        private System.Windows.Forms.Label lbGeboortedatumRegister;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboortedatumRegister;
    }
}