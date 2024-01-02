using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.filterAttendance;
using SCTAttendanceSystemUI.Forms.sortfilterForDepForm;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormIBED1 : Form
    {
        private Button currentButton;

        private Form activeForm;
        private MySqlConnection connection;

        public FormIBED1()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            SetDataGridViewStyle(dataGridViewIBED, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed

            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;

        }
        private void ApplyColumnStyles()
        {
            // Dynamic Column Color Changer
            foreach (DataGridViewColumn column in dataGridViewIBED.Columns)
            {
                // Check if the column index is even
                if (column.Index % 2 == 0)
                {
                    column.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void SetDataGridViewStyle(DataGridView dataGridView, Padding cellPadding, int cellHeight, float fontSize)
        {
            // Set the cell padding, height, and font size for the default cell style
            dataGridView.DefaultCellStyle.Padding = cellPadding;
            dataGridView.RowTemplate.Height = cellHeight;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);

            // Set the height and font size for the column headers
            dataGridView.ColumnHeadersHeight = cellHeight;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);


            // If you want to set the font size for the header cells as well, uncomment the following line
            // dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);
        }

        // Define a public method to get the DataGridView
        public DataGridView GetDataGridView()
        {
            return dataGridViewIBED; // Replace "dataGridView1" with the actual name of your DataGridView control
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            // APPLY FILTER
            // Create an instance of the second form
            filterDepForm filterForm = new filterDepForm(dataGridViewIBED);

            // Show the second form as a dialog and wait for it to close
            DialogResult result = filterForm.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected values from the comboboxes in the second form
                string occupation = filterForm.occupationCMB.SelectedItem?.ToString();
                string jobstatus = filterForm.jobStatusCMB.SelectedItem?.ToString();



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

                    (dataGridViewIBED.DataSource as DataTable).DefaultView.RowFilter = filter;

                }

            }
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
            filterDepForm filterForm = new filterDepForm(dataGridViewIBED);

            // Show the second form as a dialog and wait for it to close
            DialogResult result = filterForm.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected values from the comboboxes in the second form
                string occupation = filterForm.occupationCMB.SelectedItem?.ToString();
                string jobstatus = filterForm.jobStatusCMB.SelectedItem?.ToString();



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

                    (dataGridViewIBED.DataSource as DataTable).DefaultView.RowFilter = filter;

                }

            }
        }


        private void LoadIBED()
        {
            string specificDepartment = "IBED"; // Replace with the specific department name
            DateTime currentDate = DateTime.Now.Date; // Get the current date

            try
            {
                connection.Open();
                //Query to Retrieve present employees today and displays in a label counter 
                string query2 = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command2 = new MySqlCommand(query2, connection);
                command2.Parameters.AddWithValue("@currentDate", currentDate);
                command2.Parameters.AddWithValue("@department", specificDepartment);

                int employeeCount = Convert.ToInt32(command2.ExecuteScalar());


                // Query to retrieve the present employees in the specific department who have time-in today
                string query = "SELECT id, empnum, name, occupation, jobstatus FROM empattendance WHERE department = @department AND DATE(timein) = @currentDate";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department", specificDepartment);
                command.Parameters.AddWithValue("@currentDate", currentDate);

                // Display the count in a label
                label1.Text = employeeCount.ToString();

                // Create a DataTable to store the retrieved data
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());

                // Set the DataTable as the data source for the DataGridView
                dataGridViewIBED.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            if (dataGridViewIBED.Columns.Contains("id"))
                dataGridViewIBED.Columns["id"].HeaderText = "ID";

            if (dataGridViewIBED.Columns.Contains("empnum"))
                dataGridViewIBED.Columns["empnum"].HeaderText = "Employee Number";

            if (dataGridViewIBED.Columns.Contains("name"))
                dataGridViewIBED.Columns["name"].HeaderText = "Name";

            if (dataGridViewIBED.Columns.Contains("department"))
                dataGridViewIBED.Columns["department"].HeaderText = "Department";

            if (dataGridViewIBED.Columns.Contains("occupation"))
                dataGridViewIBED.Columns["occupation"].HeaderText = "Occupation";

            if (dataGridViewIBED.Columns.Contains("jobstatus"))
                dataGridViewIBED.Columns["jobstatus"].HeaderText = "Job Status";
        }
        private void FormIBED1_Load(object sender, EventArgs e)
        {
            ApplyColumnStyles();
            LoadIBED();
        }
        private DataView dataView;
        private System.Data.DataTable originalDataTable;
        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (System.Data.DataTable)dataGridViewIBED.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(empnum, 'System.String') LIKE '%{searchText}%'";
            dataGridViewIBED.DataSource = dataView;
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            SearchData(searchText);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            if (dataGridViewIBED.SelectedRows.Count > 0)
            {
                try
                {
                    // DELETE ITEM
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the selected data?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                        {
                            checkConnection.Open();

                            foreach (DataGridViewRow selectedRow in dataGridViewIBED.SelectedRows)
                            {
                                // Get the value from the selected row that you want to use for deletion.
                                string selectedValue = selectedRow.Cells["id"].Value.ToString();

                                // Delete from UserAct table
                                string deleteQuery = "DELETE FROM empattendance WHERE id = @id;";
                                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, checkConnection))
                                {
                                    deleteCommand.Parameters.AddWithValue("@id", selectedValue);
                                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                                    if (rowsAffected > 0)
                                    {
                                        // If deletion is successful, remove the row from the DataGridView
                                        dataGridViewIBED.Rows.Remove(selectedRow);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Delete failed. Row with ID {selectedValue} not found.");
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                }
            }
            else
            {
                MessageBox.Show("No rows selected for deletion.");
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            try
            {
                // Confirm with the user before deleting data
                DialogResult result = MessageBox.Show("Are you sure you want to delete data for department 'IBED'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                {
                    if (result == DialogResult.Yes)
                    {
                        // Clear the DataGridView
                        dataGridViewIBED.DataSource = null;

                        // Delete rows from the MySQL database where department is 'IBED'
                        checkConnection.Open();

                        string deleteQuery = "DELETE FROM empattendance WHERE department = 'IBED'";

                        using (MySqlCommand cmd = new MySqlCommand(deleteQuery, checkConnection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Data for department 'IBED' deleted successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close any open resources if needed
            }

        }

        private void clearLabel_MouseEnter(object sender, EventArgs e)
        {
            clearLabel.ForeColor = Color.Red;

        }

        private void clearLabel_MouseLeave(object sender, EventArgs e)
        {
            clearLabel.ForeColor = SystemColors.ControlText; // You can set it to your desired default color

        }
    }
}
