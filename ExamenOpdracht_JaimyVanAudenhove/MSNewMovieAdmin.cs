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
    public partial class MSNewMovieAdmin : Form
    {
        private const string ConnectionString = @"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true";
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection cn;
        public MSNewMovieAdmin()
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
            var AdminNewMovieToAdminLogin = new AdminLogin();
            this.Hide();
            AdminNewMovieToAdminLogin.Show();
        }

        private void MSNewMovieAdmin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true");
            cn.Open();
        }

        private void btnAddNewMovieAdminMovies_Click(object sender, EventArgs e)
        {
            String Name = tbMovieName.Text;
            int Rating = Convert.ToInt32(Math.Round(numMinAge.Value));
            int Rental_Duration = Convert.ToInt32(Math.Round(numLeentijd.Value));
            int Amount_Gent = Convert.ToInt32(Math.Round(numAmountGent.Value));
            int Amount_Brussel = Convert.ToInt32(Math.Round(numAmountBrussel.Value));
            int Amount_Antwerpen = Convert.ToInt32(Math.Round(numAmountAntwerpen.Value));

            if (tbMovieName.Text != string.Empty || numLeentijd.Text != "" || numAmountGent.Text != "" || numAmountBrussel.Text != "" || numAmountAntwerpen.Text != "")
            {
                cmd = new SqlCommand("select * from Movies where Name='" + tbMovieName.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Deze film staat al in onze database, geef een andere film in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into Movies values(@Name,@Rating,@Rental_Duration, @Amount_Gent, @Amount_Brussel, @Amount_Antwerpen, @Returned)", cn);
                    cmd.Parameters.AddWithValue("Name", Name);
                    cmd.Parameters.AddWithValue("Rating", Rating);
                    cmd.Parameters.AddWithValue("Rental_Duration", Rental_Duration);
                    cmd.Parameters.AddWithValue("Amount_Gent", Amount_Gent);
                    cmd.Parameters.AddWithValue("Amount_Brussel", Amount_Brussel);
                    cmd.Parameters.AddWithValue("Amount_Antwerpen", Amount_Antwerpen);
                    cmd.Parameters.AddWithValue("Returned", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(Name + " is toegevoegd aan de MovieStore database!", Name + "Toegevoegd", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var BackToAdminHome = new MSAdminHomescreen();
                    this.Hide();
                    BackToAdminHome.Show();
                }
            }
            else
            {
                MessageBox.Show("Alle velden moeten ingevuld zijn!","Velden ontbreken!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
