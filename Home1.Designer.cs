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
            labelSiena = new Label();
            labelMenu = new Label();
            panelMenu = new Panel();
            buttonLogout = new Button();
            buttonSettings = new Button();
            buttonPayroll = new Button();
            panelEmployeesSubMenu = new Panel();
            buttonDeduction = new Button();
            buttonOvertime = new Button();
            buttonEmployeeList = new Button();
            buttonEmployees = new Button();
            buttonDepartment = new Button();
            buttonAttendance = new Button();
            panelDesktopPane = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panelHeader.SuspendLayout();
            panelMenu.SuspendLayout();
            panelEmployeesSubMenu.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
<<<<<<< Updated upstream
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelHeader.Controls.Add(this.labelSiena);
            this.panelHeader.Controls.Add(this.labelMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1904, 139);
            this.panelHeader.TabIndex = 3;
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.ForeColor = System.Drawing.Color.White;
            this.labelSiena.Location = new System.Drawing.Point(251, 35);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(520, 53);
            this.labelSiena.TabIndex = 3;
            this.labelSiena.Text = "SCT Attendance  System";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(64, 89);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(98, 37);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "MENU";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonPayroll);
            this.panelMenu.Controls.Add(this.panelEmployeesSubMenu);
            this.panelMenu.Controls.Add(this.buttonEmployees);
            this.panelMenu.Controls.Add(this.buttonDepartment);
            this.panelMenu.Controls.Add(this.buttonAttendance);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 139);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 902);
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
            this.buttonLogout.Location = new System.Drawing.Point(0, 763);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(245, 101);
            this.buttonLogout.TabIndex = 24;
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
            this.buttonSettings.Location = new System.Drawing.Point(0, 662);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(245, 101);
            this.buttonSettings.TabIndex = 24;
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
            this.buttonPayroll.Location = new System.Drawing.Point(0, 561);
            this.buttonPayroll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonPayroll.Size = new System.Drawing.Size(245, 101);
            this.buttonPayroll.TabIndex = 24;
            this.buttonPayroll.Text = "     PAYROLL";
            this.buttonPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click);
            // 
            // panelEmployeesSubMenu
            // 
            this.panelEmployeesSubMenu.Controls.Add(this.buttonDeduction);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonOvertime);
            this.panelEmployeesSubMenu.Controls.Add(this.buttonEmployeeList);
            this.panelEmployeesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmployeesSubMenu.Location = new System.Drawing.Point(0, 303);
            this.panelEmployeesSubMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelEmployeesSubMenu.Name = "panelEmployeesSubMenu";
            this.panelEmployeesSubMenu.Size = new System.Drawing.Size(245, 258);
            this.panelEmployeesSubMenu.TabIndex = 24;
            // 
            // buttonDeduction
            // 
            this.buttonDeduction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeduction.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeduction.FlatAppearance.BorderSize = 0;
            this.buttonDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeduction.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDeduction.Location = new System.Drawing.Point(0, 158);
            this.buttonDeduction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeduction.Name = "buttonDeduction";
            this.buttonDeduction.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonDeduction.Size = new System.Drawing.Size(245, 79);
            this.buttonDeduction.TabIndex = 5;
            this.buttonDeduction.Text = "DEDUCTION";
            this.buttonDeduction.UseVisualStyleBackColor = true;
            this.buttonDeduction.Click += new System.EventHandler(this.buttonDeduction_Click);
            // 
            // buttonOvertime
            // 
            this.buttonOvertime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOvertime.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOvertime.FlatAppearance.BorderSize = 0;
            this.buttonOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOvertime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOvertime.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOvertime.Location = new System.Drawing.Point(0, 79);
            this.buttonOvertime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOvertime.Name = "buttonOvertime";
            this.buttonOvertime.Size = new System.Drawing.Size(245, 79);
            this.buttonOvertime.TabIndex = 4;
            this.buttonOvertime.Text = "OVERTIME";
            this.buttonOvertime.UseVisualStyleBackColor = true;
            this.buttonOvertime.Click += new System.EventHandler(this.buttonOvertime_Click);
            // 
            // buttonEmployeeList
            // 
            this.buttonEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployeeList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployeeList.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployeeList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployeeList.Location = new System.Drawing.Point(0, 0);
            this.buttonEmployeeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEmployeeList.Name = "buttonEmployeeList";
            this.buttonEmployeeList.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonEmployeeList.Size = new System.Drawing.Size(245, 79);
            this.buttonEmployeeList.TabIndex = 1;
            this.buttonEmployeeList.Text = "EMPLOYEE LIST";
            this.buttonEmployeeList.UseVisualStyleBackColor = true;
            this.buttonEmployeeList.Click += new System.EventHandler(this.buttonEmployeeList_Click);
            // 
            // buttonEmployees
            // 
            this.buttonEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployees.FlatAppearance.BorderSize = 0;
            this.buttonEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployees.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEmployees.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmployees.Image")));
            this.buttonEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEmployees.Location = new System.Drawing.Point(0, 202);
            this.buttonEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEmployees.Name = "buttonEmployees";
            this.buttonEmployees.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonEmployees.Size = new System.Drawing.Size(245, 101);
            this.buttonEmployees.TabIndex = 24;
            this.buttonEmployees.Text = "EMPLOYEES";
            this.buttonEmployees.UseVisualStyleBackColor = true;
            this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
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
            this.buttonDepartment.Location = new System.Drawing.Point(0, 101);
            this.buttonDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonDepartment.Size = new System.Drawing.Size(245, 101);
            this.buttonDepartment.TabIndex = 24;
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
            this.buttonAttendance.Location = new System.Drawing.Point(0, 0);
            this.buttonAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonAttendance.Size = new System.Drawing.Size(245, 101);
            this.buttonAttendance.TabIndex = 24;
            this.buttonAttendance.Text = "     ATTENDANCE";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click_1);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(245, 139);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDesktopPane.MaximumSize = new System.Drawing.Size(2194, 1367);
            this.panelDesktopPane.MinimumSize = new System.Drawing.Size(1661, 901);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1661, 902);
            this.panelDesktopPane.TabIndex = 5;
=======
            panelHeader.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader.Controls.Add(labelSiena);
            panelHeader.Controls.Add(labelMenu);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1666, 110);
            panelHeader.TabIndex = 3;
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
            // labelMenu
            // 
            labelMenu.AutoSize = true;
            labelMenu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Location = new Point(56, 70);
            labelMenu.Name = "labelMenu";
            labelMenu.Size = new Size(98, 37);
            labelMenu.TabIndex = 0;
            labelMenu.Text = "MENU";
            labelMenu.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(164, 16, 48);
            panelMenu.Controls.Add(buttonLogout);
            panelMenu.Controls.Add(buttonSettings);
            panelMenu.Controls.Add(buttonPayroll);
            panelMenu.Controls.Add(panelEmployeesSubMenu);
            panelMenu.Controls.Add(buttonEmployees);
            panelMenu.Controls.Add(buttonDepartment);
            panelMenu.Controls.Add(buttonAttendance);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 110);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(214, 712);
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
            buttonLogout.Location = new Point(0, 604);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 0);
            buttonLogout.Size = new Size(214, 80);
            buttonLogout.TabIndex = 24;
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
            buttonSettings.Location = new Point(0, 524);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(10, 0, 0, 0);
            buttonSettings.Size = new Size(214, 80);
            buttonSettings.TabIndex = 24;
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
            buttonPayroll.Location = new Point(0, 444);
            buttonPayroll.Name = "buttonPayroll";
            buttonPayroll.Padding = new Padding(10, 0, 0, 0);
            buttonPayroll.Size = new Size(214, 80);
            buttonPayroll.TabIndex = 24;
            buttonPayroll.Text = "     PAYROLL";
            buttonPayroll.TextAlign = ContentAlignment.MiddleLeft;
            buttonPayroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPayroll.UseVisualStyleBackColor = true;
            buttonPayroll.Click += buttonPayroll_Click;
            // 
            // panelEmployeesSubMenu
            // 
            panelEmployeesSubMenu.Controls.Add(buttonDeduction);
            panelEmployeesSubMenu.Controls.Add(buttonOvertime);
            panelEmployeesSubMenu.Controls.Add(buttonEmployeeList);
            panelEmployeesSubMenu.Dock = DockStyle.Top;
            panelEmployeesSubMenu.Location = new Point(0, 240);
            panelEmployeesSubMenu.Name = "panelEmployeesSubMenu";
            panelEmployeesSubMenu.Size = new Size(214, 204);
            panelEmployeesSubMenu.TabIndex = 24;
            // 
            // buttonDeduction
            // 
            buttonDeduction.Cursor = Cursors.Hand;
            buttonDeduction.Dock = DockStyle.Top;
            buttonDeduction.FlatAppearance.BorderSize = 0;
            buttonDeduction.FlatStyle = FlatStyle.Flat;
            buttonDeduction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDeduction.ForeColor = Color.FromArgb(164, 16, 48);
            buttonDeduction.Location = new Point(0, 124);
            buttonDeduction.Name = "buttonDeduction";
            buttonDeduction.Padding = new Padding(10, 0, 0, 0);
            buttonDeduction.Size = new Size(214, 62);
            buttonDeduction.TabIndex = 5;
            buttonDeduction.Text = "DEDUCTION";
            buttonDeduction.UseVisualStyleBackColor = true;
            // 
            // buttonOvertime
            // 
            buttonOvertime.Cursor = Cursors.Hand;
            buttonOvertime.Dock = DockStyle.Top;
            buttonOvertime.FlatAppearance.BorderSize = 0;
            buttonOvertime.FlatStyle = FlatStyle.Flat;
            buttonOvertime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOvertime.ForeColor = Color.FromArgb(164, 16, 48);
            buttonOvertime.Location = new Point(0, 62);
            buttonOvertime.Name = "buttonOvertime";
            buttonOvertime.Size = new Size(214, 62);
            buttonOvertime.TabIndex = 4;
            buttonOvertime.Text = "OVERTIME";
            buttonOvertime.UseVisualStyleBackColor = true;
            // 
            // buttonEmployeeList
            // 
            buttonEmployeeList.Cursor = Cursors.Hand;
            buttonEmployeeList.Dock = DockStyle.Top;
            buttonEmployeeList.FlatAppearance.BorderSize = 0;
            buttonEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployeeList.ForeColor = Color.Gainsboro;
            buttonEmployeeList.Location = new Point(0, 0);
            buttonEmployeeList.Name = "buttonEmployeeList";
            buttonEmployeeList.Padding = new Padding(35, 0, 0, 0);
            buttonEmployeeList.Size = new Size(214, 62);
            buttonEmployeeList.TabIndex = 1;
            buttonEmployeeList.Text = "EMPLOYEE LIST";
            buttonEmployeeList.UseVisualStyleBackColor = true;
            buttonEmployeeList.Click += buttonEmployeeList_Click;
            // 
            // buttonEmployees
            // 
            buttonEmployees.Dock = DockStyle.Top;
            buttonEmployees.FlatAppearance.BorderSize = 0;
            buttonEmployees.FlatStyle = FlatStyle.Flat;
            buttonEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployees.ForeColor = Color.Gainsboro;
            buttonEmployees.Image = (Image)resources.GetObject("buttonEmployees.Image");
            buttonEmployees.ImageAlign = ContentAlignment.MiddleRight;
            buttonEmployees.Location = new Point(0, 160);
            buttonEmployees.Name = "buttonEmployees";
            buttonEmployees.Padding = new Padding(10, 0, 10, 0);
            buttonEmployees.Size = new Size(214, 80);
            buttonEmployees.TabIndex = 24;
            buttonEmployees.Text = "EMPLOYEES";
            buttonEmployees.UseVisualStyleBackColor = true;
            buttonEmployees.Click += buttonEmployees_Click;
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
            buttonDepartment.Location = new Point(0, 80);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Padding = new Padding(10, 0, 0, 0);
            buttonDepartment.Size = new Size(214, 80);
            buttonDepartment.TabIndex = 24;
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
            buttonAttendance.Location = new Point(0, 0);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Padding = new Padding(10, 0, 0, 0);
            buttonAttendance.Size = new Size(214, 80);
            buttonAttendance.TabIndex = 24;
            buttonAttendance.Text = "     ATTENDANCE";
            buttonAttendance.TextAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click_1;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.BorderStyle = BorderStyle.FixedSingle;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(214, 110);
            panelDesktopPane.MaximumSize = new Size(1920, 1080);
            panelDesktopPane.MinimumSize = new Size(1454, 712);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1454, 712);
            panelDesktopPane.TabIndex = 5;
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2192, 1358);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Home1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelEmployeesSubMenu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

=======
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1920, 1080);
            MinimizeBox = false;
            MinimumSize = new Size(1680, 821);
            Name = "Home1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT ATTENDANCE SYSTEM";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelEmployeesSubMenu.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
>>>>>>> Stashed changes
        }

        #endregion

        private Panel panelHeader;
        private Label labelSiena;
        private Panel panelMenu;
        private Label labelMenu;
        private Panel panelDesktopPane;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private PictureBox pictureBox2;
        private Button buttonAttendance;
        private Button buttonDepartment;
        private Button buttonEmployees;
        private Panel panelEmployeesSubMenu;
        private Button buttonDeduction;
        private Button buttonOvertime;
        private Button buttonEmployeeList;
        private Button buttonPayroll;
        private Button buttonSettings;
        private Button buttonLogout;
    }
}