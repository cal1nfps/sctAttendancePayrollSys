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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //RANDOMIZE NUMBERS FOR EMPLOYEE NUM
            Random random = new Random();
            int randomNumber = random.Next(10000, 99999);
            textBox12.Text = randomNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GIVES A ERROR FOR EMPTY FIELDS
            if (string.IsNullOrEmpty(textBox12.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox3.Text)
                || comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox6.Text) || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox11.Text) || comboBox4.SelectedIndex == -1 || pictureBox1.Image == null || comboBox8.SelectedIndex == -1)
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
                        "accountnum, hiredate, timein, timeout, image_data) VALUES (@employeenum, @name, @occupation, @department, @jobstatus, @firstname, @middle, @lastname, @suffix, @gender, @dob, @homenum, @phonenum, @email, @address, " +
                        "@country, @province, @city, @postal, @accountnum, @hiredate, @timein, @timeout, @imageData)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    byte[] imageData = ImageToByteArray(pictureBox1.Image);


                    cmd.Parameters.AddWithValue("@employeenum", textBox12.Text); //textbox
                    cmd.Parameters.AddWithValue("@firstname", textBox2.Text); //textbox
                    cmd.Parameters.AddWithValue("@middle", textBox1.Text); //textbox
                    cmd.Parameters.AddWithValue("@lastname", textBox3.Text); //textbox
                    cmd.Parameters.AddWithValue("@suffix", textBox10.Text); //textbox
                    cmd.Parameters.AddWithValue("@gender", comboBox1.Text); //combobox
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value); //datetimepicker
                    cmd.Parameters.AddWithValue("@homenum", textBox8.Text); //textbox
                    cmd.Parameters.AddWithValue("@phonenum", textBox5.Text); //textbox
                    cmd.Parameters.AddWithValue("@email", textBox7.Text); //textbox
                    cmd.Parameters.AddWithValue("@address", textBox6.Text); //textbox
                    cmd.Parameters.AddWithValue("@country", comboBox2.Text); //combobox
                    cmd.Parameters.AddWithValue("@province", comboBox3.Text); //combobox
                    cmd.Parameters.AddWithValue("@city", textBox9.Text); //textbox
                    cmd.Parameters.AddWithValue("@postal", textBox4.Text); //textbox
                    cmd.Parameters.AddWithValue("@accountnum", textBox11.Text); //textbox
                    cmd.Parameters.AddWithValue("@hiredate", dateTimePicker2.Value); //datetimepicker
                    cmd.Parameters.AddWithValue("@occupation", comboBox4.Text); //combobox
                    cmd.Parameters.AddWithValue("@department", comboBox5.Text); //combobox
                    cmd.Parameters.AddWithValue("@jobstatus", comboBox8.Text); //combobox
                    cmd.Parameters.AddWithValue("@timein", comboBox6.Text); //combobox
                    cmd.Parameters.AddWithValue("@timeout", comboBox7.Text); //combobox
                    cmd.Parameters.AddWithValue("@imageData", imageData);



                    string first = textBox2.Text;
                    string middle = textBox1.Text;
                    string last = textBox3.Text;
                    string suffix = textBox10.Text;
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

        private void button2_Click(object sender, EventArgs e)
        {
            //UPLOAD AND DISPLAYS IMAGE

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(imagePath);

                // Set the position of the image within the PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                return memoryStream.ToArray();
            }
        }

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //LIMITS DIGITS NUMBERS FOR PHONE NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("You can only enter 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
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
    }
}
