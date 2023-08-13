using SCTAttendanceSystemUI.Forms.AddLeaveButton;
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
using SCTAttendanceSystemUI.Employee.sortOnLeave;
using SCTAttendanceSystemUI.Employee.sortRequest;
using SCTAttendanceSystemUI.Employee.filterOnLeave;
using SCTAttendanceSystemUI.Employee.filterLeaveReq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SCTAttendanceSystemUI.Forms.PayRoll;
using SCTAttendanceSystemUI.Forms.filterAttendance;
using System.Globalization;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormLeave : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;
        public FormLeave()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

                string empnum = selectedRow.Cells["empnum"].Value.ToString();
                string firstname = selectedRow.Cells["firstname"].Value.ToString();
                string middlename = selectedRow.Cells["middlename"].Value.ToString();
                string lastname = selectedRow.Cells["lastname"].Value.ToString();
                string suffix = selectedRow.Cells["suffix"].Value.ToString();
                string dep = selectedRow.Cells["department"].Value.ToString();
                string occupation = selectedRow.Cells["occupation"].Value.ToString();
                string jobstatus = selectedRow.Cells["jobstatus"].Value.ToString();
                string start = selectedRow.Cells["start"].Value.ToString();
                string end = selectedRow.Cells["end"].Value.ToString();
                string leavestatus = selectedRow.Cells["leavestatus"].Value.ToString();

                AddLeaveButtonForm form2 = new AddLeaveButtonForm(empnum, firstname, middlename, lastname, suffix, dep, occupation, jobstatus, start, end, leavestatus);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please select a cell in the DataGridView first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortrequests sortForm = new sortrequests();

            sortForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                // APPLY FILTER
                // Create an instance of the second form
                filterleaverequests filterForm = new filterleaverequests();

                // Show the second form as a dialog and wait for it to close
                DialogResult result = filterForm.ShowDialog();

                // Check if the user clicked the OK button
                if (result == DialogResult.OK)
                {
                    // Get the selected values from the comboboxes in the second form
                    string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                    string department = filterForm.comboBox2.SelectedItem?.ToString();
                    string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();



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
                        dataGridView1.DataSource = dataTable;

                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sortonleave sortForm = new sortonleave();
            sortForm.Show();
        }

        private void FormLeave_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM emp_onleave";
            MySqlCommand command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);

            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);

            // Set the DataSource of the DataGridView to the DataTable
            dataGridViewLeave.DataSource = table;

            string query2 = "SELECT * FROM emp_leaverequests";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            adapter = new MySqlDataAdapter(command2);

            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);

            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;


            dataGridViewLeave.Columns[1].Width = 40;
            dataGridViewLeave.Columns[2].Width = 70;
            dataGridViewLeave.Columns[3].Width = 70;
            dataGridViewLeave.Columns[4].Width = 40;
            dataGridViewLeave.Columns[5].Width = 70;
            dataGridViewLeave.Columns["id"].Visible = false;    // Hide a specific column
            dataGridViewLeave.Columns["days"].Visible = false;    // Hide a specific column



            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[7].Width = 70;
            dataGridView1.Columns[8].Width = 60;
            dataGridView1.Columns[9].Width = 70;
            dataGridView1.Columns["id"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["firstname"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["middlename"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["lastname"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["suffix"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["start"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["end"].Visible = false;    // Hide a specific column
            dataGridView1.Columns["leavestatus"].Visible = false;    // Hide a specific column

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;

            {

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridView1.Columns[e.ColumnIndex].Name == "date" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }

                if (dataGridView1.Columns[e.ColumnIndex].Name == "start" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }
                if (dataGridView1.Columns[e.ColumnIndex].Name == "end" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // DELETE EMPLOYEE INFORMATION
                DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Check if any cell is selected
                    if (dataGridViewLeave.SelectedCells.Count == 0)
                    {
                        MessageBox.Show("Please select a cell to delete an employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method
                    }

                    connection.Open();

                    // Get selected cell value from DataGridView
                    string selectedCellValue = dataGridViewLeave.SelectedCells[0].Value.ToString();

                    // Delete selected cell value from MySQL database
                    string query = "DELETE FROM emp_onleave WHERE empnum = @empnum";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@empnum", selectedCellValue);
                    command.ExecuteNonQuery();

                    // Display message box to confirm deletion
                    MessageBox.Show("Employee deleted successfully.");

                    // Refresh DataGridView to show updated data
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }

        }

        private void dataGridViewLeave_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataTable dt = dataGridViewLeave.DataSource as DataTable;

            {

                if (dataGridViewLeave.Columns[e.ColumnIndex].Name == "start" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }
                if (dataGridViewLeave.Columns[e.ColumnIndex].Name == "end" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }

            }
        }
        private DataView dataView;
        private DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (DataTable)dataGridViewLeave.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%'";
            dataGridViewLeave.DataSource = dataView;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            SearchData(searchText);
        }

        private DataView dataView2;
        private DataTable originalDataTable2;

        private void SearchData2(string searchText)
        {
            if (dataView2 == null)
            {
                originalDataTable2 = (DataTable)dataGridView1.DataSource;
                dataView2 = new DataView(originalDataTable2);
            }

            dataView2.RowFilter = $"name LIKE '%{searchText}%'";
            dataGridView1.DataSource = dataView2;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox2.Text;
            SearchData2(searchText);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                // APPLY FILTER
                // Create an instance of the second form
                filteronleave filterForm = new filteronleave();

                // Show the second form as a dialog and wait for it to close
                DialogResult result = filterForm.ShowDialog();

                // Check if the user clicked the OK button
                if (result == DialogResult.OK)
                {
                    // Get the selected values from the comboboxes in the second form
                    string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                    string department = filterForm.comboBox2.SelectedItem?.ToString();
                    string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();



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
                        dataGridViewLeave.DataSource = dataTable;

                        (dataGridViewLeave.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Employee-OnLeave-Output.xlsx"; // Default file name

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
                    for (int i = 1; i < dataGridViewLeave.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridViewLeave.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewLeave.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewLeave.Rows[i].Cells[j].Value.ToString();
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

        private void button8_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Leave-Requests-Output.xlsx"; // Default file name

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
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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
    }
}
