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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartment));
            label11 = new Label();
            panelSed = new Panel();
            labelSedCounter = new Label();
            labelAttendanceSed = new Label();
            labelSED = new Label();
            buttonSed = new Button();
            panelIbed = new Panel();
            labelIbedCounter = new Label();
            labelAttendanceIbed = new Label();
            labelIBED = new Label();
            buttonIbed = new Button();
            panelAsp = new Panel();
            labelAspCounter = new Label();
            labelAttendanceAsp = new Label();
            labelASP = new Label();
            buttonAsp = new Button();
            panel1 = new Panel();
            panelSed.SuspendLayout();
            panelIbed.SuspendLayout();
            panelAsp.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panelSed
            // 
            panelSed.BackColor = Color.FromArgb(164, 16, 48);
            panelSed.Controls.Add(labelSedCounter);
            panelSed.Controls.Add(labelAttendanceSed);
            panelSed.Controls.Add(labelSED);
            panelSed.Controls.Add(buttonSed);
            panelSed.Location = new Point(358, 302);
            panelSed.Name = "panelSed";
            panelSed.Size = new Size(307, 208);
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
            // buttonSed
            // 
            buttonSed.BackColor = Color.FromArgb(255, 121, 0);
            buttonSed.FlatStyle = FlatStyle.Flat;
            buttonSed.Location = new Point(0, 44);
            buttonSed.Name = "buttonSed";
            buttonSed.Size = new Size(307, 164);
            buttonSed.TabIndex = 35;
            buttonSed.UseVisualStyleBackColor = false;
            buttonSed.Click += buttonSed_Click;
            // 
            // panelIbed
            // 
            panelIbed.BackColor = Color.FromArgb(164, 16, 48);
            panelIbed.Controls.Add(labelIbedCounter);
            panelIbed.Controls.Add(labelAttendanceIbed);
            panelIbed.Controls.Add(labelIBED);
            panelIbed.Controls.Add(buttonIbed);
            panelIbed.Location = new Point(683, 302);
            panelIbed.Name = "panelIbed";
            panelIbed.Size = new Size(307, 208);
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
            // buttonIbed
            // 
            buttonIbed.BackColor = Color.FromArgb(99, 27, 75);
            buttonIbed.FlatStyle = FlatStyle.Flat;
            buttonIbed.Location = new Point(0, 44);
            buttonIbed.Name = "buttonIbed";
            buttonIbed.Size = new Size(307, 164);
            buttonIbed.TabIndex = 41;
            buttonIbed.UseVisualStyleBackColor = false;
            buttonIbed.Click += buttonIbed_Click;
            // 
            // panelAsp
            // 
            panelAsp.BackColor = Color.FromArgb(164, 16, 48);
            panelAsp.Controls.Add(labelAspCounter);
            panelAsp.Controls.Add(labelAttendanceAsp);
            panelAsp.Controls.Add(labelASP);
            panelAsp.Controls.Add(buttonAsp);
            panelAsp.Location = new Point(1007, 302);
            panelAsp.Name = "panelAsp";
            panelAsp.Size = new Size(307, 208);
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
            // buttonAsp
            // 
            buttonAsp.BackColor = Color.FromArgb(2, 35, 68);
            buttonAsp.FlatStyle = FlatStyle.Flat;
            buttonAsp.Location = new Point(0, 46);
            buttonAsp.Name = "buttonAsp";
            buttonAsp.Size = new Size(307, 162);
            buttonAsp.TabIndex = 43;
            buttonAsp.UseVisualStyleBackColor = false;
            buttonAsp.Click += buttonAsp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panelAsp);
            panel1.Controls.Add(panelIbed);
            panel1.Controls.Add(panelSed);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 1080);
            panel1.TabIndex = 39;
            // 
            // FormDepartment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(label11);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormDepartment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDepartment";
            Load += FormDepartment_Load_1;
            panelSed.ResumeLayout(false);
            panelSed.PerformLayout();
            panelIbed.ResumeLayout(false);
            panelIbed.PerformLayout();
            panelAsp.ResumeLayout(false);
            panelAsp.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private Panel panelSed;
        private Label labelSedCounter;
        private Label labelAttendanceSed;
        private Label labelSED;
        private Button buttonSed;
        private Panel panelIbed;
        private Label labelIbedCounter;
        private Label labelAttendanceIbed;
        private Label labelIBED;
        private Button buttonIbed;
        private Panel panelAsp;
        private Label labelAspCounter;
        private Label labelAttendanceAsp;
        private Label labelASP;
        private Button buttonAsp;
        private Panel panel1;
    }
}