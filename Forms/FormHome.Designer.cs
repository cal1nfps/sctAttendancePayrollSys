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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            labelDashboard = new Label();
            labelDashboardDate = new Label();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            panelAttendanceForToday = new Panel();
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
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelAttendanceForToday.SuspendLayout();
            SuspendLayout();
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.ForeColor = Color.Black;
            labelDashboard.Location = new Point(38, 32);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(370, 31);
            labelDashboard.TabIndex = 3;
            labelDashboard.Text = "ATTENDANCE FOR TODAY";
            // 
            // labelDashboardDate
            // 
            labelDashboardDate.AutoSize = true;
            labelDashboardDate.BackColor = Color.Transparent;
            labelDashboardDate.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboardDate.Location = new Point(414, 34);
            labelDashboardDate.Name = "labelDashboardDate";
            labelDashboardDate.Size = new Size(84, 25);
            labelDashboardDate.TabIndex = 17;
            labelDashboardDate.Text = "DATE: ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(38, 131);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1177, 514);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
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
            button4.Location = new Point(1115, 59);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 65;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(860, 64);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Name or Employee Number";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 66;
            textBox1.TextChanged += textBox1_TextChanged;
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
            button1.Location = new Point(1062, 59);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 30);
            button1.TabIndex = 69;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panelAttendanceForToday
            // 
            panelAttendanceForToday.BackColor = Color.White;
            panelAttendanceForToday.BorderStyle = BorderStyle.FixedSingle;
            panelAttendanceForToday.Controls.Add(label2);
            panelAttendanceForToday.Controls.Add(label1);
            panelAttendanceForToday.Controls.Add(labelStatus);
            panelAttendanceForToday.Controls.Add(labelOvertimeHours);
            panelAttendanceForToday.Controls.Add(labelTimeOut);
            panelAttendanceForToday.Controls.Add(labelOccupation);
            panelAttendanceForToday.Controls.Add(labelTotalHours);
            panelAttendanceForToday.Controls.Add(labelTimeIn);
            panelAttendanceForToday.Controls.Add(labelDate);
            panelAttendanceForToday.Controls.Add(labelJobStatus);
            panelAttendanceForToday.Controls.Add(labelDep);
            panelAttendanceForToday.Controls.Add(labelName);
            panelAttendanceForToday.Controls.Add(labelEmpNum);
            panelAttendanceForToday.Location = new Point(38, 95);
            panelAttendanceForToday.Name = "panelAttendanceForToday";
            panelAttendanceForToday.Size = new Size(1177, 30);
            panelAttendanceForToday.TabIndex = 70;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(1076, 7);
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
            label1.Location = new Point(980, 7);
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
            labelStatus.Location = new Point(887, 7);
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
            labelOvertimeHours.Location = new Point(800, 7);
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
            labelTimeOut.Location = new Point(625, 7);
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
            labelOccupation.Location = new Point(258, 7);
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
            labelTotalHours.Location = new Point(709, 7);
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
            labelTimeIn.Location = new Point(558, 7);
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
            labelDate.Location = new Point(478, 7);
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
            labelJobStatus.Location = new Point(351, 7);
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
            labelDep.Location = new Point(171, 7);
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
            labelName.Location = new Point(59, 7);
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
            labelEmpNum.Location = new Point(15, 7);
            labelEmpNum.Name = "labelEmpNum";
            labelEmpNum.Size = new Size(14, 14);
            labelEmpNum.TabIndex = 58;
            labelEmpNum.Text = "#";
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1168, 59);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 30);
            button2.TabIndex = 71;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(button2);
            Controls.Add(panelAttendanceForToday);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(labelDashboardDate);
            Controls.Add(labelDashboard);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHome";
            Load += FormHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelAttendanceForToday.ResumeLayout(false);
            panelAttendanceForToday.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label labelJobStatus;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
        private Label label2;
        private Label label1;
        private Button button2;
    }
}