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

namespace SCTAttendanceSystemUI.Employee.filterLeaveReq
{
    public partial class filterleaverequests : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        public filterleaverequests()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            DataGridView dataGridView2 = System.Windows.Forms.Application.OpenForms["FormLeave"].Controls["dataGridView1"] as DataGridView;
            if (dataGridView2 != null)
            {
                (dataGridView2.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }
    }
}
