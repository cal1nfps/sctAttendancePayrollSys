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
using SCTAttendanceSystemUI.Employee.sortAbsent;

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
        }

        /*private void FormAbsentees_Load(object sender, EventArgs e)
        {
            labelAbsenteesDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })  //Filter for excel file
            {
                //RETRIEVING EXCEL FILE  AND ITS DATA
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    txtFilename.Text = openFileDialog.FileName; // 'txtFilename.Text' is the selected excel file
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) //Opens and Read access to the excel file
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()   //Converts selected sheet into DataSet
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }   //Gets or sets data of selected of excel file
                            });
                            tableCollection = result.Tables;    //Gets the collection of tables
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);    //Adds the sheet to combobox

                        }
                    }
                }
            }
        }*/

        /*private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected excel sheet
            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            dv.RowFilter = "Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'" + "AND Status = 'Absent'";
            dataGridView2.DataSource = dt;   //Gets or sets data that the DataGridView displays
        }
        DataTableCollection tableCollection;    //Collection of tables for the DataSet

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            DataGridViewColumn column2 = dataGridView2.Columns[1];   //Sets Width size of a column
            column2.Width = 200;

            dataGridView2.Columns[4].DefaultCellStyle.Format = "HH:mm:ss tt";   //Setting the format of Time column on excel
            dataGridView2.Columns[8].DefaultCellStyle.Format = "HH:mm:ss tt";   //Setting the format of Time column on excel
            dataGridView2.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";    //Setting the format of Date column on excel
            dataGridView2.Columns["ID Number"].Visible = false;     //Hide a specific column
            dataGridView2.Columns["VerifyCode"].Visible = false;    //Hide a specific column    
            dataGridView2.Columns["CardNo"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Location ID"].Visible = false;   //Hide a specific column
            dataGridView2.Columns["LateTime"].Visible = false;  //Hide a specific column
            dataGridView2.Columns["AbsentTime"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Time-Out"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Time-Out-Status"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Overtime"].Visible = false;    //Hide a specific column



            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            //SETS AND CHANGE ROWS BACKGROUND COLOR OR FOREGROUND COLOR
            if (this.dataGridView2.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                //GREEN IS PRESENT
                //YELLOW IS LATE
                //RED IS ABSENT

                var onTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["Time-In"].Value);    //Arrival Time of staff
                var lateTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["LateTime"].Value);  //Late time is set to 8:08 AM
                var absentTime = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["AbsentTime"].Value);  //Late time is set to 12:00 AM in excel but when the program is executed in
                                                                                                                //DataGridView it'll be set to 00:00 AM which means the staff is absent

                if (onTime <= lateTime)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (onTime > lateTime)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (onTime == absentTime)
                {
                    e.CellStyle.BackColor = Color.Red;

                }
            }
        }*/

        /*private void buttonExport_Click(object sender, EventArgs e)
        {
            // get the name of the user in local disk c and store it in a variable
            // this is to save the excel file in the local disk c Downloads folder
            string serverName = Environment.UserName;

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program  
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet  
            worksheet.Name = "Sheet 1 Exported";

            // storing header part in Excel
            /* export all column header
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // export only the column header visible
            for (int i = 1; i < 7; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }

            List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn col in dataGridView2.Columns)
            {
                if (col.Visible)
                    listVisible.Add(col);
            }

            for (int i = 0; i < listVisible.Count; i++)
            {
                worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int j = 0; j < listVisible.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                }
            }

            /* storing Each row and column value to excel sheet and printing all columns
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            DateTime localDate = DateTime.Now;
            // save the excel file
            workbook.SaveAs("C:\\Users\\" + serverName + "\\Downloads\\Absentees-Output.xlsx " + " - " + localDate + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }*/

        /*private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sortComboBox.SelectedItem.ToString();     //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "All")
            {
                dv.RowFilter = "Status = 'Absent'";
                dataGridView2.DataSource = dv.ToTable(); //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }


        }*/

        /*private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet

            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            dv.RowFilter = "Date = '" + DateTime.Now.ToString("MM/dd/yyyy") + "'" + "AND Status = 'Absent'"; //Filters and displays all the data between the selected date on 'Date' column
            dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
        }*/

        private void labelAbsenteesDate_Click(object sender, EventArgs e)
        {

        }

        private void FormAbsentees_Load_1(object sender, EventArgs e)
        {
            labelAbsenteesDate.Text = DateTime.Now.ToLongDateString();
            LoadAbsentEmployees();

        }

/*        private void button1_Click(object sender, EventArgs e)
        {
            sortabsent sortDgvForm = new sortabsent();

            sortDgvForm.Show();

        }*/

        // Method to load absent employees and display them in the DataGridView
        private void LoadAbsentEmployees()
        {
            try
            {
                // Open the connection
                connection.Open();

                // Retrieve employees who are not present in empattendance today
                string selectQuery = "SELECT employeenum, name, department, occupation, jobstatus FROM employee WHERE employeenum NOT IN (SELECT empnum FROM empattendance WHERE DATE(date) = @today)";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@today", DateTime.Today);
                adapter = new MySqlDataAdapter(selectCommand);

                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);

                // Set the DataSource of the DataGridView to the DataTable
                dataGridView2.DataSource = table;

                // Insert the absent employees into emp_absent table
                foreach (DataRow row in table.Rows)
                {
                    string empnum = row["employeenum"].ToString();
                    string name = row["name"].ToString();
                    string dep = row["department"].ToString();
                    string occupation = row["occupation"].ToString();
                    string jobstatus = row["jobstatus"].ToString();
                    DateTime currentDate = DateTime.Now;


                    string insertQuery = "INSERT INTO emp_absents (empnum, name, department, occupation, jobstatus, date) VALUES (@empnum, @name, @department, @occupation, @jobstatus, @date)";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection);
                    insertCommand.Parameters.AddWithValue("@empnum", empnum);
                    insertCommand.Parameters.AddWithValue("@name", name);
                    insertCommand.Parameters.AddWithValue("@department", dep);
                    insertCommand.Parameters.AddWithValue("@occupation", occupation);
                    insertCommand.Parameters.AddWithValue("@jobstatus", jobstatus);
                    insertCommand.Parameters.AddWithValue("@date", currentDate);



                    insertCommand.ExecuteNonQuery();
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

        private DataView dataView;
        private DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (DataTable)dataGridView2.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(employeenum, 'System.String') LIKE '%{searchText}%'";
            dataGridView2.DataSource = dataView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            SearchData(searchText);
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
                        dataGridView2.DataSource = dataTable;

                        (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = filter;

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
                    for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
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
