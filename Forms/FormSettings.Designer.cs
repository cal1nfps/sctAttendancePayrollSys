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
            this.panelBg = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxIDNo = new System.Windows.Forms.TextBox();
            this.textBoxCurrentPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIDNo = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.panelBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBg
            // 
            this.panelBg.BackColor = System.Drawing.SystemColors.Control;
            this.panelBg.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.white1bg;
            this.panelBg.Controls.Add(this.buttonSave);
            this.panelBg.Controls.Add(this.buttonLogin);
            this.panelBg.Controls.Add(this.textBoxIDNo);
            this.panelBg.Controls.Add(this.textBoxCurrentPassword);
            this.panelBg.Controls.Add(this.textBoxNewPassword);
            this.panelBg.Controls.Add(this.labelCurrentPassword);
            this.panelBg.Controls.Add(this.labelNewPassword);
            this.panelBg.Controls.Add(this.labelPassword);
            this.panelBg.Controls.Add(this.labelIDNo);
            this.panelBg.Controls.Add(this.labelAccountNumber);
            this.panelBg.Location = new System.Drawing.Point(51, 80);
            this.panelBg.Name = "panelBg";
            this.panelBg.Size = new System.Drawing.Size(923, 434);
            this.panelBg.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(411, 362);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(150, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_2);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(1561, 739);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 40);
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "SAVE";
            this.buttonLogin.UseVisualStyleBackColor = false;
            // 
            // textBoxIDNo
            // 
            this.textBoxIDNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDNo.Location = new System.Drawing.Point(345, 88);
            this.textBoxIDNo.MaxLength = 100;
            this.textBoxIDNo.Multiline = true;
            this.textBoxIDNo.Name = "textBoxIDNo";
            this.textBoxIDNo.Size = new System.Drawing.Size(290, 40);
            this.textBoxIDNo.TabIndex = 8;
            this.textBoxIDNo.TextChanged += new System.EventHandler(this.textBoxIDNo_TextChanged_1);
            // 
            // textBoxCurrentPassword
            // 
            this.textBoxCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentPassword.Location = new System.Drawing.Point(345, 288);
            this.textBoxCurrentPassword.MaxLength = 100;
            this.textBoxCurrentPassword.Multiline = true;
            this.textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            this.textBoxCurrentPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxCurrentPassword.TabIndex = 7;
            this.textBoxCurrentPassword.TextChanged += new System.EventHandler(this.textBoxCurrentPassword_TextChanged_1);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNewPassword.Location = new System.Drawing.Point(345, 216);
            this.textBoxNewPassword.MaxLength = 100;
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(290, 40);
            this.textBoxNewPassword.TabIndex = 6;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged_1);
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPassword.Location = new System.Drawing.Point(207, 291);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(141, 28);
            this.labelCurrentPassword.TabIndex = 5;
            this.labelCurrentPassword.Text = "New Password:";
            this.labelCurrentPassword.Click += new System.EventHandler(this.labelCurrentPassword_Click_2);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNewPassword.Location = new System.Drawing.Point(172, 219);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(167, 28);
            this.labelNewPassword.TabIndex = 4;
            this.labelNewPassword.Text = "Current Password:";
            this.labelNewPassword.Click += new System.EventHandler(this.labelNewPassword_Click_1);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(400, 169);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(144, 26);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "PASSWORD";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click_1);
            // 
            // labelIDNo
            // 
            this.labelIDNo.AutoSize = true;
            this.labelIDNo.BackColor = System.Drawing.Color.Transparent;
            this.labelIDNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIDNo.Location = new System.Drawing.Point(172, 91);
            this.labelIDNo.Name = "labelIDNo";
            this.labelIDNo.Size = new System.Drawing.Size(167, 28);
            this.labelIDNo.TabIndex = 2;
            this.labelIDNo.Text = "Your Admin User: ";
            this.labelIDNo.Click += new System.EventHandler(this.labelIDNo_Click_2);
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelAccountNumber.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAccountNumber.Location = new System.Drawing.Point(429, 24);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(95, 26);
            this.labelAccountNumber.TabIndex = 1;
            this.labelAccountNumber.Text = "ADMIN";
            this.labelAccountNumber.Click += new System.EventHandler(this.labelAccountNumber_Click_2);
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.labelChangePassword.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChangePassword.Location = new System.Drawing.Point(51, 28);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(293, 31);
            this.labelChangePassword.TabIndex = 0;
            this.labelChangePassword.Text = "CHANGE PASSWORD";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.panelBg);
            this.Controls.Add(this.labelChangePassword);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSettings";
            this.panelBg.ResumeLayout(false);
            this.panelBg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelBg;
        private Label labelCurrentPassword;
        private Label labelNewPassword;
        private Label labelPassword;
        private Label labelIDNo;
        private Label labelAccountNumber;
        private Label labelChangePassword;
        private TextBox textBoxIDNo;
        private TextBox textBoxCurrentPassword;
        private TextBox textBoxNewPassword;
        private Button buttonLogin;
        private Button buttonSave;
    }
}