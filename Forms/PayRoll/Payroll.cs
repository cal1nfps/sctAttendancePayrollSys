using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Crypto.Macs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    public partial class Payroll : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public Payroll()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Payroll_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM employee", connection);


            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);


            // Set the DataSource of the DataGridView to the DataTable
            dataGridView1.DataSource = table;

            dataGridView1.Columns[0].Width = 190;
            dataGridView1.Columns[1].Width = 190;
            dataGridView1.Columns[17].Width = 190;

            dataGridView1.Columns["department"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["firstname"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["middle"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["lastname"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["gender"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["dob"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["homenum"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["phonenum"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["email"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["address"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["country"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["province"].Visible = false;    //Hide a specific column
            dataGridView1.Columns["city"].Visible = false;    //Hide a specific column
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FormHome formhome = new FormHome();
            DataGridView dgvOther = formhome.GetDataGridView();


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string employeeNumber = dataGridView1.Rows[e.RowIndex].Cells["employeenum"].Value.ToString();
                string occupation = row.Cells["occupation"].Value.ToString();

                //TimeSpan totalHours = (TimeSpan)dgvOther.CurrentRow.Cells["totalhours"].Value;
                //string totalHoursString = totalHours.ToString();

                //double totalHoursNumeric = totalHours.TotalHours;

                double jobSalary = (double)row.Cells["jobsalary"].Value;
                double totalSalary = 0.0;
                double allowance = 0.0;
                double gross = 0.0;
                double deduction = 1075.0; //SSS: 675, PAGIBIG: 100, PHILHEALTH: 300
                double net = 0.0;


                switch (occupation)
                {
                    case "Teacher":
                        allowance = 750.0;
                        jobSalary = 25000.0;
                        break;
                    case "Sports Coach":
                        allowance = 750.0;
                        jobSalary = 25000.0;
                        break;
                    case "School Nurse":
                        allowance = 750.0;
                        jobSalary = 25000.0;
                        break;
                    case "Maintenance Technician":
                        allowance = 750.0;
                        jobSalary = 15000.0;
                        break;
                    case "Registrar":
                        allowance = 750.0;
                        jobSalary = 21000.0;
                        break;
                    case "Guidance Counselor":
                        allowance = 750.0;
                        jobSalary = 28000.0;
                        break;
                    case "Chairperson":
                        allowance = 750.0;
                        jobSalary = 33000.0;
                        break;
                    case "Guard":
                        allowance = 750.0;
                        jobSalary = 13000.0;
                        break;
                    default:
                        break;

                }

                string currentMonth = DateTime.Now.ToString("MMMM");

                string query = "SELECT SUM(TIME_TO_SEC(totalhours)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) AND empnum = @EmployeeNumber";

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add a parameter to the MySqlCommand for the employee number
                    command.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);

                    // Execute the query and retrieve the totalhours
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {

                        double totalHoursNumeric = Convert.ToDouble(result);

                        textBox2.Text = totalHoursNumeric.ToString();

                        double hourlyRate = jobSalary * 12 / 365 / 8;


                        totalSalary = jobSalary + hourlyRate * totalHoursNumeric;
                        gross = totalSalary + allowance;
                        net = gross - deduction;


                        textBox1.Text = $"₱{hourlyRate.ToString("0.00")}";
                        textBox6.Text = $"₱{totalSalary.ToString("0.00")}";
                        textBox5.Text = $"₱{deduction.ToString("0.00")}";
                        textBox4.Text = $"₱{net.ToString("0.00")}";
                        textBox3.Text = $"₱{jobSalary.ToString("0.00")}";
                    }

                }




            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //STORES EMPLOYEE DATA

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string selectedCellValue1 = selectedRow.Cells[0].Value.ToString();
                string selectedCellValue2 = selectedRow.Cells[1].Value.ToString();
                string selectedCellValue3 = selectedRow.Cells[3].Value.ToString();
                string selectedCellValue4 = selectedRow.Cells[2].Value.ToString();
                string selectedCellValue5 = selectedRow.Cells[10].Value.ToString();
                string selectedCellValue6 = selectedRow.Cells[20].Value.ToString();
                string selectedCellValue7 = selectedRow.Cells[27].Value.ToString();
                string selectedCellValue8 = selectedRow.Cells[19].Value.ToString();

                DateTime dob = DateTime.Parse(selectedCellValue5);
                string dobFormatted = dob.ToString("yyyy-MM-dd");

                DateTime dob2 = DateTime.Parse(selectedCellValue6);
                string dobFormatted2 = dob2.ToString("yyyy-MM-dd");



                string query = "INSERT INTO emp_payroll (employeenum, name, department, occupation, dob, hiredate, gross, deduction, net, accountnum, jobsalary, hourlyrate, date) VALUES (@employeenum, @name, @department, @occupation, @dob, @hiredate, @gross, @deduction, @net, @accountnum, @jobsalary, @hourlyrate, @date)";
                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.Parameters.AddWithValue("@employeenum", selectedCellValue1); //textbox
                cmd.Parameters.AddWithValue("@name", selectedCellValue2); //textbox
                cmd.Parameters.AddWithValue("@department", selectedCellValue3); //textbox
                cmd.Parameters.AddWithValue("@occupation", selectedCellValue4); //textbox
                cmd.Parameters.AddWithValue("@dob", dobFormatted); //textbox
                cmd.Parameters.AddWithValue("@hiredate", dobFormatted2); //textbox
                cmd.Parameters.AddWithValue("@hourlyrate", textBox1.Text); //textbox
                cmd.Parameters.AddWithValue("@accountnum", selectedCellValue8); //textbox
                cmd.Parameters.AddWithValue("@deduction", textBox5.Text); //textbox
                cmd.Parameters.AddWithValue("@net", textBox4.Text); //textbox
                cmd.Parameters.AddWithValue("@gross", textBox6.Text); //textbox
                cmd.Parameters.AddWithValue("@jobsalary", selectedCellValue7); //textbox
                cmd.Parameters.AddWithValue("@date", DateTime.Today);




                cmd.ExecuteNonQuery();


                MessageBox.Show("Payroll success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            this.Close();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
