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

namespace SCTAttendanceSystemUI.Employee.filterOnLeave
{
    public partial class filteronleave : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        public filteronleave()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            string query = "SELECT * FROM emp_onleave WHERE 1 = 1";

            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormLeave"].Controls["dataGridViewLeave"] as DataGridView;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            System.Data.DataTable dataTable = new System.Data.DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            if (dataGridView1 != null)
            {


                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
                dataTable.DefaultView.RowFilter = string.Empty;


            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
