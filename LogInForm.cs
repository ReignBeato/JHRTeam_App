using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic;

namespace JHRTeam_App
{
    public partial class LogInForm : Form
    {

        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form RegisterForm = new RegisterForm();
            RegisterForm.ShowDialog();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Get user input
            string email = txtemail.Text.Trim();
            string password = txtPassword.Text;

            // Simple validation

            //Check if fields are empty
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            // Step 2: Validate email format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid Email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtemail.Focus();
                return;
            }

            // Step 3: Validate password length
            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }


            // Example credentials dummy data
            string validEmail = "heli@gmail.com";
            string validPassword = "1234567";


            if (email == validEmail && password == validPassword)
            {
                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form Tickets = new Tickets();
                Tickets.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
         
            }

        }

        private void linklblforgotpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string email = Microsoft.VisualBasic.Interaction.InputBox( "Enter your registered email address:","Forgot Password", "");
       

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email is required to reset your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.IO.File.Exists("users.txt"))
            {
                MessageBox.Show("No users found in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string foundPassword = null;
            var lines = System.IO.File.ReadAllLines("users.txt");
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 2 && parts[0].Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    foundPassword = parts[1];
                    break;
                }
            }

            if (foundPassword != null)
            {
                MessageBox.Show($"Your password is: {foundPassword}", "Password Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email not found. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }
    }
}

