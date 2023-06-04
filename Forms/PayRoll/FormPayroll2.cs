using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    public partial class FormPayroll2 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private string employeeNumber;
        private string selectedMonth;
        public FormPayroll2(string empNumber, string month)
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            employeeNumber = empNumber;
            selectedMonth = month;
        }

        private void FormPayroll2_Load(object sender, EventArgs e)
        {
            // Set the employee number and selected month labels
            label5.Text = employeeNumber;
            label1.Text = selectedMonth;

            // Retrieve the total hours and calculate the payroll salary
            double hourlyRate = 0.0;
            double totalHours = 0.0;
            double totalSalary = 0.0;

            string query = "SELECT totalhours FROM empattendance WHERE empnum = @employeenum AND MONTH(date) = MONTH(@selectedMonth)";

            connection.Open();
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@employeenum", employeeNumber);
                command.Parameters.AddWithValue("@selectedMonth", DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.InvariantCulture).Month);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TimeSpan jobHours = (TimeSpan)reader["totalhours"];
                        totalHours += jobHours.TotalHours;
                    }
                }
            }


            // Calculate the total salary
            hourlyRate = GetHourlyRate(employeeNumber); // Replace this with your logic to retrieve the hourly rate based on employee number
            totalSalary = hourlyRate * totalHours;

            // Display the calculated values
            textBox9.Text = hourlyRate.ToString();
            textBox8.Text = totalHours.ToString();
            textBox7.Text = totalSalary.ToString();
        }

        private double GetHourlyRate(string employeeNumber)
        {
            double hourlyRate = 0.0;

            string query = "SELECT jobsalary FROM employee WHERE employeenum = @employeenum";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@employeenum", employeeNumber);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    hourlyRate = Convert.ToDouble(result);
                }
            }


            return hourlyRate;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
