using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenOpdracht_JaimyVanAudenhove
{
    public partial class MSAdminHomescreen : Form
    {
        public MSAdminHomescreen()
        {
            InitializeComponent();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BackToAdminLogin = new AdminLogin();
            this.Hide();
            BackToAdminLogin.Show();
        }

        private void lbWelcomeHomescreen_Click(object sender, EventArgs e)
        {
            lbWelcomeHomescreen.Text = "Welkom " + AdminLogin.SetValueForUserName + "!";
        }

        private void btnGebruikersAdmin_Click(object sender, EventArgs e)
        {
            var AdminHomeToUsersAdmin = new MSUsersAdmin();
            this.Hide();
            AdminHomeToUsersAdmin.Show();
        }

        private void btnFilmsAdmin_Click(object sender, EventArgs e)
        {
            var AdminHomeToMoviesAdmin = new MSMoviesAdmin();
            this.Hide();
            AdminHomeToMoviesAdmin.Show();
        }

        private void MSAdminHomescreen_Load(object sender, EventArgs e)
        {
            lbWelcomeHomescreen.Text = "Welkom " + AdminLogin.SetValueForUserName + "!";
        }
    }
}
