namespace SCTAttendanceSystemUI.Forms.AddLeaveButton
{
    partial class AddLeaveButtonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLeaveButtonForm));
            personalButton = new Button();
            panel1 = new Panel();
            textBoxSuffix = new TextBox();
            cancelButton = new Button();
            button1 = new Button();
            labelPersonalInfo = new Label();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBoxDuration = new TextBox();
            labelDuration = new Label();
            comboBoxLeave = new ComboBox();
            labelLeave = new Label();
            comboBoxOccupation = new ComboBox();
            comboBoxDepartment = new ComboBox();
            labelDepartment = new Label();
            labelEmployeeInfo = new Label();
            labelOccupation = new Label();
            textBoxEmployeeNo = new TextBox();
            labelEmployeeNo = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxMiddleInitial = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
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
            personalButton.Size = new Size(145, 41);
            personalButton.TabIndex = 1;
            personalButton.Text = "Request Information";
            personalButton.UseMnemonic = false;
            personalButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBoxSuffix);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelPersonalInfo);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(textBoxFirstName);
            panel1.Controls.Add(textBoxLastName);
            panel1.Controls.Add(textBoxMiddleInitial);
            panel1.Location = new Point(-1, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 420);
            panel1.TabIndex = 4;
            // 
            // textBoxSuffix
            // 
            textBoxSuffix.Enabled = false;
            textBoxSuffix.ForeColor = Color.Black;
            textBoxSuffix.Location = new Point(578, 50);
            textBoxSuffix.Name = "textBoxSuffix";
            textBoxSuffix.PlaceholderText = "SUFFIX";
            textBoxSuffix.Size = new Size(67, 23);
            textBoxSuffix.TabIndex = 4;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(557, 352);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "Reject";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(463, 352);
            button1.Name = "button1";
            button1.Size = new Size(88, 34);
            button1.TabIndex = 6;
            button1.Text = "Approve";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // labelPersonalInfo
            // 
            labelPersonalInfo.AutoSize = true;
            labelPersonalInfo.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPersonalInfo.ForeColor = SystemColors.ControlDarkDark;
            labelPersonalInfo.Location = new Point(38, 21);
            labelPersonalInfo.Name = "labelPersonalInfo";
            labelPersonalInfo.Size = new Size(119, 14);
            labelPersonalInfo.TabIndex = 24;
            labelPersonalInfo.Text = "Personal Information";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(textBoxDuration);
            panel3.Controls.Add(labelDuration);
            panel3.Controls.Add(comboBoxLeave);
            panel3.Controls.Add(labelLeave);
            panel3.Controls.Add(comboBoxOccupation);
            panel3.Controls.Add(comboBoxDepartment);
            panel3.Controls.Add(labelDepartment);
            panel3.Controls.Add(labelEmployeeInfo);
            panel3.Controls.Add(labelOccupation);
            panel3.Controls.Add(textBoxEmployeeNo);
            panel3.Controls.Add(labelEmployeeNo);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(38, 89);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 235);
            panel3.TabIndex = 34;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            comboBox1.Location = new Point(103, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 73;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(74, 14);
            label2.TabIndex = 72;
            label2.Text = "JOB STATUS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(323, 76);
            label1.Name = "label1";
            label1.Size = new Size(42, 14);
            label1.TabIndex = 71;
            label1.Text = "START";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.ForeColor = Color.Silver;
            textBox1.Location = new Point(371, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 70;
            // 
            // textBoxDuration
            // 
            textBoxDuration.Enabled = false;
            textBoxDuration.ForeColor = Color.Silver;
            textBoxDuration.Location = new Point(371, 73);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(147, 23);
            textBoxDuration.TabIndex = 69;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDuration.ForeColor = SystemColors.ControlDarkDark;
            labelDuration.Location = new Point(335, 105);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(30, 14);
            labelDuration.TabIndex = 64;
            labelDuration.Text = "END";
            // 
            // comboBoxLeave
            // 
            comboBoxLeave.BackColor = Color.White;
            comboBoxLeave.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLeave.Enabled = false;
            comboBoxLeave.FormattingEnabled = true;
            comboBoxLeave.Items.AddRange(new object[] { "Sick Leave", "Emergency Leave", "Vacation Leave", "Special Leave" });
            comboBoxLeave.Location = new Point(103, 163);
            comboBoxLeave.Name = "comboBoxLeave";
            comboBoxLeave.Size = new Size(147, 23);
            comboBoxLeave.TabIndex = 61;
            // 
            // labelLeave
            // 
            labelLeave.AutoSize = true;
            labelLeave.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeave.ForeColor = SystemColors.ControlDarkDark;
            labelLeave.Location = new Point(51, 166);
            labelLeave.Name = "labelLeave";
            labelLeave.Size = new Size(42, 14);
            labelLeave.TabIndex = 60;
            labelLeave.Text = "LEAVE";
            // 
            // comboBoxOccupation
            // 
            comboBoxOccupation.BackColor = Color.White;
            comboBoxOccupation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOccupation.Enabled = false;
            comboBoxOccupation.FormattingEnabled = true;
            comboBoxOccupation.Items.AddRange(new object[] { "Teacher", "Sports Coach", "School Nurse", "Maintenance Technician", "Registrar", "Guidance Counselor", "Guard", "Chairperson" });
            comboBoxOccupation.Location = new Point(103, 105);
            comboBoxOccupation.Name = "comboBoxOccupation";
            comboBoxOccupation.Size = new Size(147, 23);
            comboBoxOccupation.TabIndex = 57;
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.BackColor = Color.White;
            comboBoxDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDepartment.Enabled = false;
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            comboBoxDepartment.Location = new Point(103, 76);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new Size(147, 23);
            comboBoxDepartment.TabIndex = 59;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDepartment.ForeColor = SystemColors.ControlDarkDark;
            labelDepartment.Location = new Point(17, 82);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(80, 14);
            labelDepartment.TabIndex = 58;
            labelDepartment.Text = "DEPARTMENT";
            // 
            // labelEmployeeInfo
            // 
            labelEmployeeInfo.AutoSize = true;
            labelEmployeeInfo.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeInfo.ForeColor = SystemColors.ControlDarkDark;
            labelEmployeeInfo.Location = new Point(10, 13);
            labelEmployeeInfo.Name = "labelEmployeeInfo";
            labelEmployeeInfo.Size = new Size(140, 14);
            labelEmployeeInfo.TabIndex = 35;
            labelEmployeeInfo.Text = "Employment Information";
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOccupation.ForeColor = SystemColors.ControlDarkDark;
            labelOccupation.Location = new Point(21, 108);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(76, 14);
            labelOccupation.TabIndex = 24;
            labelOccupation.Text = "OCCUPATION";
            // 
            // textBoxEmployeeNo
            // 
            textBoxEmployeeNo.BackColor = Color.White;
            textBoxEmployeeNo.Enabled = false;
            textBoxEmployeeNo.ForeColor = Color.Black;
            textBoxEmployeeNo.Location = new Point(103, 47);
            textBoxEmployeeNo.Name = "textBoxEmployeeNo";
            textBoxEmployeeNo.ReadOnly = true;
            textBoxEmployeeNo.Size = new Size(147, 23);
            textBoxEmployeeNo.TabIndex = 20;
            // 
            // labelEmployeeNo
            // 
            labelEmployeeNo.AutoSize = true;
            labelEmployeeNo.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmployeeNo.ForeColor = SystemColors.ControlDarkDark;
            labelEmployeeNo.Location = new Point(10, 50);
            labelEmployeeNo.Name = "labelEmployeeNo";
            labelEmployeeNo.Size = new Size(87, 14);
            labelEmployeeNo.TabIndex = 18;
            labelEmployeeNo.Text = "EMPLOYEE NO.";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Enabled = false;
            textBoxFirstName.ForeColor = Color.Black;
            textBoxFirstName.Location = new Point(42, 50);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.PlaceholderText = "FIRST NAME";
            textBoxFirstName.Size = new Size(207, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Enabled = false;
            textBoxLastName.ForeColor = Color.Black;
            textBoxLastName.Location = new Point(274, 50);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.PlaceholderText = "LAST NAME";
            textBoxLastName.Size = new Size(212, 23);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxMiddleInitial
            // 
            textBoxMiddleInitial.Enabled = false;
            textBoxMiddleInitial.ForeColor = Color.Black;
            textBoxMiddleInitial.Location = new Point(511, 50);
            textBoxMiddleInitial.Name = "textBoxMiddleInitial";
            textBoxMiddleInitial.PlaceholderText = "M.I.";
            textBoxMiddleInitial.Size = new Size(46, 23);
            textBoxMiddleInitial.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(653, 9);
            button2.Name = "button2";
            button2.Size = new Size(25, 23);
            button2.TabIndex = 35;
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddLeaveButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(690, 457);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(personalButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddLeaveButtonForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddLeaveButtonForm";
            Load += AddLeaveButtonForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button personalButton;
        private Panel panel1;
        private TextBox textBoxSuffix;
        private Button cancelButton;
        private Button button1;
        private Label labelPersonalInfo;
        private Panel panel3;
        private TextBox textBoxDuration;
        private Label labelDuration;
        private ComboBox comboBoxLeave;
        private Label labelLeave;
        private ComboBox comboBoxOccupation;
        private ComboBox comboBoxDepartment;
        private Label labelDepartment;
        private Label labelEmployeeInfo;
        private Label labelOccupation;
        private TextBox textBoxEmployeeNo;
        private Label labelEmployeeNo;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxMiddleInitial;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Button button2;
    }
}