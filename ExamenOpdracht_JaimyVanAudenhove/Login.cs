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
    public partial class MSLogin : Form
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public static string SetValueForUserName = "";
        public MSLogin()
        {
            InitializeComponent();
        }
        private void MSLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1");
            cn.Open();
        }
        private void lbRegister_Click(object sender, EventArgs e)
        {
            var LoginToRegister = new MSRegister();
            this.Hide();
            LoginToRegister.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbPasswordLogin.Text != string.Empty || tbUserNameLogin.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from Users where username='" + tbUserNameLogin.Text + "' and password='" + tbPasswordLogin.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    SetValueForUserName = tbUserNameLogin.Text;
                    dr.Close();
                    this.Hide();
                    var Homescreen = new MSHomescreen();
                    this.Hide();
                    Homescreen.Show();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Er bestaan geen accounts met de ingevulde combinatie.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Vul aub alle velden in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
