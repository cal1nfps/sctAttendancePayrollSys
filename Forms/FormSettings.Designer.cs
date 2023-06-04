namespace SCTAttendanceSystemUI.Forms
{
    partial class FormSettings
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
            panelBg = new Panel();
            buttonSave = new Button();
            buttonLogin = new Button();
            textBoxIDNo = new TextBox();
            textBoxCurrentPassword = new TextBox();
            textBoxNewPassword = new TextBox();
            labelCurrentPassword = new Label();
            labelNewPassword = new Label();
            labelPassword = new Label();
            labelIDNo = new Label();
            labelAccountNumber = new Label();
            labelAccountSettings = new Label();
            panelBg.SuspendLayout();
            SuspendLayout();
            // 
            // panelBg
            // 
            panelBg.BackColor = SystemColors.Control;
            panelBg.BackgroundImage = Properties.Resources.white1bg;
            panelBg.Controls.Add(buttonSave);
            panelBg.Controls.Add(buttonLogin);
            panelBg.Controls.Add(textBoxIDNo);
            panelBg.Controls.Add(textBoxCurrentPassword);
            panelBg.Controls.Add(textBoxNewPassword);
            panelBg.Controls.Add(labelCurrentPassword);
            panelBg.Controls.Add(labelNewPassword);
            panelBg.Controls.Add(labelPassword);
            panelBg.Controls.Add(labelIDNo);
            panelBg.Controls.Add(labelAccountNumber);
            panelBg.Location = new Point(51, 100);
            panelBg.Name = "panelBg";
            panelBg.Size = new Size(1336, 562);
            panelBg.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(247, 208, 2);
            buttonSave.Cursor = Cursors.Hand;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Location = new Point(623, 454);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 40);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click_1;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(247, 208, 2);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.Location = new Point(1561, 739);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(150, 40);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "SAVE";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxIDNo
            // 
            textBoxIDNo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxIDNo.Location = new Point(557, 113);
            textBoxIDNo.MaxLength = 100;
            textBoxIDNo.Multiline = true;
            textBoxIDNo.Name = "textBoxIDNo";
            textBoxIDNo.Size = new Size(290, 40);
            textBoxIDNo.TabIndex = 8;
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCurrentPassword.Location = new Point(557, 380);
            textBoxCurrentPassword.MaxLength = 100;
            textBoxCurrentPassword.Multiline = true;
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(290, 40);
            textBoxCurrentPassword.TabIndex = 7;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNewPassword.Location = new Point(557, 308);
            textBoxNewPassword.MaxLength = 100;
            textBoxNewPassword.Multiline = true;
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(290, 40);
            textBoxNewPassword.TabIndex = 6;
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.BackColor = Color.Transparent;
            labelCurrentPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrentPassword.Location = new Point(419, 383);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(141, 28);
            labelCurrentPassword.TabIndex = 5;
            labelCurrentPassword.Text = "New Password:";
            labelCurrentPassword.Click += labelCurrentPassword_Click_1;
            // 
            // labelNewPassword
            // 
            labelNewPassword.AutoSize = true;
            labelNewPassword.BackColor = Color.Transparent;
            labelNewPassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelNewPassword.Location = new Point(384, 311);
            labelNewPassword.Name = "labelNewPassword";
            labelNewPassword.Size = new Size(167, 28);
            labelNewPassword.TabIndex = 4;
            labelNewPassword.Text = "Current Password:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.BackColor = Color.Transparent;
            labelPassword.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(612, 261);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(144, 26);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "PASSWORD";
            // 
            // labelIDNo
            // 
            labelIDNo.AutoSize = true;
            labelIDNo.BackColor = Color.Transparent;
            labelIDNo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelIDNo.Location = new Point(384, 116);
            labelIDNo.Name = "labelIDNo";
            labelIDNo.Size = new Size(167, 28);
            labelIDNo.TabIndex = 2;
            labelIDNo.Text = "Your Admin User: ";
            labelIDNo.Click += labelIDNo_Click_1;
            // 
            // labelAccountNumber
            // 
            labelAccountNumber.AutoSize = true;
            labelAccountNumber.BackColor = Color.Transparent;
            labelAccountNumber.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccountNumber.Location = new Point(641, 49);
            labelAccountNumber.Name = "labelAccountNumber";
            labelAccountNumber.Size = new Size(95, 26);
            labelAccountNumber.TabIndex = 1;
            labelAccountNumber.Text = "ADMIN";
            labelAccountNumber.Click += labelAccountNumber_Click_1;
            // 
            // labelAccountSettings
            // 
            labelAccountSettings.AutoSize = true;
            labelAccountSettings.BackColor = Color.Transparent;
            labelAccountSettings.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAccountSettings.Location = new Point(51, 28);
            labelAccountSettings.Name = "labelAccountSettings";
            labelAccountSettings.Size = new Size(294, 31);
            labelAccountSettings.TabIndex = 0;
            labelAccountSettings.Text = "ACCOUNT SETTINGS";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(panelBg);
            Controls.Add(labelAccountSettings);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1681, 822);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSettings";
            panelBg.ResumeLayout(false);
            panelBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelBg;
        private Label labelCurrentPassword;
        private Label labelNewPassword;
        private Label labelPassword;
        private Label labelIDNo;
        private Label labelAccountNumber;
        private Label labelAccountSettings;
        private TextBox textBoxIDNo;
        private TextBox textBoxCurrentPassword;
        private TextBox textBoxNewPassword;
        private Button buttonLogin;
        private Button buttonSave;
    }
}