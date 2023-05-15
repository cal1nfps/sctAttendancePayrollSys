using SCTAttendanceSystemUI.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonEmployeeLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_form1 = new Form1();
            form_form1.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormEmployeeDashboard form_empdashboard = new FormEmployeeDashboard();
            form_empdashboard.ShowDialog();
            this.Close();
        }
    }
}
