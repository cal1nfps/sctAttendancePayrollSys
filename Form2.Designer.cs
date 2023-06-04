namespace SCTAttendanceSystemUI
{
    partial class Form2
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
            this.panelColorBg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxIDNum = new System.Windows.Forms.TextBox();
            this.labelIdNo = new System.Windows.Forms.Label();
            this.labelGreet = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTaytay = new System.Windows.Forms.Label();
            this.labelSiena = new System.Windows.Forms.Label();
            this.panelColorBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorBg
            // 
            this.panelColorBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.panelColorBg.Controls.Add(this.button1);
            this.panelColorBg.Controls.Add(this.buttonLogin);
            this.panelColorBg.Controls.Add(this.textBoxIDNum);
            this.panelColorBg.Controls.Add(this.labelIdNo);
            this.panelColorBg.Controls.Add(this.labelGreet);
            this.panelColorBg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColorBg.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelColorBg.Location = new System.Drawing.Point(1115, 0);
            this.panelColorBg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelColorBg.Name = "panelColorBg";
            this.panelColorBg.Size = new System.Drawing.Size(789, 1041);
            this.panelColorBg.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::SCTAttendanceSystemUI.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(688, 61);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 73);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(337, 612);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(171, 73);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxIDNum
            // 
            this.textBoxIDNum.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDNum.Location = new System.Drawing.Point(256, 500);
            this.textBoxIDNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxIDNum.MaxLength = 100;
            this.textBoxIDNum.Multiline = true;
            this.textBoxIDNum.Name = "textBoxIDNum";
            this.textBoxIDNum.PlaceholderText = "EMPLOYEE ID";
            this.textBoxIDNum.Size = new System.Drawing.Size(331, 50);
            this.textBoxIDNum.TabIndex = 3;
            // 
            // labelIdNo
            // 
            this.labelIdNo.AutoSize = true;
            this.labelIdNo.BackColor = System.Drawing.Color.Transparent;
            this.labelIdNo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIdNo.ForeColor = System.Drawing.Color.White;
            this.labelIdNo.Location = new System.Drawing.Point(225, 443);
            this.labelIdNo.Name = "labelIdNo";
            this.labelIdNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelIdNo.Size = new System.Drawing.Size(183, 25);
            this.labelIdNo.TabIndex = 1;
            this.labelIdNo.Text = "EMPLOYEE NO.";
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.BackColor = System.Drawing.Color.Transparent;
            this.labelGreet.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreet.ForeColor = System.Drawing.Color.White;
            this.labelGreet.Location = new System.Drawing.Point(51, 331);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(503, 45);
            this.labelGreet.TabIndex = 0;
            this.labelGreet.Text = "WELCOME, EMPLOYEE!";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.bw_logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLogo.Location = new System.Drawing.Point(489, 345);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 214);
            this.panelLogo.TabIndex = 12;
            // 
            // labelTaytay
            // 
            this.labelTaytay.AutoSize = true;
            this.labelTaytay.BackColor = System.Drawing.Color.Transparent;
            this.labelTaytay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaytay.Location = new System.Drawing.Point(489, 654);
            this.labelTaytay.Name = "labelTaytay";
            this.labelTaytay.Size = new System.Drawing.Size(215, 31);
            this.labelTaytay.TabIndex = 11;
            this.labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.Location = new System.Drawing.Point(341, 562);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(469, 62);
            this.labelSiena.TabIndex = 10;
            this.labelSiena.Text = "SIENA COLLEGE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelColorBg);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.labelTaytay);
            this.Controls.Add(this.labelSiena);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT ATTENDANCE SYSTEM EMPLOYEE";
            this.panelColorBg.ResumeLayout(false);
            this.panelColorBg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}