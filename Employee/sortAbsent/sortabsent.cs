using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Employee.sortAbsent
{
    public partial class sortabsent : Form
    {
        public sortabsent()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = filterComboBox.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from FormHome
            DataGridView dataGridView2 = System.Windows.Forms.Application.OpenForms["FormAbsentees"].Controls["dataGridView2"] as DataGridView;

            //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
            if (selectedItem == "Lowest - Highest")
            {
                dataGridView2.Sort(dataGridView2.Columns["empnum"], ListSortDirection.Descending);    //Sorts the selected column 'Employee_Number' to Ascending    
            }


            if (selectedItem == "Highest - Lowest")
            {
                dataGridView2.Sort(dataGridView2.Columns["empnum"], ListSortDirection.Ascending);   //Sorts the selected column 'Employee_Number' to Descending
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from FormHome
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormAbsentees"].Controls["dataGridView2"] as DataGridView;

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
    }
}
