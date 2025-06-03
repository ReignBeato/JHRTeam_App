using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JHRTeam_App
{
    public partial class Hotels : Form
    {
        public Hotels()
        {
            InitializeComponent();
        }

        private void buttonHotels_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
        }

        private void buttonPackages_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Packages = new Packages();
            Packages.ShowDialog();
        }

        private void buttonAirlines_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Airlines = new Airlines();
            Airlines.ShowDialog();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LogInForm = new LogInForm();
            LogInForm.ShowDialog();
        }
    }
}
