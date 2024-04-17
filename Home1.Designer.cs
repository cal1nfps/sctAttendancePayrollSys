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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home1));
            panelHeader = new Panel();
            Title = new Label();
            logo2Label = new Label();
            pictureBoxLogo = new PictureBox();
            labelSiena = new Label();
            panelMenu = new Panel();
            dropDownAbsent = new FlowLayoutPanel();
            buttonAbsentees = new Button();
            absenteesButton = new Button();
            recordsButton = new Button();
            buttonLogout = new Button();
            buttonPayroll = new Button();
            buttonLeave = new Button();
            buttonEmployeeList = new Button();
            buttonDepartment = new Button();
            buttonAttendance = new Button();
            buttonDashboard = new Button();
            labelMenu = new Label();
            panelDesktopPane = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMenu.SuspendLayout();
            dropDownAbsent.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(242, 205, 10);
            panelHeader.BackgroundImage = (Image)resources.GetObject("panelHeader.BackgroundImage");
            panelHeader.Controls.Add(Title);
            panelHeader.Controls.Add(logo2Label);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Controls.Add(labelSiena);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1904, 110);
            panelHeader.TabIndex = 3;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.White;
            Title.Location = new Point(1209, 30);
            Title.Name = "Title";
            Title.Size = new Size(552, 53);
            Title.TabIndex = 27;
            Title.Text = "ATTENDANCE SYSTEM";
            // 
            // logo2Label
            // 
            logo2Label.AutoSize = true;
            logo2Label.BackColor = Color.Transparent;
            logo2Label.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            logo2Label.ForeColor = Color.Transparent;
            logo2Label.Location = new Point(253, 65);
            logo2Label.Name = "logo2Label";
            logo2Label.Size = new Size(215, 31);
            logo2Label.TabIndex = 26;
            logo2Label.Text = "TAYTAY, RIZAL";
            logo2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(30, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(128, 89);
            pictureBoxLogo.TabIndex = 25;
            pictureBoxLogo.TabStop = false;
            // 
            // labelSiena
            // 
            labelSiena.AutoSize = true;
            labelSiena.BackColor = Color.Transparent;
            labelSiena.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            labelSiena.ForeColor = Color.White;
            labelSiena.Location = new Point(164, 12);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(407, 53);
            labelSiena.TabIndex = 3;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.FromArgb(164, 16, 48);
            panelMenu.BackgroundImage = (Image)resources.GetObject("panelMenu.BackgroundImage");
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(dropDownAbsent);
            panelMenu.Controls.Add(buttonLogout);
            panelMenu.Controls.Add(buttonPayroll);
            panelMenu.Controls.Add(buttonLeave);
            panelMenu.Controls.Add(buttonEmployeeList);
            panelMenu.Controls.Add(buttonDepartment);
            panelMenu.Controls.Add(buttonAttendance);
            panelMenu.Controls.Add(buttonDashboard);
            panelMenu.Controls.Add(labelMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 110);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(63, 771);
            panelMenu.TabIndex = 4;
            // 
            // dropDownAbsent
            // 
            dropDownAbsent.BackColor = Color.FromArgb(164, 16, 48);
            dropDownAbsent.Controls.Add(buttonAbsentees);
            dropDownAbsent.Controls.Add(absenteesButton);
            dropDownAbsent.Controls.Add(recordsButton);
            dropDownAbsent.Dock = DockStyle.Top;
            dropDownAbsent.Location = new Point(0, 455);
            dropDownAbsent.MaximumSize = new Size(370, 213);
            dropDownAbsent.MinimumSize = new Size(370, 69);
            dropDownAbsent.Name = "dropDownAbsent";
            dropDownAbsent.Size = new Size(370, 69);
            dropDownAbsent.TabIndex = 0;
            // 
            // buttonAbsentees
            // 
            buttonAbsentees.BackColor = Color.FromArgb(164, 16, 48);
            buttonAbsentees.BackgroundImageLayout = ImageLayout.None;
            buttonAbsentees.Cursor = Cursors.Hand;
            buttonAbsentees.Dock = DockStyle.Top;
            buttonAbsentees.FlatAppearance.BorderSize = 0;
            buttonAbsentees.FlatStyle = FlatStyle.Flat;
            buttonAbsentees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAbsentees.ForeColor = Color.White;
            buttonAbsentees.Image = (Image)resources.GetObject("buttonAbsentees.Image");
            buttonAbsentees.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbsentees.Location = new Point(3, 3);
            buttonAbsentees.Name = "buttonAbsentees";
            buttonAbsentees.Padding = new Padding(10, 0, 0, 0);
            buttonAbsentees.Size = new Size(210, 65);
            buttonAbsentees.TabIndex = 26;
            buttonAbsentees.Text = "     ABSENT";
            buttonAbsentees.UseVisualStyleBackColor = false;
            buttonAbsentees.Click += buttonAbsentees_Click;
            // 
            // absenteesButton
            // 
            absenteesButton.BackColor = Color.FromArgb(204, 35, 71);
            absenteesButton.BackgroundImageLayout = ImageLayout.None;
            absenteesButton.Cursor = Cursors.Hand;
            absenteesButton.Dock = DockStyle.Top;
            absenteesButton.FlatAppearance.BorderSize = 0;
            absenteesButton.FlatStyle = FlatStyle.Flat;
            absenteesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            absenteesButton.ForeColor = Color.White;
            absenteesButton.Image = (Image)resources.GetObject("absenteesButton.Image");
            absenteesButton.ImageAlign = ContentAlignment.MiddleLeft;
            absenteesButton.Location = new Point(3, 74);
            absenteesButton.Name = "absenteesButton";
            absenteesButton.Padding = new Padding(10, 0, 0, 0);
            absenteesButton.Size = new Size(210, 65);
            absenteesButton.TabIndex = 27;
            absenteesButton.Text = "     ABSENTEES";
            absenteesButton.UseVisualStyleBackColor = false;
            absenteesButton.Click += absenteesButton_Click;
            // 
            // recordsButton
            // 
            recordsButton.BackColor = Color.FromArgb(204, 35, 71);
            recordsButton.BackgroundImageLayout = ImageLayout.None;
            recordsButton.Cursor = Cursors.Hand;
            recordsButton.Dock = DockStyle.Top;
            recordsButton.FlatAppearance.BorderSize = 0;
            recordsButton.FlatStyle = FlatStyle.Flat;
            recordsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            recordsButton.ForeColor = Color.White;
            recordsButton.Image = (Image)resources.GetObject("recordsButton.Image");
            recordsButton.ImageAlign = ContentAlignment.MiddleLeft;
            recordsButton.Location = new Point(3, 145);
            recordsButton.Name = "recordsButton";
            recordsButton.Padding = new Padding(10, 0, 0, 0);
            recordsButton.Size = new Size(210, 65);
            recordsButton.TabIndex = 28;
            recordsButton.Text = "     RECORDS";
            recordsButton.UseVisualStyleBackColor = false;
            recordsButton.Click += recordsButton_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Image = Properties.Resources.logout;
            buttonLogout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogout.Location = new Point(0, 704);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(10, 0, 0, 0);
            buttonLogout.Size = new Size(61, 65);
            buttonLogout.TabIndex = 25;
            buttonLogout.Text = "     LOGOUT";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonPayroll
            // 
            buttonPayroll.Cursor = Cursors.Hand;
            buttonPayroll.Dock = DockStyle.Top;
            buttonPayroll.FlatAppearance.BorderSize = 0;
            buttonPayroll.FlatStyle = FlatStyle.Flat;
            buttonPayroll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPayroll.ForeColor = Color.White;
            buttonPayroll.Image = Properties.Resources.payroll;
            buttonPayroll.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPayroll.Location = new Point(0, 390);
            buttonPayroll.Name = "buttonPayroll";
            buttonPayroll.Padding = new Padding(10, 0, 0, 0);
            buttonPayroll.Size = new Size(61, 65);
            buttonPayroll.TabIndex = 25;
            buttonPayroll.Text = "     PAYROLL";
            buttonPayroll.TextAlign = ContentAlignment.MiddleLeft;
            buttonPayroll.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPayroll.UseVisualStyleBackColor = true;
            buttonPayroll.Visible = false;
            buttonPayroll.Click += buttonPayroll_Click;
            // 
            // buttonLeave
            // 
            buttonLeave.Cursor = Cursors.Hand;
            buttonLeave.Dock = DockStyle.Top;
            buttonLeave.FlatAppearance.BorderSize = 0;
            buttonLeave.FlatStyle = FlatStyle.Flat;
            buttonLeave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLeave.ForeColor = Color.White;
            buttonLeave.Image = Properties.Resources.leave;
            buttonLeave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLeave.Location = new Point(0, 325);
            buttonLeave.Name = "buttonLeave";
            buttonLeave.Padding = new Padding(10, 0, 0, 0);
            buttonLeave.Size = new Size(61, 65);
            buttonLeave.TabIndex = 25;
            buttonLeave.Text = "     LEAVE";
            buttonLeave.TextAlign = ContentAlignment.MiddleLeft;
            buttonLeave.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLeave.UseVisualStyleBackColor = true;
            buttonLeave.Visible = false;
            buttonLeave.Click += buttonLeave_Click_1;
            // 
            // buttonEmployeeList
            // 
            buttonEmployeeList.Cursor = Cursors.Hand;
            buttonEmployeeList.Dock = DockStyle.Top;
            buttonEmployeeList.FlatAppearance.BorderSize = 0;
            buttonEmployeeList.FlatStyle = FlatStyle.Flat;
            buttonEmployeeList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployeeList.ForeColor = Color.White;
            buttonEmployeeList.Image = (Image)resources.GetObject("buttonEmployeeList.Image");
            buttonEmployeeList.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEmployeeList.Location = new Point(0, 260);
            buttonEmployeeList.Name = "buttonEmployeeList";
            buttonEmployeeList.Padding = new Padding(10, 0, 0, 0);
            buttonEmployeeList.Size = new Size(61, 65);
            buttonEmployeeList.TabIndex = 25;
            buttonEmployeeList.Text = "     EMPLOYEES";
            buttonEmployeeList.UseVisualStyleBackColor = true;
            buttonEmployeeList.Click += buttonEmployeeList_Click_1;
            // 
            // buttonDepartment
            // 
            buttonDepartment.Cursor = Cursors.Hand;
            buttonDepartment.Dock = DockStyle.Top;
            buttonDepartment.FlatAppearance.BorderSize = 0;
            buttonDepartment.FlatStyle = FlatStyle.Flat;
            buttonDepartment.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDepartment.ForeColor = Color.White;
            buttonDepartment.Image = (Image)resources.GetObject("buttonDepartment.Image");
            buttonDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDepartment.Location = new Point(0, 195);
            buttonDepartment.Name = "buttonDepartment";
            buttonDepartment.Padding = new Padding(10, 0, 10, 0);
            buttonDepartment.Size = new Size(61, 65);
            buttonDepartment.TabIndex = 25;
            buttonDepartment.Text = "     DEPARTMENT";
            buttonDepartment.UseVisualStyleBackColor = true;
            buttonDepartment.Click += buttonDepartment_Click;
            // 
            // buttonAttendance
            // 
            buttonAttendance.Cursor = Cursors.Hand;
            buttonAttendance.Dock = DockStyle.Top;
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = (Image)resources.GetObject("buttonAttendance.Image");
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(0, 130);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Padding = new Padding(10, 0, 0, 0);
            buttonAttendance.Size = new Size(61, 65);
            buttonAttendance.TabIndex = 25;
            buttonAttendance.Text = "     ATTENDANCE";
            buttonAttendance.UseVisualStyleBackColor = true;
            buttonAttendance.Click += buttonAttendance_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Cursor = Cursors.Hand;
            buttonDashboard.Dock = DockStyle.Top;
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(0, 65);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(10, 0, 0, 0);
            buttonDashboard.Size = new Size(61, 65);
            buttonDashboard.TabIndex = 25;
            buttonDashboard.Text = "     DASHBOARD";
            buttonDashboard.UseVisualStyleBackColor = true;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // labelMenu
            // 
            labelMenu.Cursor = Cursors.Hand;
            labelMenu.Dock = DockStyle.Top;
            labelMenu.FlatStyle = FlatStyle.Flat;
            labelMenu.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelMenu.ForeColor = Color.White;
            labelMenu.Image = (Image)resources.GetObject("labelMenu.Image");
            labelMenu.ImageAlign = ContentAlignment.MiddleLeft;
            labelMenu.Location = new Point(0, 0);
            labelMenu.Name = "labelMenu";
            labelMenu.Padding = new Padding(10, 0, 0, 0);
            labelMenu.Size = new Size(61, 65);
            labelMenu.TabIndex = 25;
            labelMenu.TextAlign = ContentAlignment.MiddleCenter;
            labelMenu.Click += labelMenu_Click;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.AutoScroll = true;
            panelDesktopPane.BorderStyle = BorderStyle.FixedSingle;
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(63, 110);
            panelDesktopPane.MaximumSize = new Size(1920, 1080);
            panelDesktopPane.MinimumSize = new Size(1454, 712);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(1841, 771);
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
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Home1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 881);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelMenu);
            Controls.Add(panelHeader);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            Name = "Home1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT Attendance System";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMenu.ResumeLayout(false);
            dropDownAbsent.ResumeLayout(false);
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
        private Button buttonEmployeeList;
        private Button buttonDepartment;
        private Button buttonAttendance;
        private Button buttonDashboard;
        private Label labelMenu;
        private Button buttonLeave;
        private Button buttonPayroll;
        private Button buttonLogout;
        private Label logo2Label;
        private Label Title;
        private Button buttonAbsentees;
        private FlowLayoutPanel dropDownAbsent;
        private Button absenteesButton;
        private Button recordsButton;
        private System.Windows.Forms.Timer timer1;
    }
}