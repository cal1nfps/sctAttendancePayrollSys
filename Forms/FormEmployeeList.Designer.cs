namespace SCTAttendanceSystemUI.Forms
{
    partial class FormEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeList));
            labelEmployeeList = new Label();
            button3 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label19 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            label18 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label9 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            panel4 = new Panel();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label11 = new Label();
            label10 = new Label();
            sortComboBox = new ComboBox();
            label20 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // labelEmployeeList
            // 
            labelEmployeeList.AutoSize = true;
            labelEmployeeList.BackColor = Color.Transparent;
            labelEmployeeList.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployeeList.Location = new Point(38, 32);
            labelEmployeeList.Name = "labelEmployeeList";
            labelEmployeeList.Size = new Size(237, 31);
            labelEmployeeList.TabIndex = 9;
            labelEmployeeList.Text = "EMPLOYEE LIST";
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
            button3.Location = new Point(767, 93);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(47, 30);
            button3.TabIndex = 50;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(164, 16, 48);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(767, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 74);
            panel1.TabIndex = 51;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 8);
            label1.Name = "label1";
            label1.Size = new Size(269, 42);
            label1.TabIndex = 0;
            label1.Text = "Employee Information";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label19);
            panel2.Controls.Add(textBox9);
            panel2.Controls.Add(textBox8);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(767, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 455);
            panel2.TabIndex = 52;
            panel2.Paint += panel2_Paint;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(398, 171);
            label19.Name = "label19";
            label19.Size = new Size(13, 18);
            label19.TabIndex = 38;
            label19.Text = "-";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(417, 171);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(62, 23);
            textBox9.TabIndex = 37;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(330, 171);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(62, 23);
            textBox8.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(230, 171);
            label18.Name = "label18";
            label18.Size = new Size(94, 18);
            label18.TabIndex = 35;
            label18.Text = "TIME-IN/TIME-OUT";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox7);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(16, 240);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 145);
            panel3.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(36, 72);
            label7.Name = "label7";
            label7.Size = new Size(84, 18);
            label7.TabIndex = 37;
            label7.Text = "PHONE NUMBER";
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(126, 101);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(174, 23);
            textBox5.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(82, 101);
            label8.Name = "label8";
            label8.Size = new Size(38, 18);
            label8.TabIndex = 36;
            label8.Text = "EMAIL";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(14, 16);
            label6.Name = "label6";
            label6.Size = new Size(114, 14);
            label6.TabIndex = 23;
            label6.Text = "Contact Information";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(42, 43);
            label9.Name = "label9";
            label9.Size = new Size(78, 18);
            label9.TabIndex = 35;
            label9.Text = "HOME NUMBER";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(126, 72);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(174, 23);
            textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(126, 43);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(174, 23);
            textBox7.TabIndex = 35;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Location = new Point(16, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(252, 138);
            label5.Name = "label5";
            label5.Size = new Size(72, 18);
            label5.TabIndex = 7;
            label5.Text = "ACCOUNT NO.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(261, 75);
            label4.Name = "label4";
            label4.Size = new Size(63, 18);
            label4.TabIndex = 6;
            label4.Text = "FULL NAME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(267, 109);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 5;
            label3.Text = "HIRE DATE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(245, 46);
            label2.Name = "label2";
            label2.Size = new Size(79, 18);
            label2.TabIndex = 4;
            label2.Text = "EMPLOYEE NO.";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(330, 133);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(174, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(330, 104);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(174, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(330, 75);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(330, 46);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(38, 129);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(723, 526);
            dataGridView1.TabIndex = 53;
            dataGridView1.CellClick += dataGridView1_CellClick_1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(3, 8);
            label12.Name = "label12";
            label12.Size = new Size(37, 14);
            label12.TabIndex = 58;
            label12.Text = "Name";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(38, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(723, 30);
            panel4.TabIndex = 59;
            panel4.Paint += panel4_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ControlDarkDark;
            label17.Location = new Point(634, 7);
            label17.Name = "label17";
            label17.Size = new Size(27, 14);
            label17.TabIndex = 66;
            label17.Text = "City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ControlDarkDark;
            label16.Location = new Point(545, 8);
            label16.Name = "label16";
            label16.Size = new Size(54, 14);
            label16.TabIndex = 65;
            label16.Text = "Province";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ControlDarkDark;
            label15.Location = new Point(448, 7);
            label15.Name = "label15";
            label15.Size = new Size(50, 14);
            label15.TabIndex = 64;
            label15.Text = "Country";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlDarkDark;
            label14.Location = new Point(359, 7);
            label14.Name = "label14";
            label14.Size = new Size(61, 14);
            label14.TabIndex = 63;
            label14.Text = "Birth Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(270, 8);
            label13.Name = "label13";
            label13.Size = new Size(64, 14);
            label13.TabIndex = 62;
            label13.Text = "Job Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(194, 7);
            label11.Name = "label11";
            label11.Size = new Size(70, 14);
            label11.TabIndex = 61;
            label11.Text = "Department";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(111, 7);
            label10.Name = "label10";
            label10.Size = new Size(68, 14);
            label10.TabIndex = 60;
            label10.Text = "Occupation";
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = Color.WhiteSmoke;
            sortComboBox.Cursor = Cursors.Hand;
            sortComboBox.FlatStyle = FlatStyle.Flat;
            sortComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "None", "A - Z", "Z - A" });
            sortComboBox.Location = new Point(619, 64);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(142, 23);
            sortComboBox.TabIndex = 61;
            sortComboBox.Text = "NAME";
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.WhiteSmoke;
            label20.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(575, 64);
            label20.Name = "label20";
            label20.Size = new Size(39, 17);
            label20.TabIndex = 60;
            label20.Text = "Sort:";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(820, 94);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(45, 30);
            button1.TabIndex = 62;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(871, 93);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(45, 30);
            button2.TabIndex = 63;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            button4.Location = new Point(714, 28);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 64;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            button5.Location = new Point(922, 93);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(47, 30);
            button5.TabIndex = 72;
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // FormEmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sortComboBox);
            Controls.Add(label20);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(labelEmployeeList);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "FormEmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEmployeeList";
            Load += FormEmployeeList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmployeeList;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label12;
        private Panel panel4;
        private Label label10;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label18;
        private ComboBox sortComboBox;
        private Label label20;
        private Button button1;
        private Button button2;
        private Button button4;
        public DataGridView dataGridView1;
        public PictureBox pictureBox1;
        private Button button5;
    }
}