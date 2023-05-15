using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormIBED : Form
    {

        public FormIBED()
        {
            InitializeComponent();
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "To proceed to IBED Department", MessageBoxButtons.OK);
        }

        private void FormIBED_Load(object sender, EventArgs e)
        {

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
        }

        private void cboSheet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected excel sheet
            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable
            dt.Columns.Add(new DataColumn("TimeIn-Status", typeof(string)));
            dt.Columns.Add(new DataColumn("TimeOut-Status", typeof(string)));

            //.RowFilter = "Department = 'IBED'"; //FILTER DEPARTMENT
            dataGridView2.DataSource = dt;   //Gets or sets data that the DataGridView displays

        }
        DataTableCollection tableCollection;    //Collection of tables for the DataSet

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*    DataGridViewColumn column2 = dataGridView2.Columns[3];   //Sets Width size of a column
                column2.Width = 200;*/

            //DataTable dt = new DataTable();   //Selected excel sheet
            //DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable
            DataTable dt = dataGridView2.DataSource as DataTable;

            dataGridView2.Columns["No."].Visible = false;    //Hide a specific column
            dataGridView2.Columns["On Duty"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Off Duty"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Before OT"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["After OT"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["NDays_OT"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Work Time"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Holiday_OT"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Total OT"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["Memo"].Visible = false;    //Hide a specific column
            dataGridView2.Columns["WeekEnd_OT"].Visible = false;    //Hide a specific column

            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            var buffer = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["Clock In"].Value);
            //string onTime = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["Time-In"].Value);
            string onTime = buffer.ToString("hh:mm:ss tt");
            TimeSpan timeSpan = DateTime.Parse(onTime).TimeOfDay;
            TimeSpan arrival = DateTime.Parse("08:00:00 AM").TimeOfDay;
            int result = TimeSpan.Compare(timeSpan, arrival);

            if (this.dataGridView2.Columns[e.ColumnIndex].DataPropertyName == "TimeIn-Status")
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



            var buffer2 = Convert.ToDateTime(dataGridView2.Rows[e.RowIndex].Cells["Clock Out"].Value);
            string outTime = buffer2.ToString("hh:mm:ss tt");
            TimeSpan timeSpan2 = DateTime.Parse(outTime).TimeOfDay;
            TimeSpan arrival2 = DateTime.Parse("05:00:00 PM").TimeOfDay;
            int result2 = TimeSpan.Compare(timeSpan2, arrival2);


            if (this.dataGridView2.Columns[e.ColumnIndex].DataPropertyName == "TimeOut-Status")
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

        }




        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sortComboBox.SelectedItem.ToString();     //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "A - Z")
            {
                this.dataGridView2.Sort(this.dataGridView2.Columns["Name"], ListSortDirection.Ascending);   //Sorts the selected column 'Name' to Ascending
                dataGridView2.DataSource = dv.ToTable(); //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }

            if (selectedItem == "Z - A")
            {
                this.dataGridView2.Sort(this.dataGridView2.Columns["Name"], ListSortDirection.Descending);  //Sorts the selected column 'Name' to Descending
                dataGridView2.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView2.DataSource = dt;

            }

        }

        private void sortENcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sortENcomboBox.SelectedItem.ToString();   //Selected combobox item
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet


            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
            if (selectedItem == "Lowest")
            {
                this.dataGridView2.Sort(this.dataGridView2.Columns["AC-No."], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
                dataGridView2.DataSource = dv.ToTable();    //Creates and returns a new DataTable base on rows in DataView
            }
            else
            {
                dataGridView2.DataSource = dt;  //Gets or sets data that the DataGridView displays
            }

            if (selectedItem == "Highest")
            {
                this.dataGridView2.Sort(this.dataGridView2.Columns["AC-No."], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
                dataGridView2.DataSource = dv.ToTable();
            }
            else
            {
                dataGridView2.DataSource = dt;

            }
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
            /* export all column header
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }*/

            // export only the column header visible
            for (int i = 1; i < 7; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }

            // export only the visible columns
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
            }*/
            DateTime localDate = DateTime.Now;
            // save the excel file
            workbook.SaveAs("C:\\Users\\" + serverName + "\\Downloads\\IBED-Output.xlsx " + "-" + localDate + ".xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }
    }
}
