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
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
            //MessageBox.Show("Please enter your chosen excel file and choose a sheet. Thank you!", "To proceed to Search", MessageBoxButtons.OK);
        }

        private void FormSearch_Load(object sender, EventArgs e)
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
            dt.Columns.Add(new DataColumn("TimeIn-Status", typeof(string)));
            dt.Columns.Add(new DataColumn("TimeOut-Status", typeof(string)));

            dataGridView1.DataSource = dt;   //Gets or sets data that the DataGridView displays
        }
        DataTableCollection tableCollection;    //Collection of tables for the DataSet

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet
            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            TimeSpan hrsSpent = new TimeSpan();
            int rowindex = dataGridView1.CurrentCell.RowIndex;

            string start = dataGridView1.Rows[rowindex].Cells["Clock In"].Value.ToString();
            string end = dataGridView1.Rows[rowindex].Cells["Clock Out"].Value.ToString();

            if (DateTime.Parse(end).CompareTo(DateTime.Parse(start)) < 0)
            {
                hrsSpent += TimeSpan.FromDays(1);
            }

            hrsSpent += DateTime.Parse(end).Subtract(DateTime.Parse(start));

            workedHRSbox.Text = hrsSpent.ToString();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewColumn column2 = dataGridView1.Columns[3];   //Sets Width size of a column
            column2.Width = 200;

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
        }



        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];   //Selected sheet
            DataView dv = dt.DefaultView;   //Setting the selected excel file or sheet into DataTable

            //Searches for the typed keywords
            if (e.KeyChar == (char)13)
            {
                //dv.RowFilter = string.Format("Name like '%{0}%' OR Convert(AC-No. 'System.String')like '" + searchBox.Text + "%'", searchBox.Text);  //Search for Name and Employee Number
                dv.RowFilter = string.Format("Name like '%{0}%'", searchBox.Text);  //Search for Name  //Search for Name and Employee Number
            }
            dataGridView1.DataSource = dv.ToTable();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            TimeSpan duration2 = new TimeSpan();
            int rowindex2 = dataGridView1.CurrentCell.RowIndex;

            string start2 = dataGridView1.Rows[rowindex2].Cells["Clock In"].Value.ToString();
            string end2 = dataGridView1.Rows[rowindex2].Cells["Clock Out"].Value.ToString();

            for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
            {
                if (DateTime.Parse(end2).CompareTo(DateTime.Parse(start2)) < 0)
                {
                    duration2 += TimeSpan.FromDays(1);
                }
                duration2 += DateTime.Parse(end2).Subtract(DateTime.Parse(start2));
            }
            totalHRSbox.Text = duration2.ToString();
        }
    }
}
