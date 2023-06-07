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
    public partial class FormRequestLeave : Form
    {
        public FormRequestLeave()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomePage form_form1 = new WelcomePage();
            form_form1.ShowDialog();
            this.Close();

        }
    }
}
