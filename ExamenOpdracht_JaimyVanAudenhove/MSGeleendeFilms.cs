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
            try
            {
                this.rentalTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Rental);
            }
            catch (Exception ex)
            {

            }

            // TODO: This line of code loads data into the 'examenDotNETAdvancedDataSet.Movie_Rentals' table. You can move, or remove it, as needed.
            this.movie_RentalsTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Movie_Rentals);
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true");
            cn.Open();

            BindGrid();
        }

        private void BindGrid()
        {
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
                using (SqlCommand cmd = new SqlCommand("SELECT Rental.Rental_Id, Rental.Rental_Date, Rental.Rental_Expiry, Movie_Rentals.MovieId, Movies.Name FROM Rental inner join Movie_Rentals on Rental.Rental_Id=Movie_Rentals.RentalId inner join Movies on Movie_Rentals.MovieId=Movies.MovieId WHERE username='" + MSLogin.SetValueForUserName + "'", con))
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Rental Date calculation
            var RentalDateCell = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[3].Value);
            var RentalExpiryCell = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);

            int result = DateTime.Compare(RentalDateCell, RentalExpiryCell);

            if (result < 0)
            {
                var RentalIdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var FilmNameCell = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                //Return Movie op tijd
                cmd = new SqlCommand("DELETE FROM Movie_Rentals Where RentalId = '" + RentalIdCell + "'; DELETE FROM  Rental Where Rental_Id = '" + RentalIdCell + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                cmd.ExecuteNonQuery();
                this.BindGrid();
                MessageBox.Show("Bedankt dat je " + FilmNameCell + " op tijd hebt teruggebracht!");
            }
            else
            {
                var RentalIdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var FilmNameCell = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                //Return Movie te laat
                cmd = new SqlCommand("DELETE FROM Movie_Rentals Where RentalId = '" + RentalIdCell + "'; DELETE FROM  Rental Where Rental_Id = '" + RentalIdCell + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                cmd.ExecuteNonQuery();
                this.BindGrid();
                cmd = new SqlCommand("UPDATE Users SET Strikes = Strikes + 1 WHERE username ='" + MSLogin.SetValueForUserName + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bedankt dat je " + FilmNameCell + " hebt teruggebracht, je bent wel TE LAAT! Er wordt 1 strike aan je account toegevoegd");

            }
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var GeleendToAccount = new Account();
            this.Hide();
            GeleendToAccount.Show();
        }
    }
}
