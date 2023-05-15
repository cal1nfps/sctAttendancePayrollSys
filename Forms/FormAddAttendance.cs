using MySql.Data.MySqlClient;
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
    public partial class FormAddAttendance : Form
    {
        public FormAddAttendance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelManualInputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSaveManualInput_Click(object sender, EventArgs e)
        {

            //This is my connection string i have assigned the database file address path
            string MyConnection2 = "datasource=localhost;port=3306;username=root;password=root";
            //This is my insert query in which i am taking input from the user through windows forms
            string Query = "insert into login_attendancesystem.manualinput(empnum,Name,Department,Date,ClockIn,ClockOut) " +
            "values('" + this.textBoxManualEmployeeNumber.Text + "','" + this.textBoxManualName.Text + "','" + this.textBoxManualDepartment.Text + "','" + this.textBoxManualDate.Text + "','"
            + this.textBoxManualClockIn.Text + "','" + this.textBoxManualClockOut + "')";
            //This is  MySqlConnection here i have created the object and pass my connection string.
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
            if (MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sucessfully saved!", "Confirmation", MessageBoxButtons.OK);
                textBoxManualEmployeeNumber.Text = String.Empty;
                textBoxManualName.Text = String.Empty;
                textBoxManualDepartment.Text = String.Empty;
                textBoxManualDate.Text = String.Empty;
                textBoxManualClockIn.Text = String.Empty;
                textBoxManualClockOut.Text = String.Empty;

            }
        }

        private void FormAddAttendance_Load(object sender, EventArgs e)
        {
            labelAutomaticInputDate.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonSaveAutomaticInput_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Sucessfully saved!", "Confirmation", MessageBoxButtons.OK);
            }
        }

        private void textBoxManualEmployeeNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
