namespace SCTAttendanceSystemUI.Forms
{
    partial class FormLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeave));
            labelLeave = new Label();
            dataGridViewLeave = new DataGridView();
            panelLeaveForToday = new Panel();
            label10 = new Label();
            label9 = new Label();
            labelOccupation = new Label();
            label8 = new Label();
            labelDuration = new Label();
            labelDep = new Label();
            labelName = new Label();
            labelEmpNum = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button2 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox2 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeave).BeginInit();
            panelLeaveForToday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelLeave
            // 
            labelLeave.AutoSize = true;
            labelLeave.BackColor = Color.Transparent;
            labelLeave.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelLeave.Location = new Point(34, 114);
            labelLeave.Name = "labelLeave";
            labelLeave.Size = new Size(328, 31);
            labelLeave.TabIndex = 7;
            labelLeave.Text = "EMPLOYEES ON LEAVE";
            // 
            // dataGridViewLeave
            // 
            dataGridViewLeave.AllowUserToAddRows = false;
            dataGridViewLeave.AllowUserToDeleteRows = false;
            dataGridViewLeave.AllowUserToResizeColumns = false;
            dataGridViewLeave.AllowUserToResizeRows = false;
            dataGridViewLeave.BackgroundColor = Color.White;
            dataGridViewLeave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeave.ColumnHeadersVisible = false;
            dataGridViewLeave.EnableHeadersVisualStyles = false;
            dataGridViewLeave.Location = new Point(34, 184);
            dataGridViewLeave.MultiSelect = false;
            dataGridViewLeave.Name = "dataGridViewLeave";
            dataGridViewLeave.RowHeadersVisible = false;
            dataGridViewLeave.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewLeave.RowTemplate.Height = 25;
            dataGridViewLeave.ShowCellErrors = false;
            dataGridViewLeave.ShowCellToolTips = false;
            dataGridViewLeave.ShowEditingIcon = false;
            dataGridViewLeave.ShowRowErrors = false;
            dataGridViewLeave.Size = new Size(555, 392);
            dataGridViewLeave.TabIndex = 16;
            dataGridViewLeave.CellFormatting += dataGridViewLeave_CellFormatting;
            // 
            // panelLeaveForToday
            // 
            panelLeaveForToday.BackColor = Color.White;
            panelLeaveForToday.BorderStyle = BorderStyle.FixedSingle;
            panelLeaveForToday.Controls.Add(label10);
            panelLeaveForToday.Controls.Add(label9);
            panelLeaveForToday.Controls.Add(labelOccupation);
            panelLeaveForToday.Controls.Add(label8);
            panelLeaveForToday.Controls.Add(labelDuration);
            panelLeaveForToday.Controls.Add(labelDep);
            panelLeaveForToday.Controls.Add(labelName);
            panelLeaveForToday.Controls.Add(labelEmpNum);
            panelLeaveForToday.Location = new Point(34, 148);
            panelLeaveForToday.Name = "panelLeaveForToday";
            panelLeaveForToday.Size = new Size(555, 30);
            panelLeaveForToday.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(494, 7);
            label10.Name = "label10";
            label10.Size = new Size(32, 14);
            label10.TabIndex = 86;
            label10.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(414, 7);
            label9.Name = "label9";
            label9.Size = new Size(27, 14);
            label9.TabIndex = 85;
            label9.Text = "End";
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOccupation.ForeColor = SystemColors.ControlDarkDark;
            labelOccupation.Location = new Point(112, 7);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(68, 14);
            labelOccupation.TabIndex = 67;
            labelOccupation.Text = "Occupation";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(325, 7);
            label8.Name = "label8";
            label8.Size = new Size(33, 14);
            label8.TabIndex = 68;
            label8.Text = "Start";
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDuration.ForeColor = SystemColors.ControlDarkDark;
            labelDuration.Location = new Point(221, 7);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(64, 14);
            labelDuration.TabIndex = 64;
            labelDuration.Text = "Job Status";
            // 
            // labelDep
            // 
            labelDep.AutoSize = true;
            labelDep.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDep.ForeColor = SystemColors.ControlDarkDark;
            labelDep.Location = new Point(186, 7);
            labelDep.Name = "labelDep";
            labelDep.Size = new Size(29, 14);
            labelDep.TabIndex = 61;
            labelDep.Text = "DEP";
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
            // textBox1
            // 
            textBox1.Location = new Point(393, 122);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search Name";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 73;
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
            button1.Location = new Point(1203, 184);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 30);
            button1.TabIndex = 74;
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
            button4.Location = new Point(1203, 220);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 75;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1203, 256);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(47, 30);
            button3.TabIndex = 76;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            dataGridView1.Location = new Point(689, 184);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(508, 392);
            dataGridView1.TabIndex = 77;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(942, 114);
            label1.Name = "label1";
            label1.Size = new Size(255, 31);
            label1.TabIndex = 78;
            label1.Text = "LEAVE REQUESTS";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(595, 256);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 30);
            button2.TabIndex = 81;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(595, 220);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(47, 30);
            button5.TabIndex = 80;
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(595, 184);
            button6.Name = "button6";
            button6.Padding = new Padding(10, 0, 0, 0);
            button6.Size = new Size(47, 30);
            button6.TabIndex = 79;
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(689, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 30);
            panel1.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(356, 7);
            label3.Name = "label3";
            label3.Size = new Size(31, 14);
            label3.TabIndex = 68;
            label3.Text = "Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(136, 7);
            label2.Name = "label2";
            label2.Size = new Size(68, 14);
            label2.TabIndex = 67;
            label2.Text = "Occupation";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(286, 7);
            label4.Name = "label4";
            label4.Size = new Size(64, 14);
            label4.TabIndex = 64;
            label4.Text = "Job Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(210, 7);
            label5.Name = "label5";
            label5.Size = new Size(70, 14);
            label5.TabIndex = 61;
            label5.Text = "Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(59, 7);
            label6.Name = "label6";
            label6.Size = new Size(37, 14);
            label6.TabIndex = 60;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(15, 7);
            label7.Name = "label7";
            label7.Size = new Size(14, 14);
            label7.TabIndex = 58;
            label7.Text = "#";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(689, 122);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Search Name";
            textBox2.Size = new Size(196, 23);
            textBox2.TabIndex = 82;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button7
            // 
            button7.BackColor = Color.Green;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(595, 292);
            button7.Name = "button7";
            button7.Padding = new Padding(10, 0, 0, 0);
            button7.Size = new Size(47, 30);
            button7.TabIndex = 83;
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Green;
            button8.BackgroundImage = (Image)resources.GetObject("button8.BackgroundImage");
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(1203, 292);
            button8.Name = "button8";
            button8.Padding = new Padding(10, 0, 0, 0);
            button8.Size = new Size(47, 30);
            button8.TabIndex = 84;
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // FormLeave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(panelLeaveForToday);
            Controls.Add(dataGridViewLeave);
            Controls.Add(labelLeave);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "FormLeave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLeave";
            Load += FormLeave_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeave).EndInit();
            panelLeaveForToday.ResumeLayout(false);
            panelLeaveForToday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLeave;
        private DataGridView dataGridViewLeave;
        private Panel panelLeaveForToday;
        private Label labelOccupation;
        private Label labelDuration;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
        private TextBox textBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button2;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox2;
        private Label label3;
        private Button button7;
        private Button button8;
        private Label label9;
        private Label label8;
        private Label label10;
    }
}