using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCTAttendanceSystemUI.Forms.AddLeaveButton
{
    public partial class AddLeaveButtonForm : Form
    {
        private string transferredData1;
        private string transferredData2;
        private string transferredData3;
        private string transferredData4;
        private string transferredData5;
        private string transferredData6;
        private string transferredData7;
        private string transferredData8;
        private string transferredData9;
        private string transferredData10;
        private string transferredData11;

        public AddLeaveButtonForm(string empnum, string firstname, string middlename, string lastname, string suffix, string dep, string occupation, string jobstatus, string start, string end, string leavestatus)
        {
            InitializeComponent();
            transferredData1 = empnum;
            transferredData2 = firstname;
            transferredData3 = middlename;
            transferredData4 = lastname;
            transferredData5 = suffix;
            transferredData6 = dep;
            transferredData7 = occupation;
            transferredData8 = jobstatus;
            transferredData9 = start;
            transferredData10 = end;
            transferredData11 = leavestatus;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddLeaveButtonForm_Load(object sender, EventArgs e)
        {
            textBoxEmployeeNo.Text = transferredData1; // department
            textBoxFirstName.Text = transferredData2; // occupation
            textBoxMiddleInitial.Text = transferredData3; // salary
            textBoxLastName.Text = transferredData4; // accountnum
            textBoxSuffix.Text = transferredData5; // department
            comboBoxDepartment.Text = transferredData6; // occupation
            comboBoxOccupation.Text = transferredData7; // salary
            comboBox1.Text = transferredData8; // salary
            textBoxDuration.Text = DateTime.Parse(transferredData9).ToString("MMMM dd, yyyy"); //hired date
            textBox1.Text = DateTime.Parse(transferredData10).ToString("MMMM dd, yyyy"); //dob
            comboBoxLeave.Text = transferredData11; // salary

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
