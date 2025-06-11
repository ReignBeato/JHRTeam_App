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
    public partial class Airlines : Form
    {
        public Airlines()
        {
            InitializeComponent();

            // Load airline images from resources
            PictureboxEmirates.Image = Properties.Resources.emirates;
            PictureboxQatar.Image = Properties.Resources.qatar;
            PictureboxSingapore.Image = Properties.Resources.singapore;
            PictureboxAirIndia.Image = Properties.Resources.AirIndia;
            PictureboxThai.Image = Properties.Resources.Thai;
            PictureboxAirNZ.Image = Properties.Resources.AirNZ;
            PictureboxMalaysia.Image = Properties.Resources.Malaysia;
            PictureboxDruk.Image = Properties.Resources.Druk;


            // Set the size mode for each PictureBox to stretch the image
            PictureboxEmirates.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxQatar.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxSingapore.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxAirIndia.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxThai.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxAirNZ.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxMalaysia.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureboxDruk.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonAirlines_Click(object sender, EventArgs e)
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

        private void buttonHotels_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Hotels = new Hotels();
            Hotels.ShowDialog();
        }

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LogInForm = new LogInForm();
            LogInForm.ShowDialog();
        }

        // Event handler for  Airlines link click
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.emirates.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.qatarairways.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.singaporeair.com");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.airindia.com");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.thaiairways.com");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(" https://www.airnewzealand.co.nz");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(" https://www.malaysiaairlines.com");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(" https://drukair.com.bt");
        }
    }
}
