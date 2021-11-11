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
    public partial class MSMoviesAdmin : Form
    {
        private const string ConnectionString = @"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true";
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection cn;
        public MSMoviesAdmin()
        {
            InitializeComponent();
        }

        private void terugNaarAdminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AdminMoviesToAdminHome = new MSAdminHomescreen();
            this.Hide();
            AdminMoviesToAdminHome.Show();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AdminMoviesToAdminLogin = new AdminLogin();
            this.Hide();
            AdminMoviesToAdminLogin.Show();
        }

        private void MSMoviesAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examenDotNETAdvancedDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Movies);

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
            DataGridViewColumn filmId = new DataGridViewTextBoxColumn();
            filmId.Name = "filmId";
            filmId.HeaderText = "Film ID";
            filmId.DataPropertyName = "MovieId";
            filmId.Width = 100;
            dataGridView1.Columns.Insert(0, filmId);

            DataGridViewColumn Naam = new DataGridViewTextBoxColumn();
            Naam.HeaderText = "Naam";
            Naam.Name = "Naam";
            Naam.DataPropertyName = "Name";
            Naam.Width = 200;
            dataGridView1.Columns.Insert(1, Naam);

            DataGridViewColumn MinLeeftijd = new DataGridViewTextBoxColumn();
            MinLeeftijd.Name = "MinLeeftijd";
            MinLeeftijd.HeaderText = "Minimum Leeftijd";
            MinLeeftijd.DataPropertyName = "Rating";
            MinLeeftijd.Width = 100;
            dataGridView1.Columns.Insert(2, MinLeeftijd);

            DataGridViewColumn Leentijd = new DataGridViewTextBoxColumn();
            Leentijd.Name = "Leentijd";
            Leentijd.HeaderText = "Aantal dagen leentijd";
            Leentijd.DataPropertyName = "Rental_Duration";
            Leentijd.Width = 100;
            dataGridView1.Columns.Insert(3, Leentijd);

            DataGridViewColumn AantalBeschikbaar_Gent = new DataGridViewTextBoxColumn();
            AantalBeschikbaar_Gent.Name = "AantalBeschikbaar";
            AantalBeschikbaar_Gent.HeaderText = "Beschikbaar Gent";
            AantalBeschikbaar_Gent.DataPropertyName = "Amount_Gent";
            AantalBeschikbaar_Gent.Width = 100;
            dataGridView1.Columns.Insert(4, AantalBeschikbaar_Gent);

            DataGridViewColumn AantalBeschikbaar_Brussel = new DataGridViewTextBoxColumn();
            AantalBeschikbaar_Brussel.Name = "AantalBeschikbaar";
            AantalBeschikbaar_Brussel.HeaderText = "Beschikbaar Brussel";
            AantalBeschikbaar_Brussel.DataPropertyName = "Amount_Brussel";
            AantalBeschikbaar_Brussel.Width = 100;
            dataGridView1.Columns.Insert(5, AantalBeschikbaar_Brussel);

            DataGridViewColumn AantalBeschikbaar_Antwerpen = new DataGridViewTextBoxColumn();
            AantalBeschikbaar_Antwerpen.Name = "AantalBeschikbaar";
            AantalBeschikbaar_Antwerpen.HeaderText = "Beschikbaar Antwerpen";
            AantalBeschikbaar_Antwerpen.DataPropertyName = "Amount_Antwerpen";
            AantalBeschikbaar_Antwerpen.Width = 100;
            dataGridView1.Columns.Insert(6, AantalBeschikbaar_Antwerpen);

            DataGridViewColumn Returned = new DataGridViewTextBoxColumn();
            Returned.Name = "Returned";
            Returned.HeaderText = "Terug Gebracht";
            Returned.DataPropertyName = "Returned";
            Returned.Width = 100;
            dataGridView1.Columns.Insert(7, Returned);

            //Bind the DataGridView.
            dataGridView1.DataSource = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MovieId, Name, Rating, Rental_Duration, Amount_Gent, Amount_Brussel, Amount_Antwerpen, Returned FROM Movies", con))
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
            DataGridViewButtonColumn ReturnOneGent = new DataGridViewButtonColumn();
            ReturnOneGent.HeaderText = "Terug Naar Gent";
            ReturnOneGent.Width = 100;
            ReturnOneGent.Name = "ReturnOneGent";
            ReturnOneGent.Text = "1x Naar Gent";
            ReturnOneGent.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(8, ReturnOneGent);

            DataGridViewButtonColumn ReturnOneBrussel = new DataGridViewButtonColumn();
            ReturnOneBrussel.HeaderText = "Terug Naar Brussel";
            ReturnOneBrussel.Width = 100;
            ReturnOneBrussel.Name = "ReturnOneBrussel";
            ReturnOneBrussel.Text = "1x naar Brussel";
            ReturnOneBrussel.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(9, ReturnOneBrussel);

            DataGridViewButtonColumn ReturnOneAntwerpen = new DataGridViewButtonColumn();
            ReturnOneAntwerpen.HeaderText = "Terug Naar Antwerpen";
            ReturnOneAntwerpen.Width = 100;
            ReturnOneAntwerpen.Name = "ReturnOneAntwerpen";
            ReturnOneAntwerpen.Text = "1x Naar Antwerpen";
            ReturnOneAntwerpen.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(10, ReturnOneAntwerpen);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var FilmIdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var AantalBeschikbaarGentCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            var AantalBeschikbaarBrusselCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            var AantalBeschikbaarAntwerpenCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            var ReturnedCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[7].Value);

            if (e.ColumnIndex == dataGridView1.Columns["ReturnOneGent"].Index)
            {
                if(ReturnedCell > 0)
                {
                    cmd = new SqlCommand("select * from Movies where MovieId='" + FilmIdCell + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Movies SET Amount_Gent = Amount_Gent + 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Amount_Gent", AantalBeschikbaarGentCell + 1);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE Movies SET Returned = Returned - 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Returned", ReturnedCell - 1);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Er zijn geen films meer om terug te sturen naar de MovieStore Gent");
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["ReturnOneBrussel"].Index)
            {
                if (ReturnedCell > 0)
                {
                    cmd = new SqlCommand("select * from Movies where MovieId='" + FilmIdCell + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Movies SET Amount_Brussel = Amount_Brussel + 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Amount_Brussel", AantalBeschikbaarGentCell + 1);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE Movies SET Returned = Returned - 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Returned", ReturnedCell - 1);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Er zijn geen films meer om terug te sturen naar de MovieStore Brussel");
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["ReturnOneAntwerpen"].Index)
            {
                if (ReturnedCell > 0)
                {
                    cmd = new SqlCommand("select * from Movies where MovieId='" + FilmIdCell + "'", cn);
                    dr = cmd.ExecuteReader();
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Movies SET Amount_Antwerpen = Amount_Antwerpen + 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Amount_Antwerpen", AantalBeschikbaarGentCell + 1);
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("UPDATE Movies SET Returned = Returned - 1 WHERE MovieId ='" + FilmIdCell + "'", cn);
                    cmd.Parameters.AddWithValue("Returned", ReturnedCell - 1);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Er zijn geen films meer om terug te sturen naar de MovieStore Antwerpen");
                }
            }
            this.BindGrid();
        }
    }
}
