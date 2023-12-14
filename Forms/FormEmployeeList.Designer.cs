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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dataGridViewEmployeeList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            searchBox = new TextBox();
            clearLabel = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).BeginInit();
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
            button3.Location = new Point(1502, 94);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(47, 32);
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
            panel1.Location = new Point(997, 129);
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
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(997, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 455);
            panel2.TabIndex = 52;
            panel2.Paint += panel2_Paint;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(398, 133);
            label19.Name = "label19";
            label19.Size = new Size(13, 18);
            label19.TabIndex = 38;
            label19.Text = "-";
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(417, 133);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(62, 23);
            textBox9.TabIndex = 37;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(330, 133);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(62, 23);
            textBox8.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(230, 133);
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
            label3.Location = new Point(267, 104);
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
            // dataGridViewEmployeeList
            // 
            dataGridViewEmployeeList.AllowUserToAddRows = false;
            dataGridViewEmployeeList.AllowUserToResizeRows = false;
            dataGridViewEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployeeList.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeeList.Location = new Point(38, 129);
            dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            dataGridViewEmployeeList.ReadOnly = true;
            dataGridViewEmployeeList.RowHeadersVisible = false;
            dataGridViewEmployeeList.RowTemplate.Height = 25;
            dataGridViewEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployeeList.Size = new Size(953, 526);
            dataGridViewEmployeeList.TabIndex = 53;
            dataGridViewEmployeeList.CellClick += dataGridView1_CellClick_1;
            dataGridViewEmployeeList.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewEmployeeList.CellFormatting += dataGridView1_CellFormatting_1;
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
            button1.Location = new Point(1555, 94);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 32);
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
            button2.Location = new Point(891, 91);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 32);
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
            button4.Location = new Point(354, 91);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 32);
            button4.TabIndex = 64;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(38, 91);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 73;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Cursor = Cursors.Hand;
            clearLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearLabel.Location = new Point(880, 658);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 74;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
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
            button5.Location = new Point(944, 91);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(47, 32);
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
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(clearLabel);
            Controls.Add(searchBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridViewEmployeeList);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(labelEmployeeList);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmployeeList;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label19;
        private TextBox textBox9;
        private TextBox textBox8;
        private Label label18;
        private Button button1;
        private Button button2;
        private Button button4;
        public DataGridView dataGridViewEmployeeList;
        public PictureBox pictureBox1;
        private TextBox searchBox;
        private Label clearLabel;
        private Button button5;
    }
}