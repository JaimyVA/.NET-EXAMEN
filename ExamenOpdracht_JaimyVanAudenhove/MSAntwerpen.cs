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
    public partial class MSAntwerpen : Form
    {
        private const string ConnectionString = @"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true";
        private SqlCommand cmd;
        private SqlDataReader dr;
        private SqlConnection cn;
        DateTime today = DateTime.Today;

        public MSAntwerpen()
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

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var HomescreenToAccount = new Account();
            this.Hide();
            HomescreenToAccount.Show();
        }

        private void MSAntwerpen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examenDotNETAdvancedDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Movies);
            //TODO: This line of code loads data into the 'examenDotNETAdvancedDataSet.Movies' table.You can move, or remove it, as needed.
            //    this.moviesTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Movies);
            //TODO: This line of code loads data into the 'examenDotNETAdvancedDataSet.Users' table.You can move, or remove it, as needed.
            //    this.usersTableAdapter.Fill(this.examenDotNETAdvancedDataSet.Users);

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

            DataGridViewColumn AantalBeschikbaar = new DataGridViewTextBoxColumn();
            AantalBeschikbaar.Name = "AantalBeschikbaar";
            AantalBeschikbaar.HeaderText = "Aantal Beschikbaar";
            AantalBeschikbaar.DataPropertyName = "Amount_Antwerpen";
            AantalBeschikbaar.Width = 100;
            dataGridView1.Columns.Insert(4, AantalBeschikbaar);

            //Bind the DataGridView.
            dataGridView1.DataSource = null;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MovieId, Name, Rating, Rental_Duration, Amount_Antwerpen FROM Movies", con))
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
            DataGridViewButtonColumn Lenen = new DataGridViewButtonColumn();
            Lenen.HeaderText = "Deze Film Lenen";
            Lenen.Width = 100;
            Lenen.Name = "Lenen";
            Lenen.Text = "Lenen";
            Lenen.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Insert(5, Lenen);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var FirstCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var MovieNameCell = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            var RatingCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
            var AantalBeschikbaarCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            var LeentijdCell = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);

            if (e.ColumnIndex == dataGridView1.Columns["Lenen"].Index)
            {
                if (AantalBeschikbaarCell > 0)
                {
                    //Check User strikes
                    using (SqlCommand sqlCommand = new SqlCommand("select Strikes from Users where username='" + MSLogin.SetValueForUserName + "'", cn))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = cn;
                        using (SqlDataReader sdr = sqlCommand.ExecuteReader())
                        {
                            sdr.Read();
                            int UserStrikes = (int)sdr["Strikes"];
                            if (UserStrikes >= 3)
                            {
                                MessageBox.Show("Je bent verbannen van de MovieStore omdat je meermaals films niet op tijd terugbracht!");
                            }
                            else
                            {
                                //Check if user is currently renting a movie
                                using (SqlCommand sqlCommandCurrentlyRenting = new SqlCommand("select * from Rental where username='" + MSLogin.SetValueForUserName + "'", cn))
                                {
                                    sqlCommandCurrentlyRenting.CommandType = CommandType.Text;
                                    sqlCommandCurrentlyRenting.Connection = cn;
                                    using (SqlDataReader sdrCurrentlyRenting = sqlCommandCurrentlyRenting.ExecuteReader())
                                    {
                                        if (sdrCurrentlyRenting.Read())
                                        {
                                            sdrCurrentlyRenting.Close();
                                            MessageBox.Show("Je leent al een film, breng deze eerst terug!");
                                        }
                                        else
                                        {
                                            sdrCurrentlyRenting.Close();
                                            //user DOB Query
                                            using (SqlCommand sqlCommand1 = new SqlCommand("select DOB from Users where username='" + MSLogin.SetValueForUserName + "'", cn))
                                            {
                                                sqlCommand1.CommandType = CommandType.Text;
                                                sqlCommand1.Connection = cn;
                                                using (SqlDataReader sdr1 = sqlCommand1.ExecuteReader())
                                                {
                                                    sdr1.Read();
                                                    DateTime dob = (DateTime)sdr1["DOB"];
                                                    if (today.Year - dob.Year > RatingCell)
                                                    {
                                                        //Movie update query
                                                        cmd = new SqlCommand("select * from Movies where Name='" + FirstCell + "'", cn);
                                                        dr = cmd.ExecuteReader();
                                                        dr.Close();
                                                        cmd = new SqlCommand("UPDATE Movies SET Amount_Antwerpen = Amount_Antwerpen - 1 WHERE MovieId ='" + FirstCell + "'", cn);
                                                        cmd.Parameters.AddWithValue("Amount_Antwerpen", AantalBeschikbaarCell - 1);
                                                        cmd.ExecuteNonQuery();
                                                        MessageBox.Show("Je hebt " + MovieNameCell + " Geleend! Breng de film zeker op tijd terug!", MovieNameCell + " Geleend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        //Rental query
                                                        cmd = new SqlCommand("insert into Rental values(@Rental_Date,@Rental_Expiry,@username)", cn);
                                                        cmd.Parameters.AddWithValue("Rental_Date", today.ToString("yyyy-MM-dd"));
                                                        cmd.Parameters.AddWithValue("Rental_Expiry", today.AddDays(LeentijdCell));
                                                        cmd.Parameters.AddWithValue("username", MSLogin.SetValueForUserName);
                                                        cmd.ExecuteNonQuery();
                                                        //Movie_Rentals query
                                                        cmd = new SqlCommand("insert into Movie_Rentals values(@MovieId)", cn);
                                                        cmd.Parameters.AddWithValue("MovieId", FirstCell);
                                                        cmd.ExecuteNonQuery();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Je bent te jong voor deze film");
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Deze Film is momenteel niet meer beschikbaar");
                }
            }

            this.BindGrid();
        }
    }
}
