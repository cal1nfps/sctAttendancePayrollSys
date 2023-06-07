﻿namespace SCTAttendanceSystemUI.Forms
{
    partial class FormAbsentees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbsentees));
            this.labelAbsenteesForToday = new System.Windows.Forms.Label();
            this.labelAbsenteesDate = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelAbsenteesForToday = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelOvertimeHours = new System.Windows.Forms.Label();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelTotalHours = new System.Windows.Forms.Label();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelJobStatus = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmpNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelAbsenteesForToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAbsenteesForToday
            // 
            this.labelAbsenteesForToday.AutoSize = true;
            this.labelAbsenteesForToday.BackColor = System.Drawing.Color.Transparent;
            this.labelAbsenteesForToday.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbsenteesForToday.Location = new System.Drawing.Point(38, 32);
            this.labelAbsenteesForToday.Name = "labelAbsenteesForToday";
            this.labelAbsenteesForToday.Size = new System.Drawing.Size(341, 31);
            this.labelAbsenteesForToday.TabIndex = 6;
            this.labelAbsenteesForToday.Text = "ABSENTEES FOR TODAY";
            // 
            // labelAbsenteesDate
            // 
            this.labelAbsenteesDate.AutoSize = true;
            this.labelAbsenteesDate.BackColor = System.Drawing.Color.Transparent;
            this.labelAbsenteesDate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbsenteesDate.Location = new System.Drawing.Point(385, 32);
            this.labelAbsenteesDate.Name = "labelAbsenteesDate";
            this.labelAbsenteesDate.Size = new System.Drawing.Size(84, 25);
            this.labelAbsenteesDate.TabIndex = 16;
            this.labelAbsenteesDate.Text = "DATE: ";
            this.labelAbsenteesDate.Click += new System.EventHandler(this.labelAbsenteesDate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(951, 392);
            this.dataGridView2.TabIndex = 33;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(687, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 72;
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
            this.button1.Location = new System.Drawing.Point(889, 55);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(47, 30);
            this.button1.TabIndex = 73;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
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
            this.button4.Location = new System.Drawing.Point(942, 55);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(47, 30);
            this.button4.TabIndex = 74;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panelAbsenteesForToday
            // 
            this.panelAbsenteesForToday.BackColor = System.Drawing.Color.White;
            this.panelAbsenteesForToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAbsenteesForToday.Controls.Add(this.label2);
            this.panelAbsenteesForToday.Controls.Add(this.label1);
            this.panelAbsenteesForToday.Controls.Add(this.labelStatus);
            this.panelAbsenteesForToday.Controls.Add(this.labelOvertimeHours);
            this.panelAbsenteesForToday.Controls.Add(this.labelTimeOut);
            this.panelAbsenteesForToday.Controls.Add(this.labelOccupation);
            this.panelAbsenteesForToday.Controls.Add(this.labelTotalHours);
            this.panelAbsenteesForToday.Controls.Add(this.labelTimeIn);
            this.panelAbsenteesForToday.Controls.Add(this.labelDate);
            this.panelAbsenteesForToday.Controls.Add(this.labelJobStatus);
            this.panelAbsenteesForToday.Controls.Add(this.labelDep);
            this.panelAbsenteesForToday.Controls.Add(this.labelName);
            this.panelAbsenteesForToday.Controls.Add(this.labelEmpNum);
            this.panelAbsenteesForToday.Location = new System.Drawing.Point(38, 91);
            this.panelAbsenteesForToday.Name = "panelAbsenteesForToday";
            this.panelAbsenteesForToday.Size = new System.Drawing.Size(951, 30);
            this.panelAbsenteesForToday.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(859, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 14);
            this.label2.TabIndex = 71;
            this.label2.Text = "Late Hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(780, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 14);
            this.label1.TabIndex = 71;
            this.label1.Text = "Undertime";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelStatus.Location = new System.Drawing.Point(721, 7);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 14);
            this.labelStatus.TabIndex = 70;
            this.labelStatus.Text = "Status";
            // 
            // labelOvertimeHours
            // 
            this.labelOvertimeHours.AutoSize = true;
            this.labelOvertimeHours.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOvertimeHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOvertimeHours.Location = new System.Drawing.Point(646, 7);
            this.labelOvertimeHours.Name = "labelOvertimeHours";
            this.labelOvertimeHours.Size = new System.Drawing.Size(57, 14);
            this.labelOvertimeHours.TabIndex = 69;
            this.labelOvertimeHours.Text = "OT Hours";
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTimeOut.Location = new System.Drawing.Point(488, 7);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(57, 14);
            this.labelTimeOut.TabIndex = 68;
            this.labelTimeOut.Text = "Time-Out";
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOccupation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOccupation.Location = new System.Drawing.Point(204, 7);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(68, 14);
            this.labelOccupation.TabIndex = 67;
            this.labelOccupation.Text = "Occupation";
            // 
            // labelTotalHours
            // 
            this.labelTotalHours.AutoSize = true;
            this.labelTotalHours.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalHours.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTotalHours.Location = new System.Drawing.Point(560, 7);
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
            this.labelTimeIn.Location = new System.Drawing.Point(425, 7);
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
            this.labelDate.Location = new System.Drawing.Point(375, 7);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(31, 14);
            this.labelDate.TabIndex = 64;
            this.labelDate.Text = "Date";
            // 
            // labelJobStatus
            // 
            this.labelJobStatus.AutoSize = true;
            this.labelJobStatus.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelJobStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelJobStatus.Location = new System.Drawing.Point(290, 7);
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
            this.labelDep.Location = new System.Drawing.Point(112, 7);
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
            this.labelName.Location = new System.Drawing.Point(42, 7);
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
            this.labelEmpNum.Location = new System.Drawing.Point(13, 7);
            this.labelEmpNum.Name = "labelEmpNum";
            this.labelEmpNum.Size = new System.Drawing.Size(14, 14);
            this.labelEmpNum.TabIndex = 58;
            this.labelEmpNum.Text = "#";
            // 
            // FormAbsentees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelAbsenteesForToday);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelAbsenteesDate);
            this.Controls.Add(this.labelAbsenteesForToday);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormAbsentees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbsentees";
            this.Load += new System.EventHandler(this.FormAbsentees_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelAbsenteesForToday.ResumeLayout(false);
            this.panelAbsenteesForToday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAbsenteesForToday;
        private Label labelAbsenteesDate;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Button button1;
        private Button button4;
        private Panel panelAbsenteesForToday;
        private Label label2;
        private Label label1;
        private Label labelStatus;
        private Label labelOvertimeHours;
        private Label labelTimeOut;
        private Label labelOccupation;
        private Label labelTotalHours;
        private Label labelTimeIn;
        private Label labelDate;
        private Label labelJobStatus;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
    }
}