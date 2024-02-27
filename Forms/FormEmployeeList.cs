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
using System.Drawing;
using System.Drawing.Drawing2D;
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

            SetDataGridViewStyle(dataGridViewEmployeeList, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed

            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;

        }
        private void ApplyColumnStyles()
        {
            // Dynamic Column Color Changer
            foreach (DataGridViewColumn column in dataGridViewEmployeeList.Columns)
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
            return dataGridViewEmployeeList; // Replace "dataGridView1" with the actual name of your DataGridView control
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddEmployeeButtonForm form_addEmployee = new AddEmployeeButtonForm();
            form_addEmployee.ShowDialog();

        }

        private void dataGridView1_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewColumn column in dataGridViewEmployeeList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewEmployeeList.Columns[e.ColumnIndex].Name == "dob" && e.Value != null && e.Value is DateTime)
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
                DataGridViewRow row = dataGridViewEmployeeList.Rows[e.RowIndex];

                string value1 = row.Cells[1].Value.ToString();
                string value4 = row.Cells[19].Value.ToString();
                string value5 = row.Cells[12].Value.ToString();
                string value6 = row.Cells[13].Value.ToString();
                string value7 = row.Cells[14].Value.ToString();
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
                textBox7.Text = value5; // Home Number
                textBox6.Text = value6; // Phone number
                textBox5.Text = value7; // email
                textBox8.Text = value8; // time-in
                textBox9.Text = value9; // time-out

            }

            // Displays store image from a cell to a PictureBox
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridViewEmployeeList.Rows[e.RowIndex];

                // Check if the "image_data" cell value is not null
                if (row.Cells["image_data"].Value != DBNull.Value && row.Cells["image_data"].Value != null)
                {
                    byte[] imageBytes = (byte[])row.Cells["image_data"].Value;

                    // Check if the imageBytes array is not empty
                    if (imageBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                            {
                                // Attempt to create the Image object
                                pictureBox1.Image = Image.FromStream(memoryStream);
                            }
                        }
                        catch (ArgumentException ex)
                        {
                            // Handle the case where the image data is not a valid format
                            MessageBox.Show("Error loading image: " + ex.Message);
                            pictureBox1.Image = null; // Set a default image or clear the PictureBox.
                        }
                    }
                    else
                    {
                        // Handle the case where the imageBytes array is empty
                        pictureBox1.Image = null; // Set a default image or clear the PictureBox.
                    }
                }
                else
                {
                    // Handle the case where the "image_data" is null (optional)
                    // For example, set a default image or clear the PictureBox.
                    pictureBox1.Image = null; // Set a default image or null
                }
            }



            //Stores multiple cell values
            string data = "";
            if (e.RowIndex >= 0)
            {
                //Displays multiple cell values in a textbox
                DataGridViewRow row = dataGridViewEmployeeList.Rows[e.RowIndex];

                string firstname = row.Cells[6].Value.ToString();
                string middle = row.Cells[7].Value.ToString();
                string lastname = row.Cells[8].Value.ToString();
                string suffix = row.Cells[9].Value.ToString();

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

                string query = "SELECT employeenum, IFNULL(image_data, NULL) AS image_data FROM employee";
                MySqlCommand command = new MySqlCommand(query, connection);

                DataTable dataTable = new DataTable();
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                dataGridViewEmployeeList.DataSource = dataTable;
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


        private void button2_Click(object sender, EventArgs e)
        {
            // DELETE EMPLOYEE INFORMATION
            DialogResult result = MessageBox.Show("Are you sure you want to delete this Employee?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                connection.Open();

                // Get selected cell value from DataGridView
                string selectedCellValue = dataGridViewEmployeeList.SelectedCells[0].Value.ToString();

                // Delete selected cell value from MySQL database
                string query = "DELETE FROM employee WHERE id = @id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", selectedCellValue);
                command.ExecuteNonQuery();

                // Display message box to confirm deletion
                MessageBox.Show("Employee deleted successfully.");

                // Refresh DataGridView to show updated data
                dataGridViewEmployeeList.Update();
                dataGridViewEmployeeList.Refresh();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //EDIT BUTTON

            if (dataGridViewEmployeeList.SelectedCells.Count > 0)
            {
                // Get the selected row index
                int rowIndex = dataGridViewEmployeeList.SelectedCells[0].RowIndex;

                //create an instance of the second form
                EditButtonForm edit = new EditButtonForm();

                // Get the data from the selected row
                string id = dataGridViewEmployeeList.Rows[rowIndex].Cells[0].Value.ToString();
                string firstname = dataGridViewEmployeeList.Rows[rowIndex].Cells[6].Value.ToString();
                string middlename = dataGridViewEmployeeList.Rows[rowIndex].Cells[7].Value.ToString();
                string lastname = dataGridViewEmployeeList.Rows[rowIndex].Cells[8].Value.ToString();
                string suffix = dataGridViewEmployeeList.Rows[rowIndex].Cells[9].Value.ToString();
                string gender = dataGridViewEmployeeList.Rows[rowIndex].Cells[10].Value.ToString();
                string dob = dataGridViewEmployeeList.Rows[rowIndex].Cells[11].Value.ToString();
                string barangay = dataGridViewEmployeeList.Rows[rowIndex].Cells[18].Value.ToString();
                string address = dataGridViewEmployeeList.Rows[rowIndex].Cells[15].Value.ToString();
                string province = dataGridViewEmployeeList.Rows[rowIndex].Cells[16].Value.ToString();
                string city = dataGridViewEmployeeList.Rows[rowIndex].Cells[17].Value.ToString();
                string postal = dataGridViewEmployeeList.Rows[rowIndex].Cells[19].Value.ToString();
                string phone = dataGridViewEmployeeList.Rows[rowIndex].Cells[13].Value.ToString();
                string telephone = dataGridViewEmployeeList.Rows[rowIndex].Cells[12].Value.ToString();
                string email = dataGridViewEmployeeList.Rows[rowIndex].Cells[14].Value.ToString();
                string empnum = dataGridViewEmployeeList.Rows[rowIndex].Cells[1].Value.ToString();
                string hdate = dataGridViewEmployeeList.Rows[rowIndex].Cells[20].Value.ToString();
                string occupation = dataGridViewEmployeeList.Rows[rowIndex].Cells[3].Value.ToString();
                string department = dataGridViewEmployeeList.Rows[rowIndex].Cells[4].Value.ToString();
                string jobstatus = dataGridViewEmployeeList.Rows[rowIndex].Cells[5].Value.ToString();
                string timein = dataGridViewEmployeeList.Rows[rowIndex].Cells[21].Value.ToString();
                string timeout = dataGridViewEmployeeList.Rows[rowIndex].Cells[22].Value.ToString();
                byte[] imageData = (byte[])dataGridViewEmployeeList.Rows[rowIndex].Cells[23].Value;




                //set the public properties of the textboxes on the second form
                edit.id = id;
                edit.firstname = firstname;
                edit.middlename = middlename;
                edit.lastname = lastname;
                edit.suffix = suffix;
                edit.gender = gender;
                edit.dob = dob;
                edit.barangay = barangay;
                edit.address = address;
                edit.province = province;
                edit.city = city;
                edit.postal = postal;
                edit.phone = phone;
                edit.telephone = telephone;
                edit.email = email;
                edit.empnum = empnum;
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
                string occupation = filterForm.occupationCMB.SelectedItem?.ToString();
                string department = filterForm.depCMB.SelectedItem?.ToString();
                string gender = filterForm.genderCMB.SelectedItem?.ToString();
                string jobstatus = filterForm.jobStatusCMB.SelectedItem?.ToString();

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

                    (dataGridViewEmployeeList.DataSource as DataTable).DefaultView.RowFilter = filter;
                }
            }
        }

        private void FormEmployeeList_Load(object sender, EventArgs e)
        {
            LoadImageData();
            ApplyColumnStyles();

            {

                adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);


                // Create a DataTable to hold the data
                table = new DataTable();

                // Fill the DataTable with the data retrieved by the adapter
                adapter.Fill(table);


                // Set the DataSource of the DataGridView to the DataTable
                dataGridViewEmployeeList.DataSource = table;

                try
                {
                    connection.Open();

                    // Loop through each row in the DataGridView
                    foreach (DataGridViewRow row in dataGridViewEmployeeList.Rows)
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
                DataGridViewColumn jobTimeInColumn = dataGridViewEmployeeList.Columns["jobtimein"];
                DataGridViewColumn jobTimeOutColumn = dataGridViewEmployeeList.Columns["jobtimeout"];
                jobTimeInColumn.DefaultCellStyle.Format = "hh:mm:ss tt";
                jobTimeOutColumn.DefaultCellStyle.Format = "hh:mm:ss tt";

                dataGridViewEmployeeList.Columns["name"].HeaderText = "Name";
                dataGridViewEmployeeList.Columns["occupation"].HeaderText = "Occupation";
                dataGridViewEmployeeList.Columns["department"].HeaderText = "Department";
                dataGridViewEmployeeList.Columns["jobstatus"].HeaderText = "Job Status";
                dataGridViewEmployeeList.Columns["dob"].HeaderText = "Date Of Birth";
                dataGridViewEmployeeList.Columns["barangay"].HeaderText = "Barangay";
                dataGridViewEmployeeList.Columns["province"].HeaderText = "Province";
                dataGridViewEmployeeList.Columns["city"].HeaderText = "City";


                dataGridViewEmployeeList.Columns["id"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["employeenum"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["firstname"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["middle"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["lastname"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["gender"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["suffix"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["homenum"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["phonenum"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["email"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["address"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["postal"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["hiredate"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["timein"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["timeout"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["image_data"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["jobhours"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["jobtimein"].Visible = false;    //Hide a specific column
                dataGridViewEmployeeList.Columns["jobtimeout"].Visible = false;    //Hide a specific column



                //reader.Close();
                connection.Close();
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    for (int i = 1; i < dataGridViewEmployeeList.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridViewEmployeeList.Columns[i - 1].HeaderText;
                    }

                    // Storing each row and column value to the Excel sheet
                    for (int i = 0; i < dataGridViewEmployeeList.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewEmployeeList.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridViewEmployeeList.Rows[i].Cells[j].Value.ToString();
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

        private DataView dataView;
        private System.Data.DataTable originalDataTable;
        private void SearchData(string searchText)
        {
            if (dataView == null)
            {
                originalDataTable = (System.Data.DataTable)dataGridViewEmployeeList.DataSource;
                dataView = new DataView(originalDataTable);
            }

            dataView.RowFilter = $"name LIKE '%{searchText}%' OR Convert(employeenum, 'System.String') LIKE '%{searchText}%'";
            dataGridViewEmployeeList.DataSource = dataView;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchBox.Text;
            SearchData(searchText);
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            string connectionString2 = "server=localhost;user=root;password=root;database=payrollsys";

            try
            {
                // Confirm with the user before deleting all data
                DialogResult result = MessageBox.Show("Are you sure you want to delete all data?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                using (MySqlConnection checkConnection = new MySqlConnection(connectionString2))
                {
                    if (result == DialogResult.Yes)
                    {
                        // Clear the DataGridView
                        dataGridViewEmployeeList.DataSource = null;

                        // Delete all rows from the MySQL database
                        checkConnection.Open();

                        string deleteAllQuery = "DELETE FROM employee"; // Remove the WHERE clause

                        using (MySqlCommand cmd = new MySqlCommand(deleteAllQuery, checkConnection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("All data deleted successfully.");
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
