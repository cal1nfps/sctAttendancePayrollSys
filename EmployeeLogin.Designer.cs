namespace SCTAttendanceSystemUI
{
    partial class EmployeeLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLogin));
            panelColorBg = new Panel();
            backBtn = new Button();
            button1 = new Button();
            buttonLogin = new Button();
            labelIdNo = new Label();
            labelGreet = new Label();
            textBoxIDNum = new TextBox();
            panelLogo = new Panel();
            labelTaytay = new Label();
            labelSiena = new Label();
            panelColorBg.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorBg
            // 
            panelColorBg.BackColor = Color.FromArgb(164, 16, 52);
            panelColorBg.Controls.Add(backBtn);
            panelColorBg.Controls.Add(button1);
            panelColorBg.Controls.Add(buttonLogin);
            panelColorBg.Controls.Add(labelIdNo);
            panelColorBg.Controls.Add(labelGreet);
            panelColorBg.Controls.Add(textBoxIDNum);
            panelColorBg.Dock = DockStyle.Right;
            panelColorBg.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panelColorBg.Location = new Point(659, 0);
            panelColorBg.Name = "panelColorBg";
            panelColorBg.Size = new Size(605, 681);
            panelColorBg.TabIndex = 9;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Transparent;
            backBtn.Cursor = Cursors.Hand;
            backBtn.FlatAppearance.BorderSize = 0;
            backBtn.FlatStyle = FlatStyle.Flat;
            backBtn.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.ImageAlign = ContentAlignment.MiddleLeft;
            backBtn.Location = new Point(45, 30);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(43, 32);
            backBtn.TabIndex = 13;
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            backBtn.MouseHover += backBtn_MouseHover;
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
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(247, 208, 2);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(432, 401);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(111, 40);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Visible = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelIdNo
            // 
            labelIdNo.AutoSize = true;
            labelIdNo.BackColor = Color.Transparent;
            labelIdNo.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdNo.ForeColor = Color.White;
            labelIdNo.Location = new Point(93, 348);
            labelIdNo.Name = "labelIdNo";
            labelIdNo.RightToLeft = RightToLeft.No;
            labelIdNo.Size = new Size(183, 25);
            labelIdNo.TabIndex = 1;
            labelIdNo.Text = "EMPLOYEE NO.";
            // 
            // labelGreet
            // 
            labelGreet.AutoSize = true;
            labelGreet.BackColor = Color.Transparent;
            labelGreet.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelGreet.ForeColor = Color.White;
            labelGreet.Location = new Point(45, 261);
            labelGreet.Name = "labelGreet";
            labelGreet.Size = new Size(503, 45);
            labelGreet.TabIndex = 0;
            labelGreet.Text = "WELCOME, EMPLOYEE!";
            // 
            // textBoxIDNum
            // 
            textBoxIDNum.BackColor = Color.FromArgb(164, 16, 52);
            textBoxIDNum.BorderStyle = BorderStyle.None;
            textBoxIDNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDNum.ForeColor = Color.FromArgb(164, 16, 52);
            textBoxIDNum.Location = new Point(136, 405);
            textBoxIDNum.MaxLength = 100;
            textBoxIDNum.Name = "textBoxIDNum";
            textBoxIDNum.Size = new Size(290, 27);
            textBoxIDNum.TabIndex = 3;
            textBoxIDNum.Enter += textBoxIDNum_Enter;
            textBoxIDNum.KeyDown += textBoxIDNum_KeyDown;
            textBoxIDNum.Leave += textBoxIDNum_Leave;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = Properties.Resources.logo1;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Location = new Point(240, 190);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 169);
            panelLogo.TabIndex = 12;
            // 
            // labelTaytay
            // 
            labelTaytay.AutoSize = true;
            labelTaytay.BackColor = Color.Transparent;
            labelTaytay.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaytay.Location = new Point(225, 430);
            labelTaytay.Name = "labelTaytay";
            labelTaytay.Size = new Size(215, 31);
            labelTaytay.TabIndex = 11;
            labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            labelSiena.AutoSize = true;
            labelSiena.BackColor = Color.Transparent;
            labelSiena.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelSiena.Location = new Point(100, 360);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(469, 62);
            labelSiena.TabIndex = 10;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // EmployeeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(164, 16, 52);
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelColorBg);
            Controls.Add(panelLogo);
            Controls.Add(labelTaytay);
            Controls.Add(labelSiena);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "EmployeeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT ATTENDANCE SYSTEM EMPLOYEE";
            Load += EmployeeLogin_Load;
            panelColorBg.ResumeLayout(false);
            panelColorBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelColorBg;
        private Button button1;
        private Button buttonLogin;
        private TextBox textBoxIDNum;
        private Label labelIdNo;
        private Label labelGreet;
        private Panel panelLogo;
        private Label labelTaytay;
        private Label labelSiena;
        private Button backBtn;
    }
}