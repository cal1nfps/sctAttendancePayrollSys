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
            label2 = new Label();
            label1 = new Label();
            label12 = new Label();
            panel2 = new Panel();
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(-1, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(1036, 346);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(430, 19);
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
            label1.Location = new Point(259, 19);
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
            label12.Location = new Point(58, 19);
            label12.Name = "label12";
            label12.Size = new Size(105, 14);
            label12.TabIndex = 57;
            label12.Text = "Employee Number";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
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
            panel2.Size = new Size(429, 293);
            panel2.TabIndex = 56;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(218, 141);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 70;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(218, 89);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(218, 72);
            label6.Name = "label6";
            label6.Size = new Size(61, 14);
            label6.TabIndex = 68;
            label6.Text = "Deduction";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(218, 124);
            label7.Name = "label7";
            label7.Size = new Size(47, 14);
            label7.TabIndex = 67;
            label7.Text = "Net Pay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(218, 19);
            label8.Name = "label8";
            label8.Size = new Size(61, 14);
            label8.TabIndex = 66;
            label8.Text = "Gross Pay";
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(218, 36);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 65;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(36, 141);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(107, 23);
            textBox3.TabIndex = 64;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(36, 89);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(36, 72);
            label5.Name = "label5";
            label5.Size = new Size(68, 14);
            label5.TabIndex = 62;
            label5.Text = "Total Hours";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(36, 124);
            label4.Name = "label4";
            label4.Size = new Size(40, 14);
            label4.TabIndex = 61;
            label4.Text = "Salary";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(36, 19);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 60;
            label3.Text = "Hourly";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(36, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 1;
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
            ClientSize = new Size(1034, 450);
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
    }
}