namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSGeleendeFilms
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
            this.locatieSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieStoreToolStripMenuItem
            // 
            this.movieStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatieSelectToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
            this.movieStoreToolStripMenuItem.Name = "movieStoreToolStripMenuItem";
            this.movieStoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuItem.Text = "MovieStore";
            // 
            // locatieSelectToolStripMenuItem
            // 
            this.locatieSelectToolStripMenuItem.Name = "locatieSelectToolStripMenuItem";
            this.locatieSelectToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.locatieSelectToolStripMenuItem.Text = "terug naar Locatie select";
            this.locatieSelectToolStripMenuItem.Click += new System.EventHandler(this.locatieSelectToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // MSGeleendeFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MSGeleendeFilms";
            this.Text = "MSGeleendeFilms";
            this.Load += new System.EventHandler(this.MSGeleendeFilms_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatieSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}