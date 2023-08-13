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
using SCTAttendanceSystemUI.Forms.PayRoll;
using SCTAttendanceSystemUI.Employee.filterPayroll;
using SCTAttendanceSystemUI.Forms.sortdgvFormHome;
using SCTAttendanceSystemUI.Forms.sortPayroll;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Globalization;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormPayroll : Form
    {

        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;
        public FormPayroll()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void FormPayroll_Load_1(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM emp_payroll", connection);


            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);


            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 215;
            dataGridView1.Columns[1].Width = 165;
            dataGridView1.Columns[2].Width = 135;
            dataGridView1.Columns[3].Width = 140;
            dataGridView1.Columns[4].Width = 140;
            dataGridView1.Columns[7].Width = 110;
            dataGridView1.Columns[8].Width = 120;
            dataGridView1.Columns[12].Width = 130;
            dataGridView1.Columns[14].Width = 118;




            dataGridView1.Columns["id"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["dob"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["hiredate"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["accountnum"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["jobsalary"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["hourlyrate"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["overtimehours"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["undertime"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["late"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["absences"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["totalhours"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["salary"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["allowance"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["totalsalary"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["contributions"].Visible = false;    //Hide a specific column






            //reader.Close();
            connection.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            string dep = selectedRow.Cells["department"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string occupation = selectedRow.Cells["occupation"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string salary = selectedRow.Cells["jobsalary"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string accountnum = selectedRow.Cells["accountnum"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string hiredate = selectedRow.Cells["hiredate"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string dob = selectedRow.Cells["dob"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string hourlyrate = selectedRow.Cells["hourlyrate"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string date = selectedRow.Cells["date"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string deduction = selectedRow.Cells["deduction"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string gross = selectedRow.Cells["gross"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string net = selectedRow.Cells["net"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string name = selectedRow.Cells["name"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string payrolltype = selectedRow.Cells["payrolltype"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string overtimehours = selectedRow.Cells["overtimehours"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string undertime = selectedRow.Cells["undertime"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string late = selectedRow.Cells["late"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string totalhours = selectedRow.Cells["totalhours"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string allowance = selectedRow.Cells["allowance"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string totalsalary = selectedRow.Cells["totalsalary"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string contributions = selectedRow.Cells["contributions"].Value.ToString(); // Replace "ColumnName" with the actual column name



            PayrollCheques form2 = new PayrollCheques(dep, occupation, salary, accountnum, hiredate, dob, hourlyrate, date, deduction, gross, net, name,
                payrolltype, overtimehours, undertime, late, totalhours, allowance, totalsalary, contributions);
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sortdgvPayroll sortDgvForm = new sortdgvPayroll();

            sortDgvForm.Show();
        }

        private void buttonOvertimeAdd_Click_1(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            {
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }


                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridView1.Columns[e.ColumnIndex].Name == "date" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("MMMM dd, yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Payroll-Lists-Output.xlsx"; // Default file name

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

        private void button5_Click(object sender, EventArgs e)
        {
            {
                // APPLY FILTER
                // Create an instance of the second form
                filterpayroll filterForm = new filterpayroll();

                // Show the second form as a dialog and wait for it to close
                DialogResult result = filterForm.ShowDialog();

                // Check if the user clicked the OK button
                if (result == DialogResult.OK)
                {
                    // Get the selected values from the comboboxes in the second form
                    string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                    string department = filterForm.comboBox2.SelectedItem?.ToString();
                    string payrolltype = filterForm.comboBox3.SelectedItem?.ToString();
                    string filteryear = filterForm.comboBox4.SelectedItem?.ToString();



                    // Check if at least one combobox is selected
                    if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(department) && string.IsNullOrWhiteSpace(filteryear) && string.IsNullOrWhiteSpace(payrolltype))
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

                        if (!string.IsNullOrWhiteSpace(payrolltype))
                        {
                            if (!string.IsNullOrWhiteSpace(filter))
                            {
                                filter += " AND ";

                            }
                            filter += $"[payrolltype] = '{payrolltype}'";
                        }

                        string query = "SELECT * FROM emp_payroll WHERE 1 = 1";

                        if (!string.IsNullOrWhiteSpace(filteryear))
                        {
                            string selectedYear = DateTime.ParseExact(filteryear, "yyyy", CultureInfo.InvariantCulture).ToString("yyyy");

                            // Modify the SQL query to filter based on the month
                            query += $" AND YEAR(date) = {DateTime.ParseExact(selectedYear, "yyyy", CultureInfo.CurrentCulture).Year}";

                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }
    }
}
