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
using SCTAttendanceSystemUI.Employee.filterAbsent;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormAbsentsRecords : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormAbsentsRecords()
        {
            InitializeComponent();

            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            SetDataGridViewStyle(dataGridViewAbsentsRecords, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed
            // Set the initial visibility of controls
            dateTimePickerFilter.Visible = false;
            cancelButton.Visible = false;
            applyButton.Visible = false;


            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
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

        private void dateFilterButton_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the DateTimePicker and Button
            dateTimePickerFilter.Visible = !dateTimePickerFilter.Visible;
            cancelButton.Visible = !cancelButton.Visible;
            applyButton.Visible = !applyButton.Visible;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected date from the DateTimePicker
                DateTime selectedDate = dateTimePickerFilter.Value;

                // Format the selected date to match the DataTable date format
                string formattedDate = selectedDate.ToString("dd/MM/yyyy");

                // Filter the DataTable based on the selected date
                DataView filteredView = new DataView(table);
                filteredView.RowFilter = $"CONVERT(date, 'System.String') LIKE '{formattedDate}%'";

                // Bind the filtered DataView to the DataGridView
                dataGridViewAbsentsRecords.DataSource = filteredView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while applying the filter: " + ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            if (dataGridViewAbsentsRecords.SelectedRows.Count > 0)
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

                            foreach (DataGridViewRow selectedRow in dataGridViewAbsentsRecords.SelectedRows)
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
                                        dataGridViewAbsentsRecords.Rows.Remove(selectedRow);
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
                    for (int i = 1; i < dataGridViewAbsentsRecords.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewAbsentsRecords.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridViewAbsentsRecords.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewAbsentsRecords.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewAbsentsRecords.Rows[i].Cells[j].Value.ToString();
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
                        dataGridViewAbsentsRecords.DataSource = null;

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

        private DataView dataView;
        private DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (DataTable)dataGridViewAbsentsRecords.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(empnum, 'System.String') LIKE '%{searchText}%'";
            dataGridViewAbsentsRecords.DataSource = dataView;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            SearchData(searchText);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Hide the dateFilterButton
            dateTimePickerFilter.Visible = false;
            applyButton.Visible = false;
            cancelButton.Visible = false;
        }

        private void FormAbsentsRecords_Load(object sender, EventArgs e)
        {
            LoadAbsentEmployees();

            dataGridViewAbsentsRecords.Columns["empnum"].HeaderText = "Employee Number";
            dataGridViewAbsentsRecords.Columns["name"].HeaderText = "Name";
            dataGridViewAbsentsRecords.Columns["department"].HeaderText = "Department";
            dataGridViewAbsentsRecords.Columns["occupation"].HeaderText = "Occupation";
            dataGridViewAbsentsRecords.Columns["jobstatus"].HeaderText = "Job Status";
            dataGridViewAbsentsRecords.Columns["jobhours"].HeaderText = "Job Hours";
            dataGridViewAbsentsRecords.Columns["jobtimein"].HeaderText = "Job Time-In";
            dataGridViewAbsentsRecords.Columns["jobtimeout"].HeaderText = "Job Time-Out";
            dataGridViewAbsentsRecords.Columns["date"].HeaderText = "Date";


            dataGridViewAbsentsRecords.Columns["id"].Visible = false;    //Hide a specific column

        }

        private void LoadAbsentEmployees()
        {
            try
            {
                // Open the connection
                connection.Open();

                adapter = new MySqlDataAdapter("SELECT * FROM emp_absents", connection);


                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);


                // Set the DataSource of the DataGridView to the DataTable
                dataGridViewAbsentsRecords.DataSource = table;

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

        private void dataGridViewAbsentsRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewAbsentsRecords.Columns[e.ColumnIndex].Name == "Job Time-In" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("hh:mm:ss tt");
                e.FormattingApplied = true;
            }

            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewAbsentsRecords.Columns[e.ColumnIndex].Name == "Job Time-Out" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("hh:mm:ss tt");
                e.FormattingApplied = true;
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
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
                        dataGridViewAbsentsRecords.DataSource = dataTable;

                        (dataGridViewAbsentsRecords.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }
    }
}
