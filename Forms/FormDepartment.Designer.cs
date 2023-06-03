namespace SCTAttendanceSystemUI.Forms
{
    partial class FormDepartment
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
            panel1 = new Panel();
            panelAsp = new Panel();
            labelAspCounter = new Label();
            labelAttendanceAsp = new Label();
            labelASP = new Label();
            button7 = new Button();
            panelIbed = new Panel();
            labelIbedCounter = new Label();
            labelAttendanceIbed = new Label();
            labelIBED = new Label();
            button8 = new Button();
            panelSed = new Panel();
            labelSedCounter = new Label();
            labelAttendanceSed = new Label();
            labelSED = new Label();
            button11 = new Button();
            label11 = new Label();
            panel1.SuspendLayout();
            panelAsp.SuspendLayout();
            panelIbed.SuspendLayout();
            panelSed.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panelAsp);
            panel1.Controls.Add(panelIbed);
            panel1.Controls.Add(panelSed);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 626);
            panel1.TabIndex = 33;
            // 
            // panelAsp
            // 
            panelAsp.BackColor = Color.FromArgb(164, 16, 48);
            panelAsp.Controls.Add(labelAspCounter);
            panelAsp.Controls.Add(labelAttendanceAsp);
            panelAsp.Controls.Add(labelASP);
            panelAsp.Controls.Add(button7);
            panelAsp.Location = new Point(740, 164);
            panelAsp.Name = "panelAsp";
            panelAsp.Size = new Size(320, 208);
            panelAsp.TabIndex = 47;
            // 
            // labelAspCounter
            // 
            labelAspCounter.AutoSize = true;
            labelAspCounter.BackColor = Color.FromArgb(2, 35, 68);
            labelAspCounter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelAspCounter.ForeColor = Color.White;
            labelAspCounter.Location = new Point(228, 120);
            labelAspCounter.Name = "labelAspCounter";
            labelAspCounter.Size = new Size(38, 45);
            labelAspCounter.TabIndex = 46;
            labelAspCounter.Text = "1";
            // 
            // labelAttendanceAsp
            // 
            labelAttendanceAsp.AutoSize = true;
            labelAttendanceAsp.BackColor = Color.FromArgb(2, 35, 68);
            labelAttendanceAsp.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAttendanceAsp.ForeColor = Color.White;
            labelAttendanceAsp.Location = new Point(20, 140);
            labelAttendanceAsp.Name = "labelAttendanceAsp";
            labelAttendanceAsp.Size = new Size(202, 20);
            labelAttendanceAsp.TabIndex = 45;
            labelAttendanceAsp.Text = "Total Attendance for today:";
            // 
            // labelASP
            // 
            labelASP.AutoSize = true;
            labelASP.BackColor = Color.FromArgb(2, 35, 68);
            labelASP.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelASP.ForeColor = Color.White;
            labelASP.Location = new Point(20, 61);
            labelASP.Name = "labelASP";
            labelASP.Size = new Size(68, 37);
            labelASP.TabIndex = 44;
            labelASP.Text = "ASP";
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(2, 35, 68);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(0, 46);
            button7.Name = "button7";
            button7.Size = new Size(320, 164);
            button7.TabIndex = 43;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panelIbed
            // 
            panelIbed.BackColor = Color.FromArgb(164, 16, 48);
            panelIbed.Controls.Add(labelIbedCounter);
            panelIbed.Controls.Add(labelAttendanceIbed);
            panelIbed.Controls.Add(labelIBED);
            panelIbed.Controls.Add(button8);
            panelIbed.Location = new Point(405, 164);
            panelIbed.Name = "panelIbed";
            panelIbed.Size = new Size(320, 208);
            panelIbed.TabIndex = 46;
            // 
            // labelIbedCounter
            // 
            labelIbedCounter.AutoSize = true;
            labelIbedCounter.BackColor = Color.FromArgb(99, 27, 75);
            labelIbedCounter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelIbedCounter.ForeColor = Color.White;
            labelIbedCounter.Location = new Point(228, 120);
            labelIbedCounter.Name = "labelIbedCounter";
            labelIbedCounter.Size = new Size(38, 45);
            labelIbedCounter.TabIndex = 44;
            labelIbedCounter.Text = "1";
            // 
            // labelAttendanceIbed
            // 
            labelAttendanceIbed.AutoSize = true;
            labelAttendanceIbed.BackColor = Color.FromArgb(99, 27, 75);
            labelAttendanceIbed.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAttendanceIbed.ForeColor = Color.White;
            labelAttendanceIbed.Location = new Point(20, 140);
            labelAttendanceIbed.Name = "labelAttendanceIbed";
            labelAttendanceIbed.Size = new Size(202, 20);
            labelAttendanceIbed.TabIndex = 43;
            labelAttendanceIbed.Text = "Total Attendance for today:";
            // 
            // labelIBED
            // 
            labelIBED.AutoSize = true;
            labelIBED.BackColor = Color.FromArgb(99, 27, 75);
            labelIBED.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelIBED.ForeColor = Color.White;
            labelIBED.Location = new Point(20, 61);
            labelIBED.Name = "labelIBED";
            labelIBED.Size = new Size(77, 37);
            labelIBED.TabIndex = 42;
            labelIBED.Text = "IBED";
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(99, 27, 75);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(0, 44);
            button8.Name = "button8";
            button8.Size = new Size(320, 164);
            button8.TabIndex = 41;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // panelSed
            // 
            panelSed.BackColor = Color.FromArgb(164, 16, 48);
            panelSed.Controls.Add(labelSedCounter);
            panelSed.Controls.Add(labelAttendanceSed);
            panelSed.Controls.Add(labelSED);
            panelSed.Controls.Add(button11);
            panelSed.Location = new Point(70, 164);
            panelSed.Name = "panelSed";
            panelSed.Size = new Size(320, 208);
            panelSed.TabIndex = 45;
            // 
            // labelSedCounter
            // 
            labelSedCounter.AutoSize = true;
            labelSedCounter.BackColor = Color.FromArgb(255, 121, 0);
            labelSedCounter.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            labelSedCounter.ForeColor = Color.White;
            labelSedCounter.Location = new Point(228, 120);
            labelSedCounter.Name = "labelSedCounter";
            labelSedCounter.Size = new Size(38, 45);
            labelSedCounter.TabIndex = 38;
            labelSedCounter.Text = "1";
            // 
            // labelAttendanceSed
            // 
            labelAttendanceSed.AutoSize = true;
            labelAttendanceSed.BackColor = Color.FromArgb(255, 121, 0);
            labelAttendanceSed.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAttendanceSed.ForeColor = Color.White;
            labelAttendanceSed.Location = new Point(20, 140);
            labelAttendanceSed.Name = "labelAttendanceSed";
            labelAttendanceSed.Size = new Size(202, 20);
            labelAttendanceSed.TabIndex = 37;
            labelAttendanceSed.Text = "Total Attendance for today:";
            // 
            // labelSED
            // 
            labelSED.AutoSize = true;
            labelSED.BackColor = Color.FromArgb(255, 121, 0);
            labelSED.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelSED.ForeColor = Color.White;
            labelSED.Location = new Point(20, 61);
            labelSED.Name = "labelSED";
            labelSED.Size = new Size(66, 37);
            labelSED.TabIndex = 36;
            labelSED.Text = "SED";
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(255, 121, 0);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(0, 44);
            button11.Name = "button11";
            button11.Size = new Size(320, 164);
            button11.TabIndex = 35;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(48, 32);
            label11.Name = "label11";
            label11.Size = new Size(219, 31);
            label11.TabIndex = 33;
            label11.Text = "DEPARTMENTS";
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1120, 626);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDepartment";
            Load += FormDepartment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelAsp.ResumeLayout(false);
            panelAsp.PerformLayout();
            panelIbed.ResumeLayout(false);
            panelIbed.PerformLayout();
            panelSed.ResumeLayout(false);
            panelSed.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelASP;
        private Button button7;
        private Label labelIBED;
        private Button button8;
        private Label labelSedCounter;
        private Label labelAttendanceSed;
        private Label labelSED;
        private Button button11;
        private Label label11;
        private Panel panelIbed;
        private Label labelAttendanceIbed;
        private Panel panelSed;
        private Panel panelAsp;
        private Label labelAspCounter;
        private Label labelAttendanceAsp;
        private Label labelIbedCounter;
    }
}