namespace SCTAttendanceSystemUI
{
    partial class Form1
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
            this.panelColorBg = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelGreet = new System.Windows.Forms.Label();
            this.labelTaytay = new System.Windows.Forms.Label();
            this.labelSiena = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLogo1 = new System.Windows.Forms.Panel();
            this.panelColorBg.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorBg
            // 
            this.panelColorBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.panelColorBg.Controls.Add(this.button1);
            this.panelColorBg.Controls.Add(this.buttonLogin);
            this.panelColorBg.Controls.Add(this.labelGreet);
            this.panelColorBg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColorBg.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelColorBg.Location = new System.Drawing.Point(992, 0);
            this.panelColorBg.Name = "panelColorBg";
            this.panelColorBg.Size = new System.Drawing.Size(690, 861);
            this.panelColorBg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(404, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "EMPLOYEE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(193, 438);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(150, 71);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "ADMIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click_1);
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.BackColor = System.Drawing.Color.Transparent;
            this.labelGreet.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreet.ForeColor = System.Drawing.Color.White;
            this.labelGreet.Location = new System.Drawing.Point(91, 334);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(252, 45);
            this.labelGreet.TabIndex = 0;
            this.labelGreet.Text = "WELCOME!";
            // 
            // labelTaytay
            // 
            this.labelTaytay.AutoSize = true;
            this.labelTaytay.BackColor = System.Drawing.Color.Transparent;
            this.labelTaytay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaytay.Location = new System.Drawing.Point(378, 567);
            this.labelTaytay.Name = "labelTaytay";
            this.labelTaytay.Size = new System.Drawing.Size(215, 31);
            this.labelTaytay.TabIndex = 7;
            this.labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.Location = new System.Drawing.Point(263, 505);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(469, 62);
            this.labelSiena.TabIndex = 6;
            this.labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.panelLogo1);
            this.panelLogo.Controls.Add(this.labelSiena);
            this.panelLogo.Controls.Add(this.labelTaytay);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(992, 861);
            this.panelLogo.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 822);
            this.panel1.TabIndex = 9;
            // 
            // panelLogo1
            // 
            this.panelLogo1.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo1.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.logo1;
            this.panelLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo1.Location = new System.Drawing.Point(393, 340);
            this.panelLogo1.Name = "panelLogo1";
            this.panelLogo1.Size = new System.Drawing.Size(200, 169);
            this.panelLogo1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1682, 861);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelColorBg);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1682, 861);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.panelColorBg.ResumeLayout(false);
            this.panelColorBg.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelColorBg;
        private Button buttonLogin;
        private Label labelGreet;
        private Label labelTaytay;
        private Label labelSiena;
        private Panel panelLogo;
        private Button button1;
        private Panel panel1;
        private Panel panelLogo1;
    }
}