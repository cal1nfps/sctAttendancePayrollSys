namespace SCTAttendanceSystemUI.Employee
{
    partial class FormEmployeeDashboard
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
            this.components = new System.ComponentModel.Container();
            this.labelLoginAs = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonTimeIn = new System.Windows.Forms.Button();
            this.buttonTimeOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLoginAs
            // 
            this.labelLoginAs.AutoSize = true;
            this.labelLoginAs.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLoginAs.ForeColor = System.Drawing.Color.White;
            this.labelLoginAs.Location = new System.Drawing.Point(161, 27);
            this.labelLoginAs.Name = "labelLoginAs";
            this.labelLoginAs.Size = new System.Drawing.Size(258, 31);
            this.labelLoginAs.TabIndex = 6;
            this.labelLoginAs.Text = "You are logged in as:";
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Location = new System.Drawing.Point(219, 18);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(0, 15);
            this.labelEmployeeName.TabIndex = 7;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(136, 45);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(68, 23);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "DATE:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.Black;
            this.labelTime.Location = new System.Drawing.Point(136, 92);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(65, 23);
            this.labelTime.TabIndex = 10;
            this.labelTime.Text = "TIME:";
            // 
            // buttonTimeIn
            // 
            this.buttonTimeIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeIn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTimeIn.Location = new System.Drawing.Point(105, 153);
            this.buttonTimeIn.Name = "buttonTimeIn";
            this.buttonTimeIn.Size = new System.Drawing.Size(147, 64);
            this.buttonTimeIn.TabIndex = 11;
            this.buttonTimeIn.Text = "TIME IN";
            this.buttonTimeIn.UseVisualStyleBackColor = false;
            this.buttonTimeIn.Click += new System.EventHandler(this.buttonTimeIn_Click);
            // 
            // buttonTimeOut
            // 
            this.buttonTimeOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonTimeOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimeOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTimeOut.Location = new System.Drawing.Point(277, 153);
            this.buttonTimeOut.Name = "buttonTimeOut";
            this.buttonTimeOut.Size = new System.Drawing.Size(147, 64);
            this.buttonTimeOut.TabIndex = 12;
            this.buttonTimeOut.Text = "TIME OUT";
            this.buttonTimeOut.UseVisualStyleBackColor = false;
            this.buttonTimeOut.Click += new System.EventHandler(this.buttonTimeOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonTimeOut);
            this.panel1.Controls.Add(this.buttonTimeIn);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelEmployeeName);
            this.panel1.Location = new System.Drawing.Point(116, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 303);
            this.panel1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(425, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "**Employee Name**";
            // 
            // FormEmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLoginAs);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmployeeDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EMPLOYEE DASHBOARD";
            this.Load += new System.EventHandler(this.FormEmployeeDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLoginAs;
        private Label labelEmployeeName;
        private Label labelDate;
        private Label labelTime;
        private Button buttonTimeIn;
        private Button buttonTimeOut;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button1;
    }
}