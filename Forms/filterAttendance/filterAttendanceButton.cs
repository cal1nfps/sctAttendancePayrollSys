using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Forms.filterAttendance
{
    public partial class filterAttendanceButton : Form
    {
        public filterAttendanceButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FILTER BUTTON
            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormHome"].Controls["dataGridView1"] as DataGridView;
            if (dataGridView1 != null)
            {
                (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
