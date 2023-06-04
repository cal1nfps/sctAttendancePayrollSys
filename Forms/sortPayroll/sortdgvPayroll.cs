using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Forms.sortPayroll
{
    public partial class sortdgvPayroll : Form
    {
        public sortdgvPayroll()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Sort DGV from FormHome
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormPayroll"].Controls["dataGridView1"] as DataGridView;

            string selectedItem = comboBox1.SelectedItem.ToString();   //Selected combobox item

            if (selectedItem == "Recent - Oldest")
            {
                dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Descending);
            }
            if (selectedItem == "Oldest - Recent")
            {
                dataGridView1.Sort(dataGridView1.Columns["date"], ListSortDirection.Ascending);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from FormHome
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormPayroll"].Controls["dataGridView1"] as DataGridView;

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
            DataGridView dataGridView1 = System.Windows.Forms.Application.OpenForms["FormPayroll"].Controls["dataGridView1"] as DataGridView;

            //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
            if (selectedItem == "Lowest - Highest")
            {
                dataGridView1.Sort(dataGridView1.Columns["employeenum"], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
            }


            if (selectedItem == "Highest - Lowest")
            {
                dataGridView1.Sort(dataGridView1.Columns["employeenum"], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
            }
        }
    }
}
