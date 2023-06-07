using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.sortfilterForDepForm;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormSED1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormSED1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }


        private void DisableButton()
        {
            foreach (Control previousButton in panel1.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousButton in panel1.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousButton in panel1.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }


        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)buttonSender;
                    //currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(childForm);
            this.panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //this.panel1.Controls.Clear();


        private void button1_Click_1(object sender, EventArgs e)
        {
            sortDepForm sortDgv = new sortDepForm(dataGridView1);

            sortDgv.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            // APPLY FILTER
            // Create an instance of the second form
            filterDepForm filterForm = new filterDepForm(dataGridView1);

            // Show the second form as a dialog and wait for it to close
            DialogResult result = filterForm.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected values from the comboboxes in the second form
                string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();



                // Check if at least one combobox is selected
                if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(jobstatus))
                {
                    MessageBox.Show("Please select at least one filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Apply the filters to the datagridview
                    string filter = "";

                    if (!string.IsNullOrWhiteSpace(occupation))
                    {
                        filter += $"[occupation] = '{occupation}'";
                    }


                    if (!string.IsNullOrWhiteSpace(jobstatus))
                    {
                        if (!string.IsNullOrWhiteSpace(filter))
                        {
                            filter += " AND ";

                        }
                        filter += $"[jobstatus] = '{jobstatus}'";
                    }

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;

                }

            }
        }

        private void FormSED1_Load_1(object sender, EventArgs e)
        {
            string specificDepartment = "SED"; // Replace with the specific department name
            DateTime currentDate = DateTime.Now.Date; // Get the current date

            try
            {
                connection.Open();
                string query2 = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@currentDate", currentDate);
                command2.Parameters.AddWithValue("@department", specificDepartment);

                int employeeCount = Convert.ToInt32(command2.ExecuteScalar());


                // Query to retrieve the present employees in the specific department who have time-in today
                string query = "SELECT empnum, name, occupation, jobstatus FROM empattendance WHERE department = @department AND DATE(timein) = @currentDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department", specificDepartment);
                command.Parameters.AddWithValue("@currentDate", currentDate);

                // Display the count in a label
                label3.Text = employeeCount.ToString();

                // Create a DataTable to store the retrieved data
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());

                // Set the DataTable as the data source for the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDepartment(), sender);
        }

        /// <summary>
        /// with reference
        /// </summary>

        private void buttonBackBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDepartment(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // APPLY FILTER
            // Create an instance of the second form
            filterDepForm filterForm = new filterDepForm(dataGridView1);

            // Show the second form as a dialog and wait for it to close
            DialogResult result = filterForm.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected values from the comboboxes in the second form
                string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();



                // Check if at least one combobox is selected
                if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(jobstatus))
                {
                    MessageBox.Show("Please select at least one filter option.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Apply the filters to the datagridview
                    string filter = "";

                    if (!string.IsNullOrWhiteSpace(occupation))
                    {
                        filter += $"[occupation] = '{occupation}'";
                    }


                    if (!string.IsNullOrWhiteSpace(jobstatus))
                    {
                        if (!string.IsNullOrWhiteSpace(filter))
                        {
                            filter += " AND ";

                        }
                        filter += $"[jobstatus] = '{jobstatus}'";
                    }

                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = filter;

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sortDepForm sortDgv = new sortDepForm(dataGridView1);

            sortDgv.Show();
        }

        private void FormSED1_Load(object sender, EventArgs e)
        {
            string specificDepartment = "SED"; // Replace with the specific department name
            DateTime currentDate = DateTime.Now.Date; // Get the current date

            try
            {
                connection.Open();
                string query2 = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@currentDate", currentDate);
                command2.Parameters.AddWithValue("@department", specificDepartment);

                int employeeCount = Convert.ToInt32(command2.ExecuteScalar());


                // Query to retrieve the present employees in the specific department who have time-in today
                string query = "SELECT empnum, name, occupation, jobstatus FROM empattendance WHERE department = @department AND DATE(timein) = @currentDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department", specificDepartment);
                command.Parameters.AddWithValue("@currentDate", currentDate);

                // Display the count in a label
                label3.Text = employeeCount.ToString();

                // Create a DataTable to store the retrieved data
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());

                // Set the DataTable as the data source for the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
