﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI.Forms.sortfilterForDepForm
{
    public partial class filterDepForm : Form
    {
        private DataGridView dataGridView;

        private MySqlConnection connection;
        public filterDepForm(DataGridView dataGridView)
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            this.dataGridView = dataGridView;

            occupationCMB.KeyPress += ComboBox_KeyPress;
            jobStatusCMB.KeyPress += ComboBox_KeyPress;
        }

        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block any keypress event to prevent user input in the comboboxes
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CLEAR BUTTON
            if (dataGridView != null)
            {

                (dataGridView.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Empty;

            }
        }
    }
}
