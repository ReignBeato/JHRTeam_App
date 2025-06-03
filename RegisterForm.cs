using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
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
        // Define MySQL connection string
        string connectionString = "Server=localhost;Database=nepal;Uid=root;Pwd=;";

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

            // 🔹 Validate First Name
            if (string.IsNullOrEmpty(firstName) || firstName == "First Name")
            {
                MessageBox.Show("Please enter your First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // 🔹 Validate Last Name
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

            // 🔹 Validate Email (not empty and correct format)
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


            // 🔹 Ensure Terms and Conditions are accepted
            if (!checkBox1.Checked)
            {
                MessageBox.Show("You must accept the terms & conditions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Focus();
                return;
            }


            // 🔹 Begin database interaction
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //  Check if Email already exists
                    string emailCheckQuery = "SELECT COUNT(*) FROM users WHERE Email = @Email";
                    using (MySqlCommand emailCmd = new MySqlCommand(emailCheckQuery, conn))
                    {
                        emailCmd.Parameters.AddWithValue("@Email", email);
                        int emailCount = Convert.ToInt32(emailCmd.ExecuteScalar());
                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox4.Focus();
                            return;
                        }
                    }

                    //  Check if Phone number already exists
                    string phoneCheckQuery = "SELECT COUNT(*) FROM users WHERE Phone = @Phone";
                    using (MySqlCommand phoneCmd = new MySqlCommand(phoneCheckQuery, conn))
                    {
                        phoneCmd.Parameters.AddWithValue("@Phone", phone);
                        int phoneCount = Convert.ToInt32(phoneCmd.ExecuteScalar());
                        if (phoneCount > 0)
                        {
                            MessageBox.Show("Phone number already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBox3.Focus();
                            return;
                        }
                    }

                    //  Insert new user if validations passed and duplicates not found
                    string query = "INSERT INTO users (FirstName, LastName, Phone, Email, Password) VALUES (@FirstName, @LastName, @Phone, @Email, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password); // Note: consider password hashing for real applications

                        cmd.ExecuteNonQuery();
                    }

                    //  Show success message after registration
                    MessageBox.Show("Signup Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    //  Catch any database or connection-related errors
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void buttonBooking_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Tickets = new Tickets();
            Tickets.ShowDialog();
        }
    
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
