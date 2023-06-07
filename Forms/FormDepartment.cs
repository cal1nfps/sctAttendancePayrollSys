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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormDepartment : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormDepartment()
        {
            InitializeComponent();
            random = new Random();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            //button1.Click += new System.EventHandler(button1_Click);
            //button2.Click += new System.EventHandler(button2_Click);
        }


        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    //DisableButton();
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

        private void button11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSED1(), sender);
            //FormDepartment.asyncPopulate();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIBED1(), sender);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormASP1(), sender);
        }


        private void FormDepartment_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date; // Get the current date
            string sed = "SED"; // department
            string ibed = "IBED"; // department
            string asp = "ASP"; // department



            try
            {
                connection.Open();

                // Query to count the employees who have time-in today in the specific department
                string querySED = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command = new MySqlCommand(querySED, connection);
                command.Parameters.AddWithValue("@currentDate", currentDate);
                command.Parameters.AddWithValue("@department", sed);

                int sedCount = Convert.ToInt32(command.ExecuteScalar());

                // Count in a label
                labelSedCounter.Text = sedCount.ToString();


                // Query to count the employees who have time-in today in the specific department
                string queryIBED = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command2 = new MySqlCommand(queryIBED, connection);
                command2.Parameters.AddWithValue("@currentDate", currentDate);
                command2.Parameters.AddWithValue("@department", ibed);

                int ibedCount = Convert.ToInt32(command2.ExecuteScalar());

                // Count in a label
                labelIbedCounter.Text = ibedCount.ToString();



                // Query to count the employees who have time-in today in the specific department
                string queryASP = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command3 = new MySqlCommand(queryASP, connection);
                command3.Parameters.AddWithValue("@currentDate", currentDate);
                command3.Parameters.AddWithValue("@department", asp);

                int aspCount = Convert.ToInt32(command3.ExecuteScalar());

                // Count in a label
                labelAspCounter.Text = aspCount.ToString();
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

        /// <summary>
        /// with reference
        /// </summary>

        private void buttonSed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSED1(), sender);
            //FormDepartment.asyncPopulate();
        }

        private void buttonIbed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIBED1(), sender);
        }

        private void buttonAsp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormASP1(), sender);
        }

        private void FormDepartment_Load_1(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date; // Get the current date
            string sed = "SED"; // department
            string ibed = "IBED"; // department
            string asp = "ASP"; // department



            try
            {
                connection.Open();

                // Query to count the employees who have time-in today in the specific department
                string querySED = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command = new MySqlCommand(querySED, connection);
                command.Parameters.AddWithValue("@currentDate", currentDate);
                command.Parameters.AddWithValue("@department", sed);

                int sedCount = Convert.ToInt32(command.ExecuteScalar());

                // Count in a label
                labelSedCounter.Text = sedCount.ToString();


                // Query to count the employees who have time-in today in the specific department
                string queryIBED = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command2 = new MySqlCommand(queryIBED, connection);
                command2.Parameters.AddWithValue("@currentDate", currentDate);
                command2.Parameters.AddWithValue("@department", ibed);

                int ibedCount = Convert.ToInt32(command2.ExecuteScalar());

                // Count in a label
                labelIbedCounter.Text = ibedCount.ToString();



                // Query to count the employees who have time-in today in the specific department
                string queryASP = "SELECT COUNT(*) FROM empattendance WHERE DATE(timein) = @currentDate AND department = @department";
                MySqlCommand command3 = new MySqlCommand(queryASP, connection);
                command3.Parameters.AddWithValue("@currentDate", currentDate);
                command3.Parameters.AddWithValue("@department", asp);

                int aspCount = Convert.ToInt32(command3.ExecuteScalar());

                // Count in a label
                labelAspCounter.Text = aspCount.ToString();
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
