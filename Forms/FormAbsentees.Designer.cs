namespace SCTAttendanceSystemUI.Forms
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
            labelAbsenteesForToday = new Label();
            labelAbsenteesDate = new Label();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button4 = new Button();
            panelAbsenteesForToday = new Panel();
            label2 = new Label();
            label1 = new Label();
            labelStatus = new Label();
            labelOvertimeHours = new Label();
            labelTimeOut = new Label();
            labelOccupation = new Label();
            labelTotalHours = new Label();
            labelTimeIn = new Label();
            labelDate = new Label();
            labelJobStatus = new Label();
            labelDep = new Label();
            labelName = new Label();
            labelEmpNum = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelAbsenteesForToday.SuspendLayout();
            SuspendLayout();
            // 
            // labelAbsenteesForToday
            // 
            labelAbsenteesForToday.AutoSize = true;
            labelAbsenteesForToday.BackColor = Color.Transparent;
            labelAbsenteesForToday.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesForToday.Location = new Point(38, 32);
            labelAbsenteesForToday.Name = "labelAbsenteesForToday";
            labelAbsenteesForToday.Size = new Size(341, 31);
            labelAbsenteesForToday.TabIndex = 6;
            labelAbsenteesForToday.Text = "ABSENTEES FOR TODAY";
            // 
            // labelAbsenteesDate
            // 
            labelAbsenteesDate.AutoSize = true;
            labelAbsenteesDate.BackColor = Color.Transparent;
            labelAbsenteesDate.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesDate.Location = new Point(385, 32);
            labelAbsenteesDate.Name = "labelAbsenteesDate";
            labelAbsenteesDate.Size = new Size(84, 25);
            labelAbsenteesDate.TabIndex = 16;
            labelAbsenteesDate.Text = "DATE: ";
            labelAbsenteesDate.Click += labelAbsenteesDate_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(38, 127);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(951, 392);
            dataGridView2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(687, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 72;
            textBox1.Text = "Search Employee Number or Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(889, 55);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 30);
            button1.TabIndex = 73;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(942, 55);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 74;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            // 
            // panelAbsenteesForToday
            // 
            panelAbsenteesForToday.BackColor = Color.White;
            panelAbsenteesForToday.BorderStyle = BorderStyle.FixedSingle;
            panelAbsenteesForToday.Controls.Add(label2);
            panelAbsenteesForToday.Controls.Add(label1);
            panelAbsenteesForToday.Controls.Add(labelStatus);
            panelAbsenteesForToday.Controls.Add(labelOvertimeHours);
            panelAbsenteesForToday.Controls.Add(labelTimeOut);
            panelAbsenteesForToday.Controls.Add(labelOccupation);
            panelAbsenteesForToday.Controls.Add(labelTotalHours);
            panelAbsenteesForToday.Controls.Add(labelTimeIn);
            panelAbsenteesForToday.Controls.Add(labelDate);
            panelAbsenteesForToday.Controls.Add(labelJobStatus);
            panelAbsenteesForToday.Controls.Add(labelDep);
            panelAbsenteesForToday.Controls.Add(labelName);
            panelAbsenteesForToday.Controls.Add(labelEmpNum);
            panelAbsenteesForToday.Location = new Point(38, 91);
            panelAbsenteesForToday.Name = "panelAbsenteesForToday";
            panelAbsenteesForToday.Size = new Size(951, 30);
            panelAbsenteesForToday.TabIndex = 75;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(859, 7);
            label2.Name = "label2";
            label2.Size = new Size(66, 14);
            label2.TabIndex = 71;
            label2.Text = "Late Hours";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(780, 7);
            label1.Name = "label1";
            label1.Size = new Size(62, 14);
            label1.TabIndex = 71;
            label1.Text = "Undertime";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ForeColor = SystemColors.ControlDarkDark;
            labelStatus.Location = new Point(721, 7);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(41, 14);
            labelStatus.TabIndex = 70;
            labelStatus.Text = "Status";
            // 
            // labelOvertimeHours
            // 
            labelOvertimeHours.AutoSize = true;
            labelOvertimeHours.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOvertimeHours.ForeColor = SystemColors.ControlDarkDark;
            labelOvertimeHours.Location = new Point(646, 7);
            labelOvertimeHours.Name = "labelOvertimeHours";
            labelOvertimeHours.Size = new Size(57, 14);
            labelOvertimeHours.TabIndex = 69;
            labelOvertimeHours.Text = "OT Hours";
            // 
            // labelTimeOut
            // 
            labelTimeOut.AutoSize = true;
            labelTimeOut.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeOut.ForeColor = SystemColors.ControlDarkDark;
            labelTimeOut.Location = new Point(488, 7);
            labelTimeOut.Name = "labelTimeOut";
            labelTimeOut.Size = new Size(57, 14);
            labelTimeOut.TabIndex = 68;
            labelTimeOut.Text = "Time-Out";
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOccupation.ForeColor = SystemColors.ControlDarkDark;
            labelOccupation.Location = new Point(204, 7);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(68, 14);
            labelOccupation.TabIndex = 67;
            labelOccupation.Text = "Occupation";
            // 
            // labelTotalHours
            // 
            labelTotalHours.AutoSize = true;
            labelTotalHours.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalHours.ForeColor = SystemColors.ControlDarkDark;
            labelTotalHours.Location = new Point(560, 7);
            labelTotalHours.Name = "labelTotalHours";
            labelTotalHours.Size = new Size(68, 14);
            labelTotalHours.TabIndex = 66;
            labelTotalHours.Text = "Total Hours";
            // 
            // labelTimeIn
            // 
            labelTimeIn.AutoSize = true;
            labelTimeIn.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimeIn.ForeColor = SystemColors.ControlDarkDark;
            labelTimeIn.Location = new Point(425, 7);
            labelTimeIn.Name = "labelTimeIn";
            labelTimeIn.Size = new Size(48, 14);
            labelTimeIn.TabIndex = 65;
            labelTimeIn.Text = "Time-In";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = SystemColors.ControlDarkDark;
            labelDate.Location = new Point(375, 7);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 14);
            labelDate.TabIndex = 64;
            labelDate.Text = "Date";
            // 
            // labelJobStatus
            // 
            labelJobStatus.AutoSize = true;
            labelJobStatus.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelJobStatus.ForeColor = SystemColors.ControlDarkDark;
            labelJobStatus.Location = new Point(290, 7);
            labelJobStatus.Name = "labelJobStatus";
            labelJobStatus.Size = new Size(64, 14);
            labelJobStatus.TabIndex = 62;
            labelJobStatus.Text = "Job Status";
            // 
            // labelDep
            // 
            labelDep.AutoSize = true;
            labelDep.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDep.ForeColor = SystemColors.ControlDarkDark;
            labelDep.Location = new Point(112, 7);
            labelDep.Name = "labelDep";
            labelDep.Size = new Size(70, 14);
            labelDep.TabIndex = 61;
            labelDep.Text = "Department";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.ControlDarkDark;
            labelName.Location = new Point(42, 7);
            labelName.Name = "labelName";
            labelName.Size = new Size(37, 14);
            labelName.TabIndex = 60;
            labelName.Text = "Name";
            // 
            // labelEmpNum
            // 
            labelEmpNum.AutoSize = true;
            labelEmpNum.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmpNum.ForeColor = SystemColors.ControlDarkDark;
            labelEmpNum.Location = new Point(13, 7);
            labelEmpNum.Name = "labelEmpNum";
            labelEmpNum.Size = new Size(14, 14);
            labelEmpNum.TabIndex = 58;
            labelEmpNum.Text = "#";
            // 
            // FormAbsentees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelAbsenteesForToday);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(labelAbsenteesDate);
            Controls.Add(labelAbsenteesForToday);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "FormAbsentees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbsentees";
            Load += FormAbsentees_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelAbsenteesForToday.ResumeLayout(false);
            panelAbsenteesForToday.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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