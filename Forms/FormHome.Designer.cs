namespace SCTAttendanceSystemUI.Forms
{
    partial class FormHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.labelDashboard = new System.Windows.Forms.Label();
            this.labelDashboardDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelAttendanceForToday = new System.Windows.Forms.Panel();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelJobHours = new System.Windows.Forms.Label();
            this.labelJobStatus = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmpNum = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.labelOvertimeHours = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelAttendanceForToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboard.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDashboard.Location = new System.Drawing.Point(38, 32);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(370, 31);
            this.labelDashboard.TabIndex = 3;
            this.labelDashboard.Text = "ATTENDANCE FOR TODAY";
            // 
            // labelDashboardDate
            // 
            this.labelDashboardDate.AutoSize = true;
            this.labelDashboardDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDashboardDate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDashboardDate.Location = new System.Drawing.Point(414, 34);
            this.labelDashboardDate.Name = "labelDashboardDate";
            this.labelDashboardDate.Size = new System.Drawing.Size(84, 25);
            this.labelDashboardDate.TabIndex = 17;
            this.labelDashboardDate.Text = "DATE: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(103, 130);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 514);
            this.dataGridView1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1233, 53);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(47, 30);
            this.button4.TabIndex = 65;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(978, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 66;
            this.textBox1.Text = "Search Employee Number or Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1180, 53);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(47, 30);
            this.button1.TabIndex = 69;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelAttendanceForToday
            // 
            this.panelAttendanceForToday.BackColor = System.Drawing.Color.White;
            this.panelAttendanceForToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAttendanceForToday.Controls.Add(this.labelStatus);
            this.panelAttendanceForToday.Controls.Add(this.labelOvertimeHours);
            this.panelAttendanceForToday.Controls.Add(this.labelTimeOut);
            this.panelAttendanceForToday.Controls.Add(this.labelOccupation);
            this.panelAttendanceForToday.Controls.Add(this.labelTotalHours);
            this.panelAttendanceForToday.Controls.Add(this.labelTimeIn);
            this.panelAttendanceForToday.Controls.Add(this.labelDate);
            this.panelAttendanceForToday.Controls.Add(this.labelJobHours);
            this.panelAttendanceForToday.Controls.Add(this.labelJobStatus);
            this.panelAttendanceForToday.Controls.Add(this.labelDep);
            this.panelAttendanceForToday.Controls.Add(this.labelName);
            this.panelAttendanceForToday.Controls.Add(this.labelEmpNum);
            this.panelAttendanceForToday.Location = new System.Drawing.Point(103, 94);
            this.panelAttendanceForToday.Name = "panelAttendanceForToday";
            this.panelAttendanceForToday.Size = new System.Drawing.Size(1177, 30);
            this.panelAttendanceForToday.TabIndex = 70;
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.AutoSize = true;
            this.labelTotalHours.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTotalHours.Location = new System.Drawing.Point(855, 7);
            this.labelTotalHours.Name = "labelTotalHours";
            this.labelTotalHours.Size = new System.Drawing.Size(68, 14);
            this.labelTotalHours.TabIndex = 66;
            this.labelTotalHours.Text = "Total Hours";
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTimeIn.Location = new System.Drawing.Point(662, 7);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(48, 14);
            this.labelTimeIn.TabIndex = 65;
            this.labelTimeIn.Text = "Time-In";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDate.Location = new System.Drawing.Point(594, 7);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 14);
            this.labelDate.TabIndex = 64;
            this.labelDate.Text = "Date";
            // 
            // labelJobHours
            // 
            this.labelJobHours.AutoSize = true;
            this.labelJobHours.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJobHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJobHours.Location = new System.Drawing.Point(492, 7);
            this.labelJobHours.Name = "labelJobHours";
            this.labelJobHours.Size = new System.Drawing.Size(63, 14);
            this.labelJobHours.TabIndex = 63;
            this.labelJobHours.Text = "Job Hours";
            // 
            // labelJobStatus
            // 
            this.labelJobStatus.AutoSize = true;
            this.labelJobStatus.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJobStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJobStatus.Location = new System.Drawing.Point(393, 7);
            this.labelJobStatus.Name = "labelJobStatus";
            this.labelJobStatus.Size = new System.Drawing.Size(64, 14);
            this.labelJobStatus.TabIndex = 62;
            this.labelJobStatus.Text = "Job Status";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDep.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDep.Location = new System.Drawing.Point(171, 7);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(70, 14);
            this.labelDep.TabIndex = 61;
            this.labelDep.Text = "Department";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelName.Location = new System.Drawing.Point(59, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 14);
            this.labelName.TabIndex = 60;
            this.labelName.Text = "Name";
            // 
            // labelEmpNum
            // 
            this.labelEmpNum.AutoSize = true;
            this.labelEmpNum.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEmpNum.Location = new System.Drawing.Point(15, 7);
            this.labelEmpNum.Name = "labelEmpNum";
            this.labelEmpNum.Size = new System.Drawing.Size(14, 14);
            this.labelEmpNum.TabIndex = 58;
            this.labelEmpNum.Text = "#";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOccupation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOccupation.Location = new System.Drawing.Point(274, 7);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(68, 14);
            this.labelOccupation.TabIndex = 67;
            this.labelOccupation.Text = "Occupation";
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTimeOut.Location = new System.Drawing.Point(755, 7);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(57, 14);
            this.labelTimeOut.TabIndex = 68;
            this.labelTimeOut.Text = "Time-Out";
            // 
            // labelOvertimeHours
            // 
            this.labelOvertimeHours.AutoSize = true;
            this.labelOvertimeHours.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOvertimeHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOvertimeHours.Location = new System.Drawing.Point(963, 7);
            this.labelOvertimeHours.Name = "labelOvertimeHours";
            this.labelOvertimeHours.Size = new System.Drawing.Size(91, 14);
            this.labelOvertimeHours.TabIndex = 69;
            this.labelOvertimeHours.Text = "Overtime Hours";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatus.Location = new System.Drawing.Point(1097, 7);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 14);
            this.labelStatus.TabIndex = 70;
            this.labelStatus.Text = "Status";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1666, 822);
            this.Controls.Add(this.panelAttendanceForToday);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDashboardDate);
            this.Controls.Add(this.labelDashboard);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1680, 821);
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelAttendanceForToday.ResumeLayout(false);
            this.panelAttendanceForToday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDashboard;
        private Label labelDashboardDate;
        public DataGridView dataGridView1;
        private Button button4;
        private TextBox textBox1;
        private Button button1;
        private Panel panelAttendanceForToday;
        private Label labelStatus;
        private Label labelOvertimeHours;
        private Label labelTimeOut;
        private Label labelOccupation;
        private Label labelTotalHours;
        private Label labelTimeIn;
        private Label labelDate;
        private Label labelJobHours;
        private Label labelJobStatus;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
    }
}