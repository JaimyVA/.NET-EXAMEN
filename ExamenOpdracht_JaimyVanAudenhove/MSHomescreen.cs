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

        }

        private void btnLocatie2Home_Click(object sender, EventArgs e)
        {

        }

        private void btnLocatie3Home_Click(object sender, EventArgs e)
        {

        }

        private void MSHomescreen_Load(object sender, EventArgs e)
        {
            lbWelcomeHomescreen.Text = "Welkom " + MSLogin.SetValueForUserName + "!";
        }
    }
}
