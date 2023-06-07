namespace SCTAttendanceSystemUI
{
    partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelColorBg = new Panel();
            button1 = new Button();
            buttonLogin = new Button();
            labelGreet = new Label();
            labelTaytay = new Label();
            labelSiena = new Label();
            panelLogo1 = new Panel();
            panelColorBg.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorBg
            // 
            panelColorBg.BackColor = Color.FromArgb(164, 16, 52);
            panelColorBg.Controls.Add(button1);
            panelColorBg.Controls.Add(buttonLogin);
            panelColorBg.Controls.Add(labelGreet);
            panelColorBg.Dock = DockStyle.Right;
            panelColorBg.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panelColorBg.Location = new Point(659, 0);
            panelColorBg.Name = "panelColorBg";
            panelColorBg.Size = new Size(605, 681);
            panelColorBg.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(247, 208, 2);
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(398, 375);
            button1.Name = "button1";
            button1.Size = new Size(150, 71);
            button1.TabIndex = 6;
            button1.Text = "EMPLOYEE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(247, 208, 2);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(187, 375);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 71);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "ADMIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // labelGreet
            // 
            labelGreet.AutoSize = true;
            labelGreet.BackColor = Color.Transparent;
            labelGreet.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelGreet.ForeColor = Color.White;
            labelGreet.Location = new Point(85, 266);
            labelGreet.Name = "labelGreet";
            labelGreet.Size = new Size(252, 45);
            labelGreet.TabIndex = 0;
            labelGreet.Text = "WELCOME!";
            // 
            // labelTaytay
            // 
            labelTaytay.AutoSize = true;
            labelTaytay.BackColor = Color.Transparent;
            labelTaytay.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaytay.Location = new Point(225, 430);
            labelTaytay.Name = "labelTaytay";
            labelTaytay.Size = new Size(215, 31);
            labelTaytay.TabIndex = 7;
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
            labelSiena.TabIndex = 6;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelLogo1
            // 
            panelLogo1.BackColor = Color.Transparent;
            panelLogo1.BackgroundImage = Properties.Resources.logo1;
            panelLogo1.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo1.Location = new Point(240, 190);
            panelLogo1.Name = "panelLogo1";
            panelLogo1.Size = new Size(200, 169);
            panelLogo1.TabIndex = 16;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelColorBg);
            Controls.Add(labelTaytay);
            Controls.Add(panelLogo1);
            Controls.Add(labelSiena);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT ATTENDANCE SYSTEM";
            panelColorBg.ResumeLayout(false);
            panelColorBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelColorBg;
        private Button buttonLogin;
        private Label labelGreet;
        private Label labelTaytay;
        private Label labelSiena;
        private Button button1;
        private Panel panelLogo1;
    }
}