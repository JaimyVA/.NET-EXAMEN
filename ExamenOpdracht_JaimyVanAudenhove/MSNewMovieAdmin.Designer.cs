namespace ExamenOpdracht_JaimyVanAudenhove
{
    partial class MSNewMovieAdmin
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
            this.terugNaarAdminHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbNieuweFilmAdminNewMovie = new System.Windows.Forms.Label();
            this.lbFilmNaamAdminNewMovie = new System.Windows.Forms.Label();
            this.lbFilmRatingAdminNewMovie = new System.Windows.Forms.Label();
            this.lbFilmLeentijdAdminNewMovie = new System.Windows.Forms.Label();
            this.lbAantalBrusselAdminNewMovie = new System.Windows.Forms.Label();
            this.lbAantalGentAdminNewMovie = new System.Windows.Forms.Label();
            this.lbAantalAntwerpenAdminNewMovie = new System.Windows.Forms.Label();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.numMinAge = new System.Windows.Forms.NumericUpDown();
            this.numLeentijd = new System.Windows.Forms.NumericUpDown();
            this.numAmountBrussel = new System.Windows.Forms.NumericUpDown();
            this.numAmountGent = new System.Windows.Forms.NumericUpDown();
            this.numAmountAntwerpen = new System.Windows.Forms.NumericUpDown();
            this.btnAddNewMovieAdminMovies = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeentijd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountBrussel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountGent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountAntwerpen)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieStoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 24);
            this.menuStrip1.TabIndex = 3;
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
            // lbNieuweFilmAdminNewMovie
            // 
            this.lbNieuweFilmAdminNewMovie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbNieuweFilmAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNieuweFilmAdminNewMovie.Location = new System.Drawing.Point(174, 31);
            this.lbNieuweFilmAdminNewMovie.Name = "lbNieuweFilmAdminNewMovie";
            this.lbNieuweFilmAdminNewMovie.Size = new System.Drawing.Size(94, 20);
            this.lbNieuweFilmAdminNewMovie.TabIndex = 4;
            this.lbNieuweFilmAdminNewMovie.Text = "Nieuwe Film";
            // 
            // lbFilmNaamAdminNewMovie
            // 
            this.lbFilmNaamAdminNewMovie.AutoSize = true;
            this.lbFilmNaamAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmNaamAdminNewMovie.Location = new System.Drawing.Point(182, 71);
            this.lbFilmNaamAdminNewMovie.Name = "lbFilmNaamAdminNewMovie";
            this.lbFilmNaamAdminNewMovie.Size = new System.Drawing.Size(72, 17);
            this.lbFilmNaamAdminNewMovie.TabIndex = 5;
            this.lbFilmNaamAdminNewMovie.Text = "Film naam";
            // 
            // lbFilmRatingAdminNewMovie
            // 
            this.lbFilmRatingAdminNewMovie.AutoSize = true;
            this.lbFilmRatingAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmRatingAdminNewMovie.Location = new System.Drawing.Point(78, 114);
            this.lbFilmRatingAdminNewMovie.Name = "lbFilmRatingAdminNewMovie";
            this.lbFilmRatingAdminNewMovie.Size = new System.Drawing.Size(108, 17);
            this.lbFilmRatingAdminNewMovie.TabIndex = 6;
            this.lbFilmRatingAdminNewMovie.Text = "Minimum leeftijd";
            // 
            // lbFilmLeentijdAdminNewMovie
            // 
            this.lbFilmLeentijdAdminNewMovie.AutoSize = true;
            this.lbFilmLeentijdAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilmLeentijdAdminNewMovie.Location = new System.Drawing.Point(219, 114);
            this.lbFilmLeentijdAdminNewMovie.Name = "lbFilmLeentijdAdminNewMovie";
            this.lbFilmLeentijdAdminNewMovie.Size = new System.Drawing.Size(141, 17);
            this.lbFilmLeentijdAdminNewMovie.TabIndex = 7;
            this.lbFilmLeentijdAdminNewMovie.Text = "Aantal dagen leentijd";
            // 
            // lbAantalBrusselAdminNewMovie
            // 
            this.lbAantalBrusselAdminNewMovie.AutoSize = true;
            this.lbAantalBrusselAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAantalBrusselAdminNewMovie.Location = new System.Drawing.Point(163, 178);
            this.lbAantalBrusselAdminNewMovie.Name = "lbAantalBrusselAdminNewMovie";
            this.lbAantalBrusselAdminNewMovie.Size = new System.Drawing.Size(99, 17);
            this.lbAantalBrusselAdminNewMovie.TabIndex = 8;
            this.lbAantalBrusselAdminNewMovie.Text = "Aantal Brussel";
            // 
            // lbAantalGentAdminNewMovie
            // 
            this.lbAantalGentAdminNewMovie.AutoSize = true;
            this.lbAantalGentAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAantalGentAdminNewMovie.Location = new System.Drawing.Point(28, 178);
            this.lbAantalGentAdminNewMovie.Name = "lbAantalGentAdminNewMovie";
            this.lbAantalGentAdminNewMovie.Size = new System.Drawing.Size(83, 17);
            this.lbAantalGentAdminNewMovie.TabIndex = 9;
            this.lbAantalGentAdminNewMovie.Text = "Aantal Gent";
            // 
            // lbAantalAntwerpenAdminNewMovie
            // 
            this.lbAantalAntwerpenAdminNewMovie.AutoSize = true;
            this.lbAantalAntwerpenAdminNewMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAantalAntwerpenAdminNewMovie.Location = new System.Drawing.Point(308, 178);
            this.lbAantalAntwerpenAdminNewMovie.Name = "lbAantalAntwerpenAdminNewMovie";
            this.lbAantalAntwerpenAdminNewMovie.Size = new System.Drawing.Size(119, 17);
            this.lbAantalAntwerpenAdminNewMovie.TabIndex = 10;
            this.lbAantalAntwerpenAdminNewMovie.Text = "Aantal Antwerpen";
            // 
            // tbMovieName
            // 
            this.tbMovieName.Location = new System.Drawing.Point(81, 91);
            this.tbMovieName.MaxLength = 50;
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(281, 20);
            this.tbMovieName.TabIndex = 11;
            // 
            // numMinAge
            // 
            this.numMinAge.Location = new System.Drawing.Point(104, 134);
            this.numMinAge.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numMinAge.Name = "numMinAge";
            this.numMinAge.Size = new System.Drawing.Size(55, 20);
            this.numMinAge.TabIndex = 12;
            this.numMinAge.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // numLeentijd
            // 
            this.numLeentijd.Location = new System.Drawing.Point(256, 134);
            this.numLeentijd.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numLeentijd.Name = "numLeentijd";
            this.numLeentijd.Size = new System.Drawing.Size(55, 20);
            this.numLeentijd.TabIndex = 13;
            this.numLeentijd.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numAmountBrussel
            // 
            this.numAmountBrussel.Location = new System.Drawing.Point(185, 198);
            this.numAmountBrussel.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAmountBrussel.Name = "numAmountBrussel";
            this.numAmountBrussel.Size = new System.Drawing.Size(55, 20);
            this.numAmountBrussel.TabIndex = 14;
            // 
            // numAmountGent
            // 
            this.numAmountGent.Location = new System.Drawing.Point(41, 198);
            this.numAmountGent.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAmountGent.Name = "numAmountGent";
            this.numAmountGent.Size = new System.Drawing.Size(55, 20);
            this.numAmountGent.TabIndex = 15;
            // 
            // numAmountAntwerpen
            // 
            this.numAmountAntwerpen.Location = new System.Drawing.Point(334, 198);
            this.numAmountAntwerpen.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAmountAntwerpen.Name = "numAmountAntwerpen";
            this.numAmountAntwerpen.Size = new System.Drawing.Size(55, 20);
            this.numAmountAntwerpen.TabIndex = 16;
            // 
            // btnAddNewMovieAdminMovies
            // 
            this.btnAddNewMovieAdminMovies.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewMovieAdminMovies.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddNewMovieAdminMovies.Location = new System.Drawing.Point(121, 239);
            this.btnAddNewMovieAdminMovies.Name = "btnAddNewMovieAdminMovies";
            this.btnAddNewMovieAdminMovies.Size = new System.Drawing.Size(190, 49);
            this.btnAddNewMovieAdminMovies.TabIndex = 17;
            this.btnAddNewMovieAdminMovies.Text = "Nieuwe film toevoegen";
            this.btnAddNewMovieAdminMovies.UseVisualStyleBackColor = false;
            this.btnAddNewMovieAdminMovies.Click += new System.EventHandler(this.btnAddNewMovieAdminMovies_Click);
            // 
            // MSNewMovieAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 300);
            this.Controls.Add(this.btnAddNewMovieAdminMovies);
            this.Controls.Add(this.numAmountAntwerpen);
            this.Controls.Add(this.numAmountGent);
            this.Controls.Add(this.numAmountBrussel);
            this.Controls.Add(this.numLeentijd);
            this.Controls.Add(this.numMinAge);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.lbAantalAntwerpenAdminNewMovie);
            this.Controls.Add(this.lbAantalGentAdminNewMovie);
            this.Controls.Add(this.lbAantalBrusselAdminNewMovie);
            this.Controls.Add(this.lbFilmLeentijdAdminNewMovie);
            this.Controls.Add(this.lbFilmRatingAdminNewMovie);
            this.Controls.Add(this.lbFilmNaamAdminNewMovie);
            this.Controls.Add(this.lbNieuweFilmAdminNewMovie);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MSNewMovieAdmin";
            this.Text = "MSNewMovieAdmin";
            this.Load += new System.EventHandler(this.MSNewMovieAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMinAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLeentijd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountBrussel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountGent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountAntwerpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movieStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terugNaarAdminHomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
        private System.Windows.Forms.Label lbNieuweFilmAdminNewMovie;
        private System.Windows.Forms.Label lbFilmNaamAdminNewMovie;
        private System.Windows.Forms.Label lbFilmRatingAdminNewMovie;
        private System.Windows.Forms.Label lbFilmLeentijdAdminNewMovie;
        private System.Windows.Forms.Label lbAantalBrusselAdminNewMovie;
        private System.Windows.Forms.Label lbAantalGentAdminNewMovie;
        private System.Windows.Forms.Label lbAantalAntwerpenAdminNewMovie;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.NumericUpDown numMinAge;
        private System.Windows.Forms.NumericUpDown numLeentijd;
        private System.Windows.Forms.NumericUpDown numAmountBrussel;
        private System.Windows.Forms.NumericUpDown numAmountGent;
        private System.Windows.Forms.NumericUpDown numAmountAntwerpen;
        private System.Windows.Forms.Button btnAddNewMovieAdminMovies;
    }
}