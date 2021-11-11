namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSMoviesAdmin
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
            this.terugNaarAdminHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.examenDotNETAdvancedDataSet = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new ExamenOpdracht_JaimyVanAudenhove.ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter();
            this.movieIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountGentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountBrusselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountAntwerpenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnOneGent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReturnOneBrussel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ReturnOneAntwerpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movieStoreToolStripMenuItem
            // 
            this.movieStoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terugNaarAdminHomeToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
            this.movieStoreToolStripMenuItem.Name = "movieStoreToolStripMenuItem";
            this.movieStoreToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.movieStoreToolStripMenuItem.Text = "MovieStore";
            // 
            // terugNaarAdminHomeToolStripMenuItem
            // 
            this.terugNaarAdminHomeToolStripMenuItem.Name = "terugNaarAdminHomeToolStripMenuItem";
            this.terugNaarAdminHomeToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.terugNaarAdminHomeToolStripMenuItem.Text = "Terug naar Admin Home";
            this.terugNaarAdminHomeToolStripMenuItem.Click += new System.EventHandler(this.terugNaarAdminHomeToolStripMenuItem_Click);
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.rentalDurationDataGridViewTextBoxColumn,
            this.amountGentDataGridViewTextBoxColumn,
            this.amountBrusselDataGridViewTextBoxColumn,
            this.amountAntwerpenDataGridViewTextBoxColumn,
            this.returnedDataGridViewTextBoxColumn,
            this.ReturnOneGent,
            this.ReturnOneBrussel,
            this.ReturnOneAntwerpen});
            this.dataGridView1.DataSource = this.moviesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1245, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // examenDotNETAdvancedDataSet
            // 
            this.examenDotNETAdvancedDataSet.DataSetName = "ExamenDotNETAdvancedDataSet";
            this.examenDotNETAdvancedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.examenDotNETAdvancedDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // movieIdDataGridViewTextBoxColumn
            // 
            this.movieIdDataGridViewTextBoxColumn.DataPropertyName = "MovieId";
            this.movieIdDataGridViewTextBoxColumn.HeaderText = "MovieId";
            this.movieIdDataGridViewTextBoxColumn.Name = "movieIdDataGridViewTextBoxColumn";
            this.movieIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.movieIdDataGridViewTextBoxColumn.Width = 75;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naam";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Minimum Leeftijd";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // rentalDurationDataGridViewTextBoxColumn
            // 
            this.rentalDurationDataGridViewTextBoxColumn.DataPropertyName = "Rental_Duration";
            this.rentalDurationDataGridViewTextBoxColumn.HeaderText = "Leentijd";
            this.rentalDurationDataGridViewTextBoxColumn.Name = "rentalDurationDataGridViewTextBoxColumn";
            // 
            // amountGentDataGridViewTextBoxColumn
            // 
            this.amountGentDataGridViewTextBoxColumn.DataPropertyName = "Amount_Gent";
            this.amountGentDataGridViewTextBoxColumn.HeaderText = "Beschikbaar Gent";
            this.amountGentDataGridViewTextBoxColumn.Name = "amountGentDataGridViewTextBoxColumn";
            // 
            // amountBrusselDataGridViewTextBoxColumn
            // 
            this.amountBrusselDataGridViewTextBoxColumn.DataPropertyName = "Amount_Brussel";
            this.amountBrusselDataGridViewTextBoxColumn.HeaderText = "Beschikbaar Brussel";
            this.amountBrusselDataGridViewTextBoxColumn.Name = "amountBrusselDataGridViewTextBoxColumn";
            // 
            // amountAntwerpenDataGridViewTextBoxColumn
            // 
            this.amountAntwerpenDataGridViewTextBoxColumn.DataPropertyName = "Amount_Antwerpen";
            this.amountAntwerpenDataGridViewTextBoxColumn.HeaderText = "Beschikbaar Antwerpen";
            this.amountAntwerpenDataGridViewTextBoxColumn.Name = "amountAntwerpenDataGridViewTextBoxColumn";
            // 
            // returnedDataGridViewTextBoxColumn
            // 
            this.returnedDataGridViewTextBoxColumn.DataPropertyName = "Returned";
            this.returnedDataGridViewTextBoxColumn.HeaderText = "Teruggebracht";
            this.returnedDataGridViewTextBoxColumn.Name = "returnedDataGridViewTextBoxColumn";
            // 
            // ReturnOneGent
            // 
            this.ReturnOneGent.HeaderText = "Terug naar Gent";
            this.ReturnOneGent.Name = "ReturnOneGent";
            this.ReturnOneGent.Text = "1x naar Gent";
            this.ReturnOneGent.UseColumnTextForButtonValue = true;
            // 
            // ReturnOneBrussel
            // 
            this.ReturnOneBrussel.HeaderText = "Terug naar Brussel";
            this.ReturnOneBrussel.Name = "ReturnOneBrussel";
            // 
            // ReturnOneAntwerpen
            // 
            this.ReturnOneAntwerpen.HeaderText = "Terug naar Antwerpen";
            this.ReturnOneAntwerpen.Name = "ReturnOneAntwerpen";
            // 
            // MSMoviesAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MSMoviesAdmin";
            this.Text = "Admin paneel films";
            this.Load += new System.EventHandler(this.MSMoviesAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examenDotNETAdvancedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terugNaarAdminHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ExamenDotNETAdvancedDataSet examenDotNETAdvancedDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private ExamenDotNETAdvancedDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountGentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountBrusselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountAntwerpenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnOneGent;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnOneBrussel;
        private System.Windows.Forms.DataGridViewButtonColumn ReturnOneAntwerpen;
    }
}