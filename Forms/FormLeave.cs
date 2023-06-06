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

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormLeave : Form
    {
        public FormLeave()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddLeaveButtonForm form_addLeave = new AddLeaveButtonForm();
            form_addLeave.ShowDialog();
        }
    }
}
