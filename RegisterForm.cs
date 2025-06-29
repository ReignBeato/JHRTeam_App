﻿using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            //Get trimmed user input from all fields
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string phone = textBox3.Text.Trim();
            string email = textBox4.Text.Trim();
            string password = textBox5.Text;
            string confirmPassword = textBox6.Text;

            //  Validate First Name
            if (string.IsNullOrEmpty(firstName) || firstName == "First Name")
            {
                MessageBox.Show("Please enter your First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            //  Validate Last Name
            if (string.IsNullOrEmpty(lastName) || lastName == "Last Name")
            {
                MessageBox.Show("Please enter your Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 🔹 Validate Phone Number (not empty and digits only between 7–15)
            if (string.IsNullOrEmpty(phone) || phone == "Phone no")
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

            //  Validate Email (not empty and correct format)
            if (string.IsNullOrEmpty(email) || email == "📧  Email")
            {
                MessageBox.Show("Please enter your Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }
            else if (!IsValidEmail(email)) // assumes IsValidEmail() is defined elsewhere
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox4.Focus();
                return;
            }

            // ---------------- Password Validation ----------------
            // This part checks if the password meets the security rules:
            // - Must be at least 6 characters
            // - Must include at least one capital letter (A-Z)
            // - Must include at least one number (0-9)
            // - Must include at least one special symbol like !, @, #, etc.
            if (string.IsNullOrEmpty(password) || password == "🔒  Password")
            {
                MessageBox.Show("Please enter your Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            // Check minimum length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            // Check for uppercase letter using regular expression
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]"))
            {
                MessageBox.Show("Password must have at least one capital letter (A-Z).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            // Check for number
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "[0-100]"))
            {
                MessageBox.Show("Password must have at least one number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }

            // Check for special symbol like !, @, #, etc.
            if (!System.Text.RegularExpressions.Regex.IsMatch(password, "[!@#$%^&*(),.?\":{}|<>]"))
            {
                MessageBox.Show("Password must have at least one special character (e.g., !, @, #).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }


            //  Ensure Terms and Conditions are accepted
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must accept the terms & conditions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox5.Focus();
                return;
            }
            else
            {

                DialogResult result = MessageBox.Show("Signup Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form logInForm = new LogInForm();
                    logInForm.ShowDialog();
                }
                else
                {
                    this.Close();
                }
            }


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

       /*private void buttonBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Tickets = new Tickets();
            Tickets.ShowDialog();
        }
    */

private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
