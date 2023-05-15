using ExcelDataReader;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormHome : Form
    {

        public FormHome()
        {
            InitializeComponent();
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "To proceed to Home", MessageBoxButtons.OK);
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

        private void FormHome_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void panelFormHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelDashboardDate_Click_1(object sender, EventArgs e)
        {

        }

        private void FormHome_Load_1(object sender, EventArgs e)
        {
            labelDashboardDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
