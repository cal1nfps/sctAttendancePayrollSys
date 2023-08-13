using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Employee.sortOnLeave
{
    public partial class sortonleave : Form
    {
        public sortonleave()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from FormHome
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormLeave"].Controls["dataGridViewLeave"] as DataGridView;

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "A - Z")
            {
                dataGridView1.Sort(dataGridView1.Columns["name"], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
            }


            if (selectedItem == "Z - A")
            {
                dataGridView1.Sort(dataGridView1.Columns["name"], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = filterComboBox.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from FormHome
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormLeave"].Controls["dataGridViewLeave"] as DataGridView;

            //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
            if (selectedItem == "Lowest - Highest")
            {
                dataGridView1.Sort(dataGridView1.Columns["empnum"], ListSortDirection.Descending);    //Sorts the selected column 'Employee_Number' to Ascending    
            }


            if (selectedItem == "Highest - Lowest")
            {
                dataGridView1.Sort(dataGridView1.Columns["empnum"], ListSortDirection.Ascending);   //Sorts the selected column 'Employee_Number' to Descending
            }
        }
    }
}
