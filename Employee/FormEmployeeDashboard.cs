using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Employee
{
    public partial class FormEmployeeDashboard : Form
    {
        public FormEmployeeDashboard()
        {
            InitializeComponent();
        }

        private void FormEmployeeDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelDate.Text = "Date Today: " + DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Current Time: " + DateTime.Now.ToString("h:mm:ss tt");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimeIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_form1 = new Form1();
            form_form1.ShowDialog();
            this.Close();
        }

        private void buttonTimeOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form_form1 = new Form1();
            form_form1.ShowDialog();
            this.Close();
        }
    }
}
