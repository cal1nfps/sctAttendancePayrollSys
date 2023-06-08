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
using SCTAttendanceSystemUI.Employee;

namespace SCTAttendanceSystemUI.Resources
{
    public partial class RequestLeaveAuth : Form
    {
        private MySqlConnection connection;
        private string name;
        public RequestLeaveAuth(string name)
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            this.name = name;
        }

        private void RequestLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormRequestLeave form_form1 = new FormRequestLeave(name);
            form_form1.ShowDialog();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();
        }

        private void RequestLeaveAuth_Load_1(object sender, EventArgs e)
        {
            empname.Text = name;
        }
    }
}
