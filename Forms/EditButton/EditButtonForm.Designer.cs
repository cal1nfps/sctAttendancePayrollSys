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
            cameraButton = new Button();
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
            textBox9 = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            confirmButton = new Button();
            profilePictureBox = new PictureBox();
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
            contactPanel = new Panel();
            label15 = new Label();
            label14 = new Label();
            textBox13 = new TextBox();
            label6 = new Label();
            phoneTB = new TextBox();
            emailTB = new TextBox();
            telNumberTB = new TextBox();
            panel1.SuspendLayout();
            personalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            employmentPanel.SuspendLayout();
            contactPanel.SuspendLayout();
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
            panel1.Controls.Add(cameraButton);
            panel1.Controls.Add(personalPanel);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(confirmButton);
            panel1.Controls.Add(profilePictureBox);
            panel1.Controls.Add(employmentPanel);
            panel1.Controls.Add(contactPanel);
            panel1.Location = new Point(-1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 712);
            panel1.TabIndex = 3;
            // 
            // cameraButton
            // 
            cameraButton.AutoSize = true;
            cameraButton.BackColor = Color.FromArgb(219, 20, 62);
            cameraButton.BackgroundImageLayout = ImageLayout.Zoom;
            cameraButton.Cursor = Cursors.Hand;
            cameraButton.FlatAppearance.BorderSize = 0;
            cameraButton.FlatStyle = FlatStyle.Flat;
            cameraButton.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cameraButton.ForeColor = SystemColors.ControlDarkDark;
            cameraButton.Image = (Image)resources.GetObject("cameraButton.Image");
            cameraButton.ImageAlign = ContentAlignment.MiddleLeft;
            cameraButton.Location = new Point(867, 460);
            cameraButton.Name = "cameraButton";
            cameraButton.RightToLeft = RightToLeft.No;
            cameraButton.Size = new Size(41, 38);
            cameraButton.TabIndex = 23;
            cameraButton.TextAlign = ContentAlignment.MiddleLeft;
            cameraButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cameraButton.UseVisualStyleBackColor = false;
            cameraButton.Click += cameraButton_Click;
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
            personalPanel.Location = new Point(22, 19);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(607, 221);
            personalPanel.TabIndex = 67;
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
            provinceCMB.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
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
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.ForeColor = Color.Silver;
            textBox9.Location = new Point(1063, 23);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(39, 23);
            textBox9.TabIndex = 58;
            textBox9.Visible = false;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(219, 20, 62);
            saveButton.BackgroundImageLayout = ImageLayout.Zoom;
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Image = (Image)resources.GetObject("saveButton.Image");
            saveButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveButton.Location = new Point(914, 459);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(41, 38);
            saveButton.TabIndex = 22;
            saveButton.TextAlign = ContentAlignment.MiddleLeft;
            saveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += button2_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(1026, 633);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 24;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(219, 20, 62);
            confirmButton.BackgroundImageLayout = ImageLayout.None;
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.FlatAppearance.BorderColor = Color.DimGray;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(932, 633);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(88, 34);
            confirmButton.TabIndex = 25;
            confirmButton.Text = "Confirm";
            confirmButton.UseMnemonic = false;
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += button1_Click;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackColor = Color.WhiteSmoke;
            profilePictureBox.BorderStyle = BorderStyle.FixedSingle;
            profilePictureBox.Location = new Point(702, 49);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(400, 400);
            profilePictureBox.TabIndex = 36;
            profilePictureBox.TabStop = false;
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
            employmentPanel.Location = new Point(22, 432);
            employmentPanel.Name = "employmentPanel";
            employmentPanel.Size = new Size(607, 235);
            employmentPanel.TabIndex = 34;
            // 
            // empNumTB
            // 
            empNumTB.ForeColor = Color.Black;
            empNumTB.Location = new Point(103, 47);
            empNumTB.Name = "empNumTB";
            empNumTB.Size = new Size(204, 23);
            empNumTB.TabIndex = 67;
            // 
            // statusCMB
            // 
            statusCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCMB.FormattingEnabled = true;
            statusCMB.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            statusCMB.Location = new Point(103, 163);
            statusCMB.Name = "statusCMB";
            statusCMB.Size = new Size(204, 23);
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
            timeoutCMB.Location = new Point(410, 108);
            timeoutCMB.Name = "timeoutCMB";
            timeoutCMB.Size = new Size(147, 23);
            timeoutCMB.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(347, 112);
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
            timeinCMB.Location = new Point(410, 79);
            timeinCMB.Name = "timeinCMB";
            timeinCMB.Size = new Size(147, 23);
            timeinCMB.TabIndex = 20;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(358, 83);
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
            occupationCMB.Size = new Size(204, 23);
            occupationCMB.TabIndex = 17;
            // 
            // departmentCMB
            // 
            departmentCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            departmentCMB.FormattingEnabled = true;
            departmentCMB.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            departmentCMB.Location = new Point(103, 134);
            departmentCMB.Name = "departmentCMB";
            departmentCMB.Size = new Size(204, 23);
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
            hireDTP.Size = new Size(204, 23);
            hireDTP.TabIndex = 16;
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
            contactPanel.Location = new Point(22, 261);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(607, 145);
            contactPanel.TabIndex = 33;
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
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            employmentPanel.ResumeLayout(false);
            employmentPanel.PerformLayout();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
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
        private Panel contactPanel;
        private Label label6;
        private TextBox emailTB;
        private TextBox telNumberTB;
        private TextBox phoneTB;
        private Label label7;
        private Panel employmentPanel;
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
        private Panel personalPanel;
        private Button cameraButton;
    }
}