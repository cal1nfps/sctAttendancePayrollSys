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
            dataGridView1.Columns["emp_img"].Visible = false;    //Hide a specific column


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
            if (e.RowIndex >= 0)
            {
                // Get the value of the selected cell
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string value1 = row.Cells[17].Value.ToString();

                // Display the value in a TextBox
                textBox1.Text = value1;
            }


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string occupation = row.Cells["occupation"].Value.ToString();
                double hourlyRate = 0.0;
                double totalHours = 0.0;
                double salary = 0.0;
                double allowance = 0.0;
                double gross = 0.0;
                double deduction = 1200.0;
                double net = 0.0;

                switch (occupation)
                {
                    case "Teacher":
                        hourlyRate = 50.0;
                        totalHours = 40.0;
                        allowance = 120.0;
                        break;
                    case "Sports Coach":
                        hourlyRate = 30.0;
                        totalHours = 40.0;
                        allowance = 120.0;
                        break;
                    case "School Nurse":
                        hourlyRate = 20.0;
                        totalHours = 40.0;
                        allowance = 120.0;
                        break;
                    case "Maintenance Technician":
                        hourlyRate = 10.0;
                        totalHours = 20.0;
                        allowance = 120.0;
                        break;
                    case "Registrar":
                        hourlyRate = 25.0;
                        totalHours = 40.0;
                        allowance = 120.0;
                        break;
                    case "Guidance Counselor":
                        hourlyRate = 35.0;
                        totalHours = 40.0;
                        allowance = 120.0;
                        break;
                    case "Guard":
                        hourlyRate = 20.0;
                        totalHours = 60.0;
                        allowance = 120.0;
                        break;
                    default:
                        break;

                }

                salary = hourlyRate * totalHours;
                gross = salary + allowance;
                net = gross - deduction;

                textBox1.Text = hourlyRate.ToString();
                textBox2.Text = totalHours.ToString();
                textBox3.Text = salary.ToString();
                textBox6.Text = gross.ToString();
                textBox5.Text = deduction.ToString();
                textBox4.Text = net.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //STORES EMPLOYEE DATA
                connection.Open();

                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                string selectedCellValue1 = selectedRow.Cells[0].Value.ToString();
                string selectedCellValue2 = selectedRow.Cells[1].Value.ToString();

                string query = "INSERT INTO emp_payroll (employeenum, name, gross, deduction, net) VALUES (@employeenum, @name, @gross, @deduction, @net)";
                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.Parameters.AddWithValue("@employeenum", selectedCellValue1); //textbox
                cmd.Parameters.AddWithValue("@name", selectedCellValue2); //textbox
                cmd.Parameters.AddWithValue("@gross", textBox6.Text); //textbox
                cmd.Parameters.AddWithValue("@deduction", textBox5.Text); //textbox
                cmd.Parameters.AddWithValue("@net", textBox4.Text); //textbox
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
