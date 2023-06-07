using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Xml.Linq;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class AddEmployeeButtonForm : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm = null;

        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        private bool isDragging;
        private Point dragStartPoint;
        private Point imageStartPosition;


        public AddEmployeeButtonForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);

            //TEXTBOX FOCUS
            //this.ActiveControl = FirstName;
            //FirstName.Focus();
        }


        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            //GIVES A ERROR FOR EMPTY FIELDS
            if (string.IsNullOrEmpty(EmployeeNum.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(MiddleName.Text) || string.IsNullOrEmpty(LastName.Text)
                || Gender.SelectedIndex == -1 || string.IsNullOrEmpty(Telephone.Text) || string.IsNullOrEmpty(MobilePhone.Text) || string.IsNullOrEmpty(Email.Text) ||
                string.IsNullOrEmpty(Address.Text) || Country.SelectedIndex == -1 || Province.SelectedIndex == -1 || string.IsNullOrEmpty(City.Text) ||
                string.IsNullOrEmpty(PostalCode.Text) || string.IsNullOrEmpty(AccNum.Text) || Occupation.SelectedIndex == -1 || ProfilePic.Image == null || JobStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox14.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //STORES EMPLOYEE DATA
                    connection.Open();

                    string query = "INSERT INTO employee (employeenum, name, occupation, department, jobstatus, firstname, middle, lastname, suffix, gender, dob, homenum, phonenum, email, address, country, province, city, postal, " +
                        "accountnum, hiredate, timein, timeout, image_data, jobsalary) VALUES (@employeenum, @name, @occupation, @department, @jobstatus, @firstname, @middle, @lastname, @suffix, @gender, @dob, @homenum, @phonenum, @email, @address, " +
                        "@country, @province, @city, @postal, @accountnum, @hiredate, @timein, @timeout, @imageData, @jobsalary)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    byte[] imageData = ImageToByteArray(ProfilePic.Image);


                    cmd.Parameters.AddWithValue("@employeenum", EmployeeNum.Text); //textbox
                    cmd.Parameters.AddWithValue("@firstname", FirstName.Text); //textbox
                    cmd.Parameters.AddWithValue("@middle", MiddleName.Text); //textbox
                    cmd.Parameters.AddWithValue("@lastname", LastName.Text); //textbox
                    cmd.Parameters.AddWithValue("@suffix", Suffix.Text); //textbox
                    cmd.Parameters.AddWithValue("@gender", Gender.Text); //combobox
                    cmd.Parameters.AddWithValue("@dob", DateOfBirth.Value); //datetimepicker
                    cmd.Parameters.AddWithValue("@homenum", Telephone.Text); //textbox
                    cmd.Parameters.AddWithValue("@phonenum", MobilePhone.Text); //textbox
                    cmd.Parameters.AddWithValue("@email", Email.Text); //textbox
                    cmd.Parameters.AddWithValue("@address", Address.Text); //textbox
                    cmd.Parameters.AddWithValue("@country", Country.Text); //combobox
                    cmd.Parameters.AddWithValue("@province", Province.Text); //combobox
                    cmd.Parameters.AddWithValue("@city", City.Text); //textbox
                    cmd.Parameters.AddWithValue("@postal", PostalCode.Text); //textbox
                    cmd.Parameters.AddWithValue("@accountnum", AccNum.Text); //textbox
                    cmd.Parameters.AddWithValue("@hiredate", HireDate.Value); //datetimepicker
                    cmd.Parameters.AddWithValue("@occupation", Occupation.Text); //combobox
                    cmd.Parameters.AddWithValue("@department", Department.Text); //combobox
                    cmd.Parameters.AddWithValue("@jobstatus", JobStatus.Text); //combobox
                    cmd.Parameters.AddWithValue("@timein", TimeIn.Text); //combobox
                    cmd.Parameters.AddWithValue("@timeout", TimeOut.Text); //combobox
                    cmd.Parameters.AddWithValue("@imageData", imageData);
                    cmd.Parameters.AddWithValue("@jobsalary", textBox14.Text); //combobox




                    string first = FirstName.Text;
                    string middle = MiddleName.Text;
                    string last = LastName.Text;
                    string suffix = Suffix.Text;
                    string name = first + " " + middle + " " + last + " " + suffix;

                    cmd.Parameters.AddWithValue("@name", name); //textbox


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee data saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }


            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            //LIMITS DIGITS NUMBERS FOR HOME NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("You can only enter 8 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //UPLOAD AND DISPLAYS IMAGE

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                ProfilePic.Image = Image.FromFile(imagePath);

                // Set the position of the image within the PictureBox
                ProfilePic.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //RANDOMIZE NUMBERS FOR EMPLOYEE NUM
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            EmployeeNum.Text = randomNumber.ToString();
        }


        private void AddEmployeeButtonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


    }
}
