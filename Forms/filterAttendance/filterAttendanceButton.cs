using Microsoft.Office.Interop.Excel;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SCTAttendanceSystemUI.Forms.filterAttendance
{
    public partial class filterAttendanceButton : Form
    {
        private MySqlConnection connection;
        public filterAttendanceButton()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);

            occupationCMB.KeyPress += ComboBox_KeyPress;
            depCMB.KeyPress += ComboBox_KeyPress;
            jobStatusCMB.KeyPress += ComboBox_KeyPress;
            yearCMB.KeyPress += ComboBox_KeyPress;

        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block any keypress event to prevent user input in the comboboxes
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FILTER BUTTON
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            string query = "SELECT * FROM empattendance WHERE 1 = 1";

            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormHome"].Controls["dataGridViewAttendance"] as DataGridView;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
