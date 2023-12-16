namespace SCTAttendanceSystemUI.Forms
{
    partial class EditButtonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditButtonForm));
            personalButton = new Button();
            panel1 = new Panel();
            barangayCMB = new ComboBox();
            textBox9 = new TextBox();
            saveButton = new Button();
            cityCMB = new ComboBox();
            suffixNameTB = new TextBox();
            cancelButton = new Button();
            confirmButton = new Button();
            label7 = new Label();
            profilePictureBox = new PictureBox();
            panel3 = new Panel();
            empNumTB = new TextBox();
            statusCMB = new ComboBox();
            label18 = new Label();
            timeoutCMB = new ComboBox();
            label17 = new Label();
            timeinCMB = new ComboBox();
            label16 = new Label();
            occupationCMB = new ComboBox();
            departmentCMB = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            hireDTP = new DateTimePicker();
            label3 = new Label();
            postalTB = new TextBox();
            label1 = new Label();
            provinceCMB = new ComboBox();
            addressTB = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            label15 = new Label();
            label14 = new Label();
            textBox13 = new TextBox();
            label6 = new Label();
            phoneTB = new TextBox();
            emailTB = new TextBox();
            telNumberTB = new TextBox();
            firstNameTB = new TextBox();
            dobDTP = new DateTimePicker();
            genderCMB = new ComboBox();
            lastNameTB = new TextBox();
            initialNameTB = new TextBox();
            doblbl = new Label();
            genderlbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // personalButton
            // 
            personalButton.BackColor = Color.White;
            personalButton.BackgroundImageLayout = ImageLayout.None;
            personalButton.FlatAppearance.BorderColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.BorderSize = 2;
            personalButton.FlatAppearance.CheckedBackColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 209, 10);
            personalButton.FlatStyle = FlatStyle.Flat;
            personalButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personalButton.ForeColor = SystemColors.ControlText;
            personalButton.Location = new Point(-1, -1);
            personalButton.Name = "personalButton";
            personalButton.Size = new Size(98, 41);
            personalButton.TabIndex = 0;
            personalButton.Text = "Information";
            personalButton.UseMnemonic = false;
            personalButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(barangayCMB);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(cityCMB);
            panel1.Controls.Add(suffixNameTB);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(confirmButton);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(profilePictureBox);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(postalTB);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(provinceCMB);
            panel1.Controls.Add(addressTB);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(firstNameTB);
            panel1.Controls.Add(dobDTP);
            panel1.Controls.Add(genderCMB);
            panel1.Controls.Add(lastNameTB);
            panel1.Controls.Add(initialNameTB);
            panel1.Controls.Add(doblbl);
            panel1.Controls.Add(genderlbl);
            panel1.Location = new Point(-1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 712);
            panel1.TabIndex = 3;
            // 
            // barangayCMB
            // 
            barangayCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            barangayCMB.FormattingEnabled = true;
            barangayCMB.Location = new Point(211, 167);
            barangayCMB.Name = "barangayCMB";
            barangayCMB.Size = new Size(147, 23);
            barangayCMB.TabIndex = 9;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.ForeColor = Color.Silver;
            textBox9.Location = new Point(1012, 50);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(39, 23);
            textBox9.TabIndex = 58;
            textBox9.Visible = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.Transparent;
            saveButton.BackgroundImage = (Image)resources.GetObject("saveButton.BackgroundImage");
            saveButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(955, 203);
            saveButton.Name = "saveButton";
            saveButton.Padding = new Padding(10, 0, 0, 0);
            saveButton.Size = new Size(43, 37);
            saveButton.TabIndex = 22;
            saveButton.TextAlign = ContentAlignment.MiddleLeft;
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button2_Click;
            // 
            // cityCMB
            // 
            cityCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCMB.FormattingEnabled = true;
            cityCMB.Location = new Point(42, 167);
            cityCMB.Name = "cityCMB";
            cityCMB.Size = new Size(121, 23);
            cityCMB.TabIndex = 8;
            cityCMB.SelectedIndexChanged += cityCMB_SelectedIndexChanged;
            // 
            // suffixNameTB
            // 
            suffixNameTB.ForeColor = Color.Black;
            suffixNameTB.Location = new Point(640, 50);
            suffixNameTB.Name = "suffixNameTB";
            suffixNameTB.PlaceholderText = "Suffix";
            suffixNameTB.Size = new Size(67, 23);
            suffixNameTB.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(1026, 633);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 23;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = SystemColors.ActiveCaption;
            confirmButton.BackgroundImageLayout = ImageLayout.None;
            confirmButton.FlatAppearance.BorderColor = Color.DimGray;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.ForeColor = SystemColors.ControlText;
            confirmButton.Location = new Point(932, 633);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(88, 34);
            confirmButton.TabIndex = 24;
            confirmButton.Text = "Confirm";
            confirmButton.UseMnemonic = false;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(38, 21);
            label7.Name = "label7";
            label7.Size = new Size(146, 14);
            label7.TabIndex = 24;
            label7.Text = "PERSONAL INFORMATION";
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.WhiteSmoke;
            profilePictureBox.BorderStyle = BorderStyle.FixedSingle;
            profilePictureBox.Location = new Point(806, 50);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(200, 200);
            profilePictureBox.TabIndex = 36;
            profilePictureBox.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(empNumTB);
            panel3.Controls.Add(statusCMB);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(timeoutCMB);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(timeinCMB);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(occupationCMB);
            panel3.Controls.Add(departmentCMB);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(hireDTP);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(22, 432);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 235);
            panel3.TabIndex = 34;
            // 
            // empNumTB
            // 
            empNumTB.ForeColor = Color.Black;
            empNumTB.Location = new Point(103, 47);
            empNumTB.Name = "empNumTB";
            empNumTB.Size = new Size(147, 23);
            empNumTB.TabIndex = 67;
            // 
            // statusCMB
            // 
            statusCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCMB.FormattingEnabled = true;
            statusCMB.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            statusCMB.Location = new Point(103, 163);
            statusCMB.Name = "statusCMB";
            statusCMB.Size = new Size(147, 23);
            statusCMB.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(23, 166);
            label18.Name = "label18";
            label18.Size = new Size(74, 14);
            label18.TabIndex = 66;
            label18.Text = "JOB STATUS";
            // 
            // timeoutCMB
            // 
            timeoutCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            timeoutCMB.FormattingEnabled = true;
            timeoutCMB.Items.AddRange(new object[] { "4:00 PM", "5:00 PM", "6:00 PM" });
            timeoutCMB.Location = new Point(371, 111);
            timeoutCMB.Name = "timeoutCMB";
            timeoutCMB.Size = new Size(147, 23);
            timeoutCMB.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(308, 115);
            label17.Name = "label17";
            label17.Size = new Size(57, 14);
            label17.TabIndex = 62;
            label17.Text = "TIME OUT";
            // 
            // timeinCMB
            // 
            timeinCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            timeinCMB.FormattingEnabled = true;
            timeinCMB.Items.AddRange(new object[] { "7:00 AM", "8:00 AM", "9:00 AM" });
            timeinCMB.Location = new Point(371, 82);
            timeinCMB.Name = "timeinCMB";
            timeinCMB.Size = new Size(147, 23);
            timeinCMB.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(319, 86);
            label16.Name = "label16";
            label16.Size = new Size(46, 14);
            label16.TabIndex = 60;
            label16.Text = "TIME IN";
            // 
            // occupationCMB
            // 
            occupationCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            occupationCMB.FormattingEnabled = true;
            occupationCMB.Items.AddRange(new object[] { "Teacher", "Sports Coach", "School Nurse", "Maintenance Technician", "Registrar", "Guidance Counselor", "Guard", "Chairperson" });
            occupationCMB.Location = new Point(103, 105);
            occupationCMB.Name = "occupationCMB";
            occupationCMB.Size = new Size(147, 23);
            occupationCMB.TabIndex = 17;
            // 
            // departmentCMB
            // 
            departmentCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCMB.FormattingEnabled = true;
            departmentCMB.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            departmentCMB.Location = new Point(103, 134);
            departmentCMB.Name = "departmentCMB";
            departmentCMB.Size = new Size(147, 23);
            departmentCMB.TabIndex = 18;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(17, 137);
            label13.Name = "label13";
            label13.Size = new Size(80, 14);
            label13.TabIndex = 58;
            label13.Text = "DEPARTMENT";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(10, 10);
            label12.Name = "label12";
            label12.Size = new Size(160, 14);
            label12.TabIndex = 35;
            label12.Text = "EMPLOYMENT INFORMATION";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(21, 108);
            label8.Name = "label8";
            label8.Size = new Size(76, 14);
            label8.TabIndex = 24;
            label8.Text = "OCCUPATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(32, 82);
            label9.Name = "label9";
            label9.Size = new Size(65, 14);
            label9.TabIndex = 21;
            label9.Text = "HIRE DATE";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(10, 50);
            label11.Name = "label11";
            label11.Size = new Size(87, 14);
            label11.TabIndex = 18;
            label11.Text = "EMPLOYEE NO.";
            // 
            // hireDTP
            // 
            hireDTP.CustomFormat = "MM/dd/yyyy";
            hireDTP.Format = DateTimePickerFormat.Custom;
            hireDTP.Location = new Point(103, 76);
            hireDTP.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            hireDTP.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            hireDTP.Name = "hireDTP";
            hireDTP.Size = new Size(147, 23);
            hireDTP.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(468, 90);
            label3.Name = "label3";
            label3.Size = new Size(62, 14);
            label3.TabIndex = 26;
            label3.Text = "PROVINCE";
            // 
            // postalTB
            // 
            postalTB.ForeColor = Color.Black;
            postalTB.Location = new Point(404, 167);
            postalTB.Name = "postalTB";
            postalTB.PlaceholderText = "Postal Code";
            postalTB.Size = new Size(105, 23);
            postalTB.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(42, 149);
            label1.Name = "label1";
            label1.Size = new Size(30, 14);
            label1.TabIndex = 31;
            label1.Text = "CITY";
            // 
            // provinceCMB
            // 
            provinceCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            provinceCMB.FormattingEnabled = true;
            provinceCMB.Items.AddRange(new object[] { "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Cotabato", "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao del Norte", "Maguindanao del Sur", "Marinduque", "Masbate", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay" });
            provinceCMB.Location = new Point(468, 107);
            provinceCMB.Name = "provinceCMB";
            provinceCMB.Size = new Size(161, 23);
            provinceCMB.TabIndex = 7;
            provinceCMB.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // addressTB
            // 
            addressTB.ForeColor = Color.Black;
            addressTB.Location = new Point(42, 211);
            addressTB.Name = "addressTB";
            addressTB.PlaceholderText = "Address";
            addressTB.Size = new Size(316, 23);
            addressTB.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(211, 147);
            label4.Name = "label4";
            label4.Size = new Size(68, 14);
            label4.TabIndex = 25;
            label4.Text = "BARANGAY";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(phoneTB);
            panel2.Controls.Add(emailTB);
            panel2.Controls.Add(telNumberTB);
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(22, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 145);
            panel2.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(381, 38);
            label15.Name = "label15";
            label15.Size = new Size(72, 14);
            label15.TabIndex = 35;
            label15.Text = "TELEPHONE";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(72, 81);
            label14.Name = "label14";
            label14.Size = new Size(41, 14);
            label14.TabIndex = 35;
            label14.Text = "EMAIL";
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.ForeColor = Color.Silver;
            textBox13.Location = new Point(16, 38);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(39, 23);
            textBox13.TabIndex = 57;
            textBox13.Text = "+63";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(10, 9);
            label6.Name = "label6";
            label6.Size = new Size(136, 14);
            label6.TabIndex = 23;
            label6.Text = "CONTACT INFORMATION";
            // 
            // phoneTB
            // 
            phoneTB.ForeColor = Color.Black;
            phoneTB.Location = new Point(72, 38);
            phoneTB.Name = "phoneTB";
            phoneTB.PlaceholderText = "Phone Number";
            phoneTB.Size = new Size(206, 23);
            phoneTB.TabIndex = 12;
            phoneTB.KeyPress += textBox5_KeyPress_1;
            // 
            // emailTB
            // 
            emailTB.ForeColor = Color.Black;
            emailTB.Location = new Point(72, 98);
            emailTB.Name = "emailTB";
            emailTB.PlaceholderText = "Email";
            emailTB.Size = new Size(206, 23);
            emailTB.TabIndex = 13;
            // 
            // telNumberTB
            // 
            telNumberTB.ForeColor = Color.Black;
            telNumberTB.Location = new Point(381, 55);
            telNumberTB.Name = "telNumberTB";
            telNumberTB.PlaceholderText = "Telephone Number";
            telNumberTB.Size = new Size(206, 23);
            telNumberTB.TabIndex = 14;
            telNumberTB.KeyPress += textBox8_KeyPress_1;
            // 
            // firstNameTB
            // 
            firstNameTB.ForeColor = Color.Black;
            firstNameTB.Location = new Point(42, 50);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.PlaceholderText = "First Name";
            firstNameTB.Size = new Size(207, 23);
            firstNameTB.TabIndex = 1;
            // 
            // dobDTP
            // 
            dobDTP.CustomFormat = "MM/dd/yyyy";
            dobDTP.Location = new Point(211, 107);
            dobDTP.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dobDTP.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dobDTP.Name = "dobDTP";
            dobDTP.Size = new Size(204, 23);
            dobDTP.TabIndex = 6;
            // 
            // genderCMB
            // 
            genderCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCMB.FormattingEnabled = true;
            genderCMB.Items.AddRange(new object[] { "Male", "Female" });
            genderCMB.Location = new Point(42, 107);
            genderCMB.Name = "genderCMB";
            genderCMB.Size = new Size(121, 23);
            genderCMB.TabIndex = 5;
            genderCMB.Tag = "";
            // 
            // lastNameTB
            // 
            lastNameTB.ForeColor = Color.Black;
            lastNameTB.Location = new Point(310, 50);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.PlaceholderText = "Last Name";
            lastNameTB.Size = new Size(212, 23);
            lastNameTB.TabIndex = 2;
            // 
            // initialNameTB
            // 
            initialNameTB.ForeColor = Color.Black;
            initialNameTB.Location = new Point(564, 50);
            initialNameTB.Name = "initialNameTB";
            initialNameTB.PlaceholderText = "M.I.";
            initialNameTB.Size = new Size(46, 23);
            initialNameTB.TabIndex = 3;
            // 
            // doblbl
            // 
            doblbl.AutoSize = true;
            doblbl.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            doblbl.ForeColor = SystemColors.ControlDarkDark;
            doblbl.Location = new Point(211, 87);
            doblbl.Name = "doblbl";
            doblbl.Size = new Size(90, 14);
            doblbl.TabIndex = 12;
            doblbl.Text = "DATE OF BIRTH";
            // 
            // genderlbl
            // 
            genderlbl.AutoSize = true;
            genderlbl.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genderlbl.ForeColor = SystemColors.ControlDarkDark;
            genderlbl.Location = new Point(42, 87);
            genderlbl.Name = "genderlbl";
            genderlbl.Size = new Size(53, 14);
            genderlbl.TabIndex = 11;
            genderlbl.Text = "GENDER";
            // 
            // EditButtonForm
            // 
            BackColor = Color.FromArgb(164, 16, 48);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1159, 746);
            Controls.Add(panel1);
            Controls.Add(personalButton);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(537, 324);
            Name = "EditButtonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += EditButtonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button cancelButton;
        private Button personalButton;
        private Panel panel1;
        private Button confirmButton;
        private TextBox firstNameTB;
        private DateTimePicker dobDTP;
        private ComboBox genderCMB;
        private TextBox lastNameTB;
        private TextBox initialNameTB;
        private Label doblbl;
        private Label genderlbl;
        private TextBox postalTB;
        private Label label1;
        private ComboBox provinceCMB;
        private TextBox addressTB;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label6;
        private TextBox emailTB;
        private TextBox telNumberTB;
        private TextBox phoneTB;
        private Label label7;
        private Panel panel3;
        private Label label8;
        private Label label9;
        private Label label11;
        private DateTimePicker hireDTP;
        private Label label12;
        private Button saveButton;
        private PictureBox profilePictureBox;
        private TextBox textBox13;
        private ComboBox occupationCMB;
        private ComboBox departmentCMB;
        private Label label13;
        private Label label15;
        private Label label14;
        private TextBox suffixNameTB;
        private ComboBox timeoutCMB;
        private Label label17;
        private ComboBox timeinCMB;
        private Label label16;
        private ComboBox statusCMB;
        private Label label18;
        private ComboBox cityCMB;
        private TextBox empNumTB;
        private TextBox textBox9;
        private ComboBox barangayCMB;
    }
}