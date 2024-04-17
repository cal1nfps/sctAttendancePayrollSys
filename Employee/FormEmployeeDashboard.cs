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
using System;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Employee
{
    public partial class FormEmployeeDashboard : Form
    {
        private MySqlConnection connection;
        private System.Windows.Forms.Timer timeTimer;

        //private string name;

        public FormEmployeeDashboard()
        {


            // Make tapID interactable but invisible

            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            timeTimer = new System.Windows.Forms.Timer(); // Specify the full namespace here
            timeTimer.Interval = 1000; // 1 second
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();

            // Set focus to the tapID textbox

            tapID.Focus();

            LoadEmployeeAttendanceData();

            // Set the text cursor color to match the background color of the textbox
            tapID.BackColor = this.BackColor; // Assuming the form's background color i


            //this.name = name;

            string empNum = empNumLabel.Text;
            string status = empStatusLabel.Text;




            // Disable all controls except tapID textbox


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

        // Define the event handler for the timer's Tick event
        private void TimeTimer_Tick(object sender, EventArgs e)
        {
            // Update the timeLabel with the current time and date
            timeBox.Text = DateTime.Now.ToString("hh:mm:ss tt, MMM dd, yyyy");
        }

        private void FormEmployeeDashboard_Load_1(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy, h:mm:ss tt").ToUpper();
        }

        private void LoadEmployeeData(string scannedRFID)
        {
            try
            {
                // Disable all controls on the form except for the ones you want to keep enabled
                foreach (Control control in Controls)
                {
                    if (control != empStatusLabel && control != StatusPanel)
                    {
                        control.Enabled = false;
                    }
                }

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

                        // Start a timer to clear the displayed data after 12 seconds
                        System.Windows.Forms.Timer clearTimer = new System.Windows.Forms.Timer();
                        clearTimer.Interval = 8000; // 12 seconds
                        clearTimer.Tick += (sender, args) =>
                        {
                            clearTimer.Stop();
                            clearTimer.Dispose();

                            // Enable all controls on the form
                            foreach (Control control in Controls)
                            {
                                control.Enabled = true;
                            }

                            // Set focus to the tapID textbox
                            tapID.Focus();
                        };
                        clearTimer.Start();
                    }
                    else
                    {
                        empStatusLabel.Text = "Employee Not Found!";
                        empStatusLabel.Location = new Point(40, 20);
                        StatusPanel.BackColor = Color.FromArgb(242, 205, 10);

                        // Enable all controls on the form
                        foreach (Control control in Controls)
                        {
                            control.Enabled = true;
                        }

                        // Set focus to the tapID textbox
                        tapID.Focus();
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

        private void LoadEmployeeAttendanceData()
        {
            try
            {
                connection.Open();

                // Query to fetch all rows and columns from the empattendance table
                string query = "SELECT * FROM empattendance";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Create a DataTable to store the results
                DataTable dataTable = new DataTable();

                // Load the data into the DataTable
                dataTable.Load(command.ExecuteReader());

                // Bind the DataTable to the DataGridView
                dataChecker.DataSource = dataTable;
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
            displayTimer.Interval = 8000;
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
                                    string currentTimeStamp = DateTime.Now.ToString("HH:mm:ss");
                                    empStatusLabel.Text = $"Time-In ({currentTimeStamp})";
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
                        string currentTimeStamp = DateTime.Now.ToString("HH:mm:ss");
                        empStatusLabel.Text = $"Time-Out ({currentTimeStamp})";
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

                // Check if the user has already timed in or out for the day based on job time
                if (HasAlreadyTimedInForToday(scannedRFID) && HasAlreadyTimedOutForToday(scannedRFID))
                {
                    // Display a message informing the user that they have already timed in and out for today based on job time
                    
                    empStatusLabel.Text = $"Already Logged out";
                    empStatusLabel.Location = new Point(124, 20);
                    StatusPanel.BackColor = Color.Red;
                    return; // Exit the method
                }
                if (HasAlreadyTimedInForToday(scannedRFID))
                {
                    // Display a message informing the user that they have already timed in for today based on job time
             
                    empStatusLabel.Text = $"Already Logged out";
                    empStatusLabel.Location = new Point(124, 20);
                    StatusPanel.BackColor = Color.Red;
                    return; // Exit the method
                }
                if (HasAlreadyTimedOutForToday(scannedRFID))
                {
                    // Display a message informing the user that they have already timed out for today based on job time
                
                    empStatusLabel.Text = $"Already Logged out";
                    empStatusLabel.Location = new Point(124, 20);
                    StatusPanel.BackColor = Color.Red;
                    return; // Exit the method
                }

                // Call a method to look for the matched employeenum in the database
                LoadEmployeeData(scannedRFID);

                // Update the table to indicate that the user has timed in for today
                UpdateAttendanceTable(scannedRFID, true);

                // Reload the data into the DataGridView named dataChecker
                LoadDataIntoDataGridView();
            }
        }

        private void UpdateAttendanceTable(string employeeID, bool isTimedIn)
        {
            try
            {
                connection.Open();

                // Construct the SQL update query based on whether the user is timed in or timed out
                string query;
                if (isTimedIn)
                {
                    query = "UPDATE empattendance SET jobtimein = @timein WHERE empnum = @employeeID";
                }
                else
                {
                    query = "UPDATE empattendance SET jobtimeout = @timeout WHERE empnum = @employeeID";
                }

                // Create and execute the SQL command
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@timein", DateTime.Now);
                command.Parameters.AddWithValue("@timeout", DateTime.Now);
                command.Parameters.AddWithValue("@employeeID", employeeID);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    
                }
                else
                {
                   
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

        private void LoadDataIntoDataGridView()
        {
            // Assuming dataChecker is a DataGridView bound to a DataTable or similar data source
            // Reload data into the DataGridView
            // This assumes you have a method or logic to fetch and load the updated data source into the DataGridView
            // For example:
            dataChecker.DataSource = null; // Clear the existing data source
                                           // Reassign the data source (e.g., dt is your DataTable)
            dataChecker.DataSource = GetUpdatedDataSource(); // Replace GetUpdatedDataSource() with your method to fetch the updated data source
        }

        private DataTable GetUpdatedDataSource()
        {
            // Assuming you have a method to fetch data from your database and return it as a DataTable
            // Replace this with your actual logic to fetch the updated data source
            DataTable updatedDataSource = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT * FROM empattendance"; // Example query to fetch data from the empattendance table
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(updatedDataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching updated data source: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }

            return updatedDataSource;
        }





        private bool HasAlreadyTimedOutForToday(string employeeID)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dataChecker.Rows)
            {
                // Check if the row has data and matches the employee ID and current date
                if (!row.IsNewRow && row.Cells["empnum"].Value.ToString() == employeeID)
                {
                    // Check if timeout value exists for the current row and is not DBNull
                    if (row.Cells["timeout"].Value != null && row.Cells["timeout"].Value != DBNull.Value)
                    {
                        // If timeout value exists and is not DBNull, return true (user has already timed out for the day)
                        return true;
                    }
                }
            }

            // If no matching record found with timeout value for today or if timeout value is DBNull, return false
            return false;
        }



        private bool HasAlreadyTimedInForToday(string employeeID)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Iterate through the rows of the DataGridView
            foreach (DataGridViewRow row in dataChecker.Rows)
            {
                // Check if the row has data and matches the employee ID and current date
                if (!row.IsNewRow && row.Cells["empnum"].Value.ToString() == employeeID)
                {
                    // Check if timein value exists for the current row
                    if (row.Cells["timein"].Value != null)
                    {
                        // If timein value exists and timeout value doesn't exist, return true
                        if (row.Cells["timeout"].Value == null)
                        {
                            return true;
                        }
                    }
                }
            }

            // If no matching record found with timein value for today or if timeout value exists, return false
            return false;
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

