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
    public partial class Packages : Form
    {
        public Packages()
        {
            InitializeComponent();

            // Link buttons with IDs
            btnDetails1.Tag = 1;
            btnDetails2.Tag = 2;
            btnDetails3.Tag = 3;
            btnDetails4.Tag = 4;

          
        

        }

        private void buttonPackages_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form DashboardForm = new DashboardForm();
            DashboardForm.ShowDialog();
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

        private void buttonTickets_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LogInForm = new LogInForm();
            LogInForm.ShowDialog();
        }
        private void ShowPackage(string title, string details)
        {
            lblTitle.Text = title;
            txtDetails.Text = details;
            panel1.Visible = true;
        }


        private void Packages_Load(object sender, EventArgs e)
        {

        }
        // Dictionary to store travel packages
        private Dictionary<int, (string title, string details)> packages = new Dictionary<int, (string, string)>()
{
    {1, ("Pokhara Adventure Package", "Duration: 4 Days / 3 Nights\nPrice: NPR 15,000\nFood: Daily breakfast, 1 traditional Nepali dinner\nHotel: 3-star hotel\nHighlights: Boating, Sarangkot sunrise, Davis Falls")},
    {2, ("Kathmandu Heritage Tour", "Duration: 3 Days / 2 Nights\nPrice: NPR 12,000\nFood: Breakfast included\nHighlights: Pashupatinath Temple, Boudhanath Stupa, Durbar Square")},
    {3, ("Chitwan Jungle Safari", "Duration: 5 Days / 4 Nights\nPrice: NPR 20,000\nFood: Full board\nHighlights: Elephant rides, bird watching, Tharu cultural show")},
    {4, ("Lumbini Spiritual Tour", "Duration: 2 Days / 1 Night\nPrice: NPR 8,000\nFood: Breakfast included\nHighlights: Birthplace of Buddha, meditation sessions")}
};

        private void btnDetails1_Click(object sender, EventArgs e)
        { ShowPackage("Everest Base Camp Trek",
        "Duration: 12 Days / 11 Nights\r\n\r\n" +
        "Price:\r\n" +
        "Adult (13+ years): NPR 85,000\r\n" +
        "Child (6-12 years): NPR 60,000\r\n\r\n" +

        "Food: All meals during trek\r\n\r\n" +
        "Stay: Teahouses/lodges (shared rooms)\r\n\r\n" +
        "Transport: Flight (Kathmandu–Lukla–Kathmandu)\r\n\r\n" +
        "Highlights: EBC trek, Sherpa guide, Monastery visit\r\n\r\n" +
        "Extra Cost: Porter service (NPR 2,000/day), Hot shower, Wi-Fi");
}
        

        private void btnDetails2_Click(object sender, EventArgs e)
        {
            ShowPackage("Kathmandu Cultural Tour",
        "Duration: 3 Days / 2 Nights\r\n\r\n" +
        "Price:\r\n" +
        "Adult (13+ years): NPR 8,500\r\n" +
        "Child (6-12 years): NPR 5,000\r\n\r\n" +

        "Food: Breakfast daily, 1 welcome dinner\r\n\r\n" +
        "Hotel: 2-star hotel in Thamel\r\n\r\n" +
        "Transport: Private vehicle, Airport pickup/drop\r\n\r\n" +
        "Highlights: Temple visits, Local market tour\r\n\r\n" +
        "Extra Cost: Entry fees to monuments (approx. NPR 1,000)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btnDetails3_Click(object sender, EventArgs e)
        { 
       ShowPackage("Pokhara Adventure Package",
        "🕒 Duration:\r\n" +
        "4 Days / 3 Nights\r\n\r\n" +

        "💸 Price:\r\n" +
        "Adult (13+ years): NPR 15,000\r\n" +
        "Child (6-12 years): NPR 10,000\r\n\r\n" +

        "🍽 Food:\r\n" +
        "Daily breakfast\r\n" +
        "1 traditional Nepali dinner\r\n\r\n" +

        "🏨 Hotel:\r\n" +
        "3-star hotel near Lakeside\r\n" +
        "Free Wi-Fi included\r\n\r\n" +

        "🚌 Transport:\r\n" +
        "Tourist bus (to/from Pokhara)\r\n" +
        "Local sightseeing included\r\n\r\n" +

        "📍 Highlights:\r\n" +
        "Boating on Phewa Lake\r\n" +
        "Sarangkot sunrise view\r\n" +
        "Davis Falls\r\n" +
        "Mahendra Cave visit\r\n\r\n" +

        "💰 Extra Cost:\r\n" +
        "Paragliding: NPR 5,000\r\n" +
        "Ultra-light flight: NPR 8,000"
    );
        }

        private void btnDetails4_Click(object sender, EventArgs e)
        {
            ShowPackage("Annapurna Base Camp Trek",
                "Duration: 10 Days / 9 Nights\r\n\r\n" +
                "Price:\r\n" +
                "Adult (13+ years): NPR 65,000 per person\r\n" +
                "Child (6-12 years): NPR 45,000 per person\r\n\r\n" +

                "Food: Full meals during trek\r\n\r\n" +
                "Stay: Tea houses/lodges along the trekking route (shared rooms)\r\n\r\n" +
                "Transport: Tourist bus to Pokhara, private jeep to trailhead\r\n\r\n" +
                "Highlights: ABC, Machhapuchhre views, hot spring at Jhinu Danda\r\n\r\n" +
                "Extra Cost: Porter (NPR 2,000/day), Hot shower & Wi-Fi, Gear rental (approx. NPR 1,500)"
            );
        }
    }
    }

