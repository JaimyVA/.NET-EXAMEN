namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSAdminHomescreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGebruikersAdmin = new System.Windows.Forms.Button();
            this.lbWelcomeHomescreen = new System.Windows.Forms.Label();
            this.btnFilmsAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewMovieAdmin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(447, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieStoreToolStripMenuItem
            // 
            this.movieStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uitloggenToolStripMenuItem});
            this.movieStoreToolStripMenuItem.Name = "movieStoreToolStripMenuItem";
            this.movieStoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuItem.Text = "MovieStore";
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // btnGebruikersAdmin
            // 
            this.btnGebruikersAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGebruikersAdmin.Location = new System.Drawing.Point(140, 106);
            this.btnGebruikersAdmin.Name = "btnGebruikersAdmin";
            this.btnGebruikersAdmin.Size = new System.Drawing.Size(163, 81);
            this.btnGebruikersAdmin.TabIndex = 7;
            this.btnGebruikersAdmin.Text = "Gebruikers";
            this.btnGebruikersAdmin.UseVisualStyleBackColor = true;
            this.btnGebruikersAdmin.Click += new System.EventHandler(this.btnGebruikersAdmin_Click);
            // 
            // lbWelcomeHomescreen
            // 
            this.lbWelcomeHomescreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbWelcomeHomescreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcomeHomescreen.Location = new System.Drawing.Point(0, 24);
            this.lbWelcomeHomescreen.Name = "lbWelcomeHomescreen";
            this.lbWelcomeHomescreen.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.lbWelcomeHomescreen.Size = new System.Drawing.Size(447, 68);
            this.lbWelcomeHomescreen.TabIndex = 8;
            this.lbWelcomeHomescreen.Text = "Welkom";
            this.lbWelcomeHomescreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbWelcomeHomescreen.Click += new System.EventHandler(this.lbWelcomeHomescreen_Click);
            // 
            // btnFilmsAdmin
            // 
            this.btnFilmsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmsAdmin.Location = new System.Drawing.Point(140, 221);
            this.btnFilmsAdmin.Name = "btnFilmsAdmin";
            this.btnFilmsAdmin.Size = new System.Drawing.Size(163, 81);
            this.btnFilmsAdmin.TabIndex = 9;
            this.btnFilmsAdmin.Text = "Films";
            this.btnFilmsAdmin.UseVisualStyleBackColor = true;
            this.btnFilmsAdmin.Click += new System.EventHandler(this.btnFilmsAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bekijk de gebruikers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bekijk de films en stuur ze terug";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Voeg nieuwe films toe";
            // 
            // btnNewMovieAdmin
            // 
            this.btnNewMovieAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMovieAdmin.Location = new System.Drawing.Point(140, 338);
            this.btnNewMovieAdmin.Name = "btnNewMovieAdmin";
            this.btnNewMovieAdmin.Size = new System.Drawing.Size(163, 81);
            this.btnNewMovieAdmin.TabIndex = 12;
            this.btnNewMovieAdmin.Text = "Nieuwe film toevoegen";
            this.btnNewMovieAdmin.UseVisualStyleBackColor = true;
            this.btnNewMovieAdmin.Click += new System.EventHandler(this.btnNewMovieAdmin_Click);
            // 
            // MSAdminHomescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewMovieAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFilmsAdmin);
            this.Controls.Add(this.lbWelcomeHomescreen);
            this.Controls.Add(this.btnGebruikersAdmin);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MSAdminHomescreen";
            this.Text = "MovieStore Admin";
            this.Load += new System.EventHandler(this.MSAdminHomescreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.Button btnGebruikersAdmin;
        private System.Windows.Forms.Label lbWelcomeHomescreen;
        private System.Windows.Forms.Button btnFilmsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewMovieAdmin;
    }
}