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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using SCTAttendanceSystemUI.Forms.PayRoll;

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

            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];

            string empnum = selectedRow.Cells["empnum"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string firstname = selectedRow.Cells["firstname"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string middlename = selectedRow.Cells["middlename"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string lastname = selectedRow.Cells["lastname"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string suffix = selectedRow.Cells["suffix"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string dep = selectedRow.Cells["department"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string occupation = selectedRow.Cells["occupation"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string jobstatus = selectedRow.Cells["jobstatus"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string start = selectedRow.Cells["start"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string end = selectedRow.Cells["end"].Value.ToString(); // Replace "ColumnName" with the actual column name
            string leavestatus = selectedRow.Cells["leavestatus"].Value.ToString(); // Replace "ColumnName" with the actual column name






            AddLeaveButtonForm form2 = new AddLeaveButtonForm(empnum, firstname, middlename, lastname, suffix, dep, occupation, jobstatus, start, end, leavestatus);
            form2.Show();
        }

        private void dataGridViewLeave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelLeaveForToday_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelDep_Click(object sender, EventArgs e)
        {

        }

        private void FormLeave_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void FormLeave_Load_1(object sender, EventArgs e)
        {
            string query = "SELECT * FROM emp_leaverequests";
            MySqlCommand command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);

            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);

            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;


            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Width = 40;
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
    }
}
