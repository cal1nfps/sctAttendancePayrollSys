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
using SCTAttendanceSystemUI.Forms.sortdgvFormHome;

using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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

        private void buttonOvertimeAdd_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            payroll.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormPayroll_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM emp_payroll", connection);


            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);


            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 215;
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[2].Width = 215;
            dataGridView1.Columns[3].Width = 190;
            dataGridView1.Columns[4].Width = 215;

            dataGridView1.Columns["id"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["department"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["occupation"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["dob"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["hiredate"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["accountnum"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["jobsalary"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["date"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["payrolltype"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["hourlyrate"].Visible = false;    //Hide a specific column


            //reader.Close();
            connection.Close();
        }

        public string[] GetSelectedRowData()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Retrieve the desired cell values from the selected row
                string dep = selectedRow.Cells["department"].Value.ToString();
                string occupation = selectedRow.Cells["occupation"].Value.ToString();
                // Add more lines for each column you want to retrieve

                // Return the data as an array or any suitable format
                return new string[] { dep, occupation };
            }

            return null; // Return null if no row is selected
        }


        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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





            PayrollCheques form2 = new PayrollCheques(dep, occupation, salary, accountnum, hiredate, dob, hourlyrate, date, deduction, gross, net, name);
            form2.Show();


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            sort sortDgvForm = new sort();

            sortDgvForm.Show();
        }
    }
}
