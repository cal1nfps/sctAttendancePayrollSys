using System;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.filterAttendance;
using SCTAttendanceSystemUI.Forms.sortdgvFormHome;




namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormHome : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormHome()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "To proceed to Home", MessageBoxButtons.OK);
        }

        public void BindDataGridView(DataTable dataTable)
        {
            dataGridView1.DataSource = dataTable;
        }


        private void FormHome_Load(object sender, EventArgs e)
        {
            labelDashboardDate.Text = DateTime.Now.ToLongDateString();
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "Confirmation", MessageBoxButtons.OK);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelDashboardDate_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*DataGridViewColumn column2 = dataGridView1.Columns[1];   //Sets Width size of a column
            column2.Width = 200;*/

            /*            dataGridView1.Columns[4].DefaultCellStyle.Format = "HH:mm:ss tt";   //Setting the format of Time column on excel
                        dataGridView1.Columns[8].DefaultCellStyle.Format = @"hh\:mm\:ss tt";   //Setting the format of Time column on excel
                        dataGridView1.Columns[3].DefaultCellStyle.Format = "MM/dd/yyyy";    //Setting the format of Date column on excel
                        dataGridView1.Columns["ID Number"].Visible = false;     //Hide a specific column
                        dataGridView1.Columns["VerifyCode"].Visible = false;    //Hide a specific column    
                        dataGridView1.Columns["CardNo"].Visible = false;    //Hide a specific column
                        dataGridView1.Columns["Location ID"].Visible = false;   //Hide a specific column
                        dataGridView1.Columns["LateTime"].Visible = false;  //Hide a specific column
                        dataGridView1.Columns["AbsentTime"].Visible = false;    //Hide a specific column
                        dataGridView1.Columns["Overtime"].Visible = false;    //Hide a specific column*/

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //DataTable dt = new DataTable();   //Selected excel sheet
            //DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable
            DataTable dt = dataGridView1.DataSource as DataTable;

            dataGridView1.Columns["No."].Visible = false;    //Hide a specific column
            dataGridView1.Columns["On Duty"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Off Duty"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Before OT"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["After OT"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["NDays_OT"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Work Time"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Holiday_OT"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Total OT"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["Memo"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["WeekEnd_OT"].Visible = false;    //Hide a specific column

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            var buffer = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Clock In"].Value);
            //string onTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Time-In"].Value);
            string onTime = buffer.ToString("hh:mm:ss tt");
            TimeSpan timeSpan = DateTime.Parse(onTime).TimeOfDay;
            TimeSpan arrival = DateTime.Parse("08:00:00 AM").TimeOfDay;
            int result = TimeSpan.Compare(timeSpan, arrival);

            if (this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TimeIn-Status")
            {
                if (result <= 0)
                {
                    e.CellStyle.BackColor = Color.Green;
                    e.CellStyle.ForeColor = Color.White;
                }
                if (result > 0)
                {
                    e.CellStyle.BackColor = Color.Yellow;

                }
            }

            var buffer2 = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Clock Out"].Value);
            string outTime = buffer2.ToString("hh:mm:ss tt");
            TimeSpan timeSpan2 = DateTime.Parse(outTime).TimeOfDay;
            TimeSpan arrival2 = DateTime.Parse("05:00:00 PM").TimeOfDay;
            int result2 = TimeSpan.Compare(timeSpan2, arrival2);


            if (this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "TimeOut-Status")
            {
                if (result2 <= 0)
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                if (result2 > 0)
                {
                    e.CellStyle.BackColor = Color.Red;

                }
            }


            foreach (DataRow dr in dt.Rows)
            {
                if (result <= 0)
                {
                    dr["TimeIn-Status"] = "On-Time/Present";
                }
                if (result > 0)
                {
                    dr["TimeIn-Status"] = "Late/Present";
                }

                if (result2 <= 0)
                {
                    dr["TimeOut-Status"] = "Time-Out";

                }
                if (result2 > 0)
                {
                    dr["TimeOut-Status"] = "Time-Out/Overtime";

                }

            }



            //SETS AND CHANGE ROWS BACKGROUND COLOR OR FOREGROUND COLOR
            /* if (this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
             {
                 //GREEN IS PRESENT
                 //YELLOW IS LATE
                 //RED IS ABSENT

                 var onTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Time-In"].Value);    //Arrival Time of staff
                 var lateTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["LateTime"].Value);  //Late time is set to 8:08 AM
                 var absentTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["AbsentTime"].Value);  //Late time is set to 12:00 AM in excel but when the program is executed in
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
             }*/

            //SETS AND CHANGE ROWS BACKGROUND COLOR OR FOREGROUND COLOR
            /*  if (this.dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Time-Out-Status")
              {
                  //GREEN IS PRESENT
                  //YELLOW IS LATE
                  //RED IS ABSENT

                  var outTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Time-Out"].Value);    //Arrival Time of staff
                  var logoutTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Overtime"].Value);  //Late time is set to 12:00 AM in excel but when the program is executed in
                  var absentTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["AbsentTime"].Value);   //DataGridView it'll be set to 00:00 AM which means the staff is absent

                  if (outTime < logoutTime)
                  {
                      e.CellStyle.BackColor = Color.Orange;
                      e.CellStyle.ForeColor = Color.White;
                  }
                  if (outTime >= logoutTime)
                  {
                      e.CellStyle.BackColor = Color.Orange;
                  }
                  if (outTime == absentTime)
                  {
                      e.CellStyle.BackColor = Color.Red;
                      e.CellStyle.ForeColor = Color.White;

                  }

              }*/

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            /*using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx" })  //Filter for excel file
            {
                //RETRIEVING EXCEL FILE  AND ITS DATA
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    txtFilename.Text = openFileDialog.FileName; // 'txtFilename.Text' is the selected excel file
                    using (var stream = System.IO.File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read)) //Opens and Read access to the excel file
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
            }*/
        }

        private void cboSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected excel sheet
            dt.Columns.Add(new DataColumn("TimeIn-Status", typeof(string)));
            dt.Columns.Add(new DataColumn("TimeOut-Status", typeof(string)));

            dataGridView1.DataSource = dt;   //Gets or sets data that the DataGridView displays*/
        }
        DataTableCollection tableCollection;    //Collection of tables for the DataSet


        private void sortCombBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedItem = sortComboBox.SelectedItem.ToString();     //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "A - Z")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Ascending);   //Sorts the selected column 'Name' to Ascending
                dataGridView1.DataSource = dv.ToTable(); //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView1.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }

            if (selectedItem == "Z - A")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["Name"], ListSortDirection.Descending);  //Sorts the selected column 'Name' to Descending
                dataGridView1.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView1.DataSource = dt;

            }*/

        }

        private void sortENcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string selectedItem = sortENcomboBox.SelectedItem.ToString();   //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
            if (selectedItem == "Lowest")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["AC-No."], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
                dataGridView1.DataSource = dv.ToTable();    //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView1.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }

            if (selectedItem == "Highest")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["AC-No."], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
                dataGridView1.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView1.DataSource = dt;

            }*/


        }


        private void buttonDateTimePicker_Click(object sender, EventArgs e)
        {
            /*DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet

            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            DateTime Date1 = fromDateTimePicker.Value.Date; //From DateTimePicker
            DateTime Date2 = toDateTimePicker.Value.Date;   //To DateTimePicker

            dv.RowFilter = String.Format("Date >= '{0:MM/dd/yyyy}' AND Date <= '{1:MM/dd/yyyy}'", Date1, Date2);//Filters and displays all the data between the selected date on 'Date' column
            dataGridView1.DataSource = dt;  //Gets or sets data that the DataGridView displays */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet

            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            DateTime Date1 = fromDateTimePicker.Value.Date; //From DateTimePicker
            DateTime Date2 = toDateTimePicker.Value.Date;   //To DateTimePicker

            dv.RowFilter = String.Format(" ", Date1, Date2); //Filters and displays all the data between the selected date on 'Date' column
            dataGridView1.DataSource = dt;  //Gets or sets data that the DataGridView displays*/
        }

        private void buttonExport_Click(object sender, EventArgs e)
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
            // export all column header
            /*for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }*/

            // export only the column header visible
            for (int i = 1; i < 7; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            // export only the visible columns
            List<DataGridViewColumn> listVisible = new List<DataGridViewColumn>();

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible)
                    listVisible.Add(col);
            }

            for (int i = 0; i < listVisible.Count; i++)
            {
                worksheet.Cells[1, i + 1] = listVisible[i].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < listVisible.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[listVisible[j].Name].Value.ToString();
                }
            }

            /* storing Each row and column value to excel sheet and printing all columns
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }*/
            DateTime localDate = DateTime.Now;
            string date = localDate.ToString("dd/MM/yyyy");
            // save the excel file
            workbook.SaveAs("C:\\Users\\" + serverName + "\\Downloads\\Attendance-System-Output.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        // Define a public method to get the DataGridView
        public DataGridView GetDataGridView()
        {
            return dataGridView1; // Replace "dataGridView1" with the actual name of your DataGridView control
        }

        private void FormHome_Load_1(object sender, EventArgs e)
        {

            {
                labelDashboardDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

                string today = DateTime.Now.ToString("yyyy-MM-dd");
                string query = "SELECT * FROM empattendance WHERE DATE(date) = @today";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@today", today);
                adapter = new MySqlDataAdapter(command);

                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);

                // Set the DataSource of the DataGridView to the DataTable
                dataGridView1.DataSource = table;


                try
                {
                    connection.Open();

                    // Retrieve the occupation and job time-in from the database
                    string occupationQuery = "SELECT occupation, jobtimein FROM employee";
                    MySqlCommand occupationCommand = new MySqlCommand(occupationQuery, connection);
                    {
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {

                            string occupation = row.Cells["occupation"].Value.ToString();


                            DateTime timein = Convert.ToDateTime(row.Cells["timein"].Value);

                            DateTime jobtimein = Convert.ToDateTime(row.Cells["jobtimein"].Value);

                            string totalHoursString = row.Cells["totalhours"].Value.ToString();
                            TimeSpan totalHours = TimeSpan.Parse(totalHoursString);

                            string jobHoursString = row.Cells["jobhours"].Value.ToString();
                            TimeSpan jobHours = TimeSpan.Parse(jobHoursString);


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
                            // Update the overtimehours column in the employee table for the current occupation
                            string updateOvertimeQuery = "UPDATE empattendance SET overtimehours = @overtimehours WHERE occupation = @occupation";
                            MySqlCommand updateOvertimeCommand = new MySqlCommand(updateOvertimeQuery, connection);
                            updateOvertimeCommand.Parameters.AddWithValue("@overtimehours", overtimeHours.ToString(@"hh\:mm\:ss"));
                            updateOvertimeCommand.Parameters.AddWithValue("@occupation", occupation);
                            updateOvertimeCommand.ExecuteNonQuery();

                        }

                    }


                    dataGridView1.Columns["id"].Visible = false;    // Hide a specific column
                    dataGridView1.Columns[1].Width = 40;
                    dataGridView1.Columns[2].Width = 125;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[10].Width = 80;
                    dataGridView1.Columns[11].Width = 80;
                    dataGridView1.Columns[12].Width = 80;
                    dataGridView1.Columns[13].Width = 80;
                    dataGridView1.Columns["jobhours"].Visible = false;    // Hide a specific column
                    dataGridView1.Columns["jobtimein"].Visible = false;    // Hide a specific column
                    dataGridView1.Columns["jobtimeout"].Visible = false;    // Hide a specific column
                    dataGridView1.Columns["absences"].Visible = false;    // Hide a specific column


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

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridView1.Columns[e.ColumnIndex].Name == "timein" && e.Value != null && e.Value is DateTime)
                {
                    // Format the datetime value to the desired format
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("hh:mm:ss tt");
                    e.FormattingApplied = true;
                }

                // Check if the current cell belongs to the "DateColumn" and has a datetime value
                if (dataGridView1.Columns[e.ColumnIndex].Name == "timeout" && e.Value != null && e.Value is DateTime)
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
                    if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "status")
                    {
                        var timeInCellValue = dataGridView1.Rows[e.RowIndex].Cells["timein"].Value;
                        var jobTimeInCellValue = dataGridView1.Rows[e.RowIndex].Cells["jobtimein"].Value;

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
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;

                        (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;

                    }

                }
            }
        }

        private DataView dataView;
        private DataTable originalDataTable;

        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (DataTable)dataGridView1.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(empnum, 'System.String') LIKE '%{searchText}%'";
            dataGridView1.DataSource = dataView;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            sort sortDgvForm = new sort();

            sortDgvForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            SearchData(searchText);
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
