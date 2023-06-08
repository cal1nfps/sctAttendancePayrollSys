using SCTAttendanceSystemUI.Forms;
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
using System.Xml;
using System.Data.SqlTypes;
using SCTAttendanceSystemUI.Resources;

namespace SCTAttendanceSystemUI.Employee
{
    public partial class FormEmployeeDashboard : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;

        private string name;

        public FormEmployeeDashboard(string name)
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            this.name = name;
        }


        private void buttonTimeIn_Click_1(object sender, EventArgs e)
        {
            // Get the label text from the current form
            string name = label1.Text;
            DateTime date = Convert.ToDateTime(labelDate.Text);
            DateTime timein = Convert.ToDateTime(labelTime.Text);

            try
            {
                connection.Open();

                // Check if a record already exists for the given name and date
                string checkQuery = "SELECT COUNT(*) FROM empattendance WHERE name = @name AND date = @date";
                MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@name", name);
                checkCommand.Parameters.AddWithValue("@date", date);

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
                    string query = "SELECT employeenum, name, department, occupation, jobstatus, jobhours, jobtimein, jobtimeout FROM employee WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    // Check if any data was retrieved
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];

                        // Store the retrieved data in another table
                        string insertQuery = "INSERT INTO empattendance (empnum, name, department, occupation, jobstatus, jobhours, date, timein, jobtimein, jobtimeout) VALUES (@empnum, @name, @department, @occupation, @jobstatus, @jobhours, @date, @timein, @jobtimein, @jobtimeout)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@empnum", row["employeenum"].ToString());
                        insertCommand.Parameters.AddWithValue("@name", row["name"].ToString());
                        insertCommand.Parameters.AddWithValue("@department", row["department"].ToString());
                        insertCommand.Parameters.AddWithValue("@occupation", row["occupation"].ToString());
                        insertCommand.Parameters.AddWithValue("@jobstatus", row["jobstatus"].ToString());
                        insertCommand.Parameters.AddWithValue("@jobhours", row["jobhours"].ToString());
                        insertCommand.Parameters.AddWithValue("@date", date);
                        insertCommand.Parameters.AddWithValue("@timein", timein);
                        insertCommand.Parameters.AddWithValue("@jobtimein", row["jobtimein"]); // Assuming "jobtimein" is already a DateTime in the database
                        insertCommand.Parameters.AddWithValue("@jobtimeout", row["jobtimeout"]); // Assuming "jobtimeout" is already a DateTime in the database

                        insertCommand.ExecuteNonQuery();

                        MessageBox.Show("Attendance Time-In successfully!");
                        this.Hide();
                        WelcomePage form_form1 = new WelcomePage();
                        form_form1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given Name.");
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

        private void buttonTimeOut_Click_1(object sender, EventArgs e)
        {
            // Get the label text
            string name = label1.Text;
            DateTime timeout = Convert.ToDateTime(labelTime.Text);



            try
            {
                connection.Open();

                // Update the empty column based on label text name
                string query = "UPDATE empattendance SET timeout = @timeout, totalhours = TIMEDIFF(timeout, timein), late = IF(TIMEDIFF(timein, jobtimein) >= '00:00:00', TIMEDIFF(timein, jobtimein), '00:00:00'), undertime = IF(TIMEDIFF(jobtimeout, timeout) >= '00:00:00', TIMEDIFF(jobtimeout, timeout), '00:00:00') WHERE name = @name AND timeout IS NULL";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@timeout", timeout);
                command.Parameters.AddWithValue("@name", name);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Attendance Time-In successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to save.");
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



            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void FormEmployeeDashboard_Load_1(object sender, EventArgs e)
        {
            label1.Text = name;
            timer1.Start();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void RequestLeaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RequestLeaveAuth form_req = new RequestLeaveAuth(name);
            form_req.ShowDialog();
            this.Close();
        }

    }
}
