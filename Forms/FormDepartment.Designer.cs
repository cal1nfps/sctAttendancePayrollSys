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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIbed = new System.Windows.Forms.Panel();
            this.labelAttendanceIbed = new System.Windows.Forms.Label();
            this.labelIBED = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.panelSed = new System.Windows.Forms.Panel();
            this.labelSedCounter = new System.Windows.Forms.Label();
            this.labelAttendanceSed = new System.Windows.Forms.Label();
            this.labelSED = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelASP = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.panelAsp = new System.Windows.Forms.Panel();
            this.labelAttendanceAsp = new System.Windows.Forms.Label();
            this.labelIbedCounter = new System.Windows.Forms.Label();
            this.labelAspCounter = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelIbed.SuspendLayout();
            this.panelSed.SuspendLayout();
            this.panelAsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelAsp);
            this.panel1.Controls.Add(this.panelIbed);
            this.panel1.Controls.Add(this.panelSed);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 626);
            this.panel1.TabIndex = 33;
            // 
            // panelIbed
            // 
            this.panelIbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelIbed.Controls.Add(this.labelIbedCounter);
            this.panelIbed.Controls.Add(this.labelAttendanceIbed);
            this.panelIbed.Controls.Add(this.labelIBED);
            this.panelIbed.Controls.Add(this.button8);
            this.panelIbed.Location = new System.Drawing.Point(405, 164);
            this.panelIbed.Name = "panelIbed";
            this.panelIbed.Size = new System.Drawing.Size(320, 208);
            this.panelIbed.TabIndex = 46;
            // 
            // labelAttendanceIbed
            // 
            this.labelAttendanceIbed.AutoSize = true;
            this.labelAttendanceIbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.labelAttendanceIbed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttendanceIbed.ForeColor = System.Drawing.Color.White;
            this.labelAttendanceIbed.Location = new System.Drawing.Point(20, 140);
            this.labelAttendanceIbed.Name = "labelAttendanceIbed";
            this.labelAttendanceIbed.Size = new System.Drawing.Size(202, 20);
            this.labelAttendanceIbed.TabIndex = 43;
            this.labelAttendanceIbed.Text = "Total Attendance for today:";
            // 
            // labelIBED
            // 
            this.labelIBED.AutoSize = true;
            this.labelIBED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.labelIBED.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIBED.ForeColor = System.Drawing.Color.White;
            this.labelIBED.Location = new System.Drawing.Point(20, 61);
            this.labelIBED.Name = "labelIBED";
            this.labelIBED.Size = new System.Drawing.Size(77, 37);
            this.labelIBED.TabIndex = 42;
            this.labelIBED.Text = "IBED";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(320, 164);
            this.button8.TabIndex = 41;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // panelSed
            // 
            this.panelSed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelSed.Controls.Add(this.labelSedCounter);
            this.panelSed.Controls.Add(this.labelAttendanceSed);
            this.panelSed.Controls.Add(this.labelSED);
            this.panelSed.Controls.Add(this.button11);
            this.panelSed.Location = new System.Drawing.Point(70, 164);
            this.panelSed.Name = "panelSed";
            this.panelSed.Size = new System.Drawing.Size(320, 208);
            this.panelSed.TabIndex = 45;
            // 
            // labelSedCounter
            // 
            this.labelSedCounter.AutoSize = true;
            this.labelSedCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.labelSedCounter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSedCounter.ForeColor = System.Drawing.Color.White;
            this.labelSedCounter.Location = new System.Drawing.Point(228, 120);
            this.labelSedCounter.Name = "labelSedCounter";
            this.labelSedCounter.Size = new System.Drawing.Size(38, 45);
            this.labelSedCounter.TabIndex = 38;
            this.labelSedCounter.Text = "1";
            // 
            // labelAttendanceSed
            // 
            this.labelAttendanceSed.AutoSize = true;
            this.labelAttendanceSed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.labelAttendanceSed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttendanceSed.ForeColor = System.Drawing.Color.White;
            this.labelAttendanceSed.Location = new System.Drawing.Point(20, 140);
            this.labelAttendanceSed.Name = "labelAttendanceSed";
            this.labelAttendanceSed.Size = new System.Drawing.Size(202, 20);
            this.labelAttendanceSed.TabIndex = 37;
            this.labelAttendanceSed.Text = "Total Attendance for today:";
            // 
            // labelSED
            // 
            this.labelSED.AutoSize = true;
            this.labelSED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.labelSED.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSED.ForeColor = System.Drawing.Color.White;
            this.labelSED.Location = new System.Drawing.Point(20, 61);
            this.labelSED.Name = "labelSED";
            this.labelSED.Size = new System.Drawing.Size(66, 37);
            this.labelSED.TabIndex = 36;
            this.labelSED.Text = "SED";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(320, 164);
            this.button11.TabIndex = 35;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(48, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 31);
            this.label11.TabIndex = 33;
            this.label11.Text = "DEPARTMENTS";
            // 
            // labelASP
            // 
            this.labelASP.AutoSize = true;
            this.labelASP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.labelASP.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelASP.ForeColor = System.Drawing.Color.White;
            this.labelASP.Location = new System.Drawing.Point(20, 61);
            this.labelASP.Name = "labelASP";
            this.labelASP.Size = new System.Drawing.Size(68, 37);
            this.labelASP.TabIndex = 44;
            this.labelASP.Text = "ASP";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(0, 46);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(320, 164);
            this.button7.TabIndex = 43;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panelAsp
            // 
            this.panelAsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelAsp.Controls.Add(this.labelAspCounter);
            this.panelAsp.Controls.Add(this.labelAttendanceAsp);
            this.panelAsp.Controls.Add(this.labelASP);
            this.panelAsp.Controls.Add(this.button7);
            this.panelAsp.Location = new System.Drawing.Point(740, 164);
            this.panelAsp.Name = "panelAsp";
            this.panelAsp.Size = new System.Drawing.Size(320, 208);
            this.panelAsp.TabIndex = 47;
            // 
            // labelAttendanceAsp
            // 
            this.labelAttendanceAsp.AutoSize = true;
            this.labelAttendanceAsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.labelAttendanceAsp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAttendanceAsp.ForeColor = System.Drawing.Color.White;
            this.labelAttendanceAsp.Location = new System.Drawing.Point(20, 140);
            this.labelAttendanceAsp.Name = "labelAttendanceAsp";
            this.labelAttendanceAsp.Size = new System.Drawing.Size(202, 20);
            this.labelAttendanceAsp.TabIndex = 45;
            this.labelAttendanceAsp.Text = "Total Attendance for today:";
            // 
            // labelIbedCounter
            // 
            this.labelIbedCounter.AutoSize = true;
            this.labelIbedCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.labelIbedCounter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIbedCounter.ForeColor = System.Drawing.Color.White;
            this.labelIbedCounter.Location = new System.Drawing.Point(228, 120);
            this.labelIbedCounter.Name = "labelIbedCounter";
            this.labelIbedCounter.Size = new System.Drawing.Size(38, 45);
            this.labelIbedCounter.TabIndex = 44;
            this.labelIbedCounter.Text = "1";
            // 
            // labelAspCounter
            // 
            this.labelAspCounter.AutoSize = true;
            this.labelAspCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.labelAspCounter.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAspCounter.ForeColor = System.Drawing.Color.White;
            this.labelAspCounter.Location = new System.Drawing.Point(228, 120);
            this.labelAspCounter.Name = "labelAspCounter";
            this.labelAspCounter.Size = new System.Drawing.Size(38, 45);
            this.labelAspCounter.TabIndex = 46;
            this.labelAspCounter.Text = "1";
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1120, 626);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelIbed.ResumeLayout(false);
            this.panelIbed.PerformLayout();
            this.panelSed.ResumeLayout(false);
            this.panelSed.PerformLayout();
            this.panelAsp.ResumeLayout(false);
            this.panelAsp.PerformLayout();
            this.ResumeLayout(false);

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