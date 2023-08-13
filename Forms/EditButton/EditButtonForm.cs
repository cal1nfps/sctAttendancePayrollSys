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
        public string city { get { return comboBox9.Text; } set { comboBox9.Text = value; } }
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
                command.Parameters.AddWithValue("@city", comboBox9.Text);
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


            {
                // Populate ComboBox1 with provinces
                comboBox3.Items.Add("Abra");
                comboBox3.Items.Add("Agusan del Norte");
                comboBox3.Items.Add("Agusan del Sur");
                comboBox3.Items.Add("Aklan");
                comboBox3.Items.Add("Albay");
                comboBox3.Items.Add("Antique");
                comboBox3.Items.Add("Apayao");
                comboBox3.Items.Add("Aurora");
                comboBox3.Items.Add("Basilan");
                comboBox3.Items.Add("Bataan");
                comboBox3.Items.Add("Batanes");
                comboBox3.Items.Add("Batangas");
                comboBox3.Items.Add("Benguet");
                comboBox3.Items.Add("Biliran");
                comboBox3.Items.Add("Bohol");
                comboBox3.Items.Add("Bukidnon");
                comboBox3.Items.Add("Bulacan");
                comboBox3.Items.Add("Cagayan");
                comboBox3.Items.Add("Camarines Norte");
                comboBox3.Items.Add("Camarines Sur");
                comboBox3.Items.Add("Camiguin");
                comboBox3.Items.Add("Capiz");
                comboBox3.Items.Add("Catanduanes");
                comboBox3.Items.Add("Cavite");
                comboBox3.Items.Add("Cebu");
                comboBox3.Items.Add("Cotabato");
                comboBox3.Items.Add("Davao de Oro");
                comboBox3.Items.Add("Davao del Norte");
                comboBox3.Items.Add("Davao del Sur");
                comboBox3.Items.Add("Davao Occidental");
                comboBox3.Items.Add("Davao Oriental");
                comboBox3.Items.Add("Dinagat Islands");
                comboBox3.Items.Add("Eastern Samar");
                comboBox3.Items.Add("Guimaras");
                comboBox3.Items.Add("Ifugao");
                comboBox3.Items.Add("Ilocos Norte");
                comboBox3.Items.Add("Ilocos Sur");
                comboBox3.Items.Add("Iloilo");
                comboBox3.Items.Add("Isabela");
                comboBox3.Items.Add("Kalinga");
                comboBox3.Items.Add("La Union");
                comboBox3.Items.Add("Laguna");
                comboBox3.Items.Add("Lanao del Norte");
                comboBox3.Items.Add("Lanao del Sur");
                comboBox3.Items.Add("Leyte");
                comboBox3.Items.Add("Maguindanao del Norte");
                comboBox3.Items.Add("Maguindanao del Sur");
                comboBox3.Items.Add("Marinduque");
                comboBox3.Items.Add("Masbate");
                comboBox3.Items.Add("Misamis Occidental");
                comboBox3.Items.Add("Misamis Oriental");
                comboBox3.Items.Add("Mountain Province");
                comboBox3.Items.Add("Negros Occidental");
                comboBox3.Items.Add("Negros Oriental");
                comboBox3.Items.Add("Northern Samar");
                comboBox3.Items.Add("Nueva Ecija");
                comboBox3.Items.Add("Nueva Vizcaya");
                comboBox3.Items.Add("Occidental Mindoro");
                comboBox3.Items.Add("Oriental Mindoro");
                comboBox3.Items.Add("Palawan");
                comboBox3.Items.Add("Pampanga");
                comboBox3.Items.Add("Pangasinan");
                comboBox3.Items.Add("Quezon");
                comboBox3.Items.Add("Quirino");
                comboBox3.Items.Add("Rizal");
                comboBox3.Items.Add("Romblon");
                comboBox3.Items.Add("Samar");
                comboBox3.Items.Add("Sarangani");
                comboBox3.Items.Add("Siquijor");
                comboBox3.Items.Add("Sorsogon");
                comboBox3.Items.Add("South Cotabato");
                comboBox3.Items.Add("Southern Leyte");
                comboBox3.Items.Add("Sultan Kudarat");
                comboBox3.Items.Add("Sulu");
                comboBox3.Items.Add("Surigao del Norte");
                comboBox3.Items.Add("Surigao del Sur");
                comboBox3.Items.Add("Tarlac");
                comboBox3.Items.Add("Tawi-Tawi");
                comboBox3.Items.Add("Zambales");
                comboBox3.Items.Add("Zamboanga del Norte");
                comboBox3.Items.Add("Zamboanga del Sur");
                comboBox3.Items.Add("Zamboanga Sibugay");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                // Clear existing items in ComboBox2
                comboBox9.Items.Clear();

                // Get the selected province from ComboBox1
                string selectedProvince = comboBox3.SelectedItem.ToString();

                // Populate ComboBox2 based on the selected province
                switch (selectedProvince)
                {
                    case "Abra":
                        comboBox9.Items.Add("Bangued");
                        comboBox9.Items.Add("Boliney");
                        comboBox9.Items.Add("Bucay");
                        break;
                    case "Agusan del Norte":
                        comboBox9.Items.Add("Cabadbaran");
                        comboBox9.Items.Add("Butuan");
                        break;
                    case "Agusan del Sur":
                        comboBox9.Items.Add("Bayugan");
                        comboBox9.Items.Add("San Francisco");
                        break;
                    case "Aklan":
                        comboBox9.Items.Add("Kalibo");
                        comboBox9.Items.Add("Banga");
                        break;
                    case "Albay":
                        comboBox9.Items.Add("Legazpi");
                        comboBox9.Items.Add("Ligao");
                        break;
                    case "Antique":
                        comboBox9.Items.Add("San Jose");
                        comboBox9.Items.Add("Sibalom");
                        break;
                    case "Apayao":
                        comboBox9.Items.Add("Kabugao");
                        comboBox9.Items.Add("Conner");
                        break;
                    case "Aurora":
                        comboBox9.Items.Add("Baler");
                        comboBox9.Items.Add("Dipaculao");
                        break;
                    case "Basilan":
                        comboBox9.Items.Add("Isabela City");
                        comboBox9.Items.Add("Lamitan");
                        break;
                    case "Bataan":
                        comboBox9.Items.Add("Balanga");
                        comboBox9.Items.Add("Orani");
                        break;
                    case "Batanes":
                        comboBox9.Items.Add("Basco");
                        comboBox9.Items.Add("Itbayat");
                        break;
                    case "Batangas":
                        comboBox9.Items.Add("Batangas City");
                        comboBox9.Items.Add("Lipa");
                        break;
                    case "Benguet":
                        comboBox9.Items.Add("Baguio");
                        comboBox9.Items.Add("La Trinidad");
                        break;
                    case "Biliran":
                        comboBox9.Items.Add("Naval");
                        comboBox9.Items.Add("Caibiran");
                        break;
                    case "Bohol":
                        comboBox9.Items.Add("Tagbilaran");
                        comboBox9.Items.Add("Panglao");
                        break;
                    case "Bukidnon":
                        comboBox9.Items.Add("Malaybalay");
                        comboBox9.Items.Add("Valencia");
                        break;
                    case "Bulacan":
                        comboBox9.Items.Add("Malolos");
                        comboBox9.Items.Add("Meycauayan");
                        break;
                    case "Cagayan":
                        comboBox9.Items.Add("Tuguegarao");
                        comboBox9.Items.Add("Aparri");
                        break;
                    case "Camarines Norte":
                        comboBox9.Items.Add("Daet");
                        comboBox9.Items.Add("Labo");
                        break;
                    case "Camarines Sur":
                        comboBox9.Items.Add("Naga");
                        comboBox9.Items.Add("Iriga");
                        break;
                    case "Camiguin":
                        comboBox9.Items.Add("Mambajao");
                        comboBox9.Items.Add("Mahinog");
                        break;
                    case "Capiz":
                        comboBox9.Items.Add("Roxas City");
                        comboBox9.Items.Add("Panay");
                        break;
                    case "Catanduanes":
                        comboBox9.Items.Add("Virac");
                        comboBox9.Items.Add("San Andres");
                        break;
                    case "Cavite":
                        comboBox9.Items.Add("Cavite City");
                        comboBox9.Items.Add("Dasmariñas");
                        break;
                    case "Cebu":
                        comboBox9.Items.Add("Cebu City");
                        comboBox9.Items.Add("Mandaue");
                        break;
                    case "Cotabato":
                        comboBox9.Items.Add("Kidapawan");
                        comboBox9.Items.Add("Cotabato City");
                        break;
                    case "Davao de Oro":
                        comboBox9.Items.Add("Nabunturan");
                        comboBox9.Items.Add("Mawab");
                        break;
                    case "Davao del Norte":
                        comboBox9.Items.Add("Tagum");
                        comboBox9.Items.Add("Panabo");
                        break;
                    case "Davao del Sur":
                        comboBox9.Items.Add("Digos");
                        comboBox9.Items.Add("Bansalan");
                        break;
                    case "Davao Occidental":
                        comboBox9.Items.Add("Malita");
                        comboBox9.Items.Add("Santa Maria");
                        break;
                    case "Davao Oriental":
                        comboBox9.Items.Add("Mati");
                        comboBox9.Items.Add("Baganga");
                        break;
                    case "Dinagat Islands":
                        comboBox9.Items.Add("San Jose");
                        comboBox9.Items.Add("Dinagat");
                        break;
                    case "Eastern Samar":
                        comboBox9.Items.Add("Borongan");
                        comboBox9.Items.Add("Guiuan");
                        break;
                    case "Guimaras":
                        comboBox9.Items.Add("Jordan");
                        comboBox9.Items.Add("Buenavista");
                        break;
                    case "Ifugao":
                        comboBox9.Items.Add("Lagawe");
                        comboBox9.Items.Add("Kiangan");
                        break;
                    case "Ilocos Norte":
                        comboBox9.Items.Add("Laoag");
                        comboBox9.Items.Add("Pagudpud");
                        break;
                    case "Ilocos Sur":
                        comboBox9.Items.Add("Vigan");
                        comboBox9.Items.Add("Candon");
                        break;
                    case "Iloilo":
                        comboBox9.Items.Add("Iloilo City");
                        comboBox9.Items.Add("Oton");
                        break;
                    case "Isabela":
                        comboBox9.Items.Add("Ilagan");
                        comboBox9.Items.Add("Cauayan");
                        break;
                    case "Kalinga":
                        comboBox9.Items.Add("Tabuk");
                        comboBox9.Items.Add("Balbalan");
                        break;
                    case "La Union":
                        comboBox9.Items.Add("San Fernando");
                        comboBox9.Items.Add("Agoo");
                        break;
                    case "Laguna":
                        comboBox9.Items.Add("Calamba");
                        comboBox9.Items.Add("San Pablo");
                        break;
                    case "Lanao del Norte":
                        comboBox9.Items.Add("Iligan");
                        comboBox9.Items.Add("Tubod");
                        break;
                    case "Lanao del Sur":
                        comboBox9.Items.Add("Marawi");
                        comboBox9.Items.Add("Sultan Dumalondong");
                        break;
                    case "Leyte":
                        comboBox9.Items.Add("Tacloban");
                        comboBox9.Items.Add("Ormoc");
                        break;
                    case "Maguindanao del Norte":
                        comboBox9.Items.Add("Cotabato City");
                        comboBox9.Items.Add("Buluan");
                        break;
                    case "Maguindanao del Sur":
                        comboBox9.Items.Add("Shariff Aguak");
                        comboBox9.Items.Add("Sultan Kudarat");
                        break;
                    case "Marinduque":
                        comboBox9.Items.Add("Boac");
                        comboBox9.Items.Add("Mogpog");
                        break;
                    case "Masbate":
                        comboBox9.Items.Add("Masbate City");
                        comboBox9.Items.Add("Aroroy");
                        break;
                    case "Misamis Occidental":
                        comboBox9.Items.Add("Oroquieta");
                        comboBox9.Items.Add("Ozamiz");
                        break;
                    case "Misamis Oriental":
                        comboBox9.Items.Add("Cagayan de Oro");
                        comboBox9.Items.Add("Gingoog");
                        break;
                    case "Mountain Province":
                        comboBox9.Items.Add("Bontoc");
                        comboBox9.Items.Add("Sagada");
                        break;
                    case "Negros Occidental":
                        comboBox9.Items.Add("Bacolod");
                        comboBox9.Items.Add("Silay");
                        break;
                    case "Negros Oriental":
                        comboBox9.Items.Add("Dumaguete");
                        comboBox9.Items.Add("Bais");
                        break;
                    case "Northern Samar":
                        comboBox9.Items.Add("Catarman");
                        comboBox9.Items.Add("Laoang");
                        break;
                    case "Nueva Ecija":
                        comboBox9.Items.Add("Palayan");
                        comboBox9.Items.Add("Cabanatuan");
                        break;
                    case "Nueva Vizcaya":
                        comboBox9.Items.Add("Bayombong");
                        comboBox9.Items.Add("Solano");
                        break;
                    case "Occidental Mindoro":
                        comboBox9.Items.Add("Mamburao");
                        comboBox9.Items.Add("San Jose");
                        break;
                    case "Oriental Mindoro":
                        comboBox9.Items.Add("Calapan");
                        comboBox9.Items.Add("Baco");
                        break;
                    case "Palawan":
                        comboBox9.Items.Add("Puerto Princesa");
                        comboBox9.Items.Add("Coron");
                        break;
                    case "Pampanga":
                        comboBox9.Items.Add("San Fernando");
                        comboBox9.Items.Add("Angeles");
                        break;
                    case "Pangasinan":
                        comboBox9.Items.Add("Dagupan");
                        comboBox9.Items.Add("Urdaneta");
                        break;
                    case "Quezon":
                        comboBox9.Items.Add("Lucena");
                        comboBox9.Items.Add("Tayabas");
                        break;
                    case "Rizal":
                        comboBox9.Items.Add("Antipolo");
                        comboBox9.Items.Add("Rodriguez");
                        comboBox9.Items.Add("Binangonan");
                        comboBox9.Items.Add("Taytay");
                        comboBox9.Items.Add("Angono");
                        comboBox9.Items.Add("Tanay");
                        comboBox9.Items.Add("Cainta");
                        comboBox9.Items.Add("San Mateo");
                        comboBox9.Items.Add("Baras");
                        comboBox9.Items.Add("Cardona");
                        break;
                    case "Romblon":
                        comboBox9.Items.Add("Romblon");
                        comboBox9.Items.Add("Odiongan");
                        break;
                    case "Samar":
                        comboBox9.Items.Add("Catbalogan");
                        comboBox9.Items.Add("Calbayog");
                        break;
                    case "Sarangani":
                        comboBox9.Items.Add("Alabel");
                        comboBox9.Items.Add("Kiamba");
                        break;
                    case "Siquijor":
                        comboBox9.Items.Add("Siquijor");
                        comboBox9.Items.Add("Larena");
                        break;
                    case "Sorsogon":
                        comboBox9.Items.Add("Sorsogon City");
                        comboBox9.Items.Add("Bulan");
                        break;
                    case "South Cotabato":
                        comboBox9.Items.Add("Koronadal");
                        comboBox9.Items.Add("Surallah");
                        break;
                    case "Southern Leyte":
                        comboBox9.Items.Add("Maasin");
                        comboBox9.Items.Add("Sogod");
                        break;
                    case "Sultan Kudarat":
                        comboBox9.Items.Add("Isulan");
                        comboBox9.Items.Add("Tacurong");
                        break;
                    case "Sulu":
                        comboBox9.Items.Add("Jolo");
                        comboBox9.Items.Add("Panglima Sugala");
                        break;
                    case "Surigao del Norte":
                        comboBox9.Items.Add("Surigao City");
                        comboBox9.Items.Add("Siargao");
                        break;
                    case "Surigao del Sur":
                        comboBox9.Items.Add("Tandag");
                        comboBox9.Items.Add("Bislig");
                        break;
                    case "Tarlac":
                        comboBox9.Items.Add("Tarlac City");
                        comboBox9.Items.Add("Paniqui");
                        break;
                    case "Tawi-Tawi":
                        comboBox9.Items.Add("Bongao");
                        comboBox9.Items.Add("Panglima Sugala");
                        break;
                    case "Zambales":
                        comboBox9.Items.Add("Olongapo");
                        comboBox9.Items.Add("Iba");
                        break;
                    case "Zamboanga del Norte":
                        comboBox9.Items.Add("Dipolog");
                        comboBox9.Items.Add("Dapitan");
                        break;
                    case "Zamboanga del Sur":
                        comboBox9.Items.Add("Pagadian");
                        comboBox9.Items.Add("Zamboanga City");
                        break;
                    case "Zamboanga Sibugay":
                        comboBox9.Items.Add("Ipil");
                        comboBox9.Items.Add("Kabasalan");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
