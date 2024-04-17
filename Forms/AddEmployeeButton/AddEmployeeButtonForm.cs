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
using System.Text.RegularExpressions;
using System.Globalization;
using Xamarin.Essentials;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class AddEmployeeButtonForm : Form
    {


        private MySqlConnection connection;

        public string firstname { get { return FirstName.Text; } set { FirstName.Text = value; } }
        public string middlename { get { return MiddleName.Text; } set { MiddleName.Text = value; } }
        public string lastname { get { return LastName.Text; } set { LastName.Text = value; } }
        public string suffix { get { return Suffix.Text; } set { Suffix.Text = value; } }
        public string gender { get { return Gender.Text; } set { Gender.Text = value; } }
        public string dob { get { return DateOfBirth.Text; } set { DateOfBirth.Text = value; } }
        public string address { get { return Address.Text; } set { Address.Text = value; } }
        public string province { get { return Province.Text; } set { Province.Text = value; } }
        public string city { get { return cityCMB.Text; } set { cityCMB.Text = value; } }
        public string postal { get { return PostalCode.Text; } set { PostalCode.Text = value; } }
        public string phone { get { return phoneNum.Text; } set { phoneNum.Text = value; } }
        public string telephone { get { return Telephone.Text; } set { Telephone.Text = value; } }
        public string email { get { return Email.Text; } set { Email.Text = value; } }
        public string empnum { get { return EmployeeNum.Text; } set { EmployeeNum.Text = value; } }
        public string hdate { get { return HireDate.Text; } set { HireDate.Text = value; } }
        public string occupation { get { return Occupation.Text; } set { Occupation.Text = value; } }
        public string department { get { return Department.Text; } set { Department.Text = value; } }
        public string timein { get { return TimeIn.Text; } set { TimeIn.Text = value; } }
        public string timeout { get { return TimeOut.Text; } set { TimeOut.Text = value; } }
        public string jobstatus { get { return JobStatus.Text; } set { JobStatus.Text = value; } }
        public string barangay { get { return barangayCMB.Text; } set { barangayCMB.Text = value; } }

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
            if (image != null)
            {
                try
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return memoryStream.ToArray();
                    }
                }
                catch (ArgumentException ex)
                {
                    // Handle the case where the image data is not a valid format
                    MessageBox.Show("Error converting image to byte array: " + ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        private bool IsValidMobilePhone(string mphone)
        {
            // Use regular expression to validate 11-digit number
            return System.Text.RegularExpressions.Regex.IsMatch(mphone, @"^\d{10}$");
        }

        private bool IsValidTelephone(string telephone)
        {
            // Use regular expression to validate 11-digit number
            return System.Text.RegularExpressions.Regex.IsMatch(telephone, @"^\d{8}$");
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            // Validate empcon_HN.Text
            string mphone = phoneNum.Text.Trim();
            if (!IsValidMobilePhone(mphone))
            {
                return;
            }

            // Validate empcon_HN.Text
            string telephone = Telephone.Text.Trim();
            if (!IsValidTelephone(telephone))
            {
                return;
            }

            // Validate itemCostTB.Text as a number
            if (!Regex.IsMatch(PostalCode.Text, @"^[\d\.,₱]+$"))
            {
                MessageBox.Show("Postal must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(EmployeeNum.Text) || string.IsNullOrEmpty(FirstName.Text) || string.IsNullOrEmpty(MiddleName.Text) || string.IsNullOrEmpty(LastName.Text)
                || Gender.SelectedIndex == -1 || string.IsNullOrEmpty(Telephone.Text) || string.IsNullOrEmpty(phoneNum.Text) || string.IsNullOrEmpty(Email.Text) ||
                string.IsNullOrEmpty(Address.Text) || barangayCMB.SelectedIndex == -1 || Province.SelectedIndex == -1 || cityCMB.SelectedIndex == -1 ||
                string.IsNullOrEmpty(PostalCode.Text) || Occupation.SelectedIndex == -1 || ProfilePic.Image == null || JobStatus.SelectedIndex == -1 || Department.SelectedIndex == -1 ||
                TimeIn.SelectedIndex == -1 || TimeOut.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //STORES EMPLOYEE DATA
                    connection.Open();

                    string query = "INSERT INTO employee (employeenum, name, occupation, department, jobstatus, firstname, middle, lastname, suffix, gender, dob, homenum, phonenum, email, address, barangay, province, city, postal, " +
                        "hiredate, timein, timeout, image_data) VALUES (@employeenum, @name, @occupation, @department, @jobstatus, @firstname, @middle, @lastname, @suffix, @gender, @dob, @homenum, @phonenum, @email, @address, " +
                        "@barangay, @province, @city, @postal, @hiredate, @timein, @timeout, @imageData)";
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
                    cmd.Parameters.AddWithValue("@phonenum", phoneNum.Text); //textbox
                    cmd.Parameters.AddWithValue("@email", Email.Text); //textbox
                    cmd.Parameters.AddWithValue("@address", Address.Text); //textbox
                    cmd.Parameters.AddWithValue("@barangay", barangayCMB.Text); //combobox
                    cmd.Parameters.AddWithValue("@province", Province.Text); //combobox
                    cmd.Parameters.AddWithValue("@city", cityCMB.Text); //textbox
                    cmd.Parameters.AddWithValue("@postal", PostalCode.Text); //textbox
                    cmd.Parameters.AddWithValue("@hiredate", HireDate.Value); //datetimepicker
                    cmd.Parameters.AddWithValue("@occupation", Occupation.Text); //combobox
                    cmd.Parameters.AddWithValue("@department", Department.Text); //combobox
                    cmd.Parameters.AddWithValue("@jobstatus", JobStatus.Text); //combobox
                    cmd.Parameters.AddWithValue("@timein", TimeIn.Text); //combobox
                    cmd.Parameters.AddWithValue("@timeout", TimeOut.Text); //combobox
                    cmd.Parameters.AddWithValue("@imageData", imageData);




                    string first = FirstName.Text;
                    string middle = MiddleName.Text;
                    string last = LastName.Text;
                    string suffix = Suffix.Text;
                    string name =  last + " " + first + " " + middle + " " + suffix;

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            // UPLOAD AND DISPLAYS IMAGE

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                // Use System.Drawing.Image for Windows Forms PictureBox
                Image image = Image.FromFile(imagePath);

                // Set the position of the image within the PictureBox
                ProfilePic.SizeMode = PictureBoxSizeMode.Zoom;

                ProfilePic.Image = image;
            }
        }


        private void AddEmployeeButtonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void Province_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in ComboBox2
            cityCMB.Items.Clear();

            // Get the selected province from ComboBox1
            string selectedProvince = Province.SelectedItem.ToString();

            // Populate ComboBox2 based on the selected province
            switch (selectedProvince)
            {
                case "Abra":
                    cityCMB.Items.Add("Bangued");
                    cityCMB.Items.Add("Boliney");
                    cityCMB.Items.Add("Bucay");
                    break;
                case "Agusan del Norte":
                    cityCMB.Items.Add("Cabadbaran");
                    cityCMB.Items.Add("Butuan");
                    break;
                case "Agusan del Sur":
                    cityCMB.Items.Add("Bayugan");
                    cityCMB.Items.Add("San Francisco");
                    break;
                case "Aklan":
                    cityCMB.Items.Add("Kalibo");
                    cityCMB.Items.Add("Banga");
                    break;
                case "Albay":
                    cityCMB.Items.Add("Legazpi");
                    cityCMB.Items.Add("Ligao");
                    break;
                case "Antique":
                    cityCMB.Items.Add("San Jose");
                    cityCMB.Items.Add("Sibalom");
                    break;
                case "Apayao":
                    cityCMB.Items.Add("Kabugao");
                    cityCMB.Items.Add("Conner");
                    break;
                case "Aurora":
                    cityCMB.Items.Add("Baler");
                    cityCMB.Items.Add("Dipaculao");
                    break;
                case "Basilan":
                    cityCMB.Items.Add("Isabela City");
                    cityCMB.Items.Add("Lamitan");
                    break;
                case "Bataan":
                    cityCMB.Items.Add("Balanga");
                    cityCMB.Items.Add("Orani");
                    break;
                case "Batanes":
                    cityCMB.Items.Add("Basco");
                    cityCMB.Items.Add("Itbayat");
                    break;
                case "Batangas":
                    cityCMB.Items.Add("Batangas City");
                    cityCMB.Items.Add("Lipa");
                    break;
                case "Benguet":
                    cityCMB.Items.Add("Baguio");
                    cityCMB.Items.Add("La Trinidad");
                    break;
                case "Biliran":
                    cityCMB.Items.Add("Naval");
                    cityCMB.Items.Add("Caibiran");
                    break;
                case "Bohol":
                    cityCMB.Items.Add("Tagbilaran");
                    cityCMB.Items.Add("Panglao");
                    break;
                case "Bukidnon":
                    cityCMB.Items.Add("Malaybalay");
                    cityCMB.Items.Add("Valencia");
                    break;
                case "Bulacan":
                    cityCMB.Items.Add("Malolos");
                    cityCMB.Items.Add("Meycauayan");
                    break;
                case "Cagayan":
                    cityCMB.Items.Add("Tuguegarao");
                    cityCMB.Items.Add("Aparri");
                    break;
                case "Camarines Norte":
                    cityCMB.Items.Add("Daet");
                    cityCMB.Items.Add("Labo");
                    break;
                case "Camarines Sur":
                    cityCMB.Items.Add("Naga");
                    cityCMB.Items.Add("Iriga");
                    break;
                case "Camiguin":
                    cityCMB.Items.Add("Mambajao");
                    cityCMB.Items.Add("Mahinog");
                    // ... (other cities/towns/municipalities in Camiguin)
                    break;
                case "Capiz":
                    cityCMB.Items.Add("Roxas City");
                    cityCMB.Items.Add("Panay");
                    // ... (other cities/towns/municipalities in Capiz)
                    break;
                case "Catanduanes":
                    cityCMB.Items.Add("Virac");
                    cityCMB.Items.Add("San Andres");
                    break;
                case "Cavite":
                    cityCMB.Items.Add("Cavite City");
                    cityCMB.Items.Add("Dasmariñas");
                    break;
                case "Cebu":
                    cityCMB.Items.Add("Cebu City");
                    cityCMB.Items.Add("Mandaue");
                    break;
                case "Cotabato":
                    cityCMB.Items.Add("Kidapawan");
                    cityCMB.Items.Add("Cotabato City");
                    break;
                case "Davao de Oro":
                    cityCMB.Items.Add("Nabunturan");
                    cityCMB.Items.Add("Mawab");
                    break;
                case "Davao del Norte":
                    cityCMB.Items.Add("Tagum");
                    cityCMB.Items.Add("Panabo");
                    break;
                case "Davao del Sur":
                    cityCMB.Items.Add("Digos");
                    cityCMB.Items.Add("Bansalan");
                    break;
                case "Davao Occidental":
                    cityCMB.Items.Add("Malita");
                    cityCMB.Items.Add("Santa Maria");
                    break;
                case "Davao Oriental":
                    cityCMB.Items.Add("Mati");
                    cityCMB.Items.Add("Baganga");
                    break;
                case "Dinagat Islands":
                    cityCMB.Items.Add("San Jose");
                    cityCMB.Items.Add("Dinagat");
                    // ... (other cities/towns/municipalities in Dinagat Islands)
                    break;
                case "Eastern Samar":
                    cityCMB.Items.Add("Borongan");
                    cityCMB.Items.Add("Guiuan");
                    // ... (other cities/towns/municipalities in Eastern Samar)
                    break;
                case "Guimaras":
                    cityCMB.Items.Add("Jordan");
                    cityCMB.Items.Add("Buenavista");
                    break;
                case "Ifugao":
                    cityCMB.Items.Add("Lagawe");
                    cityCMB.Items.Add("Kiangan");
                    break;
                case "Ilocos Norte":
                    cityCMB.Items.Add("Laoag");
                    cityCMB.Items.Add("Pagudpud");
                    break;
                case "Ilocos Sur":
                    cityCMB.Items.Add("Vigan");
                    cityCMB.Items.Add("Candon");
                    break;
                case "Iloilo":
                    cityCMB.Items.Add("Iloilo City");
                    cityCMB.Items.Add("Oton");
                    break;
                case "Isabela":
                    cityCMB.Items.Add("Ilagan");
                    cityCMB.Items.Add("Cauayan");
                    break;
                case "Kalinga":
                    cityCMB.Items.Add("Tabuk");
                    cityCMB.Items.Add("Balbalan");
                    break;
                case "La Union":
                    cityCMB.Items.Add("San Fernando");
                    cityCMB.Items.Add("Agoo");
                    break;
                case "Laguna":
                    cityCMB.Items.Add("Calamba");
                    cityCMB.Items.Add("San Pablo");
                    break;
                case "Lanao del Norte":
                    cityCMB.Items.Add("Iligan");
                    cityCMB.Items.Add("Tubod");
                    break;
                case "Lanao del Sur":
                    cityCMB.Items.Add("Marawi");
                    cityCMB.Items.Add("Sultan Dumalondong");
                    break;
                case "Leyte":
                    cityCMB.Items.Add("Tacloban");
                    cityCMB.Items.Add("Ormoc");
                    break;
                case "Maguindanao del Norte":
                    cityCMB.Items.Add("Cotabato City");
                    cityCMB.Items.Add("Buluan");
                    break;
                case "Maguindanao del Sur":
                    cityCMB.Items.Add("Shariff Aguak");
                    cityCMB.Items.Add("Sultan Kudarat");
                    break;
                case "Marinduque":
                    cityCMB.Items.Add("Boac");
                    cityCMB.Items.Add("Mogpog");
                    break;
                case "Masbate":
                    cityCMB.Items.Add("Masbate City");
                    cityCMB.Items.Add("Aroroy");
                    break;
                case "Misamis Occidental":
                    cityCMB.Items.Add("Oroquieta");
                    cityCMB.Items.Add("Ozamiz");
                    break;
                case "Misamis Oriental":
                    cityCMB.Items.Add("Cagayan de Oro");
                    cityCMB.Items.Add("Gingoog");
                    break;
                case "Mountain Province":
                    cityCMB.Items.Add("Bontoc");
                    cityCMB.Items.Add("Sagada");
                    break;
                case "Negros Occidental":
                    cityCMB.Items.Add("Bacolod");
                    cityCMB.Items.Add("Silay");
                    break;
                case "Negros Oriental":
                    cityCMB.Items.Add("Dumaguete");
                    cityCMB.Items.Add("Bais");
                    // ... (other cities/towns/municipalities in Negros Oriental)
                    break;
                case "Northern Samar":
                    cityCMB.Items.Add("Catarman");
                    cityCMB.Items.Add("Laoang");
                    // ... (other cities/towns/municipalities in Northern Samar)
                    break;
                case "Nueva Ecija":
                    cityCMB.Items.Add("Palayan");
                    cityCMB.Items.Add("Cabanatuan");
                    break;
                case "Nueva Vizcaya":
                    cityCMB.Items.Add("Bayombong");
                    cityCMB.Items.Add("Solano");
                    break;
                case "Occidental Mindoro":
                    cityCMB.Items.Add("Mamburao");
                    cityCMB.Items.Add("San Jose");
                    break;
                case "Oriental Mindoro":
                    cityCMB.Items.Add("Calapan");
                    cityCMB.Items.Add("Baco");
                    break;
                case "Palawan":
                    cityCMB.Items.Add("Puerto Princesa");
                    cityCMB.Items.Add("Coron");
                    break;
                case "Pampanga":
                    cityCMB.Items.Add("San Fernando");
                    cityCMB.Items.Add("Angeles");
                    break;
                case "Pangasinan":
                    cityCMB.Items.Add("Dagupan");
                    cityCMB.Items.Add("Urdaneta");
                    break;
                case "Quezon":
                    cityCMB.Items.Add("Lucena");
                    cityCMB.Items.Add("Tayabas");
                    break;
                case "Rizal":
                    cityCMB.Items.Add("Antipolo");
                    cityCMB.Items.Add("Rodriguez");
                    cityCMB.Items.Add("Binangonan");
                    cityCMB.Items.Add("Taytay");
                    cityCMB.Items.Add("Angono");
                    cityCMB.Items.Add("Tanay");
                    cityCMB.Items.Add("Cainta");
                    cityCMB.Items.Add("San Mateo");
                    cityCMB.Items.Add("Baras");
                    cityCMB.Items.Add("Cardona");
                    break;
                case "Romblon":
                    cityCMB.Items.Add("Romblon");
                    cityCMB.Items.Add("Odiongan");
                    // ... (other cities/towns/municipalities in Romblon)
                    break;
                case "Samar":
                    cityCMB.Items.Add("Catbalogan");
                    cityCMB.Items.Add("Calbayog");
                    // ... (other cities/towns/municipalities in Samar)
                    break;
                case "Sarangani":
                    cityCMB.Items.Add("Alabel");
                    cityCMB.Items.Add("Kiamba");
                    break;
                case "Siquijor":
                    cityCMB.Items.Add("Siquijor");
                    cityCMB.Items.Add("Larena");
                    break;
                case "Sorsogon":
                    cityCMB.Items.Add("Sorsogon City");
                    cityCMB.Items.Add("Bulan");
                    break;
                case "South Cotabato":
                    cityCMB.Items.Add("Koronadal");
                    cityCMB.Items.Add("Surallah");
                    break;
                case "Southern Leyte":
                    cityCMB.Items.Add("Maasin");
                    cityCMB.Items.Add("Sogod");
                    break;
                case "Sultan Kudarat":
                    cityCMB.Items.Add("Isulan");
                    cityCMB.Items.Add("Tacurong");
                    break;
                case "Sulu":
                    cityCMB.Items.Add("Jolo");
                    cityCMB.Items.Add("Panglima Sugala");
                    break;
                case "Surigao del Norte":
                    cityCMB.Items.Add("Surigao City");
                    cityCMB.Items.Add("Siargao");
                    break;
                case "Surigao del Sur":
                    cityCMB.Items.Add("Tandag");
                    cityCMB.Items.Add("Bislig");
                    break;
                case "Tarlac":
                    cityCMB.Items.Add("Tarlac City");
                    cityCMB.Items.Add("Paniqui");
                    break;
                case "Tawi-Tawi":
                    cityCMB.Items.Add("Bongao");
                    cityCMB.Items.Add("Panglima Sugala");
                    break;
                case "Zambales":
                    cityCMB.Items.Add("Olongapo");
                    cityCMB.Items.Add("Iba");
                    break;
                case "Zamboanga del Norte":
                    cityCMB.Items.Add("Dipolog");
                    cityCMB.Items.Add("Dapitan");
                    break;
                case "Zamboanga del Sur":
                    cityCMB.Items.Add("Pagadian");
                    cityCMB.Items.Add("Zamboanga City");
                    break;
                case "Zamboanga Sibugay":
                    cityCMB.Items.Add("Ipil");
                    cityCMB.Items.Add("Kabasalan");
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cityCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                // Get the selected province from ComboBox1
                string selectedCity = cityCMB.SelectedItem.ToString();

                // Populate ComboBox2 based on the selected province
                switch (selectedCity)
                {
                    case "Antipolo":
                        barangayCMB.Items.Add("Bangued");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Bucay");
                        break;
                    case "Rodriguez":
                        barangayCMB.Items.Add("Bangued");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Bucay");
                        break;
                    case "Binangonan":
                        barangayCMB.Items.Add("Bangad");
                        barangayCMB.Items.Add("Batingan");
                        barangayCMB.Items.Add("Bilibiran");
                        barangayCMB.Items.Add("Binitagan");
                        barangayCMB.Items.Add("Bombong");
                        barangayCMB.Items.Add("Buhangin");
                        barangayCMB.Items.Add("Calumpang");
                        barangayCMB.Items.Add("Ginoong Sanay");
                        barangayCMB.Items.Add("Gulod");
                        barangayCMB.Items.Add("Habagatan");
                        barangayCMB.Items.Add("Ithan");
                        barangayCMB.Items.Add("Janosa");
                        barangayCMB.Items.Add("Kalawaan (Darangan)");
                        barangayCMB.Items.Add("Kalinawan");
                        barangayCMB.Items.Add("Kasile");
                        barangayCMB.Items.Add("Kaytome");
                        barangayCMB.Items.Add("Kinaboogan");
                        barangayCMB.Items.Add("Kinagatan");
                        barangayCMB.Items.Add("Layunan (Poblacion)");
                        barangayCMB.Items.Add("Libid (Poblacion)");
                        barangayCMB.Items.Add("Libis (Poblacion)");
                        barangayCMB.Items.Add("Limbon-limbon");
                        barangayCMB.Items.Add("Lunsad");
                        barangayCMB.Items.Add("Macamot");
                        barangayCMB.Items.Add("Mahabang Parang");
                        barangayCMB.Items.Add("Malakaban");
                        barangayCMB.Items.Add("Mambog");
                        barangayCMB.Items.Add("Pag-asa");
                        barangayCMB.Items.Add("Palangoy");
                        barangayCMB.Items.Add("Pantok");
                        barangayCMB.Items.Add("Pila-Pila");
                        barangayCMB.Items.Add("Pinagdilawan");
                        barangayCMB.Items.Add("Pipindan");
                        barangayCMB.Items.Add("Rayap");
                        barangayCMB.Items.Add("San Carlos");
                        barangayCMB.Items.Add("Sapang");
                        barangayCMB.Items.Add("Tabon");
                        barangayCMB.Items.Add("Tagpos");
                        barangayCMB.Items.Add("Tatala");
                        barangayCMB.Items.Add("Tayuman");
                        break;
                    case "Taytay":
                        barangayCMB.Items.Add("Dolores (Poblacion)");
                        barangayCMB.Items.Add("Muzon");
                        barangayCMB.Items.Add("San Isidro");
                        barangayCMB.Items.Add("San Juan");
                        barangayCMB.Items.Add("Santa Ana");

                        break;
                    case "Angono":
                        barangayCMB.Items.Add("Bagumbayan");
                        barangayCMB.Items.Add("Kalayaan");
                        barangayCMB.Items.Add("Mahabang Parang");
                        barangayCMB.Items.Add("Poblacion Ibaba");
                        barangayCMB.Items.Add("Poblacion Itaas");
                        barangayCMB.Items.Add("San Isidro");
                        barangayCMB.Items.Add("Santo Niño");
                        barangayCMB.Items.Add("San Pedro");
                        barangayCMB.Items.Add("San Roque");
                        break;
                    case "Tanay":
                        barangayCMB.Items.Add("Cayabu");
                        barangayCMB.Items.Add("Cuyambay");
                        barangayCMB.Items.Add("Daraitan");
                        barangayCMB.Items.Add("Katipunan-Bayani(Pob.)");
                        barangayCMB.Items.Add("Kay Buto(Poblacion)");
                        barangayCMB.Items.Add("Laiban");
                        barangayCMB.Items.Add("Mag-Ampon(Poblacion)");
                        barangayCMB.Items.Add("Mamuyao");
                        barangayCMB.Items.Add("Madilay-dilay");
                        barangayCMB.Items.Add("Pinagkamaligan(Poblacion)");
                        barangayCMB.Items.Add("Plaza Aldea(Poblacion)");
                        barangayCMB.Items.Add("Sampaloc");
                        barangayCMB.Items.Add("San Andres");
                        barangayCMB.Items.Add("San Isidro(Poblacion)");
                        barangayCMB.Items.Add("Santa Inez");
                        barangayCMB.Items.Add("Santo Niño");
                        barangayCMB.Items.Add("Tabing Ilog(Poblacion)");
                        barangayCMB.Items.Add("Tandang Kutyo(Poblacion)");
                        barangayCMB.Items.Add("Tinucan");
                        barangayCMB.Items.Add("Wawa(Poblacion)");
                        break;
                    case "Cainta":
                        barangayCMB.Items.Add("San Andres");
                        barangayCMB.Items.Add("Sto. Domingo");
                        barangayCMB.Items.Add("San Isidro");
                        barangayCMB.Items.Add("San Juan");
                        barangayCMB.Items.Add("Sto. Nino");
                        barangayCMB.Items.Add("San Roque");
                        barangayCMB.Items.Add("Sta. Rosa");
                        break;
                    case "San Mateo":
                        barangayCMB.Items.Add("Bangued");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Bucay");
                        break;
                    case "Baras":
                        barangayCMB.Items.Add("Bangued");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Bucay");
                        break;
                    case "Cardona":
                        barangayCMB.Items.Add("Bangued");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Bucay");
                        break;
                    default:
                        break;
                }
            }
        }

        private void phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // LIMITS DIGITS NUMBERS FOR HOME NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            System.Windows.Forms.TextBox textBox = sender as System.Windows.Forms.TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Telephone_KeyPress(object sender, KeyPressEventArgs e)
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
            }
        }

        private void cameraButton_Click_1(object sender, EventArgs e)
        {
            addWebcam webcam = new addWebcam();

            string firstname = FirstName.Text;
            string middlename = MiddleName.Text;
            string lastname = LastName.Text;
            string suffix = Suffix.Text;
            string gender = Gender.Text;
            string dob = DateOfBirth.Text;
            string barangay = barangayCMB.Text;
            string address = Address.Text;
            string province = Province.Text;
            string city = cityCMB.Text;
            string postal = PostalCode.Text;
            string phone = phoneNum.Text;
            string telephone = Telephone.Text;
            string email = Email.Text;
            string empnum = EmployeeNum.Text;
            string hdate = HireDate.Text;
            string occupation = Occupation.Text;
            string department = Department.Text;
            string jobstatus = JobStatus.Text;
            string timein = TimeIn.Text;
            string timeout = TimeOut.Text;


            //set the public properties of the textboxes on the second form
            webcam.firstname = firstname;
            webcam.middlename = middlename;
            webcam.lastname = lastname;
            webcam.suffix = suffix;
            webcam.gender = gender;
            webcam.dob = dob;
            webcam.barangay = barangay;
            webcam.address = address;
            webcam.province = province;
            webcam.city = city;
            webcam.postal = postal;
            webcam.phone = phone;
            webcam.telephone = telephone;
            webcam.email = email;
            webcam.empnum = empnum;
            webcam.hdate = hdate;
            webcam.occupation = occupation;
            webcam.department = department;
            webcam.jobstatus = jobstatus;
            webcam.timein = timein;
            webcam.timeout = timeout;

            webcam.Show();
            this.Hide();
        }

        public void SetCapturedImage(Bitmap capturedImage)
        {
            // Set the position of the image within the PictureBox
            ProfilePic.SizeMode = PictureBoxSizeMode.Zoom;
            ProfilePic.Image = capturedImage;
        }
    }
}
