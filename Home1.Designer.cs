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
            panelHeader.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Controls.Add(labelSiena);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1904, 110);
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
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(164, 16, 48);
            panelMenu.Controls.Add(buttonLogout);
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
            panelMenu.Size = new Size(214, 931);
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
            buttonLogout.Location = new Point(0, 447);
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
            panelDesktopPane.AutoScroll = true;
            panelDesktopPane.BorderStyle = BorderStyle.FixedSingle;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(214, 110);
            panelDesktopPane.MaximumSize = new Size(1920, 1080);
            panelDesktopPane.MinimumSize = new Size(1454, 712);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1690, 931);
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
            ClientSize = new Size(1904, 1041);
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
            WindowState = FormWindowState.Maximized;
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
        private Button buttonLogout;
    }
}