namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    partial class Payroll
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
            button1 = new Button();
            cancelButton = new Button();
            personalButton = new Button();
            panel1 = new Panel();
            label15 = new Label();
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            panel2 = new Panel();
            textBox16 = new TextBox();
            label20 = new Label();
            textBox15 = new TextBox();
            label19 = new Label();
            textBox14 = new TextBox();
            filterComboBox = new ComboBox();
            label11 = new Label();
            label18 = new Label();
            textBox12 = new TextBox();
            label16 = new Label();
            label17 = new Label();
            textBox13 = new TextBox();
            textBox11 = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(812, 404);
            button1.Name = "button1";
            button1.Size = new Size(88, 34);
            button1.TabIndex = 8;
            button1.Text = "Confirm";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(924, 404);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // personalButton
            // 
            personalButton.BackColor = Color.White;
            personalButton.BackgroundImageLayout = ImageLayout.None;
            personalButton.FlatAppearance.BorderColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.BorderSize = 2;
            personalButton.FlatAppearance.CheckedBackColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 209, 10);
            personalButton.FlatStyle = FlatStyle.Flat;
            personalButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personalButton.ForeColor = SystemColors.ControlText;
            personalButton.Location = new Point(-1, 0);
            personalButton.Name = "personalButton";
            personalButton.Size = new Size(144, 41);
            personalButton.TabIndex = 9;
            personalButton.Text = "Payroll Information";
            personalButton.UseMnemonic = false;
            personalButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-1, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1212, 346);
            panel1.TabIndex = 10;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(416, 19);
            label15.Name = "label15";
            label15.Size = new Size(55, 14);
            label15.TabIndex = 60;
            label15.Text = "Job Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(322, 19);
            label2.Name = "label2";
            label2.Size = new Size(68, 14);
            label2.TabIndex = 59;
            label2.Text = "Occupation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(190, 19);
            label1.Name = "label1";
            label1.Size = new Size(37, 14);
            label1.TabIndex = 58;
            label1.Text = "Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(26, 19);
            label12.Name = "label12";
            label12.Size = new Size(105, 14);
            label12.TabIndex = 57;
            label12.Text = "Employee Number";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox16);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(textBox15);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(textBox14);
            panel2.Controls.Add(filterComboBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(textBox12);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(textBox13);
            panel2.Controls.Add(textBox11);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(592, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 293);
            panel2.TabIndex = 56;
            // 
            // textBox16
            // 
            textBox16.Enabled = false;
            textBox16.Location = new Point(456, 192);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(107, 23);
            textBox16.TabIndex = 92;
            textBox16.TextAlign = HorizontalAlignment.Right;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ControlDarkDark;
            label20.Location = new Point(482, 175);
            label20.Name = "label20";
            label20.Size = new Size(81, 14);
            label20.TabIndex = 91;
            label20.Text = "Contributions";
            // 
            // textBox15
            // 
            textBox15.Enabled = false;
            textBox15.Location = new Point(311, 144);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(107, 23);
            textBox15.TabIndex = 90;
            textBox15.TextAlign = HorizontalAlignment.Right;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.ForeColor = SystemColors.ControlDarkDark;
            label19.Location = new Point(356, 127);
            label19.Name = "label19";
            label19.Size = new Size(61, 14);
            label19.TabIndex = 89;
            label19.Text = "Deduction";
            // 
            // textBox14
            // 
            textBox14.Enabled = false;
            textBox14.Location = new Point(314, 192);
            textBox14.Name = "textBox14";
            textBox14.ReadOnly = true;
            textBox14.Size = new Size(107, 23);
            textBox14.TabIndex = 88;
            textBox14.TextAlign = HorizontalAlignment.Right;
            // 
            // filterComboBox
            // 
            filterComboBox.BackColor = Color.WhiteSmoke;
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.FlatStyle = FlatStyle.Flat;
            filterComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "MONTHLY", "SEMI-MONTHLY" });
            filterComboBox.Location = new Point(254, 46);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(107, 23);
            filterComboBox.TabIndex = 63;
            filterComboBox.Text = "MONTHLY";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(272, 29);
            label11.Name = "label11";
            label11.Size = new Size(72, 14);
            label11.TabIndex = 75;
            label11.Text = "Payroll Type";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlDarkDark;
            label18.Location = new Point(359, 175);
            label18.Name = "label18";
            label18.Size = new Size(61, 14);
            label18.TabIndex = 87;
            label18.Text = "Gross Pay";
            // 
            // textBox12
            // 
            textBox12.Enabled = false;
            textBox12.Location = new Point(174, 187);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(107, 23);
            textBox12.TabIndex = 86;
            textBox12.TextAlign = HorizontalAlignment.Right;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(219, 170);
            label16.Name = "label16";
            label16.Size = new Size(62, 14);
            label16.TabIndex = 85;
            label16.Text = "Allowance";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(241, 127);
            label17.Name = "label17";
            label17.Size = new Size(40, 14);
            label17.TabIndex = 84;
            label17.Text = "Salary";
            // 
            // textBox13
            // 
            textBox13.Enabled = false;
            textBox13.Location = new Point(174, 144);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(107, 23);
            textBox13.TabIndex = 83;
            textBox13.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            textBox11.Enabled = false;
            textBox11.Location = new Point(38, 180);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(107, 23);
            textBox11.TabIndex = 82;
            textBox11.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(105, 163);
            label13.Name = "label13";
            label13.Size = new Size(40, 14);
            label13.TabIndex = 81;
            label13.Text = "Salary";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(88, 72);
            label14.Name = "label14";
            label14.Size = new Size(57, 14);
            label14.TabIndex = 78;
            label14.Text = "OT Hours";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(38, 91);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(107, 23);
            textBox9.TabIndex = 77;
            textBox9.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(465, 84);
            label10.Name = "label10";
            label10.Size = new Size(98, 14);
            label10.TabIndex = 74;
            label10.Text = "Undertime Hours";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(497, 127);
            label9.Name = "label9";
            label9.Size = new Size(66, 14);
            label9.TabIndex = 73;
            label9.Text = "Late Hours";
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(456, 144);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(107, 23);
            textBox8.TabIndex = 72;
            textBox8.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(456, 101);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(107, 23);
            textBox7.TabIndex = 71;
            textBox7.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(314, 235);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 70;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(456, 235);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(456, 218);
            label6.Name = "label6";
            label6.Size = new Size(61, 14);
            label6.TabIndex = 68;
            label6.Text = "Deduction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(314, 218);
            label7.Name = "label7";
            label7.Size = new Size(47, 14);
            label7.TabIndex = 67;
            label7.Text = "Net Pay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(174, 218);
            label8.Name = "label8";
            label8.Size = new Size(61, 14);
            label8.TabIndex = 66;
            label8.Text = "Gross Pay";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(174, 235);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 65;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(38, 235);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 64;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(38, 46);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 63;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(77, 29);
            label5.Name = "label5";
            label5.Size = new Size(68, 14);
            label5.TabIndex = 62;
            label5.Text = "Total Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(38, 218);
            label4.Name = "label4";
            label4.Size = new Size(68, 14);
            label4.TabIndex = 61;
            label4.Text = "Total Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(102, 117);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 60;
            label3.Text = "Hourly";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(38, 137);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(11, 36);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(575, 293);
            dataGridView1.TabIndex = 55;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // Payroll
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1211, 450);
            Controls.Add(panel1);
            Controls.Add(personalButton);
            Controls.Add(button1);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 300);
            Name = "Payroll";
            StartPosition = FormStartPosition.Manual;
            Text = "Payroll";
            Load += Payroll_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button cancelButton;
        private Button personalButton;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label12;
        private Label label2;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label8;
        public DataGridView dataGridView1;
        public TextBox textBox1;
        public TextBox textBox3;
        public TextBox textBox4;
        public TextBox textBox5;
        public TextBox textBox6;
        public TextBox textBox8;
        public TextBox textBox7;
        private Label label10;
        private Label label9;
        public ComboBox filterComboBox;
        private Label label11;
        private Label label14;
        public TextBox textBox9;
        private Label label13;
        public TextBox textBox11;
        public TextBox textBox12;
        private Label label16;
        private Label label17;
        public TextBox textBox13;
        public TextBox textBox15;
        private Label label19;
        public TextBox textBox14;
        private Label label18;
        public TextBox textBox16;
        private Label label20;
        private Label label15;
    }
}