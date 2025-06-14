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
            string validPassword = "Heli123!";


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

            string Email = "heli@gmail.com";
            string Password = "Heli123!";

            if (email == Email)
            {
                MessageBox.Show("Your password is: " + Password);
            }
            else
            {
                MessageBox.Show("Email not found. Try again.");
            }

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

