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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelSiena = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.panelEmployeesSubMenu = new System.Windows.Forms.Panel();
            this.buttonDeduction = new System.Windows.Forms.Button();
            this.buttonOvertime = new System.Windows.Forms.Button();
            this.buttonEmployeeList = new System.Windows.Forms.Button();
            this.buttonEmployees = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelEmployeesSubMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
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
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::SCTAttendanceSystemUI.Properties.Resources.department;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(157, 94);
            this.button2.TabIndex = 0;
            this.button2.Text = "DEPARTMENT";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(166, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 94);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Home1
            // 
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