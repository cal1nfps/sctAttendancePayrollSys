namespace SCTAttendanceSystemUI.Resources
{
    partial class RequestLeaveAuth
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
            RedPanel = new Panel();
            empname = new Label();
            button1 = new Button();
            RequestLogin = new Button();
            Empnumber = new TextBox();
            labelIdNo = new Label();
            welcomelabel = new Label();
            panelLogo = new Panel();
            labelTaytay = new Label();
            labelSiena = new Label();
            RedPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RedPanel
            // 
            RedPanel.BackColor = Color.FromArgb(164, 16, 52);
            RedPanel.Controls.Add(empname);
            RedPanel.Controls.Add(button1);
            RedPanel.Controls.Add(RequestLogin);
            RedPanel.Controls.Add(Empnumber);
            RedPanel.Controls.Add(labelIdNo);
            RedPanel.Controls.Add(welcomelabel);
            RedPanel.Dock = DockStyle.Right;
            RedPanel.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            RedPanel.Location = new Point(696, 0);
            RedPanel.Name = "RedPanel";
            RedPanel.Size = new Size(690, 788);
            RedPanel.TabIndex = 10;
            // 
            // empname
            // 
            empname.AutoSize = true;
            empname.BackColor = Color.Transparent;
            empname.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            empname.ForeColor = Color.White;
            empname.Location = new Point(116, 259);
            empname.Name = "empname";
            empname.Size = new Size(178, 31);
            empname.TabIndex = 7;
            empname.Text = "EMPLOYEE!";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = Properties.Resources.close;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(602, 48);
            button1.Name = "button1";
            button1.Size = new Size(62, 58);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // RequestLogin
            // 
            RequestLogin.BackColor = Color.FromArgb(247, 208, 2);
            RequestLogin.Cursor = Cursors.Hand;
            RequestLogin.FlatStyle = FlatStyle.Flat;
            RequestLogin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            RequestLogin.Location = new Point(432, 401);
            RequestLogin.Name = "RequestLogin";
            RequestLogin.Size = new Size(111, 40);
            RequestLogin.TabIndex = 5;
            RequestLogin.Text = "LOGIN";
            RequestLogin.UseVisualStyleBackColor = false;
            RequestLogin.Click += RequestLogin_Click;
            // 
            // Empnumber
            // 
            Empnumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Empnumber.Location = new Point(141, 401);
            Empnumber.MaxLength = 100;
            Empnumber.Multiline = true;
            Empnumber.Name = "Empnumber";
            Empnumber.PlaceholderText = "EMPLOYEE ID";
            Empnumber.Size = new Size(290, 40);
            Empnumber.TabIndex = 3;
            // 
            // labelIdNo
            // 
            labelIdNo.AutoSize = true;
            labelIdNo.BackColor = Color.Transparent;
            labelIdNo.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdNo.ForeColor = Color.White;
            labelIdNo.Location = new Point(93, 360);
            labelIdNo.Name = "labelIdNo";
            labelIdNo.RightToLeft = RightToLeft.No;
            labelIdNo.Size = new Size(158, 22);
            labelIdNo.TabIndex = 1;
            labelIdNo.Text = "EMPLOYEE NO.";
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.BackColor = Color.Transparent;
            welcomelabel.Font = new Font("Times New Roman", 32F, FontStyle.Bold, GraphicsUnit.Point);
            welcomelabel.ForeColor = Color.White;
            welcomelabel.Location = new Point(41, 172);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(269, 49);
            welcomelabel.TabIndex = 0;
            welcomelabel.Text = "WELCOME,";
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = Properties.Resources.logo1;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Location = new Point(241, 229);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 169);
            panelLogo.TabIndex = 15;
            // 
            // labelTaytay
            // 
            labelTaytay.AutoSize = true;
            labelTaytay.BackColor = Color.Transparent;
            labelTaytay.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaytay.Location = new Point(241, 473);
            labelTaytay.Name = "labelTaytay";
            labelTaytay.Size = new Size(215, 31);
            labelTaytay.TabIndex = 14;
            labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            labelSiena.AutoSize = true;
            labelSiena.BackColor = Color.Transparent;
            labelSiena.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelSiena.Location = new Point(111, 401);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(469, 62);
            labelSiena.TabIndex = 13;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // RequestLeaveAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1386, 788);
            Controls.Add(panelLogo);
            Controls.Add(labelTaytay);
            Controls.Add(labelSiena);
            Controls.Add(RedPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "RequestLeaveAuth";
            Text = "RequestLeaveAuth";
            Load += RequestLeaveAuth_Load;
            RedPanel.ResumeLayout(false);
            RedPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel RedPanel;
        private Label empname;
        private Button button1;
        private Button RequestLogin;
        private TextBox Empnumber;
        private Label labelIdNo;
        private Label welcomelabel;
        private Panel panelLogo;
        private Label labelTaytay;
        private Label labelSiena;
    }
}