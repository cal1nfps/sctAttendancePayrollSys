namespace SCTAttendanceSystemUI.Forms
{
    partial class AddEmployeeButtonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeButtonForm));
            personalButton = new Button();
            panel1 = new Panel();
            cameraButton = new Button();
            personalPanel = new Panel();
            label7 = new Label();
            FirstName = new TextBox();
            LastName = new TextBox();
            MiddleName = new TextBox();
            Suffix = new TextBox();
            cityCMB = new ComboBox();
            Address = new TextBox();
            Province = new ComboBox();
            PostalCode = new TextBox();
            label1 = new Label();
            label20 = new Label();
            doblbl = new Label();
            barangayCMB = new ComboBox();
            Gender = new ComboBox();
            DateOfBirth = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            employmentPanel = new Panel();
            label21 = new Label();
            HireDate = new DateTimePicker();
            label8 = new Label();
            label13 = new Label();
            TimeOut = new ComboBox();
            JobStatus = new ComboBox();
            label17 = new Label();
            label9 = new Label();
            Department = new ComboBox();
            EmployeeNum = new TextBox();
            TimeIn = new ComboBox();
            label18 = new Label();
            label16 = new Label();
            Occupation = new ComboBox();
            label11 = new Label();
            contactPanel = new Panel();
            label5 = new Label();
            label2 = new Label();
            textBox13 = new TextBox();
            label19 = new Label();
            Telephone = new TextBox();
            phoneNum = new TextBox();
            Email = new TextBox();
            cancelButton = new Button();
            Confirm = new Button();
            UploadImage = new Button();
            ProfilePic = new PictureBox();
            panel1.SuspendLayout();
            personalPanel.SuspendLayout();
            employmentPanel.SuspendLayout();
            contactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).BeginInit();
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
            panel1.Controls.Add(employmentPanel);
            panel1.Controls.Add(contactPanel);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(Confirm);
            panel1.Controls.Add(UploadImage);
            panel1.Controls.Add(ProfilePic);
            panel1.Location = new Point(-1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 710);
            panel1.TabIndex = 0;
            panel1.TabStop = true;
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
            cameraButton.Location = new Point(865, 459);
            cameraButton.Name = "cameraButton";
            cameraButton.RightToLeft = RightToLeft.No;
            cameraButton.Size = new Size(41, 38);
            cameraButton.TabIndex = 23;
            cameraButton.TextAlign = ContentAlignment.MiddleLeft;
            cameraButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            cameraButton.UseVisualStyleBackColor = false;
            cameraButton.Click += cameraButton_Click_1;
            // 
            // personalPanel
            // 
            personalPanel.BackColor = Color.White;
            personalPanel.BorderStyle = BorderStyle.FixedSingle;
            personalPanel.Controls.Add(label7);
            personalPanel.Controls.Add(FirstName);
            personalPanel.Controls.Add(LastName);
            personalPanel.Controls.Add(MiddleName);
            personalPanel.Controls.Add(Suffix);
            personalPanel.Controls.Add(cityCMB);
            personalPanel.Controls.Add(Address);
            personalPanel.Controls.Add(Province);
            personalPanel.Controls.Add(PostalCode);
            personalPanel.Controls.Add(label1);
            personalPanel.Controls.Add(label20);
            personalPanel.Controls.Add(doblbl);
            personalPanel.Controls.Add(barangayCMB);
            personalPanel.Controls.Add(Gender);
            personalPanel.Controls.Add(DateOfBirth);
            personalPanel.Controls.Add(label4);
            personalPanel.Controls.Add(label3);
            personalPanel.ForeColor = SystemColors.ControlText;
            personalPanel.Location = new Point(22, 21);
            personalPanel.Name = "personalPanel";
            personalPanel.Size = new Size(607, 221);
            personalPanel.TabIndex = 66;
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
            // FirstName
            // 
            FirstName.BackColor = Color.White;
            FirstName.ForeColor = Color.Black;
            FirstName.Location = new Point(16, 27);
            FirstName.Name = "FirstName";
            FirstName.PlaceholderText = "First Name";
            FirstName.Size = new Size(207, 23);
            FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            LastName.BackColor = Color.White;
            LastName.ForeColor = Color.Black;
            LastName.Location = new Point(229, 27);
            LastName.Name = "LastName";
            LastName.PlaceholderText = "Last Name";
            LastName.Size = new Size(212, 23);
            LastName.TabIndex = 2;
            // 
            // MiddleName
            // 
            MiddleName.BackColor = Color.White;
            MiddleName.ForeColor = Color.Black;
            MiddleName.Location = new Point(457, 27);
            MiddleName.Name = "MiddleName";
            MiddleName.PlaceholderText = "M.I.";
            MiddleName.Size = new Size(46, 23);
            MiddleName.TabIndex = 3;
            // 
            // Suffix
            // 
            Suffix.BackColor = Color.White;
            Suffix.ForeColor = Color.Black;
            Suffix.Location = new Point(520, 27);
            Suffix.Name = "Suffix";
            Suffix.PlaceholderText = "Suffix";
            Suffix.Size = new Size(67, 23);
            Suffix.TabIndex = 4;
            // 
            // cityCMB
            // 
            cityCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            cityCMB.ForeColor = Color.Black;
            cityCMB.FormattingEnabled = true;
            cityCMB.Location = new Point(16, 141);
            cityCMB.Name = "cityCMB";
            cityCMB.Size = new Size(121, 23);
            cityCMB.TabIndex = 8;
            cityCMB.SelectedIndexChanged += cityCMB_SelectedIndexChanged;
            // 
            // Address
            // 
            Address.BackColor = Color.White;
            Address.ForeColor = Color.Black;
            Address.Location = new Point(15, 184);
            Address.Multiline = true;
            Address.Name = "Address";
            Address.PlaceholderText = "Address";
            Address.Size = new Size(418, 23);
            Address.TabIndex = 11;
            // 
            // Province
            // 
            Province.DropDownStyle = ComboBoxStyle.DropDownList;
            Province.ForeColor = Color.Black;
            Province.FormattingEnabled = true;
            Province.Location = new Point(426, 85);
            Province.Name = "Province";
            Province.Size = new Size(161, 23);
            Province.TabIndex = 7;
            Province.SelectedIndexChanged += Province_SelectedIndexChanged;
            // 
            // PostalCode
            // 
            PostalCode.BackColor = Color.White;
            PostalCode.ForeColor = Color.Black;
            PostalCode.Location = new Point(371, 141);
            PostalCode.Name = "PostalCode";
            PostalCode.PlaceholderText = "Postal Code";
            PostalCode.Size = new Size(105, 23);
            PostalCode.TabIndex = 10;
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
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(15, 65);
            label20.Name = "label20";
            label20.Size = new Size(53, 14);
            label20.TabIndex = 61;
            label20.Text = "GENDER";
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
            // barangayCMB
            // 
            barangayCMB.DropDownStyle = ComboBoxStyle.DropDownList;
            barangayCMB.ForeColor = Color.Black;
            barangayCMB.FormattingEnabled = true;
            barangayCMB.Location = new Point(184, 141);
            barangayCMB.Name = "barangayCMB";
            barangayCMB.Size = new Size(147, 23);
            barangayCMB.TabIndex = 9;
            // 
            // Gender
            // 
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            Gender.ForeColor = Color.Black;
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female" });
            Gender.Location = new Point(15, 85);
            Gender.Name = "Gender";
            Gender.Size = new Size(121, 23);
            Gender.TabIndex = 5;
            // 
            // DateOfBirth
            // 
            DateOfBirth.CalendarMonthBackground = Color.White;
            DateOfBirth.CustomFormat = "MM/dd/yyyy";
            DateOfBirth.Location = new Point(184, 85);
            DateOfBirth.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            DateOfBirth.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(204, 23);
            DateOfBirth.TabIndex = 6;
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
            // employmentPanel
            // 
            employmentPanel.BackColor = Color.White;
            employmentPanel.BorderStyle = BorderStyle.FixedSingle;
            employmentPanel.Controls.Add(label21);
            employmentPanel.Controls.Add(HireDate);
            employmentPanel.Controls.Add(label8);
            employmentPanel.Controls.Add(label13);
            employmentPanel.Controls.Add(TimeOut);
            employmentPanel.Controls.Add(JobStatus);
            employmentPanel.Controls.Add(label17);
            employmentPanel.Controls.Add(label9);
            employmentPanel.Controls.Add(Department);
            employmentPanel.Controls.Add(EmployeeNum);
            employmentPanel.Controls.Add(TimeIn);
            employmentPanel.Controls.Add(label18);
            employmentPanel.Controls.Add(label16);
            employmentPanel.Controls.Add(Occupation);
            employmentPanel.Controls.Add(label11);
            employmentPanel.ForeColor = SystemColors.ControlText;
            employmentPanel.Location = new Point(22, 432);
            employmentPanel.Name = "employmentPanel";
            employmentPanel.Size = new Size(607, 235);
            employmentPanel.TabIndex = 66;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.ForeColor = SystemColors.ControlDarkDark;
            label21.Location = new Point(10, 10);
            label21.Name = "label21";
            label21.Size = new Size(160, 14);
            label21.TabIndex = 35;
            label21.Text = "EMPLOYMENT INFORMATION";
            // 
            // HireDate
            // 
            HireDate.CustomFormat = "MM/dd/yyyy";
            HireDate.Location = new Point(103, 76);
            HireDate.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            HireDate.MinDate = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            HireDate.Name = "HireDate";
            HireDate.Size = new Size(204, 23);
            HireDate.TabIndex = 16;
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
            // TimeOut
            // 
            TimeOut.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeOut.ForeColor = Color.Black;
            TimeOut.FormattingEnabled = true;
            TimeOut.Items.AddRange(new object[] { "4:00 PM", "5:00 PM", "6:00 PM" });
            TimeOut.Location = new Point(409, 111);
            TimeOut.Name = "TimeOut";
            TimeOut.Size = new Size(147, 23);
            TimeOut.TabIndex = 21;
            // 
            // JobStatus
            // 
            JobStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            JobStatus.ForeColor = Color.Black;
            JobStatus.FormattingEnabled = true;
            JobStatus.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            JobStatus.Location = new Point(103, 163);
            JobStatus.Name = "JobStatus";
            JobStatus.Size = new Size(204, 23);
            JobStatus.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(346, 115);
            label17.Name = "label17";
            label17.Size = new Size(57, 14);
            label17.TabIndex = 62;
            label17.Text = "TIME OUT";
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
            // Department
            // 
            Department.DropDownStyle = ComboBoxStyle.DropDownList;
            Department.ForeColor = Color.Black;
            Department.FormattingEnabled = true;
            Department.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            Department.Location = new Point(103, 134);
            Department.Name = "Department";
            Department.Size = new Size(204, 23);
            Department.TabIndex = 18;
            // 
            // EmployeeNum
            // 
            EmployeeNum.BackColor = Color.White;
            EmployeeNum.ForeColor = Color.Black;
            EmployeeNum.Location = new Point(103, 47);
            EmployeeNum.Name = "EmployeeNum";
            EmployeeNum.Size = new Size(204, 23);
            EmployeeNum.TabIndex = 15;
            // 
            // TimeIn
            // 
            TimeIn.DropDownStyle = ComboBoxStyle.DropDownList;
            TimeIn.ForeColor = Color.Black;
            TimeIn.FormattingEnabled = true;
            TimeIn.Items.AddRange(new object[] { "7:00 AM", "8:00 AM", "9:00 AM" });
            TimeIn.Location = new Point(409, 82);
            TimeIn.Name = "TimeIn";
            TimeIn.Size = new Size(147, 23);
            TimeIn.TabIndex = 20;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(23, 166);
            label18.Name = "label18";
            label18.Size = new Size(74, 14);
            label18.TabIndex = 64;
            label18.Text = "JOB STATUS";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(357, 86);
            label16.Name = "label16";
            label16.Size = new Size(46, 14);
            label16.TabIndex = 60;
            label16.Text = "TIME IN";
            // 
            // Occupation
            // 
            Occupation.DropDownStyle = ComboBoxStyle.DropDownList;
            Occupation.ForeColor = Color.Black;
            Occupation.FormattingEnabled = true;
            Occupation.Items.AddRange(new object[] { "Teacher", "Sports Coach", "School Nurse", "Maintenance Technician", "Registrar", "Guidance Counselor", "Guard", "Chairperson" });
            Occupation.Location = new Point(103, 105);
            Occupation.Name = "Occupation";
            Occupation.Size = new Size(204, 23);
            Occupation.TabIndex = 17;
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
            // contactPanel
            // 
            contactPanel.BackColor = Color.White;
            contactPanel.BorderStyle = BorderStyle.FixedSingle;
            contactPanel.Controls.Add(label5);
            contactPanel.Controls.Add(label2);
            contactPanel.Controls.Add(textBox13);
            contactPanel.Controls.Add(label19);
            contactPanel.Controls.Add(Telephone);
            contactPanel.Controls.Add(phoneNum);
            contactPanel.Controls.Add(Email);
            contactPanel.ForeColor = SystemColors.ControlText;
            contactPanel.Location = new Point(22, 261);
            contactPanel.Name = "contactPanel";
            contactPanel.Size = new Size(607, 145);
            contactPanel.TabIndex = 65;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(381, 38);
            label5.Name = "label5";
            label5.Size = new Size(72, 14);
            label5.TabIndex = 60;
            label5.Text = "TELEPHONE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(72, 81);
            label2.Name = "label2";
            label2.Size = new Size(41, 14);
            label2.TabIndex = 59;
            label2.Text = "EMAIL";
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.ForeColor = Color.Silver;
            textBox13.Location = new Point(16, 38);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(39, 23);
            textBox13.TabIndex = 58;
            textBox13.Text = "+63";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(10, 9);
            label19.Name = "label19";
            label19.Size = new Size(136, 14);
            label19.TabIndex = 23;
            label19.Text = "CONTACT INFORMATION";
            // 
            // Telephone
            // 
            Telephone.BackColor = Color.White;
            Telephone.ForeColor = Color.Black;
            Telephone.Location = new Point(381, 55);
            Telephone.Name = "Telephone";
            Telephone.PlaceholderText = "Telephone Number";
            Telephone.Size = new Size(206, 23);
            Telephone.TabIndex = 14;
            Telephone.KeyPress += Telephone_KeyPress;
            // 
            // phoneNum
            // 
            phoneNum.BackColor = Color.White;
            phoneNum.ForeColor = Color.Black;
            phoneNum.Location = new Point(72, 38);
            phoneNum.Name = "phoneNum";
            phoneNum.PlaceholderText = "Phone Number";
            phoneNum.Size = new Size(206, 23);
            phoneNum.TabIndex = 12;
            phoneNum.KeyPress += phoneNum_KeyPress;
            // 
            // Email
            // 
            Email.BackColor = Color.White;
            Email.ForeColor = Color.Black;
            Email.Location = new Point(72, 98);
            Email.Name = "Email";
            Email.PlaceholderText = "Email";
            Email.Size = new Size(206, 23);
            Email.TabIndex = 13;
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
            // Confirm
            // 
            Confirm.BackColor = Color.FromArgb(219, 20, 62);
            Confirm.BackgroundImageLayout = ImageLayout.None;
            Confirm.Cursor = Cursors.Hand;
            Confirm.FlatAppearance.BorderColor = Color.DimGray;
            Confirm.FlatStyle = FlatStyle.Flat;
            Confirm.ForeColor = Color.White;
            Confirm.Location = new Point(932, 633);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(88, 34);
            Confirm.TabIndex = 25;
            Confirm.Text = "Confirm";
            Confirm.UseMnemonic = false;
            Confirm.UseVisualStyleBackColor = false;
            Confirm.Click += button1_Click_1;
            // 
            // UploadImage
            // 
            UploadImage.AutoSize = true;
            UploadImage.BackColor = Color.FromArgb(219, 20, 62);
            UploadImage.BackgroundImageLayout = ImageLayout.Zoom;
            UploadImage.Cursor = Cursors.Hand;
            UploadImage.FlatAppearance.BorderSize = 0;
            UploadImage.FlatStyle = FlatStyle.Flat;
            UploadImage.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UploadImage.ForeColor = SystemColors.ControlDarkDark;
            UploadImage.Image = (Image)resources.GetObject("UploadImage.Image");
            UploadImage.ImageAlign = ContentAlignment.MiddleLeft;
            UploadImage.Location = new Point(912, 459);
            UploadImage.Name = "UploadImage";
            UploadImage.RightToLeft = RightToLeft.No;
            UploadImage.Size = new Size(41, 38);
            UploadImage.TabIndex = 22;
            UploadImage.TextAlign = ContentAlignment.MiddleRight;
            UploadImage.TextImageRelation = TextImageRelation.ImageBeforeText;
            UploadImage.UseVisualStyleBackColor = false;
            UploadImage.Click += button2_Click_1;
            // 
            // ProfilePic
            // 
            ProfilePic.BackColor = Color.WhiteSmoke;
            ProfilePic.BorderStyle = BorderStyle.FixedSingle;
            ProfilePic.Location = new Point(702, 49);
            ProfilePic.Name = "ProfilePic";
            ProfilePic.Size = new Size(400, 400);
            ProfilePic.TabIndex = 36;
            ProfilePic.TabStop = false;
            // 
            // AddEmployeeButtonForm
            // 
            BackColor = Color.FromArgb(164, 16, 48);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1159, 746);
            Controls.Add(panel1);
            Controls.Add(personalButton);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Location = new Point(537, 324);
            Name = "AddEmployeeButtonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddEmployeeButtonForm_Load;
            KeyDown += AddEmployeeButtonForm_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            personalPanel.ResumeLayout(false);
            personalPanel.PerformLayout();
            employmentPanel.ResumeLayout(false);
            employmentPanel.PerformLayout();
            contactPanel.ResumeLayout(false);
            contactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button personalButton;
        private Panel panel1;
        private Button Confirm;
        private TextBox FirstName;
        private DateTimePicker DateOfBirth;
        private TextBox LastName;
        private TextBox MiddleName;
        private Label doblbl;
        private ComboBox barangayCMB;
        private TextBox PostalCode;
        private Label label1;
        private ComboBox Province;
        private TextBox Address;
        private Label label3;
        private Label label4;
        private TextBox Email;
        private TextBox Telephone;
        private TextBox phoneNum;
        private Label label7;
        private TextBox EmployeeNum;
        private Label label11;
        private Button UploadImage;
        private PictureBox ProfilePic;
        private TextBox Suffix;
        private ComboBox TimeOut;
        private Label label17;
        private ComboBox TimeIn;
        private Label label16;
        private ComboBox Gender;
        private Label label20;
        private ComboBox JobStatus;
        private Label label18;
        private ComboBox Occupation;
        private ComboBox Department;
        private Label label13;
        private Label label8;
        private Label label9;
        private DateTimePicker HireDate;
        private ComboBox cityCMB;
        private Button cancelButton;
        private Panel contactPanel;
        private Label label19;
        private TextBox textBox13;
        private Label label5;
        private Label label2;
        private Panel employmentPanel;
        private Label label21;
        private Panel personalPanel;
        private Button cameraButton;
    }
}