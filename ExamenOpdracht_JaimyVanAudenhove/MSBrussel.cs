﻿using System;
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
    public partial class MSBrussel : Form
    {
        public MSBrussel()
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
    }
}
