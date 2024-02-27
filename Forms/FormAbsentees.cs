using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using MySql.Data.MySqlClient;
using ExcelDataReader;


using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SCTAttendanceSystemUI.Employee.filterAbsent;
using System.Globalization;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormAbsentees : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;
        public FormAbsentees()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            SetDataGridViewStyle(dataGridViewAbsentees, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed

            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
            InitializeTimer();


        }

        private void ApplyColumnStyles()
        {
            // Dynamic Column Color Changer
            foreach (DataGridViewColumn column in dataGridViewAbsentees.Columns)
            {
                // Check if the column index is even
                if (column.Index % 2 == 0)
                {
                    column.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void SetDataGridViewStyle(DataGridView dataGridView, Padding cellPadding, int cellHeight, float fontSize)
        {
            // Set the cell padding, height, and font size for the default cell style
            dataGridView.DefaultCellStyle.Padding = cellPadding;
            dataGridView.RowTemplate.Height = cellHeight;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);

            // Set the height and font size for the column headers
            dataGridView.ColumnHeadersHeight = cellHeight;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);


            // If you want to set the font size for the header cells as well, uncomment the following line
            // dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);
        }

        // Define a public method to get the DataGridView
        public DataGridView GetDataGridView()
        {
            return dataGridViewAbsentees; // Replace "dataGridView1" with the actual name of your DataGridView control
        }

        private void labelAbsenteesDate_Click(object sender, EventArgs e)
        {

        }

        private void FormAbsentees_Load_1(object sender, EventArgs e)
        {
            labelAbsenteesDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy, h:mm:ss tt").ToUpper();
            LoadAbsentEmployees();
            ApplyColumnStyles();


            dataGridViewAbsentees.Columns["employeenum"].HeaderText = "Employee Number";
            dataGridViewAbsentees.Columns["name"].HeaderText = "Name";
            dataGridViewAbsentees.Columns["department"].HeaderText = "Department";
            dataGridViewAbsentees.Columns["occupation"].HeaderText = "Occupation";
            dataGridViewAbsentees.Columns["jobstatus"].HeaderText = "Job Status";
            dataGridViewAbsentees.Columns["jobhours"].HeaderText = "Job Hours";
            dataGridViewAbsentees.Columns["jobtimein"].HeaderText = "Job Time-In";
            dataGridViewAbsentees.Columns["jobtimeout"].HeaderText = "Job Time-Out";



        }

        // Method to load absent employees and display them in the DataGridView
        private void LoadAbsentEmployees()
        {
            try
            {
                // Open the connection
                connection.Open();

                // Retrieve employees who are not present in empattendance today
                string selectQuery = "SELECT employeenum, name, department, occupation, jobstatus, jobhours, jobtimein, jobtimeout FROM employee WHERE employeenum NOT IN (SELECT empnum FROM empattendance WHERE DATE(date) = @today)";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@today", DateTime.Today);
                adapter = new MySqlDataAdapter(selectCommand);

                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);

                // Set the DataSource of the DataGridView to the DataTable
                dataGridViewAbsentees.DataSource = table;

                // Check if the end of the day has passed
                if (IsEndOfDay())
                {
                    // Insert the absent employees into emp_absents table
                    InsertAbsentEmployees();

                    // Update the last stored date
                    UpdateLastStoredDate();
                }

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

        private bool IsEndOfDay()
        {
            // Specify the time zone for the Philippines
            TimeZoneInfo phTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");

            // Get the current time in the Philippines time zone
            DateTime currentTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, phTimeZone);

            // Set the end of the day time in the Philippines time zone
            DateTime endOfDayTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 23, 59, 59, 999);

            return currentTime >= endOfDayTime;
        }

        private void UpdateLastStoredDate()
        {
            try
            {
                // Open the connection
                connection.Open();

                // Specify the time zone for the Philippines
                TimeZoneInfo phTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");

                // Get the current date in the Philippines time zone
                DateTime currentDate = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, phTimeZone).Date;

                // Update the last stored date in your settings or another table
                string updateQuery = "UPDATE settings SET last_stored_date = @today";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@today", currentDate);
                updateCommand.ExecuteNonQuery();
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

        private void InsertAbsentEmployees()
        {
            try
            {
                // Open the connection
                connection.Open();

                // Iterate through the rows of the DataGridView
                foreach (DataGridViewRow row in dataGridViewAbsentees.Rows)
                {
                    if (row.IsNewRow) continue; // Skip the new row if any

                    // Retrieve values from the DataGridView (check for null values)
                    string empnum = row.Cells["employeenum"].Value?.ToString();
                    string name = row.Cells["name"].Value?.ToString();
                    string dep = row.Cells["department"].Value?.ToString();
                    string occupation = row.Cells["occupation"].Value?.ToString();
                    string jobstatus = row.Cells["jobstatus"].Value?.ToString();
                    string jobhours = row.Cells["jobhours"].Value?.ToString();
                    string jobtimeinString = row.Cells["jobtimein"].Value?.ToString();
                    string jobtimeoutString = row.Cells["jobtimeout"].Value?.ToString();

                    // Convert string values to DateTime
                    DateTime jobtimein = DateTime.Parse(jobtimeinString);
                    DateTime jobtimeout = DateTime.Parse(jobtimeoutString);

                    // Format DateTime values to string with "hh:mm:ss tt" format
                    string formattedJobTimeIn = jobtimein.ToString("hh:mm:ss tt");
                    string formattedJobTimeOut = jobtimeout.ToString("hh:mm:ss tt");

                    DateTime currentDate = DateTime.Now;

                    // Insert the absent employee into emp_absents table
                    string insertQuery = "INSERT INTO emp_absents (empnum, name, department, occupation, jobstatus, jobhours, jobtimein, jobtimeout, date) " +
                                         "VALUES (@empnum, @name, @department, @occupation, @jobstatus, @jobhours, @jobtimein, @jobtimeout, @date)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@empnum", empnum);
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@department", dep);
                    insertCommand.Parameters.AddWithValue("@occupation", occupation);
                    insertCommand.Parameters.AddWithValue("@jobstatus", jobstatus);
                    insertCommand.Parameters.AddWithValue("@jobhours", jobhours);
                    insertCommand.Parameters.AddWithValue("@jobtimein", formattedJobTimeIn);
                    insertCommand.Parameters.AddWithValue("@jobtimeout", formattedJobTimeOut);
                    insertCommand.Parameters.AddWithValue("@date", currentDate);

                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Absent employees inserted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during insertion: " + ex.Message);
            }
            finally
            {
                // Close the connection
                connection.Close();
            }
        }

        private DataView dataView;
        private DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (DataTable)dataGridViewAbsentees.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(employeenum, 'System.String') LIKE '%{searchText}%'";
            dataGridViewAbsentees.DataSource = dataView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                // APPLY FILTER
                // Create an instance of the second form
                filterabsent filterForm = new filterabsent();

                // Show the second form as a dialog and wait for it to close
                DialogResult result = filterForm.ShowDialog();

                // Check if the user clicked the OK button
                if (result == DialogResult.OK)
                {
                    // Get the selected values from the comboboxes in the second form
                    string occupation = filterForm.occupationCMB.SelectedItem?.ToString();
                    string department = filterForm.depCMB.SelectedItem?.ToString();
                    string jobstatus = filterForm.jobStatusCMB.SelectedItem?.ToString();



                    // Check if at least one combobox is selected
                    if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(department) && string.IsNullOrWhiteSpace(jobstatus))
                    {
                        MessageBox.Show("Please select at least one filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Apply the filters to the datagridview
                        string filter = "";

                        if (!string.IsNullOrWhiteSpace(occupation))
                        {
                            filter += $"[occupation] = '{occupation}'";
                        }

                        if (!string.IsNullOrWhiteSpace(department))
                        {
                            if (!string.IsNullOrWhiteSpace(filter))
                            {
                                filter += " AND ";

                            }
                            filter += $"[department] = '{department}'";
                        }

                        if (!string.IsNullOrWhiteSpace(jobstatus))
                        {
                            if (!string.IsNullOrWhiteSpace(filter))
                            {
                                filter += " AND ";

                            }
                            filter += $"[jobstatus] = '{jobstatus}'";
                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewAbsentees.DataSource = dataTable;

                        (dataGridViewAbsentees.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Absentees-Output.xlsx"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path and name
                    string filePath = saveFileDialog.FileName;

                    // Creating Excel Application
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                    // Creating new Workbook within Excel application
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                    // Creating new Excel sheet in workbook
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    // See the Excel sheet behind the program
                    app.Visible = true;

                    // Get the reference of the first sheet. By default, its name is Sheet1.
                    // Store its reference to the worksheet
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;

                    // Changing the name of the active sheet
                    worksheet.Name = "Sheet 1 Exported";

                    // Storing header part in Excel
                    for (int i = 1; i < dataGridViewAbsentees.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewAbsentees.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridViewAbsentees.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewAbsentees.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewAbsentees.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Save the Excel file
                    workbook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    // Close the workbook and Excel application
                    workbook.Close();
                    app.Quit();

                    MessageBox.Show("Data exported to Excel successfully!");
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            SearchData(searchText);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            if (dataGridViewAbsentees.SelectedRows.Count > 0)
            {
                try
                {
                    // DELETE ITEM
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                        {
                            checkConnection.Open();

                            foreach (DataGridViewRow selectedRow in dataGridViewAbsentees.SelectedRows)
                            {
                                // Get the value from the selected row that you want to use for deletion.
                                string selectedValue = selectedRow.Cells["id"].Value.ToString();

                                // Delete from UserAct table
                                string deleteQuery = "DELETE FROM emp_absents WHERE id = @id;";
                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, checkConnection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@id", selectedValue);
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // If deletion is successful, remove the row from the DataGridView
                                        dataGridViewAbsentees.Rows.Remove(selectedRow);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Delete failed. Row with ID {selectedValue} not found.");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("No rows selected for deletion.");
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            try
            {
                // Confirm with the user before deleting all data
                DialogResult result = MessageBox.Show("Are you sure you want to delete all data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                {
                    if (result == DialogResult.Yes)
                    {
                        // Clear the DataGridView
                        dataGridViewAbsentees.DataSource = null;

                        // Delete all rows from the MySQL database
                        checkConnection.Open();

                        string deleteAllQuery = "DELETE FROM emp_absents"; // Remove the WHERE clause

                        using (MySqlCommand cmd = new MySqlCommand(deleteAllQuery, checkConnection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("All data deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
            }
        }

        private void clearLabel_MouseEnter(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.Red;

        }

        private void clearLabel_MouseLeave(object sender, EventArgs e)
        {
            clearLabel.ForeColor = SystemColors.ControlText; // You can set it to your desired default color

        }

        private void dataGridViewAbsentees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewAbsentees.Columns[e.ColumnIndex].Name == "jobtimein" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("hh:mm:ss tt");
                e.FormattingApplied = true;
            }

            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewAbsentees.Columns[e.ColumnIndex].Name == "jobtimeout" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("hh:mm:ss tt");
                e.FormattingApplied = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertAbsentEmployees();
        }

        private System.Threading.Timer timer;

        private void InitializeTimer()
        {
            // Set the initial delay to the time until the next day
            DateTime now = DateTime.Now;
            DateTime nextDay = now.AddDays(1).Date;
            TimeSpan initialDelay = nextDay - now;

            // Set the timer to trigger every 24 hours after the initial delay
            timer = new System.Threading.Timer(TimerCallback, null, (int)initialDelay.TotalMilliseconds, (int)TimeSpan.FromHours(24).TotalMilliseconds);
        }

        private void TimerCallback(object state)
        {
            // Insert absent employees
            InsertAbsentEmployees();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Insert absent employees
            InsertAbsentEmployees();

            // Reset the timer
            timer1.Stop();
            timer1.Start();
        }
    }
}
