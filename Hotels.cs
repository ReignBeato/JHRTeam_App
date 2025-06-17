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
            // Load hotel images from resources
            picboxEverestviewhotel.Image = Properties.Resources.hotelEverestview;
            picboxBarahi.Image = Properties.Resources.barahi_hotel;
            picboxGokarnaresort.Image = Properties.Resources.Gokarnaresort;
            picboxMiddlepathhotel.Image = Properties.Resources.Middle_path_hotel;
            picboxNaturalspringhotel.Image = Properties.Resources.natural_spring_hotel;
            picboxPanormahotel.Image = Properties.Resources.Panorma_hotel;
            picboxSambalahotel.Image = Properties.Resources.sambala_hotel;
            picboxTerracesresort.Image = Properties.Resources.Terraces_resort;

            // Set the size mode for each PictureBox to stretch the image
            picboxEverestviewhotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxBarahi.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxGokarnaresort.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxMiddlepathhotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxNaturalspringhotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxPanormahotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxSambalahotel.SizeMode = PictureBoxSizeMode.StretchImage;
            picboxTerracesresort.SizeMode = PictureBoxSizeMode.StretchImage;




        }
        private void Hotels_Load(object sender, EventArgs e)
        {
         


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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://hoteleverestview.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://barahi.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gokarna.com");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hotel-middlepath.com");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.hoteles.com/en/ho3073742016/hotel-natural-spring-pvt-ltd");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://panoramalodge.com.np");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://shambalahotel.com");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.terracesresort.com");
        }
    }
}
