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
            button4 = new Button();
            panelAbsenteesForToday = new Panel();
            labelOccupation = new Label();
            labelJobStatus = new Label();
            labelDep = new Label();
            labelName = new Label();
            labelEmpNum = new Label();
            button2 = new Button();
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
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.Location = new Point(38, 127);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.ShowCellErrors = false;
            dataGridView2.ShowCellToolTips = false;
            dataGridView2.ShowEditingIcon = false;
            dataGridView2.ShowRowErrors = false;
            dataGridView2.Size = new Size(951, 392);
            dataGridView2.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(687, 60);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Name or Employee Number";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 72;
            textBox1.TextChanged += textBox1_TextChanged;
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
            button4.Location = new Point(889, 55);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 74;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelAbsenteesForToday
            // 
            panelAbsenteesForToday.BackColor = Color.White;
            panelAbsenteesForToday.BorderStyle = BorderStyle.FixedSingle;
            panelAbsenteesForToday.Controls.Add(labelOccupation);
            panelAbsenteesForToday.Controls.Add(labelJobStatus);
            panelAbsenteesForToday.Controls.Add(labelDep);
            panelAbsenteesForToday.Controls.Add(labelName);
            panelAbsenteesForToday.Controls.Add(labelEmpNum);
            panelAbsenteesForToday.Location = new Point(38, 91);
            panelAbsenteesForToday.Name = "panelAbsenteesForToday";
            panelAbsenteesForToday.Size = new Size(951, 30);
            panelAbsenteesForToday.TabIndex = 75;
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOccupation.ForeColor = SystemColors.ControlDarkDark;
            labelOccupation.Location = new Point(309, 7);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(68, 14);
            labelOccupation.TabIndex = 67;
            labelOccupation.Text = "Occupation";
            // 
            // labelJobStatus
            // 
            labelJobStatus.AutoSize = true;
            labelJobStatus.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelJobStatus.ForeColor = SystemColors.ControlDarkDark;
            labelJobStatus.Location = new Point(392, 7);
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
            labelDep.Location = new Point(216, 7);
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
            labelName.Location = new Point(124, 7);
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
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(942, 55);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 30);
            button2.TabIndex = 76;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // FormAbsentees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(button2);
            Controls.Add(panelAbsenteesForToday);
            Controls.Add(button4);
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
        private Button button4;
        private Panel panelAbsenteesForToday;
        private Label labelOccupation;
        private Label labelJobStatus;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
        private Button button2;
    }
}