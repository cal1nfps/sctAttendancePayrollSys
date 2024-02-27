using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI
{
    public partial class AdminLogin : Form
    {
        private MySqlConnection connection;
        public AdminLogin()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*            string enteredUsername = textBoxIDNum.Text;
                        string enteredPassword = textBoxPassword.Text;

                        if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword))
                        {
                            MessageBox.Show("Please enter both username and password.");
                            return;
                        }

                        if (Authentication(enteredUsername, enteredPassword))
                        {
                            this.Hide();
                            Home1 form_home1 = new Home1();
                            form_home1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your credentials.");
                        }
            */

            this.Hide();
            Home1 form_home1 = new Home1();
            form_home1.ShowDialog();
            this.Close();

        }

        private bool Authentication(string enteredUsername, string enteredPassword)
        {
            try
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM adminlogin WHERE username = @username AND password = @password;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", enteredUsername);
                    command.Parameters.AddWithValue("@password", enteredPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during authentication: " + ex.Message);
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(164, 16, 48);
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
            hidePassword.Visible = true;

        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            hidePassword.Visible = false;

        }
    }
}
