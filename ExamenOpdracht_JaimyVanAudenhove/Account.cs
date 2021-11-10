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
    public partial class Account : Form
    {
        private const string ConnectionString = @"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1;MultipleActiveResultSets=true";
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=jaimy.database.windows.net;Initial Catalog=ExamenDotNETAdvanced;Persist Security Info=True;User ID=jaimy;Password=DotNetExamen1");
            cn.Open();
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, username, password, DOB FROM Users WHERE username ='" + MSLogin.SetValueForUserName + "'")) 
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = cn;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        DateTime dob = (DateTime)sdr["DOB"];
                        tbUserNameAccount.Text = sdr["username"].ToString();
                        tbPasswordAccount.Text = sdr["password"].ToString();
                        dateTimePickerGeboortedatumAccount.Value = dob;
                    }
                }
            }
        }

        private void terugNaarHomeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            string olduser = tbUserNameAccount.Text;
            if (tbPasswordAccount.Text != string.Empty || tbUserNameAccount.Text != string.Empty || dateTimePickerGeboortedatumAccount.Text != String.Empty)
            {
                cmd = new SqlCommand("select * from Users where username='" + tbUserNameAccount.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Deze gebruikersnaam bestaat al, probeer een andere", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("UPDATE Users SET [username] = @username, [password] = @password, [DOB] = @DOB WHERE username='" + MSLogin.SetValueForUserName + "'", cn);
                    cmd.Parameters.AddWithValue("username", tbUserNameAccount.Text);
                    cmd.Parameters.AddWithValue("password", tbPasswordAccount.Text);
                    cmd.Parameters.AddWithValue("DOB", dateTimePickerGeboortedatumAccount.Value.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account aangepast! je wordt nu teruggestuurd naar login.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var BackToLogin = new MSLogin();
                    this.Hide();
                    BackToLogin.Show();
                }
            }
            else
            {
                MessageBox.Show("Vul aub alle velden in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
