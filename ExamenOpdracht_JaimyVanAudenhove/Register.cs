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
    public partial class MSRegister : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public MSRegister()
        {
            InitializeComponent();
        }
        private void MSRegister_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1");
            cn.Open();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
                if (tbPasswordRegister.Text != string.Empty || tbUserNameRegister.Text != string.Empty || dateTimePickerGeboortedatumRegister.Text != String.Empty)
                {
                        cmd = new SqlCommand("select * from Users where username='" + tbUserNameRegister.Text + "'", cn);
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Deze gebruikersnaam bestaat al, probeer een andere", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("insert into Users values(@username,@password,@DOB)", cn);
                            cmd.Parameters.AddWithValue("username", tbUserNameRegister.Text);
                            cmd.Parameters.AddWithValue("password", tbPasswordRegister.Text);
                            cmd.Parameters.AddWithValue("DOB", dateTimePickerGeboortedatumRegister.Value.ToString("yyyy-MM-dd"));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account aangemaakt! Je kan nu inloggen.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vul aub alle velden in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void lbLoginInstead_Click(object sender, EventArgs e)
        {
            var RegisterToLogin = new MSLogin();
            this.Hide();
            RegisterToLogin.Show();
        }
    }
}
