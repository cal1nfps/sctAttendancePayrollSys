namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    partial class FormPayroll2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll2));
            label5 = new Label();
            label1 = new Label();
            cancelButton = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox9 = new TextBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(67, 36);
            label5.Name = "label5";
            label5.Size = new Size(0, 14);
            label5.TabIndex = 63;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(145, 36);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 64;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Transparent;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.White;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Roboto Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.Gray;
            cancelButton.Image = (Image)resources.GetObject("cancelButton.Image");
            cancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelButton.Location = new Point(12, 8);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(110, 25);
            cancelButton.TabIndex = 68;
            cancelButton.Text = "Payroll";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(249, 214);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(107, 23);
            textBox4.TabIndex = 82;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(249, 162);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(107, 23);
            textBox5.TabIndex = 81;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(249, 145);
            label6.Name = "label6";
            label6.Size = new Size(61, 14);
            label6.TabIndex = 80;
            label6.Text = "Deduction";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(249, 197);
            label7.Name = "label7";
            label7.Size = new Size(47, 14);
            label7.TabIndex = 79;
            label7.Text = "Net Pay";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(249, 92);
            label8.Name = "label8";
            label8.Size = new Size(61, 14);
            label8.TabIndex = 78;
            label8.Text = "Gross Pay";
            label8.Click += label8_Click;
            // 
            // textBox6
            // 
            textBox6.Enabled = false;
            textBox6.Location = new Point(249, 109);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(107, 23);
            textBox6.TabIndex = 77;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(67, 214);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(107, 23);
            textBox7.TabIndex = 76;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Enabled = false;
            textBox8.Location = new Point(67, 162);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(107, 23);
            textBox8.TabIndex = 75;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(67, 145);
            label2.Name = "label2";
            label2.Size = new Size(68, 14);
            label2.TabIndex = 74;
            label2.Text = "Total Hours";
            label2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(67, 197);
            label4.Name = "label4";
            label4.Size = new Size(40, 14);
            label4.TabIndex = 73;
            label4.Text = "Salary";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(67, 92);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 72;
            label3.Text = "Hourly";
            label3.Click += label3_Click;
            // 
            // textBox9
            // 
            textBox9.Enabled = false;
            textBox9.Location = new Point(67, 109);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(107, 23);
            textBox9.TabIndex = 71;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // FormPayroll2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(429, 293);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox8);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox9);
            Controls.Add(cancelButton);
            Controls.Add(label1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(592, 36);
            Name = "FormPayroll2";
            StartPosition = FormStartPosition.Manual;
            Text = "FormPayroll2";
            Load += FormPayroll2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Button cancelButton;
        public TextBox textBox4;
        public TextBox textBox5;
        private Label label6;
        private Label label7;
        private Label label8;
        public TextBox textBox6;
        public TextBox textBox7;
        private TextBox textBox8;
        private Label label2;
        private Label label4;
        private Label label3;
        public TextBox textBox9;
    }
}