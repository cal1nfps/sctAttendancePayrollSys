namespace SCTAttendanceSystemUI.Forms
{
    partial class addWebcam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addWebcam));
            deviceCMB = new ComboBox();
            captureButton = new Button();
            webcamPictureBox = new PictureBox();
            personalPanel = new Panel();
            barangayCMB = new ComboBox();
            postalTB = new TextBox();
            genderlbl = new Label();
            doblbl = new Label();
            cityCMB = new ComboBox();
            initialNameTB = new TextBox();
            suffixNameTB = new TextBox();
            lastNameTB = new TextBox();
            genderCMB = new ComboBox();
            dobDTP = new DateTimePicker();
            label7 = new Label();
            firstNameTB = new TextBox();
            label4 = new Label();
            addressTB = new TextBox();
            label3 = new Label();
            provinceCMB = new ComboBox();
            label1 = new Label();
            contactPanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            textBox13 = new TextBox();
            label6 = new Label();
            phoneTB = new TextBox();
            emailTB = new TextBox();
            telNumberTB = new TextBox();
            employmentPanel = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)webcamPictureBox).BeginInit();
            personalPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            employmentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // deviceCMB
            // 
            deviceCMB.BackColor = Color.White;
            deviceCMB.Cursor = Cursors.Hand;
            deviceCMB.FlatStyle = FlatStyle.Flat;
            deviceCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            deviceCMB.FormattingEnabled = true;
            deviceCMB.Location = new Point(877, 978);
            deviceCMB.Name = "deviceCMB";
            deviceCMB.Size = new Size(142, 23);
            deviceCMB.TabIndex = 78;
            deviceCMB.SelectedIndexChanged += deviceCMB_SelectedIndexChanged;
            // 
            // captureButton
            // 
            captureButton.AutoSize = true;
            captureButton.BackColor = Color.FromArgb(219, 20, 62);
            captureButton.BackgroundImageLayout = ImageLayout.Zoom;
            captureButton.Cursor = Cursors.Hand;
            captureButton.FlatAppearance.BorderSize = 0;
            captureButton.FlatStyle = FlatStyle.Flat;
            captureButton.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            captureButton.ForeColor = SystemColors.ControlDarkDark;
            captureButton.Image = (Image)resources.GetObject("captureButton.Image");
            captureButton.Location = new Point(921, 908);
            captureButton.Name = "captureButton";
            captureButton.RightToLeft = RightToLeft.No;
            captureButton.Size = new Size(70, 64);
            captureButton.TabIndex = 77;
            captureButton.TextAlign = ContentAlignment.MiddleLeft;
            captureButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            captureButton.UseVisualStyleBackColor = false;
            captureButton.Click += captureButton_Click;
            // 
            // webcamPictureBox
            // 
            webcamPictureBox.BackColor = Color.WhiteSmoke;
            webcamPictureBox.BorderStyle = BorderStyle.FixedSingle;
            webcamPictureBox.Location = new Point(12, 12);
            webcamPictureBox.Name = "webcamPictureBox";
            webcamPictureBox.Size = new Size(1880, 1017);
            webcamPictureBox.TabIndex = 76;
            webcamPictureBox.TabStop = false;
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.BorderStyle = BorderStyle.FixedSingle;
            personalPanel.Controls.Add(barangayCMB);
            personalPanel.Controls.Add(postalTB);
            personalPanel.Controls.Add(genderlbl);
            personalPanel.Controls.Add(doblbl);
            personalPanel.Controls.Add(cityCMB);
            personalPanel.Controls.Add(initialNameTB);
            personalPanel.Controls.Add(suffixNameTB);
            personalPanel.Controls.Add(lastNameTB);
            personalPanel.Controls.Add(genderCMB);
            personalPanel.Controls.Add(dobDTP);
            personalPanel.Controls.Add(label7);
            personalPanel.Controls.Add(firstNameTB);
            personalPanel.Controls.Add(label4);
            personalPanel.Controls.Add(addressTB);
            personalPanel.Controls.Add(label3);
            personalPanel.Controls.Add(provinceCMB);
            personalPanel.Controls.Add(label1);
            personalPanel.ForeColor = SystemColors.ControlText;
            personalPanel.Location = new Point(384, 278);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(607, 221);
            personalPanel.TabIndex = 79;
            // 
            // barangayCMB
            // 
            barangayCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            barangayCMB.FormattingEnabled = true;
            barangayCMB.Location = new Point(184, 141);
            barangayCMB.Name = "barangayCMB";
            barangayCMB.Size = new Size(147, 23);
            barangayCMB.TabIndex = 9;
            // 
            // postalTB
            // 
            postalTB.ForeColor = Color.Black;
            postalTB.Location = new Point(371, 141);
            postalTB.Name = "postalTB";
            postalTB.PlaceholderText = "Postal Code";
            postalTB.Size = new Size(105, 23);
            postalTB.TabIndex = 10;
            // 
            // genderlbl
            // 
            genderlbl.AutoSize = true;
            genderlbl.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            genderlbl.ForeColor = SystemColors.ControlDarkDark;
            genderlbl.Location = new Point(15, 65);
            genderlbl.Name = "genderlbl";
            genderlbl.Size = new Size(53, 14);
            genderlbl.TabIndex = 11;
            genderlbl.Text = "GENDER";
            // 
            // doblbl
            // 
            doblbl.AutoSize = true;
            doblbl.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            doblbl.ForeColor = SystemColors.ControlDarkDark;
            doblbl.Location = new Point(184, 68);
            doblbl.Name = "doblbl";
            doblbl.Size = new Size(90, 14);
            doblbl.TabIndex = 12;
            doblbl.Text = "DATE OF BIRTH";
            // 
            // cityCMB
            // 
            cityCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCMB.FormattingEnabled = true;
            cityCMB.Location = new Point(16, 141);
            cityCMB.Name = "cityCMB";
            cityCMB.Size = new Size(121, 23);
            cityCMB.TabIndex = 8;
            cityCMB.SelectedIndexChanged += cityCMB_SelectedIndexChanged;
            // 
            // initialNameTB
            // 
            initialNameTB.ForeColor = Color.Black;
            initialNameTB.Location = new Point(457, 27);
            initialNameTB.Name = "initialNameTB";
            initialNameTB.PlaceholderText = "M.I.";
            initialNameTB.Size = new Size(46, 23);
            initialNameTB.TabIndex = 3;
            // 
            // suffixNameTB
            // 
            suffixNameTB.ForeColor = Color.Black;
            suffixNameTB.Location = new Point(520, 27);
            suffixNameTB.Name = "suffixNameTB";
            suffixNameTB.PlaceholderText = "Suffix";
            suffixNameTB.Size = new Size(67, 23);
            suffixNameTB.TabIndex = 4;
            // 
            // lastNameTB
            // 
            lastNameTB.ForeColor = Color.Black;
            lastNameTB.Location = new Point(229, 27);
            lastNameTB.Name = "lastNameTB";
            lastNameTB.PlaceholderText = "Last Name";
            lastNameTB.Size = new Size(212, 23);
            lastNameTB.TabIndex = 2;
            // 
            // genderCMB
            // 
            genderCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            genderCMB.FormattingEnabled = true;
            genderCMB.Items.AddRange(new object[] { "Male", "Female" });
            genderCMB.Location = new Point(15, 85);
            genderCMB.Name = "genderCMB";
            genderCMB.Size = new Size(121, 23);
            genderCMB.TabIndex = 5;
            genderCMB.Tag = "";
            // 
            // dobDTP
            // 
            dobDTP.CustomFormat = "MM/dd/yyyy";
            dobDTP.Location = new Point(184, 85);
            dobDTP.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dobDTP.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dobDTP.Name = "dobDTP";
            dobDTP.Size = new Size(204, 23);
            dobDTP.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(146, 14);
            label7.TabIndex = 24;
            label7.Text = "PERSONAL INFORMATION";
            // 
            // firstNameTB
            // 
            firstNameTB.ForeColor = Color.Black;
            firstNameTB.Location = new Point(16, 27);
            firstNameTB.Name = "firstNameTB";
            firstNameTB.PlaceholderText = "First Name";
            firstNameTB.Size = new Size(207, 23);
            firstNameTB.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(184, 121);
            label4.Name = "label4";
            label4.Size = new Size(68, 14);
            label4.TabIndex = 25;
            label4.Text = "BARANGAY";
            // 
            // addressTB
            // 
            addressTB.ForeColor = Color.Black;
            addressTB.Location = new Point(15, 184);
            addressTB.Name = "addressTB";
            addressTB.PlaceholderText = "Address";
            addressTB.Size = new Size(418, 23);
            addressTB.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(426, 68);
            label3.Name = "label3";
            label3.Size = new Size(62, 14);
            label3.TabIndex = 26;
            label3.Text = "PROVINCE";
            // 
            // provinceCMB
            // 
            provinceCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            provinceCMB.FormattingEnabled = true;
            provinceCMB.Items.AddRange(new object[] { "Abra", "Agusan del Norte", "Agusan del Sur", "Aklan", "Albay", "Antique", "Apayao", "Aurora", "Basilan", "Bataan", "Batanes", "Batangas", "Benguet", "Biliran", "Bohol", "Bukidnon", "Bulacan", "Cagayan", "Camarines Norte", "Camarines Sur", "Camiguin", "Capiz", "Catanduanes", "Cavite", "Cebu", "Cotabato", "Davao de Oro", "Davao del Norte", "Davao del Sur", "Davao Occidental", "Davao Oriental", "Dinagat Islands", "Eastern Samar", "Guimaras", "Ifugao", "Ilocos Norte", "Ilocos Sur", "Iloilo", "Isabela", "Kalinga", "La Union", "Laguna", "Lanao del Norte", "Lanao del Sur", "Leyte", "Maguindanao del Norte", "Maguindanao del Sur", "Marinduque", "Masbate", "Misamis Occidental", "Misamis Oriental", "Mountain Province", "Negros Occidental", "Negros Oriental", "Northern Samar", "Nueva Ecija", "Nueva Vizcaya", "Occidental Mindoro", "Oriental Mindoro", "Palawan", "Pampanga", "Pangasinan", "Quezon", "Quirino", "Rizal", "Romblon", "Samar", "Sarangani", "Siquijor", "Sorsogon", "South Cotabato", "Southern Leyte", "Sultan Kudarat", "Sulu", "Surigao del Norte", "Surigao del Sur", "Tarlac", "Tawi-Tawi", "Zambales", "Zamboanga del Norte", "Zamboanga del Sur", "Zamboanga Sibugay" });
            provinceCMB.Location = new Point(426, 85);
            provinceCMB.Name = "provinceCMB";
            provinceCMB.Size = new Size(161, 23);
            provinceCMB.TabIndex = 7;
            provinceCMB.SelectedIndexChanged += provinceCMB_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(16, 123);
            label1.Name = "label1";
            label1.Size = new Size(30, 14);
            label1.TabIndex = 31;
            label1.Text = "CITY";
            // 
            // contactPanel
            // 
            contactPanel.BackColor = Color.White;
            contactPanel.BorderStyle = BorderStyle.FixedSingle;
            contactPanel.Controls.Add(label15);
            contactPanel.Controls.Add(label14);
            contactPanel.Controls.Add(textBox13);
            contactPanel.Controls.Add(label6);
            contactPanel.Controls.Add(phoneTB);
            contactPanel.Controls.Add(emailTB);
            contactPanel.Controls.Add(telNumberTB);
            contactPanel.ForeColor = SystemColors.ControlText;
            contactPanel.Location = new Point(384, 567);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(607, 145);
            contactPanel.TabIndex = 72;
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
            // 
            // employmentPanel
            // 
            employmentPanel.BackColor = Color.White;
            employmentPanel.BorderStyle = BorderStyle.FixedSingle;
            employmentPanel.Controls.Add(empNumTB);
            employmentPanel.Controls.Add(statusCMB);
            employmentPanel.Controls.Add(label18);
            employmentPanel.Controls.Add(timeoutCMB);
            employmentPanel.Controls.Add(label17);
            employmentPanel.Controls.Add(timeinCMB);
            employmentPanel.Controls.Add(label16);
            employmentPanel.Controls.Add(occupationCMB);
            employmentPanel.Controls.Add(departmentCMB);
            employmentPanel.Controls.Add(label13);
            employmentPanel.Controls.Add(label12);
            employmentPanel.Controls.Add(label8);
            employmentPanel.Controls.Add(label9);
            employmentPanel.Controls.Add(label11);
            employmentPanel.Controls.Add(hireDTP);
            employmentPanel.ForeColor = SystemColors.ControlText;
            employmentPanel.Location = new Point(177, 737);
            employmentPanel.Name = "employmentPanel";
            employmentPanel.Size = new Size(607, 235);
            employmentPanel.TabIndex = 73;
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
            hireDTP.Location = new Point(103, 76);
            hireDTP.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            hireDTP.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            hireDTP.Name = "hireDTP";
            hireDTP.Size = new Size(147, 23);
            hireDTP.TabIndex = 16;
            // 
            // addWebcam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1904, 1041);
            Controls.Add(employmentPanel);
            Controls.Add(contactPanel);
            Controls.Add(personalPanel);
            Controls.Add(deviceCMB);
            Controls.Add(captureButton);
            Controls.Add(webcamPictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            Name = "addWebcam";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Webcam";
            WindowState = FormWindowState.Maximized;
            FormClosing += addWebcam_FormClosing;
            ((System.ComponentModel.ISupportInitialize)webcamPictureBox).EndInit();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            employmentPanel.ResumeLayout(false);
            employmentPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox deviceCMB;
        private Button captureButton;
        private PictureBox webcamPictureBox;
        private Panel personalPanel;
        private ComboBox barangayCMB;
        private TextBox postalTB;
        private Label genderlbl;
        private Label doblbl;
        private ComboBox cityCMB;
        private TextBox initialNameTB;
        private TextBox suffixNameTB;
        private TextBox lastNameTB;
        private ComboBox genderCMB;
        private DateTimePicker dobDTP;
        private Label label7;
        private TextBox firstNameTB;
        private Label label4;
        private TextBox addressTB;
        private Label label3;
        private ComboBox provinceCMB;
        private Label label1;
        private Panel contactPanel;
        private Label label15;
        private Label label14;
        private TextBox textBox13;
        private Label label6;
        private TextBox phoneTB;
        private TextBox emailTB;
        private TextBox telNumberTB;
        private Panel employmentPanel;
        private TextBox empNumTB;
        private ComboBox statusCMB;
        private Label label18;
        private ComboBox timeoutCMB;
        private Label label17;
        private ComboBox timeinCMB;
        private Label label16;
        private ComboBox occupationCMB;
        private ComboBox departmentCMB;
        private Label label13;
        private Label label12;
        private Label label8;
        private Label label9;
        private Label label11;
        private DateTimePicker hireDTP;
    }
}