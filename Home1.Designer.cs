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
            buttonDeduction.ForeColor = Color.Gainsboro;
            buttonDeduction.Location = new Point(0, 124);
            buttonDeduction.Name = "buttonDeduction";
            buttonDeduction.Padding = new Padding(10, 0, 0, 0);
            buttonDeduction.Size = new Size(214, 62);
            buttonDeduction.TabIndex = 5;
            buttonDeduction.Text = "DEDUCTION";
            buttonDeduction.UseVisualStyleBackColor = true;
            buttonDeduction.Click += buttonDeduction_Click_1;
            // 
            // buttonOvertime
            // 
            buttonOvertime.Cursor = Cursors.Hand;
            buttonOvertime.Dock = DockStyle.Top;
            buttonOvertime.FlatAppearance.BorderSize = 0;
            buttonOvertime.FlatStyle = FlatStyle.Flat;
            buttonOvertime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOvertime.ForeColor = Color.Gainsboro;
            buttonOvertime.Location = new Point(0, 62);
            buttonOvertime.Name = "buttonOvertime";
            buttonOvertime.Size = new Size(214, 62);
            buttonOvertime.TabIndex = 4;
            buttonOvertime.Text = "OVERTIME";
            buttonOvertime.UseVisualStyleBackColor = true;
            buttonOvertime.Click += buttonOvertime_Click_1;
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