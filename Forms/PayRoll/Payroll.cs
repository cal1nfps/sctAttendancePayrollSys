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
using Microsoft.Kiota.Abstractions;

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

            dataGridView1.Columns[0].Width = 140;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[17].Width = 190;

            dataGridView1.AutoGenerateColumns = false;


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
                TimeSpan jobHours = (TimeSpan)row.Cells["jobhours"].Value;
                double jobHoursNumeric = jobHours.TotalHours;


                double totalSalary = 0.0;
                double allowance = 0.0;
                double gross = 0.0;
                double sss = 675.0;
                double ph = 300.0;
                double pagibig = 100.0;
                double deduction = 0.0; //SSS: 675, PAGIBIG: 100, PHILHEALTH: 300
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
                if (filterComboBox.SelectedItem.ToString() == "MONTHLY")
                {
                    string totalHoursQuery = "SELECT SUM(TIME_TO_SEC(totalhours)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) AND empnum = @EmployeeNumber";
                    string undertimeQuery = "SELECT SUM(TIME_TO_SEC(undertime)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) AND empnum = @EmployeeNumber";
                    string lateQuery = "SELECT SUM(TIME_TO_SEC(late)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) AND empnum = @EmployeeNumber";
                    string overtimeQuery = "SELECT SUM(TIME_TO_SEC(overtimehours)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) AND empnum = @EmployeeNumber";


                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (MySqlCommand totalHoursCommand = new MySqlCommand(totalHoursQuery, connection))
                    using (MySqlCommand undertimeCommand = new MySqlCommand(undertimeQuery, connection))
                    using (MySqlCommand lateCommand = new MySqlCommand(lateQuery, connection))
                    using (MySqlCommand overtimeCommand = new MySqlCommand(overtimeQuery, connection))
                    {
                        totalHoursCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        undertimeCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        lateCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        overtimeCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);


                        double overtimeHours = 0;
                        double totalHours = 0;
                        double undertime = 0;
                        double late = 0;

                        object totalHoursResult = totalHoursCommand.ExecuteScalar();
                        object undertimeResult = undertimeCommand.ExecuteScalar();
                        object lateResult = lateCommand.ExecuteScalar();
                        object overtimeResult = overtimeCommand.ExecuteScalar();

                        if (totalHoursResult != DBNull.Value)
                            totalHours = Convert.ToDouble(totalHoursResult);

                        if (undertimeResult != DBNull.Value)
                            undertime = Convert.ToDouble(undertimeResult);

                        if (lateResult != DBNull.Value)
                            late = Convert.ToDouble(lateResult);

                        if (overtimeResult != DBNull.Value)
                            overtimeHours += Convert.ToDouble(overtimeResult);

                        double otHours = overtimeHours / jobHoursNumeric * 100;

                        double contributions = sss + pagibig + ph;
                        double hourlyRate = jobSalary * 12 / 365 / jobHoursNumeric;
                        deduction = late + undertime + contributions;
                        totalSalary = jobSalary + hourlyRate + otHours * totalHours;
                        gross = totalSalary + allowance;
                        net = gross - deduction;

                        textBox6.Text = $"₱{gross.ToString("0.00")}";
                        textBox5.Text = $"₱{deduction.ToString("0.00")}";
                        textBox4.Text = $"₱{net.ToString("0.00")}";


                        //Deduction
                        textBox16.Text = $"₱{contributions.ToString("0.00")}";
                        textBox7.Text = undertime.ToString();
                        textBox8.Text = late.ToString();

                        //Net Pay
                        textBox14.Text = $"₱{gross.ToString("0.00")}";
                        textBox15.Text = $"₱{deduction.ToString("0.00")}";

                        //Gross Pay
                        textBox13.Text = $"₱{totalSalary.ToString("0.00")}";
                        textBox12.Text = $"₱{allowance.ToString("0.00")}";

                        //Total Salary
                        textBox2.Text = totalHours.ToString();
                        textBox9.Text = overtimeHours.ToString();
                        textBox1.Text = $"₱{hourlyRate.ToString("0.00")}";
                        textBox11.Text = $"₱{jobSalary.ToString("0.00")}";
                        textBox3.Text = $"₱{totalSalary.ToString("0.00")}";
                    }
                }

                if (filterComboBox.SelectedItem.ToString() == "SEMI-MONTHLY")
                {
                    string totalHoursQuery = "SELECT SUM(TIME_TO_SEC(totalhours)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) / 2 AND empnum = @EmployeeNumber";
                    string undertimeQuery = "SELECT SUM(TIME_TO_SEC(undertime)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) / 2 AND empnum = @EmployeeNumber";
                    string lateQuery = "SELECT SUM(TIME_TO_SEC(late)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) / 2 AND empnum = @EmployeeNumber";
                    string overtimeQuery = "SELECT SUM(TIME_TO_SEC(overtimehours)) / 3600 AS TotalHours FROM empattendance WHERE MONTH(date) = MONTH(CURRENT_DATE()) / 2 AND empnum = @EmployeeNumber";


                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (MySqlCommand totalHoursCommand = new MySqlCommand(totalHoursQuery, connection))
                    using (MySqlCommand undertimeCommand = new MySqlCommand(undertimeQuery, connection))
                    using (MySqlCommand lateCommand = new MySqlCommand(lateQuery, connection))
                    using (MySqlCommand overtimeCommand = new MySqlCommand(overtimeQuery, connection))
                    {
                        totalHoursCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        undertimeCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        lateCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);
                        overtimeCommand.Parameters.AddWithValue("@EmployeeNumber", employeeNumber);

                        double overtimeHours = 0;
                        double totalHours = 0;
                        double undertime = 0;
                        double late = 0;

                        object totalHoursResult = totalHoursCommand.ExecuteScalar();
                        object undertimeResult = undertimeCommand.ExecuteScalar();
                        object lateResult = lateCommand.ExecuteScalar();
                        object overtimeResult = overtimeCommand.ExecuteScalar();


                        if (totalHoursResult != DBNull.Value)
                            totalHours = Convert.ToDouble(totalHoursResult);

                        if (undertimeResult != DBNull.Value)
                            undertime = Convert.ToDouble(undertimeResult);

                        if (lateResult != DBNull.Value)
                            late = Convert.ToDouble(lateResult);

                        if (overtimeResult != DBNull.Value)
                            overtimeHours += Convert.ToDouble(overtimeResult);


                        double totalJobSalary = jobSalary / 2;
                        double hourlyRate = totalJobSalary * 12 / 365 / jobHoursNumeric;
                        double contributions = sss + pagibig + ph / 2;

                        double otHours = overtimeHours / jobHoursNumeric * 100;

                        deduction = contributions + undertime + late;
                        totalSalary = totalJobSalary + hourlyRate + otHours * totalHours;
                        gross = totalSalary + allowance;
                        net = gross - deduction;

                        textBox6.Text = $"₱{gross.ToString("0.00")}";
                        textBox5.Text = $"₱{deduction.ToString("0.00")}";
                        textBox4.Text = $"₱{net.ToString("0.00")}";
                        textBox2.Text = totalHours.ToString();

                        //Deduction
                        textBox16.Text = $"₱{contributions.ToString("0.00")}";
                        textBox7.Text = undertime.ToString();
                        textBox8.Text = late.ToString();


                        //Net Pay
                        textBox14.Text = $"₱{gross.ToString("0.00")}";
                        textBox15.Text = $"₱{deduction.ToString("0.00")}";

                        //Gross Pay
                        textBox13.Text = $"₱{totalSalary.ToString("0.00")}";
                        textBox12.Text = $"₱{allowance.ToString("0.00")}";

                        //Total Salary
                        textBox2.Text = totalHours.ToString();
                        textBox9.Text = overtimeHours.ToString();
                        textBox1.Text = $"₱{hourlyRate.ToString("0.00")}";
                        textBox11.Text = $"₱{totalJobSalary.ToString("0.00")}";
                        textBox3.Text = $"₱{totalSalary.ToString("0.00")}";

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
                string employeenum = selectedRow.Cells[0].Value.ToString();
                string name = selectedRow.Cells[1].Value.ToString();
                string department = selectedRow.Cells[3].Value.ToString();
                string occupation = selectedRow.Cells[2].Value.ToString();
                string selectedCellValue5 = selectedRow.Cells[10].Value.ToString();
                string selectedCellValue6 = selectedRow.Cells[20].Value.ToString();
                string jobsalary = selectedRow.Cells[27].Value.ToString();
                string accountnum = selectedRow.Cells[19].Value.ToString();
                string image = selectedRow.Cells[23].Value.ToString();

                DateTime dob = DateTime.Parse(selectedCellValue5);
                string dobFormatted = dob.ToString("yyyy-MM-dd");

                DateTime dob2 = DateTime.Parse(selectedCellValue6);
                string dobFormatted2 = dob2.ToString("yyyy-MM-dd");



                string query = "INSERT INTO emp_payroll (employeenum, name, department, occupation, dob, hiredate, gross, deduction, net, accountnum, jobsalary, hourlyrate, date, " +
                    "payrolltype, overtimehours, undertime, late, totalhours, salary, allowance, totalsalary, contributions) VALUES (@employeenum, @name, @department, @occupation, @dob, @hiredate, " +
                    "@gross, @deduction, @net, @accountnum, @jobsalary, @hourlyrate, @date, @payrolltype, @overtimehours, @undertime, @late, @totalhours, @salary, @allowance, @totalsalary, @contributions)";
                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.Parameters.AddWithValue("@employeenum", employeenum); //textbox
                cmd.Parameters.AddWithValue("@name", name); //textbox
                cmd.Parameters.AddWithValue("@department", department); //textbox
                cmd.Parameters.AddWithValue("@occupation", occupation); //textbox
                cmd.Parameters.AddWithValue("@dob", dobFormatted); //textbox
                cmd.Parameters.AddWithValue("@hiredate", dobFormatted2); //textbox
                cmd.Parameters.AddWithValue("@hourlyrate", textBox1.Text); //textbox
                cmd.Parameters.AddWithValue("@accountnum", accountnum); //textbox
                cmd.Parameters.AddWithValue("@deduction", textBox5.Text); //textbox
                cmd.Parameters.AddWithValue("@net", textBox4.Text); //textbox
                cmd.Parameters.AddWithValue("@gross", textBox6.Text); //textbox
                cmd.Parameters.AddWithValue("@jobsalary", jobsalary); //textbox
                cmd.Parameters.AddWithValue("@overtimehours", textBox9.Text); //textbox
                cmd.Parameters.AddWithValue("@undertime", textBox7.Text); //textbox
                cmd.Parameters.AddWithValue("@late", textBox8.Text); //textbox
                cmd.Parameters.AddWithValue("@totalhours", textBox2.Text); //textbox
                cmd.Parameters.AddWithValue("@salary", textBox11.Text); //textbox
                cmd.Parameters.AddWithValue("@allowance", textBox12.Text); //textbox
                cmd.Parameters.AddWithValue("@totalsalary", textBox3.Text); //textbox
                cmd.Parameters.AddWithValue("@contributions", textBox16.Text); //textbox
                cmd.Parameters.AddWithValue("@payrolltype", filterComboBox.Text); //textbox


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
    }
}
