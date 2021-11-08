namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSGent
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
            this.movieStoreToolStripMenuMovieStore = new System.Windows.Forms.ToolStripMenuItem();
            this.LocatieSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examenDotNETAdvancedDataSet = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSetTableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.examenDotNETAdvancedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lenen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter();
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moviesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuMovieStore});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMSGent";
            // 
            // movieStoreToolStripMenuMovieStore
            // 
            this.movieStoreToolStripMenuMovieStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocatieSelectToolStripMenuItem});
            this.movieStoreToolStripMenuMovieStore.Name = "movieStoreToolStripMenuMovieStore";
            this.movieStoreToolStripMenuMovieStore.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuMovieStore.Text = "MovieStore";
            // 
            // LocatieSelectToolStripMenuItem
            // 
            this.LocatieSelectToolStripMenuItem.Name = "LocatieSelectToolStripMenuItem";
            this.LocatieSelectToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.LocatieSelectToolStripMenuItem.Text = "Terug naar Locatie select";
            this.LocatieSelectToolStripMenuItem.Click += new System.EventHandler(this.LocatieSelectToolStripMenuItem_Click);
            // 
            // examenDotNETAdvancedDataSet
            // 
            this.examenDotNETAdvancedDataSet.DataSetName = "ExamenDotNETAdvancedDataSet";
            this.examenDotNETAdvancedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.examenDotNETAdvancedDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.examenDotNETAdvancedDataSet;
            // 
            // examenDotNETAdvancedDataSetBindingSource
            // 
            this.examenDotNETAdvancedDataSetBindingSource.DataSource = this.examenDotNETAdvancedDataSet;
            this.examenDotNETAdvancedDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMovieId,
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.rentalDurationDataGridViewTextBoxColumn,
            this.amountGentDataGridViewTextBoxColumn,
            this.Lenen});
            this.dataGridView1.DataSource = this.moviesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 426);
            this.dataGridView1.TabIndex = 1;
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
            this.rentalDurationDataGridViewTextBoxColumn.HeaderText = "Aantal dagen  leentijd";
            this.rentalDurationDataGridViewTextBoxColumn.Name = "rentalDurationDataGridViewTextBoxColumn";
            this.rentalDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountGentDataGridViewTextBoxColumn
            // 
            this.amountGentDataGridViewTextBoxColumn.DataPropertyName = "Amount_Gent";
            this.amountGentDataGridViewTextBoxColumn.HeaderText = "Aantal Beschikbaar";
            this.amountGentDataGridViewTextBoxColumn.Name = "amountGentDataGridViewTextBoxColumn";
            this.amountGentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Lenen
            // 
            this.Lenen.HeaderText = "Deze Lenen";
            this.Lenen.Name = "Lenen";
            this.Lenen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lenen.Text = "Lenen";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.examenDotNETAdvancedDataSetBindingSource;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.examenDotNETAdvancedDataSetBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // moviesBindingSource2
            // 
            this.moviesBindingSource2.DataMember = "Movies";
            this.moviesBindingSource2.DataSource = this.examenDotNETAdvancedDataSetBindingSource;
            // 
            // MSGent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MSGent";
            this.Text = "MovieStore Gent";
            this.Load += new System.EventHandler(this.MSGent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuMovieStore;
        private System.Windows.Forms.ToolStripMenuItem LocatieSelectToolStripMenuItem;
        private ExamenDotNETAdvancedDataSet examenDotNETAdvancedDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private ExamenDotNETAdvancedDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.BindingSource examenDotNETAdvancedDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource moviesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMovieId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Lenen;
    }
}