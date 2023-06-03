using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.filterButton;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormEmployeeList : Form
    {


        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormEmployeeList()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddEmployeeButtonForm form_addEmployee = new AddEmployeeButtonForm();
            form_addEmployee.ShowDialog();

        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridView1.Columns[e.ColumnIndex].Name == "dob" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("MMMM dd, yyyy");
                e.FormattingApplied = true;
            }

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {

                // Get the value of the selected cell
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string value1 = row.Cells[0].Value.ToString();
                string value4 = row.Cells[19].Value.ToString();
                string value5 = row.Cells[11].Value.ToString();
                string value6 = row.Cells[12].Value.ToString();
                string value7 = row.Cells[13].Value.ToString();
                string value8 = row.Cells[21].Value.ToString();
                string value9 = row.Cells[22].Value.ToString();

                string cellValue = row.Cells[20].Value.ToString();
                if (DateTime.TryParse(cellValue, out DateTime value3))
                {
                    textBox3.Text = value3.ToString("MMMM dd, yyyy");
                }
                else
                {
                }

                // Display the value in a TextBox
                textBox1.Text = value1; // Employee number
                textBox4.Text = value4; // Account number
                textBox7.Text = value5; // Home Number
                textBox6.Text = value6; // Phone number
                textBox5.Text = value7; // email
                textBox8.Text = value8; // time-in
                textBox9.Text = value9; // time-out

            }

            // Displays store image from a cell to a PictureBox
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                byte[] imageBytes = (byte[])row.Cells["image_data"].Value;

                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }

            //Stores multiple cell values
            string data = "";
            if (e.RowIndex >= 0)
            {
                //Displays multiple cell values in a textbox
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                string firstname = row.Cells[5].Value.ToString();
                string middle = row.Cells[6].Value.ToString();
                string lastname = row.Cells[7].Value.ToString();
                string suffix = row.Cells[8].Value.ToString();

                data += firstname + " " + middle + "." + " " + lastname + " " + suffix;

            }

            // Set the Text property of the TextBox to the concatenated data
            textBox2.Text = data;
        }

        private Dictionary<string, (TimeSpan, TimeSpan)> occupationTimeMapping;

        private void AssignTimeInTimeout()
        {
            // Get the DataGridView instance
            adapter = new MySqlDataAdapter("SELECT * FROM empattendance", connection);


            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);


            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;
            try
            {
                connection.Open();

                // Loop through each row in the DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Get the occupation value from the "occupation" column
                    string occupation = row.Cells["occupation"].Value.ToString();

                    // Assign time-in and time-out based on the matched occupation
                    string jobTimeIn, jobTimeOut;

                    switch (occupation)
                    {
                        case "Teacher":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "17:00:00";
                            break;
                        case "Sports Coach":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "16:00:00";
                            break;
                        case "School Nurse":
                            jobTimeIn = "08:00:00";
                            jobTimeOut = "16:00:00";
                            break;
                        case "Maintenance Technician":
                            jobTimeIn = "09:00:00";
                            jobTimeOut = "17:00:00";
                            break;
                        case "Registrar":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "17:00:00";
                            break;
                        case "Guidance Counselor":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "16:00:00";
                            break;
                        case "Guard":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "18:00:00";
                            break;
                        case "Chairperson":
                            jobTimeIn = "07:00:00";
                            jobTimeOut = "18:00:00";
                            break;
                        default:
                            // Handle unmatched occupation (if needed)
                            jobTimeIn = string.Empty;
                            jobTimeOut = string.Empty;
                            break;
                    }

                    // Update the jobtimein and jobtimeout columns in the database
                    if (!string.IsNullOrEmpty(jobTimeIn) && !string.IsNullOrEmpty(jobTimeOut))
                    {
                        int employeeNum = Convert.ToInt32(row.Cells["empnum"].Value);

                        string query = "UPDATE employee SET jobtimein = @jobTimeIn, jobtimeout = @jobTimeOut WHERE employeenum = @employeeNum";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@jobTimeIn", jobTimeIn);
                        command.Parameters.AddWithValue("@jobTimeOut", jobTimeOut);
                        command.Parameters.AddWithValue("@employeeNum", employeeNum);

                        command.ExecuteNonQuery();
                    }
                }
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





        private void FormEmployeeList_Load_1(object sender, EventArgs e)
        {
            LoadImageData();
            AssignTimeInTimeout();


            {

                adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);


                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);


                // Set the DataSource of the DataGridView to the DataTable
                dataGridView1.DataSource = table;

                dataGridView1.Columns[3].Width = 70;
                dataGridView1.Columns[4].Width = 70;
                dataGridView1.Columns[11].Width = 80;
                dataGridView1.Columns[15].Width = 80;
                
                    try
                    {
                        connection.Open();

                        // Loop through each row in the DataGridView
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            // Retrieve the occupation value from the "Occupation" column
                            string occupation = row.Cells["occupation"].Value.ToString();

                            // Assign job hours based on the matched occupation
                            TimeSpan jobHours;
                            switch (occupation)
                            {
                                case "Teacher":
                                    jobHours = new TimeSpan(10, 0, 0);
                                    break;
                                case "Sports Coach":
                                    jobHours = new TimeSpan(9, 0, 0);
                                    break;
                                case "School Nurse":
                                    jobHours = new TimeSpan(8, 0, 0);
                                    break;
                                case "Maintenance Technician":
                                    jobHours = new TimeSpan(8, 0, 0);
                                    break;
                                case "Registrar":
                                    jobHours = new TimeSpan(10, 0, 0);
                                    break;
                                case "Guidance Counselor":
                                    jobHours = new TimeSpan(9, 0, 0);
                                    break;
                                case "Guard":
                                    jobHours = new TimeSpan(11, 0, 0);
                                    break;
                                case "Chairperson":
                                    jobHours = new TimeSpan(11, 0, 0);
                                    break;
                                default:
                                    jobHours = TimeSpan.Zero; // Set a default value if occupation does not match any case
                                    break;
                            }

                            // Update the JobHours column in the MySQL table for the current row
                            string updateQuery = "UPDATE employee SET jobhours = @jobhours WHERE occupation = @occupation";
                            MySqlCommand command = new MySqlCommand(updateQuery, connection);
                            command.Parameters.AddWithValue("@jobhours", jobHours);
                            command.Parameters.AddWithValue("@occupation", occupation);
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                


                dataGridView1.Columns["employeenum"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["firstname"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["middle"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["lastname"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["gender"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["suffix"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["homenum"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["phonenum"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["email"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["address"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["postal"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["accountnum"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["hiredate"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["timein"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["timeout"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["image_data"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["jobhours"].Visible = false;    //Hide a specific column

                //reader.Close();
                connection.Close();
            }
        }

        private void LoadImageData()
        {
            try
            {
                connection.Open();

                string query = "SELECT employeenum, image_data FROM employee";
                MySqlCommand command = new MySqlCommand(query, connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;


                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = sortComboBox.SelectedItem.ToString();     //Selected combobox item

            //SORTS THE COLUMN 'NAME'
            if (selectedItem == "A - Z")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["name"], ListSortDirection.Ascending);   //Sorts the selected column 'Name' to Ascending
            }

            if (selectedItem == "Z - A")
            {
                this.dataGridView1.Sort(this.dataGridView1.Columns["name"], ListSortDirection.Descending);  //Sorts the selected column 'Name' to Descending
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // DELETE EMPLOYEE INFORMATION
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                connection.Open();

                // Get selected cell value from DataGridView
                string selectedCellValue = dataGridView1.SelectedCells[0].Value.ToString();

                // Delete selected cell value from MySQL database
                string query = "DELETE FROM employee WHERE name = @name";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", selectedCellValue);
                command.ExecuteNonQuery();

                // Display message box to confirm deletion
                MessageBox.Show("Employee deleted successfully.");

                // Refresh DataGridView to show updated data
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //EDIT BUTTON

            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                //create an instance of the second form
                EditButtonForm edit = new EditButtonForm();

                // Get the data from the selected row
                string firstname = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
                string middlename = dataGridView1.Rows[rowIndex].Cells[6].Value.ToString();
                string lastname = dataGridView1.Rows[rowIndex].Cells[7].Value.ToString();
                string suffix = dataGridView1.Rows[rowIndex].Cells[8].Value.ToString();
                string gender = dataGridView1.Rows[rowIndex].Cells[9].Value.ToString();
                string dob = dataGridView1.Rows[rowIndex].Cells[10].Value.ToString();
                string country = dataGridView1.Rows[rowIndex].Cells[15].Value.ToString();
                string address = dataGridView1.Rows[rowIndex].Cells[14].Value.ToString();
                string province = dataGridView1.Rows[rowIndex].Cells[16].Value.ToString();
                string city = dataGridView1.Rows[rowIndex].Cells[17].Value.ToString();
                string postal = dataGridView1.Rows[rowIndex].Cells[18].Value.ToString();
                string phone = dataGridView1.Rows[rowIndex].Cells[12].Value.ToString();
                string telephone = dataGridView1.Rows[rowIndex].Cells[11].Value.ToString();
                string email = dataGridView1.Rows[rowIndex].Cells[13].Value.ToString();
                string empnum = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
                string account = dataGridView1.Rows[rowIndex].Cells[19].Value.ToString();
                string hdate = dataGridView1.Rows[rowIndex].Cells[20].Value.ToString();
                string occupation = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                string department = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                string jobstatus = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
                string timein = dataGridView1.Rows[rowIndex].Cells[21].Value.ToString();
                string timeout = dataGridView1.Rows[rowIndex].Cells[22].Value.ToString();
                byte[] imageData = (byte[])dataGridView1.Rows[rowIndex].Cells[23].Value;

                //set the public properties of the textboxes on the second form
                edit.firstname = firstname;
                edit.middlename = middlename;
                edit.lastname = lastname;
                edit.suffix = suffix;
                edit.gender = gender;
                edit.dob = dob;
                edit.country = country;
                edit.address = address;
                edit.province = province;
                edit.city = city;
                edit.postal = postal;
                edit.phone = phone;
                edit.telephone = telephone;
                edit.email = email;
                edit.empnum = empnum;
                edit.account = account;
                edit.hdate = hdate;
                edit.occupation = occupation;
                edit.department = department;
                edit.jobstatus = jobstatus;
                edit.timein = timein;
                edit.timeout = timeout;
                edit.image = imageData;

                //show the second form
                edit.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // APPLY FILTER
            // Create an instance of the second form
            filterForm filterForm = new filterForm();

            // Show the second form as a dialog and wait for it to close
            DialogResult result = filterForm.ShowDialog();

            // Check if the user clicked the OK button
            if (result == DialogResult.OK)
            {
                // Get the selected values from the comboboxes in the second form
                string occupation = filterForm.filterComboBox.SelectedItem?.ToString();
                string department = filterForm.comboBox2.SelectedItem?.ToString();
                string gender = filterForm.comboBox1.SelectedItem?.ToString();
                string jobstatus = filterForm.comboBox3.SelectedItem?.ToString();

                // Check if at least one combobox is selected
                if (string.IsNullOrWhiteSpace(occupation) && string.IsNullOrWhiteSpace(department) && string.IsNullOrWhiteSpace(gender) && string.IsNullOrWhiteSpace(jobstatus))
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

                    if (!string.IsNullOrWhiteSpace(department))
                    {
                        if (!string.IsNullOrWhiteSpace(filter))
                        {
                            filter += " AND ";
                        }

                        filter += $"[department] = '{department}'";
                    }

                    if (!string.IsNullOrWhiteSpace(gender))
                    {
                        if (!string.IsNullOrWhiteSpace(filter))
                        {
                            filter += " AND ";
                        }

                        filter += $"[gender] = '{gender}'";
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
    }
}
