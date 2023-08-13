using Microsoft.Kiota.Abstractions;
using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;

namespace SCTAttendanceSystemUI.Forms.AddLeaveButton
{
    public partial class AddLeaveButtonForm : Form
    {
        private string transferredData1;
        private string transferredData2;
        private string transferredData3;
        private string transferredData4;
        private string transferredData5;
        private string transferredData6;
        private string transferredData7;
        private string transferredData8;
        private string transferredData9;
        private string transferredData10;
        private string transferredData11;
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;


        public AddLeaveButtonForm(string empnum, string firstname, string middlename, string lastname, string suffix, string dep, string occupation, string jobstatus, string start, string end, string leavestatus)
        {
            InitializeComponent();
            transferredData1 = empnum;
            transferredData2 = firstname;
            transferredData3 = middlename;
            transferredData4 = lastname;
            transferredData5 = suffix;
            transferredData6 = dep;
            transferredData7 = occupation;
            transferredData8 = jobstatus;
            transferredData9 = start;
            transferredData10 = end;
            transferredData11 = leavestatus;
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                // Delete the selected row from emp_leaverequests table
                string deleteQuery = "DELETE FROM emp_leaverequests WHERE empnum = @empnum";
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@empnum", textBoxEmployeeNo.Text);
                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Request Rejected!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Close();
        }

        private void AddLeaveButtonForm_Load(object sender, EventArgs e)
        {
            textBoxEmployeeNo.Text = transferredData1; // department
            textBoxFirstName.Text = transferredData2; // occupation
            textBoxMiddleInitial.Text = transferredData3; // salary
            textBoxLastName.Text = transferredData4; // accountnum
            textBoxSuffix.Text = transferredData5; // department
            comboBoxDepartment.Text = transferredData6; // occupation
            comboBoxOccupation.Text = transferredData7; // salary
            comboBox1.Text = transferredData8; // salary
            textBoxDuration.Text = DateTime.Parse(transferredData9).ToString("MMMM dd, yyyy"); //hired date
            textBox1.Text = DateTime.Parse(transferredData10).ToString("MMMM dd, yyyy"); //dob
            comboBoxLeave.Text = transferredData11; // salary

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string textBoxDurationValue = textBoxDuration.Text;
            DateTime startDateTime = DateTime.ParseExact(textBoxDurationValue, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
            string formattedStartDateTime = startDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            string textBoxEndValue = textBox1.Text;
            DateTime endDateTime = DateTime.ParseExact(textBoxEndValue, "MMMM dd, yyyy", CultureInfo.InvariantCulture);
            string formattedEndDateTime = endDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                // Open the connection
                connection.Open();

                // Retrieve the name from the emp_leaverequests table based on empnum
                string query = "SELECT name FROM emp_leaverequests WHERE empnum = @empnum";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@empnum", textBoxEmployeeNo.Text);
                string name = command.ExecuteScalar()?.ToString();

                // Insert the selected row into emp_onleave table
                string insertQuery = "INSERT INTO emp_onleave (empnum, name, occupation, department, jobstatus, start, end, leavestatus) " +
                    "VALUES (@empnum, @name, @occupation, @department, @jobstatus, @start, @end, @leavestatus)";
                MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@empnum", textBoxEmployeeNo.Text);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@occupation", comboBoxOccupation.Text);
                insertCommand.Parameters.AddWithValue("@department", comboBoxDepartment.Text);
                insertCommand.Parameters.AddWithValue("@jobstatus", comboBox1.Text);
                insertCommand.Parameters.AddWithValue("@start", formattedStartDateTime);
                insertCommand.Parameters.AddWithValue("@end", formattedEndDateTime);
                insertCommand.Parameters.AddWithValue("@leavestatus", comboBoxLeave.Text);
                insertCommand.ExecuteNonQuery();

                // Delete the selected row from emp_leaverequests table
                string deleteQuery = "DELETE FROM emp_leaverequests WHERE empnum = @empnum";
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@empnum", textBoxEmployeeNo.Text);
                deleteCommand.ExecuteNonQuery();

                MessageBox.Show("Request Approved!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                connection.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

