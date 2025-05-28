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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get trimmed user input
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string password = textBox5.Text;
            string confirmPassword = textBox6.Text;

            // Simple validation
            if (string.IsNullOrEmpty(firstName) || firstName == "👤  First Name")
            {
                MessageBox.Show("Please enter your First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrEmpty(lastName) || lastName == "👤  Last Name")
            {
                MessageBox.Show("Please enter your Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone) || phone == "📞  Phone no")
            {
                MessageBox.Show("Please enter your Phone Number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{7,15}$"))
            {
                MessageBox.Show("Phone Number must be digits only and between 7 to 15 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }
            if (string.IsNullOrEmpty(email) || email == "📧  Email")
            {
                MessageBox.Show("Please enter your Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password) || password == "🔒  Password")
            {
                MessageBox.Show("Please enter your Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox6.Focus();
                return;
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must accept the terms & conditions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Focus();
                return;
            }

            // If all validation passed
            MessageBox.Show("Signup Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Optionally clear fields or close form
            //ClearForm();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                return System.Text.RegularExpressions.Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }
    }
}