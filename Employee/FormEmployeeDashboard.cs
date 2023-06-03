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

        private void FormEmployeeDashboard_Load(object sender, EventArgs e)
        {
            label1.Text = name;
            timer1.Start();
            labelDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void buttonTimeIn_Click(object sender, EventArgs e)
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
                    Form1 form_form1 = new Form1();
                    form_form1.ShowDialog();
                }
                else
                {


                    // Query to retrieve the employee number and department based on the label text
                    string query = "SELECT employeenum, name, department, occupation, jobstatus, jobhours FROM employee WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    string jobhours = command.ExecuteScalar()?.ToString();


                    // Create a DataTable to store the retrieved data
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    // Check if any data was retrieved
                    if (dt.Rows.Count > 0)
                    {
                        // Store the retrieved data in another table
                        string insertQuery = "INSERT INTO empattendance (empnum, name, department, occupation, jobstatus, jobhours, date, timein) VALUES (@empnum, @name, @department, @occupation, @jobstatus, @jobhours, @date, @timein)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.Add("@empnum", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@department", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@occupation", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@jobstatus", MySqlDbType.VarChar);
                        insertCommand.Parameters.AddWithValue("@jobhours", jobhours);
                        insertCommand.Parameters.AddWithValue("@date", date);
                        insertCommand.Parameters.AddWithValue("@timein", timein);

                        foreach (DataRow row in dt.Rows)
                        {
                            insertCommand.Parameters["@empnum"].Value = row["employeenum"].ToString();
                            insertCommand.Parameters["@name"].Value = row["name"].ToString();
                            insertCommand.Parameters["@department"].Value = row["department"].ToString();
                            insertCommand.Parameters["@occupation"].Value = row["occupation"].ToString();
                            insertCommand.Parameters["@jobstatus"].Value = row["jobstatus"].ToString();
                            insertCommand.Parameters["@jobhours"].Value = row["jobhours"].ToString();
                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Attendance Time-In successfully!");
                        this.Hide();
                        Form1 form_form1 = new Form1();
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



        private void buttonTimeOut_Click(object sender, EventArgs e)
        {
            // Get the label text
            string name = label1.Text;
            int id = 123;
            DateTime timeout = Convert.ToDateTime(labelTime.Text);


            try
            {
                connection.Open();

                // Update the empty column based on label text name
                string query = "UPDATE empattendance SET timeout = @timeout, totalhours = TIMEDIFF(timeout, timein) WHERE name = @name AND timeout IS NULL";
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
            Form1 form_form1 = new Form1();
            form_form1.ShowDialog();
            this.Close();
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
                    Form1 form_form1 = new Form1();
                    form_form1.ShowDialog();
                }
                else
                {


                    // Query to retrieve the employee number and department based on the label text
                    string query = "SELECT employeenum, name, department, occupation, jobstatus, jobhours FROM employee WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", name);

                    string jobhours = command.ExecuteScalar()?.ToString();


                    // Create a DataTable to store the retrieved data
                    DataTable dt = new DataTable();
                    dt.Load(command.ExecuteReader());

                    // Check if any data was retrieved
                    if (dt.Rows.Count > 0)
                    {
                        // Store the retrieved data in another table
                        string insertQuery = "INSERT INTO empattendance (empnum, name, department, occupation, jobstatus, jobhours, date, timein) VALUES (@empnum, @name, @department, @occupation, @jobstatus, @jobhours, @date, @timein)";
                        MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                        insertCommand.Parameters.Add("@empnum", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@name", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@department", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@occupation", MySqlDbType.VarChar);
                        insertCommand.Parameters.Add("@jobstatus", MySqlDbType.VarChar);
                        insertCommand.Parameters.AddWithValue("@jobhours", jobhours);
                        insertCommand.Parameters.AddWithValue("@date", date);
                        insertCommand.Parameters.AddWithValue("@timein", timein);

                        foreach (DataRow row in dt.Rows)
                        {
                            insertCommand.Parameters["@empnum"].Value = row["employeenum"].ToString();
                            insertCommand.Parameters["@name"].Value = row["name"].ToString();
                            insertCommand.Parameters["@department"].Value = row["department"].ToString();
                            insertCommand.Parameters["@occupation"].Value = row["occupation"].ToString();
                            insertCommand.Parameters["@jobstatus"].Value = row["jobstatus"].ToString();
                            insertCommand.Parameters["@jobhours"].Value = row["jobhours"].ToString();
                            insertCommand.ExecuteNonQuery();
                        }

                        MessageBox.Show("Attendance Time-In successfully!");
                        this.Hide();
                        Form1 form_form1 = new Form1();
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
            int id = 123;
            DateTime timeout = Convert.ToDateTime(labelTime.Text);


            try
            {
                connection.Open();

                // Update the empty column based on label text name
                string query = "UPDATE empattendance SET timeout = @timeout, totalhours = TIMEDIFF(timeout, timein) WHERE name = @name AND timeout IS NULL";
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
            Form1 form_form1 = new Form1();
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
    }
}
