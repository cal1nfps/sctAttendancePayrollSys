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
using System.Globalization;
using System.Threading;
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
                string jobsalary = dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();


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
                edit.jobsalary = jobsalary;


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

        private void button3_Click(object sender, EventArgs e)
        {
            AddEmployeeButtonForm form_addEmployee = new AddEmployeeButtonForm();
            form_addEmployee.ShowDialog();
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            LoadImageData();

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
                        // Retrieve the occupation value from the "occupation" column
                        string occupation = row.Cells["occupation"].Value.ToString();

                        // Assign job hours based on the matched occupation
                        TimeSpan jobHours;
                        DateTime jobTimeIn, jobTimeOut;
                        switch (occupation)
                        {
                            case "Teacher":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("17:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Sports Coach":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("16:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "School Nurse":
                                jobTimeIn = DateTime.ParseExact("08:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("16:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Maintenance Technician":
                                jobTimeIn = DateTime.ParseExact("09:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("17:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Registrar":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("17:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Guidance Counselor":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("16:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Guard":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("18:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            case "Chairperson":
                                jobTimeIn = DateTime.ParseExact("07:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                jobTimeOut = DateTime.ParseExact("18:00:00", "HH:mm:ss", CultureInfo.InvariantCulture);
                                break;
                            default:
                                jobTimeIn = DateTime.MinValue;
                                jobTimeOut = DateTime.MinValue;
                                break;
                        }

                        // Update the jobtimein, jobtimeout, and jobhours columns in the MySQL table for the current row
                        string updateQuery = "UPDATE employee SET jobtimein = @jobtimein, jobtimeout = @jobtimeout, jobhours = SEC_TO_TIME(TIME_TO_SEC(@jobtimeout) - TIME_TO_SEC(@jobtimein)) WHERE occupation = @occupation";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@jobtimein", jobTimeIn);
                        command.Parameters.AddWithValue("@jobtimeout", jobTimeOut);
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

                // Set the format of the jobtimein and jobtimeout columns in the DataGridView
                DataGridViewColumn jobTimeInColumn = dataGridView1.Columns["jobtimein"];
                DataGridViewColumn jobTimeOutColumn = dataGridView1.Columns["jobtimeout"];
                jobTimeInColumn.DefaultCellStyle.Format = "hh:mm:ss tt";
                jobTimeOutColumn.DefaultCellStyle.Format = "hh:mm:ss tt";



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
                dataGridView1.Columns["jobtimein"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["jobtimeout"].Visible = false;    //Hide a specific column
                dataGridView1.Columns["jobsalary"].Visible = false;    //Hide a specific column



                //reader.Close();
                connection.Close();
            }
        }

        private void sortComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
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
                string jobsalary = dataGridView1.Rows[rowIndex].Cells[27].Value.ToString();


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
                edit.jobsalary = jobsalary;


                //show the second form
                edit.Show();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                // Create a SaveFileDialog to choose the file path and name
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.FileName = "Employee-List-Output.xlsx"; // Default file name

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the selected file path and name
                    string filePath = saveFileDialog.FileName;

                    // Creating Excel Application
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                    // Creating new Workbook within Excel application
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                    // Creating new Excel sheet in workbook
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                    // See the Excel sheet behind the program
                    app.Visible = true;

                    // Get the reference of the first sheet. By default, its name is Sheet1.
                    // Store its reference to the worksheet
                    worksheet = workbook.Sheets["Sheet1"];
                    worksheet = workbook.ActiveSheet;

                    // Changing the name of the active sheet
                    worksheet.Name = "Sheet 1 Exported";

                    // Storing header part in Excel
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Save the Excel file
                    workbook.SaveAs(filePath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                    // Close the workbook and Excel application
                    workbook.Close();
                    app.Quit();

                    MessageBox.Show("Data exported to Excel successfully!");
                }
            }
        }
    }
}
