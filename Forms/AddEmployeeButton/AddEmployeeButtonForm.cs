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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class AddEmployeeButtonForm : Form
    {
        System.Windows.Forms.Button currentButton;
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
            if (string.IsNullOrEmpty(EmployeeNum.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(MiddleName.Text) || string.IsNullOrEmpty(LastName.Text)
                || Gender.SelectedIndex == -1 || string.IsNullOrEmpty(Telephone.Text) || string.IsNullOrEmpty(MobilePhone.Text) || string.IsNullOrEmpty(Email.Text) ||
                string.IsNullOrEmpty(Address.Text) || Country.SelectedIndex == -1 || Province.SelectedIndex == -1 || comboBox1.SelectedIndex == -1 ||
                string.IsNullOrEmpty(PostalCode.Text) || string.IsNullOrEmpty(AccNum.Text) || Occupation.SelectedIndex == -1 || string.IsNullOrEmpty(textBox14.Text) ||
                ProfilePic.Image == null || JobStatus.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox14.Text))
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
                    cmd.Parameters.AddWithValue("@city", comboBox1.Text); //textbox
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
                    this.Close();
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

        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // LIMITS DIGITS NUMBERS FOR HOME NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 8 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("You can only enter 8 digits for mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void MobilePhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // LIMITS DIGITS NUMBERS FOR MOBILE NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            System.Windows.Forms.TextBox textBox2 = sender as System.Windows.Forms.TextBox;
            if (textBox2 != null && textBox2.Text.Length >= 11 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("You can only enter 11 digits for mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in ComboBox2
            comboBox1.Items.Clear();

            // Get the selected province from ComboBox1
            string selectedProvince = Province.SelectedItem.ToString();

            // Populate ComboBox2 based on the selected province
            switch (selectedProvince)
            {
                case "Abra":
                    comboBox1.Items.Add("Bangued");
                    comboBox1.Items.Add("Boliney");
                    comboBox1.Items.Add("Bucay");
                    break;
                case "Agusan del Norte":
                    comboBox1.Items.Add("Cabadbaran");
                    comboBox1.Items.Add("Butuan");
                    break;
                case "Agusan del Sur":
                    comboBox1.Items.Add("Bayugan");
                    comboBox1.Items.Add("San Francisco");
                    break;
                case "Aklan":
                    comboBox1.Items.Add("Kalibo");
                    comboBox1.Items.Add("Banga");
                    break;
                case "Albay":
                    comboBox1.Items.Add("Legazpi");
                    comboBox1.Items.Add("Ligao");
                    break;
                case "Antique":
                    comboBox1.Items.Add("San Jose");
                    comboBox1.Items.Add("Sibalom");
                    break;
                case "Apayao":
                    comboBox1.Items.Add("Kabugao");
                    comboBox1.Items.Add("Conner");
                    break;
                case "Aurora":
                    comboBox1.Items.Add("Baler");
                    comboBox1.Items.Add("Dipaculao");
                    break;
                case "Basilan":
                    comboBox1.Items.Add("Isabela City");
                    comboBox1.Items.Add("Lamitan");
                    break;
                case "Bataan":
                    comboBox1.Items.Add("Balanga");
                    comboBox1.Items.Add("Orani");
                    break;
                case "Batanes":
                    comboBox1.Items.Add("Basco");
                    comboBox1.Items.Add("Itbayat");
                    break;
                case "Batangas":
                    comboBox1.Items.Add("Batangas City");
                    comboBox1.Items.Add("Lipa");
                    break;
                case "Benguet":
                    comboBox1.Items.Add("Baguio");
                    comboBox1.Items.Add("La Trinidad");
                    break;
                case "Biliran":
                    comboBox1.Items.Add("Naval");
                    comboBox1.Items.Add("Caibiran");
                    break;
                case "Bohol":
                    comboBox1.Items.Add("Tagbilaran");
                    comboBox1.Items.Add("Panglao");
                    break;
                case "Bukidnon":
                    comboBox1.Items.Add("Malaybalay");
                    comboBox1.Items.Add("Valencia");
                    break;
                case "Bulacan":
                    comboBox1.Items.Add("Malolos");
                    comboBox1.Items.Add("Meycauayan");
                    break;
                case "Cagayan":
                    comboBox1.Items.Add("Tuguegarao");
                    comboBox1.Items.Add("Aparri");
                    break;
                case "Camarines Norte":
                    comboBox1.Items.Add("Daet");
                    comboBox1.Items.Add("Labo");
                    break;
                case "Camarines Sur":
                    comboBox1.Items.Add("Naga");
                    comboBox1.Items.Add("Iriga");
                    break;
                case "Camiguin":
                    comboBox1.Items.Add("Mambajao");
                    comboBox1.Items.Add("Mahinog");
                    // ... (other cities/towns/municipalities in Camiguin)
                    break;
                case "Capiz":
                    comboBox1.Items.Add("Roxas City");
                    comboBox1.Items.Add("Panay");
                    // ... (other cities/towns/municipalities in Capiz)
                    break;
                case "Catanduanes":
                    comboBox1.Items.Add("Virac");
                    comboBox1.Items.Add("San Andres");
                    break;
                case "Cavite":
                    comboBox1.Items.Add("Cavite City");
                    comboBox1.Items.Add("Dasmariñas");
                    break;
                case "Cebu":
                    comboBox1.Items.Add("Cebu City");
                    comboBox1.Items.Add("Mandaue");
                    break;
                case "Cotabato":
                    comboBox1.Items.Add("Kidapawan");
                    comboBox1.Items.Add("Cotabato City");
                    break;
                case "Davao de Oro":
                    comboBox1.Items.Add("Nabunturan");
                    comboBox1.Items.Add("Mawab");
                    break;
                case "Davao del Norte":
                    comboBox1.Items.Add("Tagum");
                    comboBox1.Items.Add("Panabo");
                    break;
                case "Davao del Sur":
                    comboBox1.Items.Add("Digos");
                    comboBox1.Items.Add("Bansalan");
                    break;
                case "Davao Occidental":
                    comboBox1.Items.Add("Malita");
                    comboBox1.Items.Add("Santa Maria");
                    break;
                case "Davao Oriental":
                    comboBox1.Items.Add("Mati");
                    comboBox1.Items.Add("Baganga");
                    break;
                case "Dinagat Islands":
                    comboBox1.Items.Add("San Jose");
                    comboBox1.Items.Add("Dinagat");
                    // ... (other cities/towns/municipalities in Dinagat Islands)
                    break;
                case "Eastern Samar":
                    comboBox1.Items.Add("Borongan");
                    comboBox1.Items.Add("Guiuan");
                    // ... (other cities/towns/municipalities in Eastern Samar)
                    break;
                case "Guimaras":
                    comboBox1.Items.Add("Jordan");
                    comboBox1.Items.Add("Buenavista");
                    break;
                case "Ifugao":
                    comboBox1.Items.Add("Lagawe");
                    comboBox1.Items.Add("Kiangan");
                    break;
                case "Ilocos Norte":
                    comboBox1.Items.Add("Laoag");
                    comboBox1.Items.Add("Pagudpud");
                    break;
                case "Ilocos Sur":
                    comboBox1.Items.Add("Vigan");
                    comboBox1.Items.Add("Candon");
                    break;
                case "Iloilo":
                    comboBox1.Items.Add("Iloilo City");
                    comboBox1.Items.Add("Oton");
                    break;
                case "Isabela":
                    comboBox1.Items.Add("Ilagan");
                    comboBox1.Items.Add("Cauayan");
                    break;
                case "Kalinga":
                    comboBox1.Items.Add("Tabuk");
                    comboBox1.Items.Add("Balbalan");
                    break;
                case "La Union":
                    comboBox1.Items.Add("San Fernando");
                    comboBox1.Items.Add("Agoo");
                    break;
                case "Laguna":
                    comboBox1.Items.Add("Calamba");
                    comboBox1.Items.Add("San Pablo");
                    break;
                case "Lanao del Norte":
                    comboBox1.Items.Add("Iligan");
                    comboBox1.Items.Add("Tubod");
                    break;
                case "Lanao del Sur":
                    comboBox1.Items.Add("Marawi");
                    comboBox1.Items.Add("Sultan Dumalondong");
                    break;
                case "Leyte":
                    comboBox1.Items.Add("Tacloban");
                    comboBox1.Items.Add("Ormoc");
                    break;
                case "Maguindanao del Norte":
                    comboBox1.Items.Add("Cotabato City");
                    comboBox1.Items.Add("Buluan");
                    break;
                case "Maguindanao del Sur":
                    comboBox1.Items.Add("Shariff Aguak");
                    comboBox1.Items.Add("Sultan Kudarat");
                    break;
                case "Marinduque":
                    comboBox1.Items.Add("Boac");
                    comboBox1.Items.Add("Mogpog");
                    break;
                case "Masbate":
                    comboBox1.Items.Add("Masbate City");
                    comboBox1.Items.Add("Aroroy");
                    break;
                case "Misamis Occidental":
                    comboBox1.Items.Add("Oroquieta");
                    comboBox1.Items.Add("Ozamiz");
                    break;
                case "Misamis Oriental":
                    comboBox1.Items.Add("Cagayan de Oro");
                    comboBox1.Items.Add("Gingoog");
                    break;
                case "Mountain Province":
                    comboBox1.Items.Add("Bontoc");
                    comboBox1.Items.Add("Sagada");
                    break;
                case "Negros Occidental":
                    comboBox1.Items.Add("Bacolod");
                    comboBox1.Items.Add("Silay");
                    break;
                case "Negros Oriental":
                    comboBox1.Items.Add("Dumaguete");
                    comboBox1.Items.Add("Bais");
                    // ... (other cities/towns/municipalities in Negros Oriental)
                    break;
                case "Northern Samar":
                    comboBox1.Items.Add("Catarman");
                    comboBox1.Items.Add("Laoang");
                    // ... (other cities/towns/municipalities in Northern Samar)
                    break;
                case "Nueva Ecija":
                    comboBox1.Items.Add("Palayan");
                    comboBox1.Items.Add("Cabanatuan");
                    break;
                case "Nueva Vizcaya":
                    comboBox1.Items.Add("Bayombong");
                    comboBox1.Items.Add("Solano");
                    break;
                case "Occidental Mindoro":
                    comboBox1.Items.Add("Mamburao");
                    comboBox1.Items.Add("San Jose");
                    break;
                case "Oriental Mindoro":
                    comboBox1.Items.Add("Calapan");
                    comboBox1.Items.Add("Baco");
                    break;
                case "Palawan":
                    comboBox1.Items.Add("Puerto Princesa");
                    comboBox1.Items.Add("Coron");
                    break;
                case "Pampanga":
                    comboBox1.Items.Add("San Fernando");
                    comboBox1.Items.Add("Angeles");
                    break;
                case "Pangasinan":
                    comboBox1.Items.Add("Dagupan");
                    comboBox1.Items.Add("Urdaneta");
                    break;
                case "Quezon":
                    comboBox1.Items.Add("Lucena");
                    comboBox1.Items.Add("Tayabas");
                    break;
                case "Rizal":
                    comboBox1.Items.Add("Antipolo");
                    comboBox1.Items.Add("Rodriguez");
                    comboBox1.Items.Add("Binangonan");
                    comboBox1.Items.Add("Taytay");
                    comboBox1.Items.Add("Angono");
                    comboBox1.Items.Add("Tanay");
                    comboBox1.Items.Add("Cainta");
                    comboBox1.Items.Add("San Mateo");
                    comboBox1.Items.Add("Baras");
                    comboBox1.Items.Add("Cardona");
                    break;
                case "Romblon":
                    comboBox1.Items.Add("Romblon");
                    comboBox1.Items.Add("Odiongan");
                    // ... (other cities/towns/municipalities in Romblon)
                    break;
                case "Samar":
                    comboBox1.Items.Add("Catbalogan");
                    comboBox1.Items.Add("Calbayog");
                    // ... (other cities/towns/municipalities in Samar)
                    break;
                case "Sarangani":
                    comboBox1.Items.Add("Alabel");
                    comboBox1.Items.Add("Kiamba");
                    break;
                case "Siquijor":
                    comboBox1.Items.Add("Siquijor");
                    comboBox1.Items.Add("Larena");
                    break;
                case "Sorsogon":
                    comboBox1.Items.Add("Sorsogon City");
                    comboBox1.Items.Add("Bulan");
                    break;
                case "South Cotabato":
                    comboBox1.Items.Add("Koronadal");
                    comboBox1.Items.Add("Surallah");
                    break;
                case "Southern Leyte":
                    comboBox1.Items.Add("Maasin");
                    comboBox1.Items.Add("Sogod");
                    break;
                case "Sultan Kudarat":
                    comboBox1.Items.Add("Isulan");
                    comboBox1.Items.Add("Tacurong");
                    break;
                case "Sulu":
                    comboBox1.Items.Add("Jolo");
                    comboBox1.Items.Add("Panglima Sugala");
                    break;
                case "Surigao del Norte":
                    comboBox1.Items.Add("Surigao City");
                    comboBox1.Items.Add("Siargao");
                    break;
                case "Surigao del Sur":
                    comboBox1.Items.Add("Tandag");
                    comboBox1.Items.Add("Bislig");
                    break;
                case "Tarlac":
                    comboBox1.Items.Add("Tarlac City");
                    comboBox1.Items.Add("Paniqui");
                    break;
                case "Tawi-Tawi":
                    comboBox1.Items.Add("Bongao");
                    comboBox1.Items.Add("Panglima Sugala");
                    break;
                case "Zambales":
                    comboBox1.Items.Add("Olongapo");
                    comboBox1.Items.Add("Iba");
                    break;
                case "Zamboanga del Norte":
                    comboBox1.Items.Add("Dipolog");
                    comboBox1.Items.Add("Dapitan");
                    break;
                case "Zamboanga del Sur":
                    comboBox1.Items.Add("Pagadian");
                    comboBox1.Items.Add("Zamboanga City");
                    break;
                case "Zamboanga Sibugay":
                    comboBox1.Items.Add("Ipil");
                    comboBox1.Items.Add("Kabasalan");
                    break;
                default:
                    break;
            }
        }

        private void AddEmployeeButtonForm_Load(object sender, EventArgs e)
        {
            // Populate ComboBox1 with provinces
            Province.Items.Add("Abra");
            Province.Items.Add("Agusan del Norte");
            Province.Items.Add("Agusan del Sur");
            Province.Items.Add("Aklan");
            Province.Items.Add("Albay");
            Province.Items.Add("Antique");
            Province.Items.Add("Apayao");
            Province.Items.Add("Aurora");
            Province.Items.Add("Basilan");
            Province.Items.Add("Bataan");
            Province.Items.Add("Batanes");
            Province.Items.Add("Batangas");
            Province.Items.Add("Benguet");
            Province.Items.Add("Biliran");
            Province.Items.Add("Bohol");
            Province.Items.Add("Bukidnon");
            Province.Items.Add("Bulacan");
            Province.Items.Add("Cagayan");
            Province.Items.Add("Camarines Norte");
            Province.Items.Add("Camarines Sur");
            Province.Items.Add("Camiguin");
            Province.Items.Add("Capiz");
            Province.Items.Add("Catanduanes");
            Province.Items.Add("Cavite");
            Province.Items.Add("Cebu");
            Province.Items.Add("Cotabato");
            Province.Items.Add("Davao de Oro");
            Province.Items.Add("Davao del Norte");
            Province.Items.Add("Davao del Sur");
            Province.Items.Add("Davao Occidental");
            Province.Items.Add("Davao Oriental");
            Province.Items.Add("Dinagat Islands");
            Province.Items.Add("Eastern Samar");
            Province.Items.Add("Guimaras");
            Province.Items.Add("Ifugao");
            Province.Items.Add("Ilocos Norte");
            Province.Items.Add("Ilocos Sur");
            Province.Items.Add("Iloilo");
            Province.Items.Add("Isabela");
            Province.Items.Add("Kalinga");
            Province.Items.Add("La Union");
            Province.Items.Add("Laguna");
            Province.Items.Add("Lanao del Norte");
            Province.Items.Add("Lanao del Sur");
            Province.Items.Add("Leyte");
            Province.Items.Add("Maguindanao del Norte");
            Province.Items.Add("Maguindanao del Sur");
            Province.Items.Add("Marinduque");
            Province.Items.Add("Masbate");
            Province.Items.Add("Misamis Occidental");
            Province.Items.Add("Misamis Oriental");
            Province.Items.Add("Mountain Province");
            Province.Items.Add("Negros Occidental");
            Province.Items.Add("Negros Oriental");
            Province.Items.Add("Northern Samar");
            Province.Items.Add("Nueva Ecija");
            Province.Items.Add("Nueva Vizcaya");
            Province.Items.Add("Occidental Mindoro");
            Province.Items.Add("Oriental Mindoro");
            Province.Items.Add("Palawan");
            Province.Items.Add("Pampanga");
            Province.Items.Add("Pangasinan");
            Province.Items.Add("Quezon");
            Province.Items.Add("Quirino");
            Province.Items.Add("Rizal");
            Province.Items.Add("Romblon");
            Province.Items.Add("Samar");
            Province.Items.Add("Sarangani");
            Province.Items.Add("Siquijor");
            Province.Items.Add("Sorsogon");
            Province.Items.Add("South Cotabato");
            Province.Items.Add("Southern Leyte");
            Province.Items.Add("Sultan Kudarat");
            Province.Items.Add("Sulu");
            Province.Items.Add("Surigao del Norte");
            Province.Items.Add("Surigao del Sur");
            Province.Items.Add("Tarlac");
            Province.Items.Add("Tawi-Tawi");
            Province.Items.Add("Zambales");
            Province.Items.Add("Zamboanga del Norte");
            Province.Items.Add("Zamboanga del Sur");
            Province.Items.Add("Zamboanga Sibugay");
        }
    }
}
