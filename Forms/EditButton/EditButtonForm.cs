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
using System.Drawing;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class EditButtonForm : Form
    {
        private Random random;
        private int tempIndex;
        private Form activeForm = null;

        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;


        public EditButtonForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        public string firstname { get { return textBox2.Text; } set { textBox2.Text = value; } }
        public string middlename { get { return textBox1.Text; } set { textBox1.Text = value; } }
        public string lastname { get { return textBox3.Text; } set { textBox3.Text = value; } }
        public string suffix { get { return textBox10.Text; } set { textBox10.Text = value; } }
        public string gender { get { return comboBox1.Text; } set { comboBox1.Text = value; } }
        public string dob { get { return dateTimePicker1.Text; } set { dateTimePicker1.Text = value; } }
        public string country { get { return comboBox2.Text; } set { comboBox2.Text = value; } }
        public string address { get { return textBox6.Text; } set { textBox6.Text = value; } }
        public string province { get { return comboBox3.Text; } set { comboBox3.Text = value; } }
        public string city { get { return textBox9.Text; } set { textBox9.Text = value; } }
        public string postal { get { return textBox4.Text; } set { textBox4.Text = value; } }
        public string phone { get { return textBox5.Text; } set { textBox5.Text = value; } }
        public string telephone { get { return textBox8.Text; } set { textBox8.Text = value; } }
        public string email { get { return textBox7.Text; } set { textBox7.Text = value; } }
        public string empnum { get { return textBox12.Text; } set { textBox12.Text = value; } }
        public string account { get { return textBox11.Text; } set { textBox11.Text = value; } }
        public string hdate { get { return dateTimePicker2.Text; } set { dateTimePicker2.Text = value; } }
        public string occupation { get { return comboBox4.Text; } set { comboBox4.Text = value; } }
        public string department { get { return comboBox5.Text; } set { comboBox5.Text = value; } }
        public string timein { get { return comboBox6.Text; } set { comboBox6.Text = value; } }
        public string timeout { get { return comboBox7.Text; } set { comboBox7.Text = value; } }
        public string jobstatus { get { return comboBox8.Text; } set { comboBox8.Text = value; } }
        public string jobsalary { get { return textBox14.Text; } set { textBox14.Text = value; } }


        public byte[] image
        {
            get
            {
                ImageConverter converter = new ImageConverter();
                return (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
            }
            set
            {
                if (value != null)
                {
                    ImageConverter converter = new ImageConverter();
                    pictureBox1.Image = (Image)converter.ConvertFrom(value);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }




        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATES EMPLOYEE INFORMATION
            try
            {
                connection.Open();

                string query = "UPDATE employee SET occupation = @occupation, department = @department, jobstatus = @jobstatus, name = @name, firstname = @firstname, middle = @middlename, lastname = @lastname, suffix = @suffix, homenum = @homenum, " +
                    "phonenum = @phonenum, email = @email, address = @address, province = @province, city = @city, postal = @postal, accountnum = @accountnum, timein = @timein, timeout = @timeout, image_data = @imageData, jobsalary = @jobsalary" +
                    " WHERE employeenum = @employeenum";
                MySqlCommand command = new MySqlCommand(query, connection);

                byte[] imageData = ImageToByteArray(pictureBox1.Image);

                command.Parameters.AddWithValue("@occupation", comboBox4.Text);
                command.Parameters.AddWithValue("@department", comboBox5.Text);
                command.Parameters.AddWithValue("@jobstatus", comboBox8.Text);
                command.Parameters.AddWithValue("@firstname", textBox2.Text);
                command.Parameters.AddWithValue("@middlename", textBox1.Text);
                command.Parameters.AddWithValue("@lastname", textBox3.Text);
                command.Parameters.AddWithValue("@suffix", textBox10.Text);
                command.Parameters.AddWithValue("@homenum", textBox8.Text);
                command.Parameters.AddWithValue("@phonenum", textBox5.Text);
                command.Parameters.AddWithValue("@email", textBox7.Text);
                command.Parameters.AddWithValue("@address", textBox6.Text);
                command.Parameters.AddWithValue("@province", comboBox3.Text);
                command.Parameters.AddWithValue("@city", textBox9.Text);
                command.Parameters.AddWithValue("@postal", textBox4.Text);
                command.Parameters.AddWithValue("@accountnum", textBox11.Text);
                command.Parameters.AddWithValue("@timein", comboBox6.Text);
                command.Parameters.AddWithValue("@timeout", comboBox7.Text);
                command.Parameters.AddWithValue("@employeenum", textBox12.Text);
                command.Parameters.AddWithValue("@imageData", imageData);
                command.Parameters.AddWithValue("@jobsalary", textBox14.Text);


                string first = textBox2.Text;
                string middle = textBox1.Text;
                string last = textBox3.Text;
                string suffix = textBox10.Text;
                string name = first + " " + middle + " " + last + " " + suffix;

                command.Parameters.AddWithValue("@name", name); //textbox

                command.ExecuteNonQuery();

                MessageBox.Show("Employee Information Updated Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
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

        private void EditButtonForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
