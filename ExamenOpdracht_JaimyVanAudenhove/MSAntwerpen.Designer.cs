namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSAntwerpen
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movieStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locatieSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountAntwerpenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenDotNETAdvancedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examenDotNETAdvancedDataSet = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSet();
            this.moviesTableAdapter = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieStoreToolStripMenuItem
            // 
            this.movieStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locatieSelectToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
            this.movieStoreToolStripMenuItem.Name = "movieStoreToolStripMenuItem";
            this.movieStoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuItem.Text = "MovieStore";
            // 
            // locatieSelectToolStripMenuItem
            // 
            this.locatieSelectToolStripMenuItem.Name = "locatieSelectToolStripMenuItem";
            this.locatieSelectToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.locatieSelectToolStripMenuItem.Text = "Terug naar Locatie select";
            this.locatieSelectToolStripMenuItem.Click += new System.EventHandler(this.locatieSelectToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMovieId,
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.rentalDurationDataGridViewTextBoxColumn,
            this.amountAntwerpenDataGridViewTextBoxColumn,
            this.Lenen});
            this.dataGridView1.DataSource = this.moviesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(761, 426);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnMovieId
            // 
            this.ColumnMovieId.DataPropertyName = "MovieId";
            this.ColumnMovieId.HeaderText = "Film ID";
            this.ColumnMovieId.Name = "ColumnMovieId";
            this.ColumnMovieId.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Minimum Leeftijd";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentalDurationDataGridViewTextBoxColumn
            // 
            this.rentalDurationDataGridViewTextBoxColumn.DataPropertyName = "Rental_Duration";
            this.rentalDurationDataGridViewTextBoxColumn.HeaderText = "Aantal dagen leentijd";
            this.rentalDurationDataGridViewTextBoxColumn.Name = "rentalDurationDataGridViewTextBoxColumn";
            this.rentalDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountAntwerpenDataGridViewTextBoxColumn
            // 
            this.amountAntwerpenDataGridViewTextBoxColumn.DataPropertyName = "Amount_Antwerpen";
            this.amountAntwerpenDataGridViewTextBoxColumn.HeaderText = "Aantal Beschikbaar";
            this.amountAntwerpenDataGridViewTextBoxColumn.Name = "amountAntwerpenDataGridViewTextBoxColumn";
            this.amountAntwerpenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Lenen
            // 
            this.Lenen.HeaderText = "Deze Lenen";
            this.Lenen.Name = "Lenen";
            this.Lenen.ReadOnly = true;
            this.Lenen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lenen.Text = "Lenen";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.examenDotNETAdvancedDataSetBindingSource;
            // 
            // examenDotNETAdvancedDataSetBindingSource
            // 
            this.examenDotNETAdvancedDataSetBindingSource.DataSource = this.examenDotNETAdvancedDataSet;
            this.examenDotNETAdvancedDataSetBindingSource.Position = 0;
            // 
            // examenDotNETAdvancedDataSet
            // 
            this.examenDotNETAdvancedDataSet.DataSetName = "ExamenDotNETAdvancedDataSet";
            this.examenDotNETAdvancedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // MSAntwerpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MSAntwerpen";
            this.Text = "MovieStore Antwerpen";
            this.Load += new System.EventHandler(this.MSAntwerpen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locatieSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource examenDotNETAdvancedDataSetBindingSource;
        private ExamenDotNETAdvancedDataSet examenDotNETAdvancedDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountAntwerpenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Lenen;
    }
}