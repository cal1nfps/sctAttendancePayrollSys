namespace SCTAttendanceSystemUI
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            panelColorBg = new Panel();
            button1 = new Button();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            textBoxIDNum = new TextBox();
            labelPassword = new Label();
            labelIdNo = new Label();
            labelGreet = new Label();
            panelLogo = new Panel();
            labelTaytay = new Label();
            labelSiena = new Label();
            panelColorBg.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorBg
            // 
            panelColorBg.BackColor = Color.FromArgb(164, 16, 52);
            panelColorBg.Controls.Add(button1);
            panelColorBg.Controls.Add(buttonLogin);
            panelColorBg.Controls.Add(textBoxPassword);
            panelColorBg.Controls.Add(textBoxIDNum);
            panelColorBg.Controls.Add(labelPassword);
            panelColorBg.Controls.Add(labelIdNo);
            panelColorBg.Controls.Add(labelGreet);
            panelColorBg.Dock = DockStyle.Right;
            panelColorBg.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panelColorBg.Location = new Point(659, 0);
            panelColorBg.Name = "panelColorBg";
            panelColorBg.Size = new Size(605, 681);
            panelColorBg.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(30, 25);
            button1.Name = "button1";
            button1.Size = new Size(43, 32);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseHover += button1_MouseHover;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(247, 208, 2);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(271, 508);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 58);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ImeMode = ImeMode.NoControl;
            textBoxPassword.Location = new Point(187, 411);
            textBoxPassword.MaxLength = 100;
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.PlaceholderText = "PASSWORD";
            textBoxPassword.Size = new Size(290, 40);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxIDNum
            // 
            textBoxIDNum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDNum.Location = new Point(187, 298);
            textBoxIDNum.MaxLength = 100;
            textBoxIDNum.Multiline = true;
            textBoxIDNum.Name = "textBoxIDNum";
            textBoxIDNum.PlaceholderText = "ID NO.";
            textBoxIDNum.Size = new Size(290, 40);
            textBoxIDNum.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(160, 367);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(133, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "PASSWORD";
            // 
            // labelIdNo
            // 
            labelIdNo.AutoSize = true;
            labelIdNo.BackColor = Color.Transparent;
            labelIdNo.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelIdNo.ForeColor = Color.White;
            labelIdNo.Location = new Point(160, 253);
            labelIdNo.Name = "labelIdNo";
            labelIdNo.RightToLeft = RightToLeft.No;
            labelIdNo.Size = new Size(82, 25);
            labelIdNo.TabIndex = 1;
            labelIdNo.Text = "ID NO.";
            // 
            // labelGreet
            // 
            labelGreet.AutoSize = true;
            labelGreet.BackColor = Color.Transparent;
            labelGreet.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelGreet.ForeColor = Color.White;
            labelGreet.Location = new Point(77, 166);
            labelGreet.Name = "labelGreet";
            labelGreet.Size = new Size(411, 45);
            labelGreet.TabIndex = 0;
            labelGreet.Text = "WELCOME, ADMIN!";
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Transparent;
            panelLogo.BackgroundImage = Properties.Resources.logo1;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Location = new Point(240, 190);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 169);
            panelLogo.TabIndex = 15;
            // 
            // labelTaytay
            // 
            labelTaytay.AutoSize = true;
            labelTaytay.BackColor = Color.Transparent;
            labelTaytay.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaytay.Location = new Point(225, 430);
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
            labelSiena.Location = new Point(100, 360);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(469, 62);
            labelSiena.TabIndex = 13;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelLogo);
            Controls.Add(labelTaytay);
            Controls.Add(labelSiena);
            Controls.Add(panelColorBg);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panelColorBg.ResumeLayout(false);
            panelColorBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelColorBg;
        private Button button1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxIDNum;
        private Label labelPassword;
        private Label labelIdNo;
        private Label labelGreet;
        private Panel panelLogo;
        private Label labelTaytay;
        private Label labelSiena;
    }
}