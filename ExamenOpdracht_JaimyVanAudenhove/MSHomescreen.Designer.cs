namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSHomescreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSHomescreen));
            this.lbWelcomeHomescreen = new System.Windows.Forms.Label();
            this.lbKiesWinkelHomepage = new System.Windows.Forms.Label();
            this.btnLocatie1Home = new System.Windows.Forms.Button();
            this.btnLocatie2Home = new System.Windows.Forms.Button();
            this.btnLocatie3Home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcomeHomescreen
            // 
            this.lbWelcomeHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWelcomeHomescreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeHomescreen.Location = new System.Drawing.Point(0, 0);
            this.lbWelcomeHomescreen.Name = "lbWelcomeHomescreen";
            this.lbWelcomeHomescreen.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lbWelcomeHomescreen.Size = new System.Drawing.Size(787, 68);
            this.lbWelcomeHomescreen.TabIndex = 0;
            this.lbWelcomeHomescreen.Text = "Welkom";
            this.lbWelcomeHomescreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbKiesWinkelHomepage
            // 
            this.lbKiesWinkelHomepage.AutoSize = true;
            this.lbKiesWinkelHomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKiesWinkelHomepage.Location = new System.Drawing.Point(313, 93);
            this.lbKiesWinkelHomepage.Name = "lbKiesWinkelHomepage";
            this.lbKiesWinkelHomepage.Size = new System.Drawing.Size(160, 17);
            this.lbKiesWinkelHomepage.TabIndex = 1;
            this.lbKiesWinkelHomepage.Text = "Kies MovieStore Locatie";
            // 
            // btnLocatie1Home
            // 
            this.btnLocatie1Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocatie1Home.BackgroundImage")));
            this.btnLocatie1Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocatie1Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocatie1Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocatie1Home.Location = new System.Drawing.Point(12, 132);
            this.btnLocatie1Home.Name = "btnLocatie1Home";
            this.btnLocatie1Home.Size = new System.Drawing.Size(250, 220);
            this.btnLocatie1Home.TabIndex = 2;
            this.btnLocatie1Home.Text = "Gent";
            this.btnLocatie1Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocatie1Home.UseVisualStyleBackColor = true;
            this.btnLocatie1Home.Click += new System.EventHandler(this.btnLocatie1Home_Click);
            // 
            // btnLocatie2Home
            // 
            this.btnLocatie2Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocatie2Home.BackgroundImage")));
            this.btnLocatie2Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocatie2Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocatie2Home.Location = new System.Drawing.Point(268, 132);
            this.btnLocatie2Home.Name = "btnLocatie2Home";
            this.btnLocatie2Home.Size = new System.Drawing.Size(250, 220);
            this.btnLocatie2Home.TabIndex = 3;
            this.btnLocatie2Home.Text = "Brussel";
            this.btnLocatie2Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocatie2Home.UseVisualStyleBackColor = true;
            this.btnLocatie2Home.Click += new System.EventHandler(this.btnLocatie2Home_Click);
            // 
            // btnLocatie3Home
            // 
            this.btnLocatie3Home.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLocatie3Home.BackgroundImage")));
            this.btnLocatie3Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLocatie3Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocatie3Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLocatie3Home.Location = new System.Drawing.Point(525, 132);
            this.btnLocatie3Home.Name = "btnLocatie3Home";
            this.btnLocatie3Home.Size = new System.Drawing.Size(250, 220);
            this.btnLocatie3Home.TabIndex = 4;
            this.btnLocatie3Home.Text = "Antwerpen";
            this.btnLocatie3Home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLocatie3Home.UseVisualStyleBackColor = true;
            this.btnLocatie3Home.Click += new System.EventHandler(this.btnLocatie3Home_Click);
            // 
            // MSHomescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 443);
            this.Controls.Add(this.btnLocatie3Home);
            this.Controls.Add(this.btnLocatie2Home);
            this.Controls.Add(this.btnLocatie1Home);
            this.Controls.Add(this.lbKiesWinkelHomepage);
            this.Controls.Add(this.lbWelcomeHomescreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MSHomescreen";
            this.Text = "MovieStore Home";
            this.Load += new System.EventHandler(this.MSHomescreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcomeHomescreen;
        private System.Windows.Forms.Label lbKiesWinkelHomepage;
        private System.Windows.Forms.Button btnLocatie1Home;
        private System.Windows.Forms.Button btnLocatie2Home;
        private System.Windows.Forms.Button btnLocatie3Home;
    }
}