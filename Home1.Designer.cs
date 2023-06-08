namespace SCTAttendanceSystemUI
{
    partial class Home1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home1));
            panelHeader = new Panel();
            pictureBoxLogo = new PictureBox();
            labelSiena = new Label();
            panelMenu = new Panel();
            buttonLogout = new Button();
            buttonSettings = new Button();
            buttonPayroll = new Button();
            buttonLeave = new Button();
            buttonAbsentees = new Button();
            buttonEmployeeList = new Button();
            buttonDepartment = new Button();
            buttonAttendance = new Button();
            labelMenu = new Label();
            panelDesktopPane = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelHeader.Controls.Add(this.pictureBoxLogo);
            this.panelHeader.Controls.Add(this.labelSiena);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 110);
            this.panelHeader.TabIndex = 3;
            panelHeader.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Controls.Add(labelSiena);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1584, 110);
            panelHeader.TabIndex = 3;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = Properties.Resources.logo1;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Dock = DockStyle.Left;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(214, 110);
            pictureBoxLogo.TabIndex = 25;
            pictureBoxLogo.TabStop = false;
            // 
            // labelSiena
            // 
            labelSiena.AutoSize = true;
            labelSiena.BackColor = Color.Transparent;
            labelSiena.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            labelSiena.ForeColor = Color.White;
            labelSiena.Location = new Point(220, 28);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(520, 53);
            labelSiena.TabIndex = 3;
            labelSiena.Text = "SCT Attendance  System";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonPayroll);
            this.panelMenu.Controls.Add(this.buttonLeave);
            this.panelMenu.Controls.Add(this.buttonAbsentees);
            this.panelMenu.Controls.Add(this.buttonEmployeeList);
            this.panelMenu.Controls.Add(this.buttonDepartment);
            this.panelMenu.Controls.Add(this.buttonAttendance);
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 110);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(214, 571);
            this.panelMenu.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Image = global::SCTAttendanceSystemUI.Properties.Resources.logout;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(0, 512);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(197, 65);
            this.buttonLogout.TabIndex = 25;
            this.buttonLogout.Text = "     LOGOUT";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Image = global::SCTAttendanceSystemUI.Properties.Resources.settings1;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 447);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(197, 65);
            this.buttonSettings.TabIndex = 25;
            this.buttonSettings.Text = "     SETTINGS";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPayroll.FlatAppearance.BorderSize = 0;
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayroll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonPayroll.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPayroll.Image = global::SCTAttendanceSystemUI.Properties.Resources.payroll;
            this.buttonPayroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.Location = new System.Drawing.Point(0, 382);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonPayroll.Size = new System.Drawing.Size(197, 65);
            this.buttonPayroll.TabIndex = 25;
            this.buttonPayroll.Text = "     PAYROLL";
            this.buttonPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonLeave.FlatAppearance.BorderSize = 0;
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLeave.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLeave.Image = global::SCTAttendanceSystemUI.Properties.Resources.leave;
            this.buttonLeave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeave.Location = new System.Drawing.Point(0, 317);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonLeave.Size = new System.Drawing.Size(197, 65);
            this.buttonLeave.TabIndex = 25;
            this.buttonLeave.Text = "     LEAVE";
            this.buttonLeave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLeave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click_1);
            // 
            // buttonAbsentees
            // 
            this.buttonAbsentees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbsentees.FlatAppearance.BorderSize = 0;
            this.buttonAbsentees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbsentees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAbsentees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAbsentees.Image = global::SCTAttendanceSystemUI.Properties.Resources.absentees;
            this.buttonAbsentees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsentees.Location = new System.Drawing.Point(0, 252);
            this.buttonAbsentees.Name = "buttonAbsentees";
            this.buttonAbsentees.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAbsentees.Size = new System.Drawing.Size(197, 65);
            this.buttonAbsentees.TabIndex = 25;
            this.buttonAbsentees.Text = "     ABSENTEES";
            this.buttonAbsentees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbsentees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAbsentees.UseVisualStyleBackColor = true;
            this.buttonAbsentees.Click += new System.EventHandler(this.buttonAbsentees_Click_1);
            // 
            // buttonEmployeeList
            // 
            this.buttonEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployeeList.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployeeList.Image = global::SCTAttendanceSystemUI.Properties.Resources.employees;
            this.buttonEmployeeList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeeList.Location = new System.Drawing.Point(0, 187);
            this.buttonEmployeeList.Name = "buttonEmployeeList";
            this.buttonEmployeeList.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonEmployeeList.Size = new System.Drawing.Size(197, 65);
            this.buttonEmployeeList.TabIndex = 25;
            this.buttonEmployeeList.Text = "    EMPLOYEE LIST";
            this.buttonEmployeeList.UseVisualStyleBackColor = true;
            this.buttonEmployeeList.Click += new System.EventHandler(this.buttonEmployeeList_Click);
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDepartment.FlatAppearance.BorderSize = 0;
            this.buttonDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDepartment.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDepartment.Image = global::SCTAttendanceSystemUI.Properties.Resources.department;
            this.buttonDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepartment.Location = new System.Drawing.Point(0, 122);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDepartment.Size = new System.Drawing.Size(197, 65);
            this.buttonDepartment.TabIndex = 25;
            this.buttonDepartment.Text = "DEPARTMENTS";
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click_1);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAttendance.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAttendance.Image = global::SCTAttendanceSystemUI.Properties.Resources.dashboard;
            this.buttonAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.Location = new System.Drawing.Point(0, 57);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonAttendance.Size = new System.Drawing.Size(197, 65);
            this.buttonAttendance.TabIndex = 25;
            this.buttonAttendance.Text = "     ATTENDANCE";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click_1);

            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(164, 16, 48);
            panelMenu.Controls.Add(buttonLogout);
            panelMenu.Controls.Add(buttonSettings);
            panelMenu.Controls.Add(buttonPayroll);
            panelMenu.Controls.Add(buttonLeave);
            panelMenu.Controls.Add(buttonAbsentees);
            panelMenu.Controls.Add(buttonEmployeeList);
            panelMenu.Controls.Add(buttonDepartment);
            panelMenu.Controls.Add(buttonAttendance);
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 110);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 751);
            panelMenu.TabIndex = 4;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Top;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.Gainsboro;
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 512);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 0);
            buttonLogout.Size = new Size(214, 65);
            buttonLogout.TabIndex = 25;
            buttonLogout.Text = "     LOGOUT";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Dock = DockStyle.Top;
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSettings.ForeColor = Color.Gainsboro;
            buttonSettings.Image = Properties.Resources.settings1;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(0, 447);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(10, 0, 0, 0);
            buttonSettings.Size = new Size(214, 65);
            buttonSettings.TabIndex = 25;
            buttonSettings.Text = "     SETTINGS";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonPayroll
            // 
            buttonPayroll.Dock = DockStyle.Top;
            buttonPayroll.FlatAppearance.BorderSize = 0;
            buttonPayroll.FlatStyle = FlatStyle.Flat;
            buttonPayroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPayroll.ForeColor = Color.Gainsboro;
            buttonPayroll.Image = Properties.Resources.payroll;
            buttonPayroll.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPayroll.Location = new Point(0, 382);
            buttonPayroll.Name = "buttonPayroll";
            buttonPayroll.Padding = new Padding(10, 0, 0, 0);
            buttonPayroll.Size = new Size(214, 65);
            buttonPayroll.TabIndex = 25;
            buttonPayroll.Text = "     PAYROLL";
            buttonPayroll.TextAlign = ContentAlignment.MiddleLeft;
            buttonPayroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPayroll.UseVisualStyleBackColor = true;
            buttonPayroll.Click += buttonPayroll_Click;
            // 
            // buttonLeave
            // 
            buttonLeave.Dock = DockStyle.Top;
            buttonLeave.FlatAppearance.BorderSize = 0;
            buttonLeave.FlatStyle = FlatStyle.Flat;
            buttonLeave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLeave.ForeColor = Color.Gainsboro;
            buttonLeave.Image = Properties.Resources.leave;
            buttonLeave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLeave.Location = new Point(0, 317);
            buttonLeave.Name = "buttonLeave";
            buttonLeave.Padding = new Padding(10, 0, 0, 0);
            buttonLeave.Size = new Size(214, 65);
            buttonLeave.TabIndex = 25;
            buttonLeave.Text = "     LEAVE";
            buttonLeave.TextAlign = ContentAlignment.MiddleLeft;
            buttonLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLeave.UseVisualStyleBackColor = true;
            buttonLeave.Click += buttonLeave_Click_1;
            // 
            // buttonAbsentees
            // 
            buttonAbsentees.Dock = DockStyle.Top;
            buttonAbsentees.FlatAppearance.BorderSize = 0;
            buttonAbsentees.FlatStyle = FlatStyle.Flat;
            buttonAbsentees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAbsentees.ForeColor = Color.Gainsboro;
            buttonAbsentees.Image = Properties.Resources.absentees;
            buttonAbsentees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbsentees.Location = new Point(0, 252);
            buttonAbsentees.Name = "buttonAbsentees";
            buttonAbsentees.Padding = new Padding(10, 0, 0, 0);
            buttonAbsentees.Size = new Size(214, 65);
            buttonAbsentees.TabIndex = 25;
            buttonAbsentees.Text = "     ABSENTEES";
            buttonAbsentees.TextAlign = ContentAlignment.MiddleLeft;
            buttonAbsentees.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAbsentees.UseVisualStyleBackColor = true;
            buttonAbsentees.Click += buttonAbsentees_Click_1;
            // 
            // buttonEmployeeList
            // 
            buttonEmployeeList.Dock = DockStyle.Top;
            buttonEmployeeList.FlatAppearance.BorderSize = 0;
            buttonEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployeeList.ForeColor = Color.Gainsboro;
            buttonEmployeeList.Image = Properties.Resources.employees;
            buttonEmployeeList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmployeeList.Location = new Point(0, 187);
            buttonEmployeeList.Name = "buttonEmployeeList";
            buttonEmployeeList.Padding = new Padding(10, 0, 10, 0);
            buttonEmployeeList.Size = new Size(214, 65);
            buttonEmployeeList.TabIndex = 25;
            buttonEmployeeList.Text = "    EMPLOYEE LIST";
            buttonEmployeeList.UseVisualStyleBackColor = true;
            buttonEmployeeList.Click += buttonEmployeeList_Click;
            // 
            // buttonDepartment
            // 
            buttonDepartment.Dock = DockStyle.Top;
            buttonDepartment.FlatAppearance.BorderSize = 0;
            buttonDepartment.FlatStyle = FlatStyle.Flat;
            buttonDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDepartment.ForeColor = Color.Gainsboro;
            buttonDepartment.Image = Properties.Resources.department;
            buttonDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDepartment.Location = new Point(0, 122);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Padding = new Padding(10, 0, 0, 0);
            buttonDepartment.Size = new Size(214, 65);
            buttonDepartment.TabIndex = 25;
            buttonDepartment.Text = "DEPARTMENTS";
            buttonDepartment.UseVisualStyleBackColor = true;
            buttonDepartment.Click += buttonDepartment_Click_1;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Cursor = Cursors.Hand;
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAttendance.ForeColor = Color.Gainsboro;
            buttonAttendance.Image = Properties.Resources.dashboard;
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(0, 57);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Padding = new Padding(10, 0, 0, 0);
            buttonAttendance.Size = new Size(214, 65);
            buttonAttendance.TabIndex = 25;
            buttonAttendance.Text = "     ATTENDANCE";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click_1;
            // 
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Dock = DockStyle.Top;
            labelMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(0, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Padding = new Padding(60, 10, 0, 10);
            labelMenu.Size = new Size(158, 57);
            labelMenu.TabIndex = 25;
            labelMenu.Text = "MENU";
            labelMenu.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.AutoScroll = true;
            this.panelDesktopPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(214, 110);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1050, 571);
            this.panelDesktopPane.TabIndex = 5;

            panelDesktopPane.BorderStyle = BorderStyle.FixedSingle;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(214, 110);
            panelDesktopPane.MaximumSize = new Size(1920, 1080);
            panelDesktopPane.MinimumSize = new Size(1454, 712);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1454, 751);
            panelDesktopPane.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 37F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Image = Properties.Resources.department;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(157, 94);
            button2.TabIndex = 0;
            button2.Text = "DEPARTMENT";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(166, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 94);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Home1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);


            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1584, 861);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimizeBox = false;
            MinimumSize = new Size(1364, 726);
            Name = "Home1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT ATTENDANCE SYSTEM";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelSiena;
        private Panel panelMenu;
        private Panel panelDesktopPane;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBoxLogo;
        private Button buttonAbsentees;
        private Button buttonEmployeeList;
        private Button buttonDepartment;
        private Button buttonAttendance;
        private Label labelMenu;
        private Button buttonLeave;
        private Button buttonPayroll;
        private Button buttonSettings;
        private Button buttonLogout;
    }
}