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
           
            

        }
    }
}
