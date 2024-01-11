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
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics.Metrics;
using SCTAttendanceSystemUI.Forms.filterAttendance;


namespace SCTAttendanceSystemUI.Forms
{
    public partial class EditButtonForm : Form
    {

        private MySqlConnection connection;


        public EditButtonForm()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        public string firstname { get { return firstNameTB.Text; } set { firstNameTB.Text = value; } }
        public string middlename { get { return initialNameTB.Text; } set { initialNameTB.Text = value; } }
        public string lastname { get { return lastNameTB.Text; } set { lastNameTB.Text = value; } }
        public string suffix { get { return suffixNameTB.Text; } set { suffixNameTB.Text = value; } }
        public string gender { get { return genderCMB.Text; } set { genderCMB.Text = value; } }
        public string dob { get { return dobDTP.Text; } set { dobDTP.Text = value; } }
        public string address { get { return addressTB.Text; } set { addressTB.Text = value; } }
        public string province { get { return provinceCMB.Text; } set { provinceCMB.Text = value; } }
        public string city { get { return cityCMB.Text; } set { cityCMB.Text = value; } }
        public string postal { get { return postalTB.Text; } set { postalTB.Text = value; } }
        public string phone { get { return phoneTB.Text; } set { phoneTB.Text = value; } }
        public string telephone { get { return telNumberTB.Text; } set { telNumberTB.Text = value; } }
        public string email { get { return emailTB.Text; } set { emailTB.Text = value; } }
        public string empnum { get { return empNumTB.Text; } set { empNumTB.Text = value; } }
        public string hdate { get { return hireDTP.Text; } set { hireDTP.Text = value; } }
        public string occupation { get { return occupationCMB.Text; } set { occupationCMB.Text = value; } }
        public string department { get { return departmentCMB.Text; } set { departmentCMB.Text = value; } }
        public string timein { get { return timeinCMB.Text; } set { timeinCMB.Text = value; } }
        public string timeout { get { return timeoutCMB.Text; } set { timeoutCMB.Text = value; } }
        public string jobstatus { get { return statusCMB.Text; } set { statusCMB.Text = value; } }
        public string id { get { return textBox9.Text; } set { textBox9.Text = value; } }
        public string barangay { get { return barangayCMB.Text; } set { barangayCMB.Text = value; } }




        public byte[] image
        {
            get
            {
                ImageConverter converter = new ImageConverter();

                if (profilePictureBox.Image != null)
                {
                    try
                    {
                        return (byte[])converter.ConvertTo(profilePictureBox.Image, typeof(byte[]));
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
            set
            {
                if (value != null && value.Length > 0)
                {
                    try
                    {
                        ImageConverter converter = new ImageConverter();
                        profilePictureBox.Image = (Image)converter.ConvertFrom(value);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle the case where the image data is not a valid format
                        MessageBox.Show("Error converting byte array to image: " + ex.Message);
                        profilePictureBox.Image = null;
                    }
                }
                else
                {
                    profilePictureBox.Image = null;
                }
            }
        }




        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

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
        private void button1_Click(object sender, EventArgs e)
        {
            //UPDATES EMPLOYEE INFORMATION

            // Validate itemCostTB.Text as a number
            if (!Regex.IsMatch(postalTB.Text, @"^[\d\.,₱]+$"))
            {
                MessageBox.Show("Postal must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validate empcon_HN.Text
            string mphone = phoneTB.Text.Trim();
            if (!IsValidMobilePhone(mphone))
            {
                return;
            }

            // Validate empcon_HN.Text
            string telephone = telNumberTB.Text.Trim();
            if (!IsValidTelephone(telephone))
            {
                return;
            }

            if (string.IsNullOrEmpty(empNumTB.Text) || string.IsNullOrEmpty(firstNameTB.Text) || string.IsNullOrEmpty(initialNameTB.Text) || string.IsNullOrEmpty(lastNameTB.Text)
            || string.IsNullOrEmpty(telNumberTB.Text) || string.IsNullOrEmpty(phoneTB.Text) || string.IsNullOrEmpty(emailTB.Text) || string.IsNullOrEmpty(addressTB.Text) || barangayCMB.SelectedIndex == -1 ||
            provinceCMB.SelectedIndex == -1 || genderCMB.SelectedIndex == -1 || string.IsNullOrEmpty(postalTB.Text) || profilePictureBox.Image == null || statusCMB.SelectedIndex == -1 || cityCMB.SelectedIndex == -1
             || occupationCMB.SelectedIndex == -1 || departmentCMB.SelectedIndex == -1 || statusCMB.SelectedIndex == -1 || genderCMB.SelectedIndex == -1 || timeinCMB.SelectedIndex == -1 || timeoutCMB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connection.Open();

                    // Update employee information using employeenum as a condition
                    string query = "UPDATE employee SET employeenum = @employeenum, occupation = @occupation, department = @department, jobstatus = @jobstatus, " +
                        "firstname = @firstname, middle = @middlename, lastname = @lastname, suffix = @suffix, gender = @gender, dob = @dob, homenum = @homenum, " +
                        "phonenum = @phonenum, email = @email, address = @address, province = @province, " +
                        "city = @city, barangay = @barangay, postal = @postal, hiredate = @hiredate, timein = @timein, timeout = @timeout, image_data = @imageData" +
                        " WHERE id = @id";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Convert image to byte array
                    byte[] imageData = ImageToByteArray(profilePictureBox.Image);

                    // Add parameters
                    command.Parameters.AddWithValue("@id", textBox9.Text);
                    command.Parameters.AddWithValue("@employeenum", empNumTB.Text);
                    command.Parameters.AddWithValue("@occupation", occupationCMB.Text);
                    command.Parameters.AddWithValue("@department", departmentCMB.Text);
                    command.Parameters.AddWithValue("@jobstatus", statusCMB.Text);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@middlename", middlename);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@suffix", suffixNameTB.Text);
                    command.Parameters.AddWithValue("@gender", genderCMB.Text);
                    command.Parameters.AddWithValue("@dob", dobDTP.Value);
                    command.Parameters.AddWithValue("@homenum", telNumberTB.Text);
                    command.Parameters.AddWithValue("@phonenum", phoneTB.Text);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@address", addressTB.Text);
                    command.Parameters.AddWithValue("@province", provinceCMB.Text);
                    command.Parameters.AddWithValue("@city", cityCMB.Text);
                    command.Parameters.AddWithValue("@barangay", barangayCMB.Text);
                    command.Parameters.AddWithValue("@postal", postalTB.Text);
                    command.Parameters.AddWithValue("@hiredate", hireDTP.Value);
                    command.Parameters.AddWithValue("@timein", timeinCMB.Text);  // Include if comboBox6 is a valid field in your form
                    command.Parameters.AddWithValue("@timeout", timeoutCMB.Text);  // Include if comboBox7 is a valid field in your form
                    command.Parameters.AddWithValue("@imageData", imageData);

                    // Execute the query
                    command.ExecuteNonQuery();

                    MessageBox.Show("Employee Information Updated Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //UPLOAD AND DISPLAYS IMAGE

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                profilePictureBox.Image = Image.FromFile(imagePath);

            }
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

        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //LIMITS DIGITS NUMBERS FOR PHONE NUMBER
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
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
            }
        }

        private void EditButtonForm_Load(object sender, EventArgs e)
        {
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;


            {
                // Populate ComboBox1 with provinces
                provinceCMB.Items.Add("Abra");
                provinceCMB.Items.Add("Agusan del Norte");
                provinceCMB.Items.Add("Agusan del Sur");
                provinceCMB.Items.Add("Aklan");
                provinceCMB.Items.Add("Albay");
                provinceCMB.Items.Add("Antique");
                provinceCMB.Items.Add("Apayao");
                provinceCMB.Items.Add("Aurora");
                provinceCMB.Items.Add("Basilan");
                provinceCMB.Items.Add("Bataan");
                provinceCMB.Items.Add("Batanes");
                provinceCMB.Items.Add("Batangas");
                provinceCMB.Items.Add("Benguet");
                provinceCMB.Items.Add("Biliran");
                provinceCMB.Items.Add("Bohol");
                provinceCMB.Items.Add("Bukidnon");
                provinceCMB.Items.Add("Bulacan");
                provinceCMB.Items.Add("Cagayan");
                provinceCMB.Items.Add("Camarines Norte");
                provinceCMB.Items.Add("Camarines Sur");
                provinceCMB.Items.Add("Camiguin");
                provinceCMB.Items.Add("Capiz");
                provinceCMB.Items.Add("Catanduanes");
                provinceCMB.Items.Add("Cavite");
                provinceCMB.Items.Add("Cebu");
                provinceCMB.Items.Add("Cotabato");
                provinceCMB.Items.Add("Davao de Oro");
                provinceCMB.Items.Add("Davao del Norte");
                provinceCMB.Items.Add("Davao del Sur");
                provinceCMB.Items.Add("Davao Occidental");
                provinceCMB.Items.Add("Davao Oriental");
                provinceCMB.Items.Add("Dinagat Islands");
                provinceCMB.Items.Add("Eastern Samar");
                provinceCMB.Items.Add("Guimaras");
                provinceCMB.Items.Add("Ifugao");
                provinceCMB.Items.Add("Ilocos Norte");
                provinceCMB.Items.Add("Ilocos Sur");
                provinceCMB.Items.Add("Iloilo");
                provinceCMB.Items.Add("Isabela");
                provinceCMB.Items.Add("Kalinga");
                provinceCMB.Items.Add("La Union");
                provinceCMB.Items.Add("Laguna");
                provinceCMB.Items.Add("Lanao del Norte");
                provinceCMB.Items.Add("Lanao del Sur");
                provinceCMB.Items.Add("Leyte");
                provinceCMB.Items.Add("Maguindanao del Norte");
                provinceCMB.Items.Add("Maguindanao del Sur");
                provinceCMB.Items.Add("Marinduque");
                provinceCMB.Items.Add("Masbate");
                provinceCMB.Items.Add("Misamis Occidental");
                provinceCMB.Items.Add("Misamis Oriental");
                provinceCMB.Items.Add("Mountain Province");
                provinceCMB.Items.Add("Negros Occidental");
                provinceCMB.Items.Add("Negros Oriental");
                provinceCMB.Items.Add("Northern Samar");
                provinceCMB.Items.Add("Nueva Ecija");
                provinceCMB.Items.Add("Nueva Vizcaya");
                provinceCMB.Items.Add("Occidental Mindoro");
                provinceCMB.Items.Add("Oriental Mindoro");
                provinceCMB.Items.Add("Palawan");
                provinceCMB.Items.Add("Pampanga");
                provinceCMB.Items.Add("Pangasinan");
                provinceCMB.Items.Add("Quezon");
                provinceCMB.Items.Add("Quirino");
                provinceCMB.Items.Add("Rizal");
                provinceCMB.Items.Add("Romblon");
                provinceCMB.Items.Add("Samar");
                provinceCMB.Items.Add("Sarangani");
                provinceCMB.Items.Add("Siquijor");
                provinceCMB.Items.Add("Sorsogon");
                provinceCMB.Items.Add("South Cotabato");
                provinceCMB.Items.Add("Southern Leyte");
                provinceCMB.Items.Add("Sultan Kudarat");
                provinceCMB.Items.Add("Sulu");
                provinceCMB.Items.Add("Surigao del Norte");
                provinceCMB.Items.Add("Surigao del Sur");
                provinceCMB.Items.Add("Tarlac");
                provinceCMB.Items.Add("Tawi-Tawi");
                provinceCMB.Items.Add("Zambales");
                provinceCMB.Items.Add("Zamboanga del Norte");
                provinceCMB.Items.Add("Zamboanga del Sur");
                provinceCMB.Items.Add("Zamboanga Sibugay");
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                // Clear existing items in ComboBox2
                cityCMB.Items.Clear();

                // Get the selected province from ComboBox1
                string selectedProvince = provinceCMB.SelectedItem.ToString();

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
                        break;
                    case "Capiz":
                        cityCMB.Items.Add("Roxas City");
                        cityCMB.Items.Add("Panay");
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
                        break;
                    case "Eastern Samar":
                        cityCMB.Items.Add("Borongan");
                        cityCMB.Items.Add("Guiuan");
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
                        break;
                    case "Northern Samar":
                        cityCMB.Items.Add("Catarman");
                        cityCMB.Items.Add("Laoang");
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
                        break;
                    case "Samar":
                        cityCMB.Items.Add("Catbalogan");
                        cityCMB.Items.Add("Calbayog");
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
                        barangayCMB.Items.Add("Bagong Nayon");
                        barangayCMB.Items.Add("Beverly Hills");
                        barangayCMB.Items.Add("Calawis");
                        barangayCMB.Items.Add("Cupang");
                        barangayCMB.Items.Add("Dalig");
                        barangayCMB.Items.Add("Dela Paz");
                        barangayCMB.Items.Add("Inarawan");
                        barangayCMB.Items.Add("Mambugan");
                        barangayCMB.Items.Add("Mayamot");
                        barangayCMB.Items.Add("Muntindilaw");
                        barangayCMB.Items.Add("San Isidro");
                        barangayCMB.Items.Add("San Jose");
                        barangayCMB.Items.Add("San Juan");
                        barangayCMB.Items.Add("San Luis");
                        barangayCMB.Items.Add("San Roque");
                        barangayCMB.Items.Add("Santa Cruz");
                        break;
                    case "Rodriguez":
                        barangayCMB.Items.Add("Balite");
                        barangayCMB.Items.Add("Burgos");
                        barangayCMB.Items.Add("Geronimo");
                        barangayCMB.Items.Add("Macabud");
                        barangayCMB.Items.Add("Manggahan");
                        barangayCMB.Items.Add("Mascap");
                        barangayCMB.Items.Add("Puray");
                        barangayCMB.Items.Add("Rosario");
                        barangayCMB.Items.Add("San Isidro");
                        barangayCMB.Items.Add("San Jose");
                        barangayCMB.Items.Add("San Rafael");
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
                        barangayCMB.Items.Add("Ampid 1");
                        barangayCMB.Items.Add("Ampid 2");
                        barangayCMB.Items.Add("Banaba");
                        barangayCMB.Items.Add("Dulong Bayan 1");
                        barangayCMB.Items.Add("Dulong Bayan 2");
                        barangayCMB.Items.Add("Guinayang");
                        barangayCMB.Items.Add("Guitnang Bayan 1");
                        barangayCMB.Items.Add("Guitnang Bayan 2");
                        barangayCMB.Items.Add("Gulod Malaya"); 
                        barangayCMB.Items.Add("Malanday");
                        barangayCMB.Items.Add("Maly");
                        barangayCMB.Items.Add("Pintong Bukawe");
                        barangayCMB.Items.Add("Santa Ana");
                        barangayCMB.Items.Add("Santo Niño");
                        barangayCMB.Items.Add("Silangan");
                        break;
                    case "Baras":
                        barangayCMB.Items.Add("San Juan");
                        barangayCMB.Items.Add("Concepcion");
                        barangayCMB.Items.Add("Santiago");
                        barangayCMB.Items.Add("Evangelista");
                        barangayCMB.Items.Add("Mabini");
                        barangayCMB.Items.Add("San Salvador");
                        barangayCMB.Items.Add("San Jose");
                        barangayCMB.Items.Add("San Miguel");
                        barangayCMB.Items.Add("Rizal");
                        barangayCMB.Items.Add("Pinugay");
                        break;
                    case "Cardona":
                        barangayCMB.Items.Add("Calahan");
                        barangayCMB.Items.Add("Dalig");
                        barangayCMB.Items.Add("Del Remedio");
                        barangayCMB.Items.Add("Iglesia");
                        barangayCMB.Items.Add("Boliney");
                        barangayCMB.Items.Add("Looc");
                        barangayCMB.Items.Add("Nagsulo");
                        barangayCMB.Items.Add("Patunhay");
                        barangayCMB.Items.Add("Real");
                        barangayCMB.Items.Add("Sampad");
                        barangayCMB.Items.Add("San Roque");
                        barangayCMB.Items.Add("Ticulio");
                        break;
                    default:
                        break;
                }
            }
        }

        private void cameraButton_Click(object sender, EventArgs e)
        {
            Webcam webcam = new Webcam();

            // Get the data from the selected row
            string id = textBox9.Text;
            string firstname = firstNameTB.Text;
            string middlename = initialNameTB.Text;
            string lastname = lastNameTB.Text;
            string suffix = suffixNameTB.Text;
            string gender = genderCMB.Text;
            string dob = dobDTP.Text;
            string barangay = barangayCMB.Text;
            string address = addressTB.Text;
            string province = provinceCMB.Text;
            string city = cityCMB.Text;
            string postal = postalTB.Text;
            string phone = phoneTB.Text;
            string telephone = telNumberTB.Text;
            string email = emailTB.Text;
            string empnum = empNumTB.Text;
            string hdate = hireDTP.Text;
            string occupation = occupationCMB.Text;
            string department = departmentCMB.Text;
            string jobstatus = statusCMB.Text;
            string timein = timeinCMB.Text;
            string timeout = timeoutCMB.Text;




            //set the public properties of the textboxes on the second form
            webcam.id = id;
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

            // Show the second form as a dialog and wait for it to close
            //show the second form
            webcam.Show();
            this.Close();
        }

        public void SetCapturedImage(Bitmap capturedImage)
        {
            profilePictureBox.Image = capturedImage;
        }
    }
}
