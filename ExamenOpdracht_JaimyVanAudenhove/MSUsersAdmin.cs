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
    public partial class MSUsersAdmin : Form
    {
        public MSUsersAdmin()
        {
            InitializeComponent();
        }

        private void MSUsersAdmin_Load(object sender, EventArgs e)
        {
            //Linq data ophaling voor dataGridView1
            ExamenDotNETAdvancedEntities2 UDS = new ExamenDotNETAdvancedEntities2();
            dataGridView1.DataSource = UDS.Users.Select(x => new { x.Id, x.username, x.DOB, x.Strikes }).ToList();

        }

        private void terugNaarAdminHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AdminUsersToAdminHome = new MSAdminHomescreen();
            this.Hide();
            AdminUsersToAdminHome.Show();
        }

        private void uitloggenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var AdminUsersToAdminLogin = new AdminLogin();
            this.Hide();
            AdminUsersToAdminLogin.Show();
        }
    }
}
