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


        //private string name;

        public FormEmployeeDashboard()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);


            //this.name = name;

            string empNum = empNumLabel.Text;
            string status = empStatusLabel.Text;


            InitializeControls();

        }

        private void InitializeControls()
        {

/*            // Create a PictureBox and set its properties
            PictureBox pictureBox = employeePB;
            employeePB.Dock = DockStyle.Fill; // Dock the PictureBox to fill the Panel
            employeePB.SizeMode = PictureBoxSizeMode.StretchImage; // Set the size mode as needed

            // Add the PictureBox to the Panel
            panelPB.Controls.Add(employeePB);

            // Set the border radius of the Panel (creating a rounded border effect)
            int borderRadius = 400; // Adjust the value based on your preference
            System.Drawing.Drawing2D.GraphicsPath panelPath = new System.Drawing.Drawing2D.GraphicsPath();
            panelPath.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            panelPath.AddArc(panelPB.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
            panelPath.AddArc(panelPB.Width - borderRadius, panelPB.Height - borderRadius, borderRadius, borderRadius, 0, 90);
            panelPath.AddArc(0, panelPB.Height - borderRadius, borderRadius, borderRadius, 90, 90);
            panelPath.CloseFigure();
            panelPB.Region = new System.Drawing.Region(panelPath);*/

        }

        private void FormEmployeeDashboard_Load_1(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy, h:mm:ss tt").ToUpper();
        }

        private void LoadEmployeeData(string scannedRFID)
        {
            try
            {
                connection.Open();

                // Use a parameterized query to avoid SQL injection
                string query = "SELECT employeenum, name, occupation, department, image_data FROM employee WHERE employeenum = @employeeNumber";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@employeeNumber", scannedRFID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DisplayEmployeeData(reader);
                    }
                    else
                    {
                        ClearDisplayedData();
                        empStatusLabel.Text = "Employee Not Found!";
                        empStatusLabel.Location = new Point(40, 20);
                        StatusPanel.BackColor = Color.FromArgb(242, 205, 10);

                        //empStatusLabel.ForeColor = Color.Red;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void DisplayEmployeeData(MySqlDataReader reader)
        {
            empNumLabel.Text = reader["employeenum"].ToString();
            empNumLabel.Location = new Point(100, 19);

            empName.Text = reader["name"].ToString();
            occupationLabel.Text = reader["occupation"].ToString();
            departmentLabel.Text = reader["department"].ToString();

            byte[] imageData = (byte[])reader["image_data"];
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                employeePB.Image = Image.FromStream(ms);
                employeePB.SizeMode = PictureBoxSizeMode.Zoom;
            }

            TimeIn();
            StartDisplayTimer();

        }

        private System.Windows.Forms.Timer displayTimer;

        private void StartDisplayTimer()
        {
            // Create and configure the timer
            displayTimer = new System.Windows.Forms.Timer();
            displayTimer.Interval = 5000; // 5 seconds
            displayTimer.Tick += DisplayTimer_Tick;


            // Start the timer
            displayTimer.Start();
        }

        private void DisplayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer when it ticks (after 10 seconds)
            displayTimer.Stop();

            // Clear or hide the displayed data
            ClearDisplayedData();
        }

        private void ClearDisplayedData()
        {
            // Clear or hide the displayed data on your form
            empNumLabel.Text = "EMPLOYEE NUMBER";
            empNumLabel.Location = new Point(20, 19);

            empName.Text = "NAME";
            occupationLabel.Text = "OCCUPATION";
            departmentLabel.Text = "DEPARTMENT";
            employeePB.Image = null; // Clear the image

            // Additional clearing code as needed

            // Call TimeOut here if you want to proceed to TimeOut after 10 seconds
            // TimeOut();

            // Reset the status label and color
            empStatusLabel.Text = "STATUS";
            StatusPanel.BackColor = Color.FromArgb(242, 205, 10);

            // Reset the tapID label
            tapID.Text = "";
        }

        private void TimeIn()
        {
            string name = empName.Text;
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";
            string connectionString3 = "server=localhost;user=root;password=root;database=payrollsys";
            DateTime date = Convert.ToDateTime(dateLabel.Text);
            DateTime time = DateTime.Now;

            try
            {
                string checkQuery = "SELECT COUNT(*) FROM empattendance WHERE name = @name AND date = @date";
                using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                {
                    checkConnection.Open();
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, checkConnection);
                    checkCommand.Parameters.AddWithValue("@name", name);
                    checkCommand.Parameters.AddWithValue("@date", date);

                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (count > 0)
                    {
                        tapID.Text = "";
                        TimeOut();
                    }
                    else
                    {
                        string query = "SELECT employeenum, name, department, occupation, jobstatus, jobhours, jobtimein, jobtimeout FROM employee WHERE name = @name";
                        using (MySqlConnection insertConnection = new MySqlConnection(connectionString3))
                        {
                            insertConnection.Open();
                            MySqlCommand command = new MySqlCommand(query, insertConnection);
                            command.Parameters.AddWithValue("@name", name);

                            DataTable dt = new DataTable();
                            dt.Load(command.ExecuteReader());

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];

                                string insertQuery = "INSERT INTO empattendance (empnum, name, department, occupation, jobstatus, jobhours, date, timein, jobtimein, jobtimeout) VALUES (@empnum, @name, @department, @occupation, @jobstatus, @jobhours, @date, @timein, @jobtimein, @jobtimeout)";
                                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, insertConnection))
                                {
                                    insertCommand.Parameters.AddWithValue("@empnum", row["employeenum"].ToString());
                                    insertCommand.Parameters.AddWithValue("@name", row["name"].ToString());
                                    insertCommand.Parameters.AddWithValue("@department", row["department"].ToString());
                                    insertCommand.Parameters.AddWithValue("@occupation", row["occupation"].ToString());
                                    insertCommand.Parameters.AddWithValue("@jobstatus", row["jobstatus"].ToString());
                                    insertCommand.Parameters.AddWithValue("@jobhours", row["jobhours"].ToString());
                                    insertCommand.Parameters.AddWithValue("@date", date);
                                    insertCommand.Parameters.AddWithValue("@timein", time);
                                    insertCommand.Parameters.AddWithValue("@jobtimein", row["jobtimein"]);
                                    insertCommand.Parameters.AddWithValue("@jobtimeout", row["jobtimeout"]);

                                    insertCommand.ExecuteNonQuery();

                                    tapID.Text = "";
                                    empStatusLabel.Text = "Time-In";
                                    empStatusLabel.Location = new Point(124, 20);
                                    StatusPanel.BackColor = Color.Green;
                                    StartDisplayTimer();
                                }
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given Name.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void TimeOut()
        {
            string name = empName.Text;
            DateTime timeout = DateTime.Now;
            string connectionString3 = "server=localhost;user=root;password=root;database=payrollsys";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString3))
                {
                    connection.Open();

                    string query = "UPDATE empattendance SET timeout = @timeout, totalhours = TIMEDIFF(timeout, timein), late = IF(TIMEDIFF(timein, jobtimein) >= '00:00:00', TIMEDIFF(timein, jobtimein), '00:00:00'), undertime = IF(TIMEDIFF(jobtimeout, timeout) >= '00:00:00', TIMEDIFF(jobtimeout, timeout), '00:00:00') WHERE name = @name AND timeout IS NULL";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@timeout", timeout);
                    command.Parameters.AddWithValue("@name", name);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        empStatusLabel.Text = "Time-Out";
                        empStatusLabel.Location = new Point(124, 20);
                        StatusPanel.BackColor = Color.Red; 
                        StartDisplayTimer();
                    }
                    else
                    {
                        TimeIn();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }




        private void tapID_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key was pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Handle RFID input here
                string scannedRFID = tapID.Text;

                // Call a method to look for the matched employeenum in the database
                LoadEmployeeData(scannedRFID);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void ToggleMaximizeRestore()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                // If currently Maximized, restore to Normal
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                // If currently Normal, maximize the window
                this.WindowState = FormWindowState.Maximized;
            }
        }

    }

}

