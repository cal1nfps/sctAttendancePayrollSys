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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI
{
    public partial class AdminLogin : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;
        public AdminLogin()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            /*            string username = textBoxIDNum.Text;
                        string password = textBoxPassword.Text;

                        try
                        {
                            connection.Open();

                            // Create a query to check the username and password against the adminlogin table
                            string query = "SELECT COUNT(*) FROM adminlogin WHERE username = @Username AND password = @Password";

                            using (MySqlCommand command = new MySqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@Username", username);
                                command.Parameters.AddWithValue("@Password", password);

                                // Execute the query and retrieve the result
                                int result = Convert.ToInt32(command.ExecuteScalar());

<<<<<<< Updated upstream
                    if (result > 0)
                    {
                        this.Hide();
                        Home1 form_home = new Home1();
                        form_home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
=======
                                if (result > 0)
                                {
                                    Home1 form_home = new Home1();
                                    form_home.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid username or password. Please try again.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }*/

            this.Hide();
            Home1 form_home1 = new Home1();
            form_home1.ShowDialog();
            this.Close();

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
    }
}
