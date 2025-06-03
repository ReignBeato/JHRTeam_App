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

        private bool IsValidUser(string email, string password)
        {
            // Read users from file
            var lines = System.IO.File.ReadAllLines("users.txt");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length >= 2 && parts[0].Trim() == email && parts[1].Trim() == password)
                {
                    return true; // User found
                }
            }
            return false; // User not found
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
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Please enter your email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }
            if (!System.IO.File.Exists("users.txt"))
            {
                MessageBox.Show("No registered users found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

       
        
                // Read users from file
                if (IsValidUser(email, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form MainForm = new Form();
                MainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
