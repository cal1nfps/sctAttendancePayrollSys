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
            sortrequests sortForm = new sortrequests();

            sortForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            // DELETE EMPLOYEE INFORMATION
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                connection.Open();

                // Get selected cell value from DataGridView
                string selectedCellValue = dataGridViewLeave.SelectedCells[0].Value.ToString();

                // Delete selected cell value from MySQL database
                string query = "DELETE FROM emp_onleave WHERE name = @name";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", selectedCellValue);
                command.ExecuteNonQuery();

                // Display message box to confirm deletion
                MessageBox.Show("Employee deleted successfully.");

                // Refresh DataGridView to show updated data
                dataGridView1.Update();
                dataGridView1.Refresh();
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
    }
}
