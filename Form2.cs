using SCTAttendanceSystemUI.Employee;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SCTAttendanceSystemUI.Forms;

namespace SCTAttendanceSystemUI
{
    public partial class Form2 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        public Form2()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_form1 = new Form1();
            form_form1.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string empnum = textBoxIDNum.Text;

            if (ValidateInputs(empnum))
            {
                try
                {
                    connection.Open();

                    // Perform the login authentication here
                    // You can execute SQL queries or stored procedures to check the credentials

                    // For example:
                    string query = "SELECT name FROM employee WHERE employeenum = @employeeNumber";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@employeeNumber", empnum);
                    string name = (string)command.ExecuteScalar();


                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            this.Hide();
                            FormEmployeeDashboard empDashboard = new FormEmployeeDashboard(name);
                            empDashboard.ShowDialog();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid Employee Number!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception or display an error message
                    MessageBox.Show("Error occurred: " + ex.Message);
                }
            }
        }

        private bool ValidateInputs(string empnum)
        {
            // Perform any necessary validation here

            if (string.IsNullOrEmpty(empnum))
            {
                MessageBox.Show("Please enter Employee Number!");
                return false;
            }

            return true;
        }


    }
}
