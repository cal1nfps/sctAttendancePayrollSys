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
using Microsoft.Office.Interop.Excel;

namespace SCTAttendanceSystemUI
{
    public partial class EmployeeLogin : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        public EmployeeLogin()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void LookupEmployee(string scannedRFID)
        {
            try
            {
                connection.Open();

                // Use a parameterized query to avoid SQL injection
                string query = "SELECT name FROM employee WHERE employeenum = @employeeNumber";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Replace textBoxIDNum.Text with the actual value from your RFID scanner
                command.Parameters.AddWithValue("@employeeNumber", textBoxIDNum.Text);
                string name = (string)command.ExecuteScalar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    System.Data.DataTable dataTable = new System.Data.DataTable(); // Specify the namespace
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {

                        this.Hide();
                        FormEmployeeDashboard empDashboard = new FormEmployeeDashboard(name);
                        empDashboard.ShowDialog();
                    }
                    else
                    {
                        // Handle the case where no match is found
                        MessageBox.Show("Employee not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void textBoxIDNum_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Handle RFID input here
                string scannedRFID = textBoxIDNum.Text;

                // Call a method to look for the matched employeenum in the database
                LookupEmployee(scannedRFID);
            }
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void backBtn_MouseHover(object sender, EventArgs e)
        {
            backBtn.BackColor = Color.FromArgb(164, 16, 48);
        }

        private void textBoxIDNum_Enter(object sender, EventArgs e)
        {
            textBoxIDNum.HideSelection = false;
        }

        private void textBoxIDNum_Leave(object sender, EventArgs e)
        {
            textBoxIDNum.HideSelection = true;
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
