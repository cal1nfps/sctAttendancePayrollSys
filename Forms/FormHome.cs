using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Graph.Models.Security;
using Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.filterAttendance;
using SCTAttendanceSystemUI.Forms.sortdgvFormHome;




namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormHome : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable table;

        public FormHome()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "To proceed to Home", MessageBoxButtons.OK);

            filterComboBox.Items.Add("Department");
            //sortCB.Items.Add("itemPrice");
            filterComboBox.Items.Add("Occupation");
            filterComboBox.Items.Add("Job Status");
            filterComboBox.Items.Add("Status");

            filterComboBox.KeyPress += ComboBox_KeyPress;
            filterApplyCMB.KeyPress += ComboBox_KeyPress;

            SetDataGridViewStyle(dataGridViewAttendance, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed

        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block any keypress event to prevent user input in the comboboxes
            e.Handled = true;
        }

        private void ApplyColumnStyles()
        {
            // Dynamic Column Color Changer
            foreach (DataGridViewColumn column in dataGridViewAttendance.Columns)
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
            return dataGridViewAttendance; // Replace "dataGridView1" with the actual name of your DataGridView control
        }

        private void FormHome_Load_1(object sender, EventArgs e)
        {
            ApplyColumnStyles();
            {
                labelDashboardDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy, h:mm:ss tt").ToUpper();

                string today = DateTime.Now.ToString("yyyy-MM-dd");
                string query = "SELECT * FROM empattendance WHERE DATE(date) = @today";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@today", today);
                adapter = new MySqlDataAdapter(command);

                // Create a DataTable to hold the data
                table = new System.Data.DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);

                // Set the DataSource of the DataGridView to the DataTable
                dataGridViewAttendance.DataSource = table;


                try
                {
                    connection.Open();

                    // Retrieve the occupation and job time-in from the database
                    string occupationQuery = "SELECT occupation, jobtimein FROM employee";
                    MySqlCommand occupationCommand = new MySqlCommand(occupationQuery, connection);
                    {
                        foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
                        {

                            string occupation = row.Cells["occupation"].Value.ToString();


                            DateTime timein = Convert.ToDateTime(row.Cells["timein"].Value);

                            DateTime jobtimein = Convert.ToDateTime(row.Cells["jobtimein"].Value);

                            string totalHoursString = row.Cells["totalhours"].Value?.ToString();
                            TimeSpan totalHours;
                            if (TimeSpan.TryParse(totalHoursString, out totalHours))
                            {
                                // Successfully parsed, you can use 'totalHours' now
                            }
                            else
                            {
                                // Handle the case where parsing failed or the value is null
                                // You may want to assign a default value or show an error message
                                totalHours = TimeSpan.Zero; // For example, set a default value
                            }

                            string jobHoursString = row.Cells["jobhours"].Value?.ToString();
                            TimeSpan jobHours;
                            if (TimeSpan.TryParse(jobHoursString, out jobHours))
                            {
                                // Successfully parsed, you can use 'jobHours' now
                            }
                            else
                            {
                                // Handle the case where parsing failed or the value is null
                                // You may want to assign a default value or show an error message
                                jobHours = TimeSpan.Zero; // For example, set a default value
                            }


                            // Calculate the expected time-in based on occupation
                            TimeSpan expectedTimeIn;
                            switch (occupation)
                            {
                                case "Teacher":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "Sports Coach":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "Registrar":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "Guidance Counselor":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "Guard":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "Chairperson":
                                    expectedTimeIn = new TimeSpan(7, 0, 0);
                                    break;
                                case "School Nurse":
                                    expectedTimeIn = new TimeSpan(8, 0, 0);
                                    break;
                                case "Maintenance Technician":
                                    expectedTimeIn = new TimeSpan(9, 0, 0);
                                    break;
                                default:
                                    expectedTimeIn = TimeSpan.Zero; // Set a default value if occupation does not match any case
                                    break;
                            }

                            // Compare the job time-in with the expected time-in to determine the status
                            string status = (timein.TimeOfDay <= expectedTimeIn) ? "Present/On-Time" : "Present/Late";

                            // Update the status in the empattendance table
                            string updateQuery = "UPDATE empattendance SET status = @status WHERE timein = @timein";
                            MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);

                            updateCommand.Parameters.AddWithValue("@status", status);
                            updateCommand.Parameters.AddWithValue("@timein", timein);
                            updateCommand.ExecuteNonQuery();

                            TimeSpan overtimeHours = totalHours - jobHours;

                            if (overtimeHours < TimeSpan.Zero)
                            {
                                overtimeHours = TimeSpan.Zero;
                            }

                            // Check if there is a value in the timeout column
                            if (row.Cells["timeout"].Value != null)
                            {
                                // Update the overtimehours column in the empattendance table
                                string updateOvertimeQuery = "UPDATE empattendance SET overtimehours = @overtimehours WHERE occupation = @occupation";
                                MySqlCommand updateOvertimeCommand = new MySqlCommand(updateOvertimeQuery, connection);
                                updateOvertimeCommand.Parameters.AddWithValue("@overtimehours", overtimeHours.ToString(@"hh\:mm\:ss"));
                                updateOvertimeCommand.Parameters.AddWithValue("@occupation", occupation);
                                updateOvertimeCommand.ExecuteNonQuery();
                            }


                        }

                    }

                    dataGridViewAttendance.Columns["empnum"].HeaderText = "Employee Number";
                    dataGridViewAttendance.Columns["name"].HeaderText = "Name";
                    dataGridViewAttendance.Columns["department"].HeaderText = "Department";
                    dataGridViewAttendance.Columns["occupation"].HeaderText = "Occupation";
                    dataGridViewAttendance.Columns["jobstatus"].HeaderText = "Job Status";
                    dataGridViewAttendance.Columns["date"].HeaderText = "Date";
                    dataGridViewAttendance.Columns["timein"].HeaderText = "Time-In";
                    dataGridViewAttendance.Columns["timeout"].HeaderText = "Time-Out";
                    dataGridViewAttendance.Columns["totalhours"].HeaderText = "Total Hours";
                    dataGridViewAttendance.Columns["overtimehours"].HeaderText = "OT Hours";
                    dataGridViewAttendance.Columns["undertime"].HeaderText = "Undertime";
                    dataGridViewAttendance.Columns["late"].HeaderText = "Late";
                    dataGridViewAttendance.Columns["status"].HeaderText = "Status";



                    dataGridViewAttendance.Columns["id"].Visible = false;    // Hide a specific column
                    dataGridViewAttendance.Columns[1].Width = 40;
                    dataGridViewAttendance.Columns[2].Width = 125;
                    dataGridViewAttendance.Columns[3].Width = 80;
                    dataGridViewAttendance.Columns[10].Width = 80;
                    dataGridViewAttendance.Columns[11].Width = 80;
                    dataGridViewAttendance.Columns[12].Width = 80;
                    dataGridViewAttendance.Columns[13].Width = 80;
                    dataGridViewAttendance.Columns["jobhours"].Visible = false;    // Hide a specific column
                    dataGridViewAttendance.Columns["jobtimein"].Visible = false;    // Hide a specific column
                    dataGridViewAttendance.Columns["jobtimeout"].Visible = false;    // Hide a specific column
                    dataGridViewAttendance.Columns["absences"].Visible = false;    // Hide a specific column




                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    connection.Close();
                }
            }
        }



        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            System.Data.DataTable dt = dataGridViewAttendance.DataSource as System.Data.DataTable;

            {

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridViewAttendance.Columns[e.ColumnIndex].Name == "date" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridViewAttendance.Columns[e.ColumnIndex].Name == "timein" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("hh:mm:ss tt");
                    e.FormattingApplied = true;
                }

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridViewAttendance.Columns[e.ColumnIndex].Name == "timeout" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("hh:mm:ss tt");
                    e.FormattingApplied = true;
                }
                /*                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                                if (dataGridView1.Columns[e.ColumnIndex].Name == "totalhours" && e.Value != null && e.Value is DateTime)
                                {
                                    // Format the datetime value to the desired format
                                    DateTime dateValue = (DateTime)e.Value;
                                    e.Value = dateValue.ToString("hh:mm:ss");
                                    e.FormattingApplied = true;
                                }*/

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewAttendance.Columns[e.ColumnIndex].DataPropertyName == "status")
                    {
                        var timeInCellValue = dataGridViewAttendance.Rows[e.RowIndex].Cells["timein"].Value;
                        var jobTimeInCellValue = dataGridViewAttendance.Rows[e.RowIndex].Cells["jobtimein"].Value;

                        if (timeInCellValue != null && jobTimeInCellValue != null)
                        {
                            TimeSpan timeIn = ((DateTime)timeInCellValue).TimeOfDay;
                            TimeSpan jobTimeIn = ((DateTime)jobTimeInCellValue).TimeOfDay;
                            int result = TimeSpan.Compare(timeIn, jobTimeIn);

                            if (result <= 0)
                            {
                                e.CellStyle.BackColor = Color.Green;
                                e.CellStyle.ForeColor = Color.White;
                                e.Value = "Present/On-Time";
                            }
                            else
                            {
                                e.CellStyle.BackColor = Color.Yellow;
                                e.Value = "Present/Late";
                            }

                            e.FormattingApplied = true; // Prevent default style overwrite
                        }
                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            {
                // APPLY FILTER
                // Create an instance of the second form
                filterAttendanceButton filterForm = new filterAttendanceButton();

                // Show the second form as a dialog and wait for it to close
                DialogResult result = filterForm.ShowDialog();

                // Check if the user clicked the OK button
                if (result == DialogResult.OK)
                {
                    // Get the selected values from the comboboxes in the second form
                    string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                    string department = filterForm.comboBox2.SelectedItem?.ToString();
                    string filteryear = filterForm.comboBox4.SelectedItem?.ToString();
                    string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();



                    // Check if at least one combobox is selected
                    if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(department) && string.IsNullOrWhiteSpace(filteryear) && string.IsNullOrWhiteSpace(jobstatus))
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

                        string query = "SELECT * FROM empattendance WHERE 1 = 1";

                        if (!string.IsNullOrWhiteSpace(filteryear))
                        {
                            string selectedYear = DateTime.ParseExact(filteryear, "yyyy", CultureInfo.InvariantCulture).ToString("yyyy");

                            // Modify the SQL query to filter based on the month
                            query += $" AND YEAR(date) = {DateTime.ParseExact(selectedYear, "yyyy", CultureInfo.CurrentCulture).Year}";

                        }

                        /*                        string query2 = "SELECT * FROM empattendance WHERE 1 = 1";

                                                if (!string.IsNullOrWhiteSpace(filtermonth))
                                                {
                                                    string selectedMonth = DateTime.ParseExact(filtermonth, "MMMM", CultureInfo.InvariantCulture).ToString("MMMM");

                                                    // Modify the SQL query to filter based on the month
                                                    query2 += $" AND MONTH(date) = {DateTime.ParseExact(selectedMonth, "MMMM", CultureInfo.CurrentCulture).Month}";

                                                }*/

                        // Execute the query and bind the result to the DataGridView

                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        System.Data.DataTable dataTable = new System.Data.DataTable();
                        adapter.Fill(dataTable);
                        dataGridViewAttendance.DataSource = dataTable;

                        ((System.Data.DataTable)dataGridViewAttendance.DataSource).DefaultView.RowFilter = filter;

                    }

                }
            }
        }

        private DataView dataView;
        private System.Data.DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (System.Data.DataTable)dataGridViewAttendance.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(empnum, 'System.String') LIKE '%{searchText}%'";
            dataGridViewAttendance.DataSource = dataView;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Attendance-System-Output.xlsx"; // Default file name

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
                    for (int i = 1; i < dataGridViewAttendance.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewAttendance.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridViewAttendance.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewAttendance.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewAttendance.Rows[i].Cells[j].Value.ToString();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            if (dataGridViewAttendance.SelectedRows.Count > 0)
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

                            foreach (DataGridViewRow selectedRow in dataGridViewAttendance.SelectedRows)
                            {
                                // Get the value from the selected row that you want to use for deletion.
                                string selectedValue = selectedRow.Cells["id"].Value.ToString();

                                // Delete from UserAct table
                                string deleteQuery = "DELETE FROM empattendance WHERE id = @id;";
                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, checkConnection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@id", selectedValue);
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // If deletion is successful, remove the row from the DataGridView
                                        dataGridViewAttendance.Rows.Remove(selectedRow);
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
                        dataGridViewAttendance.DataSource = null;

                        // Delete all rows from the MySQL database
                        checkConnection.Open();

                        string deleteAllQuery = "DELETE FROM empattendance"; // Remove the WHERE clause

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

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in ComboBox2
            filterApplyCMB.Items.Clear();

            // Get the selected sort option from ComboBox1
            string selectedSort = filterComboBox.SelectedItem?.ToString();

            // Populate ComboBox2 based on the selected sort option
            switch (selectedSort)
            {
                case "Department":
                    filterApplyCMB.Items.Add("ASP");
                    filterApplyCMB.Items.Add("IBED");
                    filterApplyCMB.Items.Add("SED");
                    break;
                case "Occupation":
                    filterApplyCMB.Items.Add("Chairperson");
                    filterApplyCMB.Items.Add("Guard");
                    filterApplyCMB.Items.Add("Guidance Counselor");
                    filterApplyCMB.Items.Add("Maintenance Technician");
                    filterApplyCMB.Items.Add("Registrar");
                    filterApplyCMB.Items.Add("School Nurse");
                    filterApplyCMB.Items.Add("Sports Coach");
                    filterApplyCMB.Items.Add("Teacher");
                    break;
                case "Job Status":
                    filterApplyCMB.Items.Add("FULL-TIME");
                    filterApplyCMB.Items.Add("PART-TIME");
                    break;
                case "Status":
                    filterApplyCMB.Items.Add("Present/On-Time");
                    filterApplyCMB.Items.Add("Late");
                    break;
                default:
                    break;
            }

            // Apply the filter
            ApplyFilter();
        }

        private void ApplyFilter()
        {

            // exception handling
            try
            {
                string selectedFilter = filterComboBox.SelectedItem?.ToString();
                string selectedApply = filterApplyCMB.SelectedItem?.ToString();

                // Check if both sort and filter values are selected
                if (!string.IsNullOrEmpty(selectedFilter) && !string.IsNullOrEmpty(selectedApply))
                {
                    // Apply the filter to the DataGridView
                    if (dataGridViewAttendance.DataSource is System.Data.DataTable dataTable)
                    {
                        dataTable.DefaultView.RowFilter = $"{selectedFilter} = '{selectedApply}'";
                    }
                }
                // If only the sort value is selected
                else if (!string.IsNullOrEmpty(selectedFilter))
                {
                    // Remove the filter
                    if (dataGridViewAttendance.DataSource is System.Data.DataTable dataTable)
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
                // If neither sort nor filter is selected, show all rows
                else
                {
                    if (dataGridViewAttendance.DataSource is System.Data.DataTable dataTable)
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., display an error message, log the exception)
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            SearchData(searchText);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            dataSet.Tables["empattendance"].Clear();
            adapter.Fill(dataSet, "empattendance");
        }
    }
}
