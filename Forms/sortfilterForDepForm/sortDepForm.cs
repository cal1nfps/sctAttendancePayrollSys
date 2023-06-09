using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI.Forms.sortfilterForDepForm
{
    public partial class sortDepForm : Form
    {
        private DataGridView dataGridView;

        public sortDepForm(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            filterComboBox.Items.AddRange(new string[] { "Lowest - Highest", "Highest - Lowest" });
            comboBox2.Items.AddRange(new string[] { "A - Z", "Z - A" });

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox2.SelectedItem.ToString();   //Selected combobox item
                                                                       //Sort DGV from Department
            if (dataGridView != null)
            {
                //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
                if (selectedItem == "A - Z")
                {
                    dataGridView.Sort(dataGridView.Columns["name"], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
                }


                if (selectedItem == "Z - A")
                {
                    dataGridView.Sort(dataGridView.Columns["name"], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
                }
            }
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = filterComboBox.SelectedItem.ToString();   //Selected combobox item

            //Sort DGV from Department
            if (dataGridView != null)
            {
                //SORTS THE COLUMN 'EMPLOYEE_NUMBER'
                if (selectedItem == "Lowest - Highest")
                {
                    dataGridView.Sort(dataGridView.Columns["empnum"], ListSortDirection.Ascending);    //Sorts the selected column 'Employee_Number' to Ascending    
                }


                if (selectedItem == "Highest - Lowest")
                {
                    dataGridView.Sort(dataGridView.Columns["empnum"], ListSortDirection.Descending);   //Sorts the selected column 'Employee_Number' to Descending
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
