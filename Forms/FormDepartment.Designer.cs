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
            this.panelAsp = new System.Windows.Forms.Panel();
            this.labelAspCounter = new System.Windows.Forms.Label();
            this.labelAttendanceAsp = new System.Windows.Forms.Label();
            this.labelASP = new System.Windows.Forms.Label();
            this.buttonAsp = new System.Windows.Forms.Button();
            this.panelIbed = new System.Windows.Forms.Panel();
            this.labelIbedCounter = new System.Windows.Forms.Label();
            this.labelAttendanceIbed = new System.Windows.Forms.Label();
            this.labelIBED = new System.Windows.Forms.Label();
            this.buttonIbed = new System.Windows.Forms.Button();
            this.panelSed = new System.Windows.Forms.Panel();
            this.labelSedCounter = new System.Windows.Forms.Label();
            this.labelAttendanceSed = new System.Windows.Forms.Label();
            this.labelSED = new System.Windows.Forms.Label();
            this.buttonSed = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelAsp.SuspendLayout();
            this.panelIbed.SuspendLayout();
            this.panelSed.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 33;
            // 
            // panelAsp
            // 
            this.panelAsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelAsp.Controls.Add(this.labelAspCounter);
            this.panelAsp.Controls.Add(this.labelAttendanceAsp);
            this.panelAsp.Controls.Add(this.labelASP);
            this.panelAsp.Controls.Add(this.buttonAsp);
            this.panelAsp.Location = new System.Drawing.Point(697, 163);
            this.panelAsp.Name = "panelAsp";
            this.panelAsp.Size = new System.Drawing.Size(307, 208);
            this.panelAsp.TabIndex = 47;
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
            // buttonAsp
            // 
            this.buttonAsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(35)))), ((int)(((byte)(68)))));
            this.buttonAsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAsp.Location = new System.Drawing.Point(0, 46);
            this.buttonAsp.Name = "buttonAsp";
            this.buttonAsp.Size = new System.Drawing.Size(307, 162);
            this.buttonAsp.TabIndex = 43;
            this.buttonAsp.UseVisualStyleBackColor = false;
            this.buttonAsp.Click += new System.EventHandler(this.buttonAsp_Click);
            // 
            // panelIbed
            // 
            this.panelIbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelIbed.Controls.Add(this.labelIbedCounter);
            this.panelIbed.Controls.Add(this.labelAttendanceIbed);
            this.panelIbed.Controls.Add(this.labelIBED);
            this.panelIbed.Controls.Add(this.buttonIbed);
            this.panelIbed.Location = new System.Drawing.Point(373, 163);
            this.panelIbed.Name = "panelIbed";
            this.panelIbed.Size = new System.Drawing.Size(307, 208);
            this.panelIbed.TabIndex = 46;
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
            // buttonIbed
            // 
            this.buttonIbed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(27)))), ((int)(((byte)(75)))));
            this.buttonIbed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIbed.Location = new System.Drawing.Point(0, 44);
            this.buttonIbed.Name = "buttonIbed";
            this.buttonIbed.Size = new System.Drawing.Size(307, 164);
            this.buttonIbed.TabIndex = 41;
            this.buttonIbed.UseVisualStyleBackColor = false;
            this.buttonIbed.Click += new System.EventHandler(this.buttonIbed_Click);
            // 
            // panelSed
            // 
            this.panelSed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.panelSed.Controls.Add(this.labelSedCounter);
            this.panelSed.Controls.Add(this.labelAttendanceSed);
            this.panelSed.Controls.Add(this.labelSED);
            this.panelSed.Controls.Add(this.buttonSed);
            this.panelSed.Location = new System.Drawing.Point(48, 163);
            this.panelSed.Name = "panelSed";
            this.panelSed.Size = new System.Drawing.Size(307, 208);
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
            // buttonSed
            // 
            this.buttonSed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(0)))));
            this.buttonSed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSed.Location = new System.Drawing.Point(0, 44);
            this.buttonSed.Name = "buttonSed";
            this.buttonSed.Size = new System.Drawing.Size(307, 164);
            this.buttonSed.TabIndex = 35;
            this.buttonSed.UseVisualStyleBackColor = false;
            this.buttonSed.Click += new System.EventHandler(this.buttonSed_Click);
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
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDepartment";
            this.Load += new System.EventHandler(this.FormDepartment_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelAsp.ResumeLayout(false);
            this.panelAsp.PerformLayout();
            this.panelIbed.ResumeLayout(false);
            this.panelIbed.PerformLayout();
            this.panelSed.ResumeLayout(false);
            this.panelSed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label labelASP;
        private Button buttonAsp;
        private Label labelIBED;
        private Button buttonIbed;
        private Label labelSedCounter;
        private Label labelAttendanceSed;
        private Label labelSED;
        private Button buttonSed;
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