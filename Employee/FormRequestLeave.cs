using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kiota.Abstractions;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI.Employee
{
    public partial class FormRequestLeave : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private string name;
        public FormRequestLeave(string name)
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            this.name = name;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = empname.Text;
            try
            {
                connection.Open();

                // Check if a record already exists for the given name and date
                string checkQuery = "SELECT COUNT(*) FROM emp_leaverequests WHERE name = @name ";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@name", name);

                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                if (count > 0)
                {
                    // A record already exists, meaning the user has already time-in for the day
                    MessageBox.Show("You have already time-in for today.");
                    this.Hide();
                    WelcomePage form_form1 = new WelcomePage();
                    form_form1.ShowDialog();
                }
                else
                {
                    // Query to retrieve the employee number and department based on the label text
                    string query = "SELECT employeenum, name, firstname, middle, lastname, suffix, occupation, department, jobstatus FROM employee WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    // Check if any data was retrieved
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Store the retrieved data in another table
                        string insertQuery = "INSERT INTO emp_leaverequests (empnum, name, firstname, middlename, lastname, suffix, department, occupation, jobstatus, date, start, end, leavestatus) VALUES (@empnum, @name, " +
                            "@firstname, @middlename, @lastname, @suffix, @department, @occupation, @jobstatus, @date, @start, @end, @leavestatus)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@empnum", row["employeenum"].ToString());
                        insertCommand.Parameters.AddWithValue("@name", row["name"].ToString());
                        insertCommand.Parameters.AddWithValue("@firstname", row["firstname"].ToString());
                        insertCommand.Parameters.AddWithValue("@middlename", row["middle"].ToString());
                        insertCommand.Parameters.AddWithValue("@lastname", row["lastname"].ToString());
                        insertCommand.Parameters.AddWithValue("@suffix", row["suffix"].ToString());
                        insertCommand.Parameters.AddWithValue("@department", row["department"].ToString());
                        insertCommand.Parameters.AddWithValue("@occupation", row["occupation"].ToString());
                        insertCommand.Parameters.AddWithValue("@jobstatus", row["jobstatus"].ToString());
                        insertCommand.Parameters.AddWithValue("@date", DateTime.Today);
                        insertCommand.Parameters.AddWithValue("@start", dateTimePickerLeave.Value.Date);
                        insertCommand.Parameters.AddWithValue("@end", dateTimePicker1.Value.Date);
                        insertCommand.Parameters.AddWithValue("@leavestatus", comboBoxLeave.SelectedItem.ToString());



                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Leave Request Submitted!");
                        this.Hide();
                        WelcomePage form_form1 = new WelcomePage();
                        form_form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the matched Name.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void empname_Click(object sender, EventArgs e)
        {

        }

        private void labelLeaveInfo_Click(object sender, EventArgs e)
        {

        }

        private void FormRequestLeave_Load(object sender, EventArgs e)
        {
            empname.Text = name;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployeeDashboard form_form1 = new FormEmployeeDashboard(name);
            form_form1.ShowDialog();
            this.Close();
        }

        private void ExitBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void labelDuration_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
