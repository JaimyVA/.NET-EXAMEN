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
    public partial class MSHomescreen : Form
    {
        public MSHomescreen()
        {
            InitializeComponent();
        }

        private void btnLocatie1Home_Click(object sender, EventArgs e)
        {
            var LocationGent = new MSGent();
            this.Hide();
            LocationGent.Show();
        }

        private void btnLocatie2Home_Click(object sender, EventArgs e)
        {
            var LocationBrussel = new MSBrussel();
            this.Hide();
            LocationBrussel.Show();
        }

        private void btnLocatie3Home_Click(object sender, EventArgs e)
        {
            var LocationAntwerpen = new MSAntwerpen();
            this.Hide();
            LocationAntwerpen.Show();
        }

        private void MSHomescreen_Load(object sender, EventArgs e)
        {
            lbWelcomeHomescreen.Text = "Welkom " + MSLogin.SetValueForUserName + "!";
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var BackToLogin = new MSLogin();
            this.Hide();
            BackToLogin.Show();
        }

        private void lbGeleendeFilmsHome_Click(object sender, EventArgs e)
        {
            var HomescreenToGeleendeFilms = new MSGeleendeFilms();
            this.Hide();
            HomescreenToGeleendeFilms.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var HomescreenToAccount = new Account();
            this.Hide();
            HomescreenToAccount.Show();
        }
    }
}
