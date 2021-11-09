using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenOpdracht_JaimyVanAudenhove
{
    public partial class MSGeleendeFilms : Form
    {

        private const string ConnectionString = @"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true";
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection cn;

        public MSGeleendeFilms()
        {
            InitializeComponent();
        }

        private void locatieSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BackToLocationSelect = new MSHomescreen();
            this.Hide();
            BackToLocationSelect.Show();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BackToLogin = new MSLogin();
            this.Hide();
            BackToLogin.Show();
        }

        private void MSGeleendeFilms_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true");
            cn.Open();

            BindGrid();
        }

        private void BindGrid()
        {
            //var RentalIdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //var MovieIdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            //Hide the last blank line.
            dataGridView1.AllowUserToAddRows = false;

            //Clear Columns.
            dataGridView1.Columns.Clear();

            //Add Columns.
            DataGridViewColumn RentalId = new DataGridViewTextBoxColumn();
            RentalId.Name = "RentalId";
            RentalId.HeaderText = "RentalId";
            RentalId.DataPropertyName = "Rental_Id";
            RentalId.Width = 100;
            dataGridView1.Columns.Insert(0, RentalId);

            DataGridViewColumn filmId = new DataGridViewTextBoxColumn();
            filmId.Name = "filmId";
            filmId.HeaderText = "Film ID";
            filmId.DataPropertyName = "MovieId";
            filmId.Width = 100;
            dataGridView1.Columns.Insert(1, filmId);

            DataGridViewColumn Naam = new DataGridViewTextBoxColumn();
            Naam.HeaderText = "Naam";
            Naam.Name = "Naam";
            Naam.DataPropertyName = "Name";
            Naam.Width = 200;
            dataGridView1.Columns.Insert(2, Naam);

            DataGridViewColumn RentalDate = new DataGridViewTextBoxColumn();
            RentalDate.Name = "RentalDate";
            RentalDate.HeaderText = "Datum lening";
            RentalDate.DataPropertyName = "Rental_Date";
            RentalDate.Width = 100;
            dataGridView1.Columns.Insert(3, RentalDate);

            DataGridViewColumn RentalExpiry = new DataGridViewTextBoxColumn();
            RentalExpiry.Name = "RentalExpiry";
            RentalExpiry.HeaderText = "Vervaldatum lening";
            RentalExpiry.DataPropertyName = "Rental_Expiry";
            RentalExpiry.Width = 100;
            dataGridView1.Columns.Insert(4, RentalExpiry);
            //Bind the DataGridView.

            dataGridView1.DataSource = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Rental.Rental_Id, Rental.Rental_Date, Rental.Rental_Expiry, Movie_Rentals.MovieId, Movies.Name FROM Rentalinner join Movie_Rentals on Rental.Rental_Id=Movie_Rentals.RentalId inner join Movies on Movie_Rentals.MovieId=Movies.MovieId WHERE username='" + MSLogin.SetValueForUserName + "'", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }

            //Add the Button Column.
            DataGridViewButtonColumn TerugBrengen = new DataGridViewButtonColumn();
            TerugBrengen.HeaderText = "Deze Film Terugbrengen";
            TerugBrengen.Width = 100;
            TerugBrengen.Name = "Terugbrengen";
            TerugBrengen.Text = "Terugbrengen";
            TerugBrengen.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(5, TerugBrengen);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
