using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Xamarin.Essentials;
using System.Drawing.Drawing2D;
using AForge.Video.DirectShow;
using AForge.Video;

namespace SCTAttendanceSystemUI.Forms
{

    public partial class addWebcam : Form
    {

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public addWebcam()
        {
            InitializeComponent();
            InitializeCamera();
            PopulateCameraList();
            deviceCMB.KeyPress += ComboBox_KeyPress;
            ApplyCircularMask(captureButton);

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
        public string barangay { get { return barangayCMB.Text; } set { barangayCMB.Text = value; } }

        private void ApplyCircularMask(System.Windows.Forms.Button captureButton)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, captureButton.Width, captureButton.Height);
                Region region = new Region(path);
                captureButton.Region = region;
            }
        }


        private void ComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Block any keypress event to prevent user input in the comboboxes
            e.Handled = true;
        }

        private void InitializeCamera()
        {
            // Get the available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // If there are video devices, initialize the camera with the first one
            if (videoDevices.Count > 0)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
            }
            else
            {
                MessageBox.Show("No video devices found.");
            }
        }
        private void PopulateCameraList()
        {
            // Populate a ComboBox with the available video devices
            foreach (FilterInfo device in videoDevices)
            {
                deviceCMB.Items.Add(device.Name);
            }

            if (videoDevices.Count > 0)
            {
                deviceCMB.SelectedIndex = 0; // Select the first device by default
            }
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Update the PictureBox with the captured frame
            webcamPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void StartCamera()
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
            }
        }

        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();

                Bitmap capturedImage = (Bitmap)webcamPictureBox.Image.Clone();

                // Create an instance of Form2
                AddEmployeeButtonForm addForm = new AddEmployeeButtonForm();


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


                addForm.firstname = firstname;
                addForm.middlename = middlename;
                addForm.lastname = lastname;
                addForm.suffix = suffix;
                addForm.gender = gender;
                addForm.dob = dob;
                addForm.barangay = barangay;
                addForm.address = address;
                addForm.province = province;
                addForm.city = city;
                addForm.postal = postal;
                addForm.phone = phone;
                addForm.telephone = telephone;
                addForm.email = email;
                addForm.empnum = empnum;
                addForm.hdate = hdate;
                addForm.occupation = occupation;
                addForm.department = department;
                addForm.jobstatus = jobstatus;
                addForm.timein = timein;
                addForm.timeout = timeout;

                // Display the captured image in Form2's PictureBox
                addForm.SetCapturedImage(capturedImage);
                addForm.Show();
                this.Close();

            }
        }

        private void addWebcam_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the camera when the form is closing
            StopCamera();
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

        private void provinceCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void deviceCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Stop the current camera
            StopCamera();

            // Initialize the selected camera
            videoSource = new VideoCaptureDevice(videoDevices[deviceCMB.SelectedIndex].MonikerString);
            videoSource.NewFrame += VideoSource_NewFrame;

            // Start the new camera
            StartCamera();
        }
    }


}
