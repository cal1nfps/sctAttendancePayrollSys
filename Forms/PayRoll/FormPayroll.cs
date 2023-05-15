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


            //reader.Close();
            connection.Close();
        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
