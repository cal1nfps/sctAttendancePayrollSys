namespace SCTAttendanceSystemUI.Employee
{
    partial class FormEmployeeDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeDashboard));
            labelLoginAs = new Label();
            labelEmployeeName = new Label();
            dateLabel = new Label();
            panelBG = new Panel();
            panelPB = new Panel();
            employeePB = new PictureBox();
            backButton = new Button();
            occupationPanel = new Panel();
            occupationLabel = new Label();
            departmentPanel = new Panel();
            departmentLabel = new Label();
            namePanel = new Panel();
            empName = new Label();
            todayLabel = new Label();
            StatusPanel = new Panel();
            empStatusLabel = new Label();
            empNumPanel = new Panel();
            empNumLabel = new Label();
            SCTLogoPanel = new Panel();
            logo2Label = new Label();
            logo1Label = new Label();
            leaveButton = new Button();
            sctLogoPB = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            domiePB = new PictureBox();
            tapID = new TextBox();
            panelBG.SuspendLayout();
            panelPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeePB).BeginInit();
            occupationPanel.SuspendLayout();
            departmentPanel.SuspendLayout();
            namePanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            empNumPanel.SuspendLayout();
            SCTLogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sctLogoPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)domiePB).BeginInit();
            SuspendLayout();
            // 
            // labelLoginAs
            // 
            labelLoginAs.AutoSize = true;
            labelLoginAs.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelLoginAs.ForeColor = Color.White;
            labelLoginAs.Location = new Point(468, 36);
            labelLoginAs.Name = "labelLoginAs";
            labelLoginAs.Size = new Size(258, 31);
            labelLoginAs.TabIndex = 6;
            labelLoginAs.Text = "You are logged in as:";
            // 
            // labelEmployeeName
            // 
            labelEmployeeName.AutoSize = true;
            labelEmployeeName.Location = new Point(219, 18);
            labelEmployeeName.Name = "labelEmployeeName";
            labelEmployeeName.Size = new Size(0, 13);
            labelEmployeeName.TabIndex = 7;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.White;
            dateLabel.Location = new Point(315, 922);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(0, 53);
            dateLabel.TabIndex = 9;
            // 
            // panelBG
            // 
            panelBG.BackColor = Color.FromArgb(164, 16, 52);
            panelBG.BackgroundImage = (Image)resources.GetObject("panelBG.BackgroundImage");
            panelBG.BackgroundImageLayout = ImageLayout.Stretch;
            panelBG.Controls.Add(panelPB);
            panelBG.Controls.Add(backButton);
            panelBG.Controls.Add(occupationPanel);
            panelBG.Controls.Add(departmentPanel);
            panelBG.Controls.Add(namePanel);
            panelBG.Controls.Add(dateLabel);
            panelBG.Controls.Add(todayLabel);
            panelBG.Controls.Add(StatusPanel);
            panelBG.Controls.Add(empNumPanel);
            panelBG.Controls.Add(SCTLogoPanel);
            panelBG.Controls.Add(labelEmployeeName);
            panelBG.Controls.Add(tapID);
            panelBG.Dock = DockStyle.Fill;
            panelBG.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelBG.Location = new Point(0, 0);
            panelBG.Name = "panelBG";
            panelBG.Size = new Size(1900, 1037);
            panelBG.TabIndex = 1;
            // 
            // panelPB
            // 
            panelPB.BackColor = Color.FromArgb(242, 205, 10);
            panelPB.BackgroundImage = (Image)resources.GetObject("panelPB.BackgroundImage");
            panelPB.BackgroundImageLayout = ImageLayout.None;
            panelPB.Controls.Add(employeePB);
            panelPB.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panelPB.Location = new Point(66, 274);
            panelPB.Name = "panelPB";
            panelPB.Size = new Size(400, 400);
            panelPB.TabIndex = 24;
            // 
            // employeePB
            // 
            employeePB.BackColor = Color.WhiteSmoke;
            employeePB.Location = new Point(0, 0);
            employeePB.Name = "employeePB";
            employeePB.Size = new Size(400, 400);
            employeePB.TabIndex = 16;
            employeePB.TabStop = false;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Image = (Image)resources.GetObject("backButton.Image");
            backButton.ImageAlign = ContentAlignment.MiddleLeft;
            backButton.Location = new Point(0, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(71, 56);
            backButton.TabIndex = 7;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // occupationPanel
            // 
            occupationPanel.BackColor = Color.FromArgb(242, 205, 10);
            occupationPanel.BackgroundImage = (Image)resources.GetObject("occupationPanel.BackgroundImage");
            occupationPanel.BackgroundImageLayout = ImageLayout.None;
            occupationPanel.Controls.Add(occupationLabel);
            occupationPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            occupationPanel.Location = new Point(707, 414);
            occupationPanel.Name = "occupationPanel";
            occupationPanel.Size = new Size(915, 85);
            occupationPanel.TabIndex = 25;
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Font = new Font("Times New Roman", 30.75F, FontStyle.Regular, GraphicsUnit.Point);
            occupationLabel.ForeColor = Color.White;
            occupationLabel.Location = new Point(0, 19);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new Size(275, 47);
            occupationLabel.TabIndex = 14;
            occupationLabel.Text = "OCCUPATION";
            occupationLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // departmentPanel
            // 
            departmentPanel.BackColor = Color.FromArgb(242, 205, 10);
            departmentPanel.BackgroundImage = (Image)resources.GetObject("departmentPanel.BackgroundImage");
            departmentPanel.BackgroundImageLayout = ImageLayout.None;
            departmentPanel.Controls.Add(departmentLabel);
            departmentPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            departmentPanel.Location = new Point(707, 516);
            departmentPanel.Name = "departmentPanel";
            departmentPanel.Size = new Size(915, 85);
            departmentPanel.TabIndex = 24;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Font = new Font("Times New Roman", 30.75F, FontStyle.Regular, GraphicsUnit.Point);
            departmentLabel.ForeColor = Color.White;
            departmentLabel.Location = new Point(3, 17);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(289, 47);
            departmentLabel.TabIndex = 14;
            departmentLabel.Text = "DEPARTMENT";
            departmentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // namePanel
            // 
            namePanel.BackColor = Color.FromArgb(242, 205, 10);
            namePanel.BackgroundImage = (Image)resources.GetObject("namePanel.BackgroundImage");
            namePanel.BackgroundImageLayout = ImageLayout.None;
            namePanel.Controls.Add(empName);
            namePanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            namePanel.Location = new Point(707, 310);
            namePanel.Name = "namePanel";
            namePanel.Size = new Size(915, 85);
            namePanel.TabIndex = 23;
            // 
            // empName
            // 
            empName.AutoSize = true;
            empName.Font = new Font("Times New Roman", 35.75F, FontStyle.Regular, GraphicsUnit.Point);
            empName.ForeColor = Color.White;
            empName.Location = new Point(0, 16);
            empName.Name = "empName";
            empName.Size = new Size(165, 55);
            empName.TabIndex = 14;
            empName.Text = "NAME";
            empName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            todayLabel.AutoSize = true;
            todayLabel.Font = new Font("Times New Roman", 35.75F, FontStyle.Bold, GraphicsUnit.Point);
            todayLabel.ForeColor = Color.White;
            todayLabel.Location = new Point(66, 920);
            todayLabel.Name = "todayLabel";
            todayLabel.Size = new Size(249, 55);
            todayLabel.TabIndex = 21;
            todayLabel.Text = "TODAY IS";
            // 
            // StatusPanel
            // 
            StatusPanel.BackColor = Color.FromArgb(242, 205, 10);
            StatusPanel.BackgroundImage = (Image)resources.GetObject("StatusPanel.BackgroundImage");
            StatusPanel.BackgroundImageLayout = ImageLayout.None;
            StatusPanel.Controls.Add(empStatusLabel);
            StatusPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            StatusPanel.Location = new Point(66, 767);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(400, 81);
            StatusPanel.TabIndex = 20;
            // 
            // empStatusLabel
            // 
            empStatusLabel.AutoSize = true;
            empStatusLabel.Font = new Font("Times New Roman", 25.75F, FontStyle.Regular, GraphicsUnit.Point);
            empStatusLabel.ForeColor = Color.White;
            empStatusLabel.Location = new Point(124, 20);
            empStatusLabel.Name = "empStatusLabel";
            empStatusLabel.Size = new Size(138, 40);
            empStatusLabel.TabIndex = 23;
            empStatusLabel.Text = "STATUS";
            empStatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // empNumPanel
            // 
            empNumPanel.BackColor = Color.FromArgb(242, 205, 10);
            empNumPanel.BackgroundImage = (Image)resources.GetObject("empNumPanel.BackgroundImage");
            empNumPanel.BackgroundImageLayout = ImageLayout.None;
            empNumPanel.Controls.Add(empNumLabel);
            empNumPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            empNumPanel.Location = new Point(66, 680);
            empNumPanel.Name = "empNumPanel";
            empNumPanel.Size = new Size(400, 81);
            empNumPanel.TabIndex = 19;
            // 
            // empNumLabel
            // 
            empNumLabel.AutoSize = true;
            empNumLabel.Font = new Font("Times New Roman", 25.75F, FontStyle.Regular, GraphicsUnit.Point);
            empNumLabel.ForeColor = Color.White;
            empNumLabel.Location = new Point(24, 19);
            empNumLabel.Name = "empNumLabel";
            empNumLabel.Size = new Size(358, 40);
            empNumLabel.TabIndex = 22;
            empNumLabel.Text = "EMPLOYEE NUMBER";
            empNumLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SCTLogoPanel
            // 
            SCTLogoPanel.BackColor = Color.FromArgb(242, 205, 10);
            SCTLogoPanel.BackgroundImage = (Image)resources.GetObject("SCTLogoPanel.BackgroundImage");
            SCTLogoPanel.BackgroundImageLayout = ImageLayout.None;
            SCTLogoPanel.Controls.Add(logo2Label);
            SCTLogoPanel.Controls.Add(logo1Label);
            SCTLogoPanel.Controls.Add(leaveButton);
            SCTLogoPanel.Controls.Add(sctLogoPB);
            SCTLogoPanel.Controls.Add(label2);
            SCTLogoPanel.Controls.Add(label3);
            SCTLogoPanel.Controls.Add(label4);
            SCTLogoPanel.Controls.Add(domiePB);
            SCTLogoPanel.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SCTLogoPanel.Location = new Point(0, 70);
            SCTLogoPanel.Name = "SCTLogoPanel";
            SCTLogoPanel.Size = new Size(1920, 116);
            SCTLogoPanel.TabIndex = 15;
            // 
            // logo2Label
            // 
            logo2Label.AutoSize = true;
            logo2Label.BackColor = Color.Transparent;
            logo2Label.Font = new Font("Times New Roman", 25F, FontStyle.Bold, GraphicsUnit.Point);
            logo2Label.ForeColor = Color.Transparent;
            logo2Label.Location = new Point(889, 68);
            logo2Label.Name = "logo2Label";
            logo2Label.Size = new Size(272, 38);
            logo2Label.TabIndex = 17;
            logo2Label.Text = "TAYTAY, RIZAL";
            logo2Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo1Label
            // 
            logo1Label.AutoSize = true;
            logo1Label.BackColor = Color.Transparent;
            logo1Label.Font = new Font("Times New Roman", 50F, FontStyle.Bold, GraphicsUnit.Point);
            logo1Label.ForeColor = Color.Transparent;
            logo1Label.Location = new Point(742, 3);
            logo1Label.Name = "logo1Label";
            logo1Label.Size = new Size(598, 76);
            logo1Label.TabIndex = 16;
            logo1Label.Text = "SIENA COLLEGE ";
            logo1Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // leaveButton
            // 
            leaveButton.BackColor = Color.FromArgb(255, 121, 0);
            leaveButton.FlatStyle = FlatStyle.Flat;
            leaveButton.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            leaveButton.Location = new Point(262, 395);
            leaveButton.Name = "leaveButton";
            leaveButton.Size = new Size(167, 51);
            leaveButton.TabIndex = 13;
            leaveButton.Text = "REQUEST LEAVE";
            leaveButton.UseVisualStyleBackColor = false;
            // 
            // sctLogoPB
            // 
            sctLogoPB.BackColor = Color.Transparent;
            sctLogoPB.BackgroundImage = Properties.Resources.logo;
            sctLogoPB.BackgroundImageLayout = ImageLayout.Zoom;
            sctLogoPB.Location = new Point(613, 4);
            sctLogoPB.Name = "sctLogoPB";
            sctLogoPB.Size = new Size(158, 103);
            sctLogoPB.TabIndex = 14;
            sctLogoPB.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(206, 240);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 10;
            label2.Text = "TIME: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(206, 193);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 9;
            label3.Text = "DATE: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 18);
            label4.Name = "label4";
            label4.Size = new Size(0, 13);
            label4.TabIndex = 7;
            // 
            // domiePB
            // 
            domiePB.BackColor = Color.Transparent;
            domiePB.BackgroundImage = (Image)resources.GetObject("domiePB.BackgroundImage");
            domiePB.BackgroundImageLayout = ImageLayout.Zoom;
            domiePB.Location = new Point(1720, 0);
            domiePB.Name = "domiePB";
            domiePB.Size = new Size(168, 118);
            domiePB.TabIndex = 18;
            domiePB.TabStop = false;
            // 
            // tapID
            // 
            tapID.BackColor = Color.FromArgb(242, 205, 10);
            tapID.BorderStyle = BorderStyle.None;
            tapID.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            tapID.ForeColor = Color.FromArgb(164, 16, 52);
            tapID.Location = new Point(707, 644);
            tapID.MaxLength = 100;
            tapID.Name = "tapID";
            tapID.Size = new Size(915, 54);
            tapID.TabIndex = 1;
            tapID.KeyDown += tapID_KeyDown;
            // 
            // FormEmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(164, 16, 52);
            ClientSize = new Size(1900, 1037);
            Controls.Add(panelBG);
            Controls.Add(labelLoginAs);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1600, 900);
            Name = "FormEmployeeDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT Attendance System";
            WindowState = FormWindowState.Maximized;
            Load += FormEmployeeDashboard_Load_1;
            panelBG.ResumeLayout(false);
            panelBG.PerformLayout();
            panelPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeePB).EndInit();
            occupationPanel.ResumeLayout(false);
            occupationPanel.PerformLayout();
            departmentPanel.ResumeLayout(false);
            departmentPanel.PerformLayout();
            namePanel.ResumeLayout(false);
            namePanel.PerformLayout();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            empNumPanel.ResumeLayout(false);
            empNumPanel.PerformLayout();
            SCTLogoPanel.ResumeLayout(false);
            SCTLogoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sctLogoPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)domiePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLoginAs;
        private Label labelEmployeeName;
        private Label dateLabel;
        private Panel panelBG;
        private Label empName;
        private Panel SCTLogoPanel;
        private Button leaveButton;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox sctLogoPB;
        private Label logo1Label;
        private Label logo2Label;
        private PictureBox domiePB;
        public PictureBox employeePB;
        private Panel empNumPanel;
        private Panel StatusPanel;
        private Label empStatusLabel;
        private Label empNumLabel;
        private Label todayLabel;
        private Panel namePanel;
        private Panel occupationPanel;
        private Label occupationLabel;
        private Panel departmentPanel;
        private Label departmentLabel;
        private TextBox tapID;
        private Button backButton;
        private Panel panelPB;
    }
}