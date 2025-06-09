using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;

namespace JHRTeam_App
{
    public partial class Tickets : Form
    {
        int adultTickets;
        int childrenTickets;
        int total;

        public Tickets()
        {
            InitializeComponent();
            monthCalendarFrom.Visible = false;
            monthCalendarTo.Visible = false;
        }

        private void buttonTickets_Click(object sender, EventArgs e)
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

        private void buttonHotels_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Hotels = new Hotels();
            Hotels.ShowDialog();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (comboBoxPackages.Text == "")
            {
                MessageBox.Show("Please select a package.");
                return;
            }
            if (textBoxAdultsTickets.Text == "")
            {
                MessageBox.Show("Please enter the number of adult tickets.");
                return;
            }
            if (textBoxChildrenTickets.Text == "")
            {
                MessageBox.Show("Please enter the number of children tickets.");
                return;
            }
            if (textBoxFromDate.Text == "")
            {
                MessageBox.Show("Please enter the start date of the tour.");
                return;
            }
            if (textBoxToDate.Text == "")
            {
                MessageBox.Show("Please enter the end date of the tour.");
                return;
            }

            listBoxOrder.Items.Add($"Package: {comboBoxPackages.Text}");
            listBoxOrder.Items.Add("Number of Tickets:");
            listBoxOrder.Items.Add($"   Adults: {textBoxAdultsTickets.Text} = ${adultTickets * Convert.ToInt32(textBoxAdultsTickets.Text)}");
            listBoxOrder.Items.Add($"   Children: {textBoxChildrenTickets.Text} = ${childrenTickets * Convert.ToInt32(textBoxChildrenTickets.Text)}");

            int totalAdults = adultTickets * Convert.ToInt32(textBoxAdultsTickets.Text);
            int totalChildren = childrenTickets * Convert.ToInt32(textBoxChildrenTickets.Text);

            listBoxOrder.Items.Add("Date of Tour:");
            listBoxOrder.Items.Add($"   From: {textBoxFromDate.Text}");
            listBoxOrder.Items.Add($"   To: {textBoxToDate.Text}");

            total = totalAdults + totalChildren;
            textBoxTotalCost.Text = ($" ${total}");

            DialogResult result = MessageBox.Show("Your tickets have been booked successfully!", "Booking Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string orderDetails = $"Package: {comboBoxPackages.Text}\n";
            orderDetails += "Number of Tickets:\n";
            orderDetails += $"   Adults: {textBoxAdultsTickets.Text} = ${totalAdults}\n";
            orderDetails += $"   Children: {textBoxChildrenTickets.Text} = ${totalChildren}\n";
            orderDetails += "Date of Tour:\n";
            orderDetails += $"   From: {textBoxFromDate.Text}\n";
            orderDetails += $"   To: {textBoxToDate.Text}";

            if (result == DialogResult.OK)
            {
                MessageBox.Show(orderDetails, "Order Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBoxOrder.Items.Clear();
                comboBoxPackages.Text = "";
                textBoxAdultsTickets.Text = "";
                textBoxChildrenTickets.Text = "";
                textBoxTotalCost.Text = "";
                textBoxFromDate.Text = "";
                textBoxToDate.Text = "";
            }
        }
        

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxOrder.Items.Clear();
            comboBoxPackages.Text = "";
            textBoxAdultsTickets.Text = "";
            textBoxChildrenTickets.Text = "";
            textBoxTotalCost.Text = "";
            textBoxFromDate.Text = "";
            textBoxToDate.Text = "";
        }

        private void comboBoxPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPackages.SelectedIndex == 0)
            {
                adultTickets = 100;
                childrenTickets = 50;
                labelPrice.Text = "Adult Price: $100                 Child Price: $50";
            }
            else if (comboBoxPackages.SelectedIndex == 1)
            {
                adultTickets = 150;
                childrenTickets = 75;
                labelPrice.Text = "Adult Price: $150                 Child Price: $75";
            }
            else if (comboBoxPackages.SelectedIndex == 2)
            {
                adultTickets = 200;
                childrenTickets = 100;
                labelPrice.Text = "Adult Price: $200                 Child Price: $100";
            }
            else
            {
                adultTickets = 250;
                childrenTickets = 150;
                labelPrice.Text = "Adult Price: $250                 Child Price: $150";
            }
        }

        private void textBoxFromDate_Click(object sender, EventArgs e)
        {
            monthCalendarTo.Visible = false;
            monthCalendarFrom.Visible = true;
        }

        private void textBoxToDate_Click(object sender, EventArgs e)
        {
            monthCalendarFrom.Visible = false;
            monthCalendarTo.Visible = true;
        }

        private void monthCalendarFrom_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxFromDate.Text = monthCalendarFrom.SelectionStart.ToString("dd MMMM yyyy");
        }

        private void monthCalendarTo_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxToDate.Text = monthCalendarTo.SelectionStart.ToString("dd MMMM yyyy");

            if (monthCalendarFrom.SelectionStart == monthCalendarTo.SelectionStart)
            {
                MessageBox.Show("Please select different dates for the tour.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFromDate.Text = "";
                textBoxToDate.Text = "";
                return;
            }
        }

        private void Tickets_Click(object sender, EventArgs e)
        {
            monthCalendarFrom.Visible = false;
            monthCalendarTo.Visible = false;
        }
    }
}
