namespace SCTAttendanceSystemUI.Employee.filterOnLeave
{
    partial class filteronleave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filteronleave));
            panel1 = new Panel();
            comboBox3 = new ComboBox();
            button2 = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            button1 = new Button();
            filterComboBox = new ComboBox();
            cancelButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(filterComboBox);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 332);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.WhiteSmoke;
            comboBox3.Cursor = Cursors.Hand;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            comboBox3.Location = new Point(40, 152);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(142, 23);
            comboBox3.TabIndex = 70;
            comboBox3.Text = "JOB STATUS";
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Roboto Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DimGray;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(130, 292);
            button2.Name = "button2";
            button2.Size = new Size(71, 29);
            button2.TabIndex = 68;
            button2.Text = "Clear";
            button2.UseMnemonic = false;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(0, 224);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 2);
            panel4.TabIndex = 67;
            panel4.Paint += panel4_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(-1, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 2);
            panel2.TabIndex = 66;
            panel2.Paint += panel2_Paint;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.WhiteSmoke;
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            comboBox2.Location = new Point(40, 123);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 65;
            comboBox2.Text = "DEPARTMENT";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Roboto Mono", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(53, 292);
            button1.Name = "button1";
            button1.Size = new Size(71, 29);
            button1.TabIndex = 63;
            button1.Text = "Apply";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // filterComboBox
            // 
            filterComboBox.BackColor = Color.WhiteSmoke;
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.FlatStyle = FlatStyle.Flat;
            filterComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Teacher", "Sports Coach", "School Nurse", "Maintenance Technician", "Registrar", "Guidance Counselor", "Guard", "Chairperson" });
            filterComboBox.Location = new Point(40, 94);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(142, 23);
            filterComboBox.TabIndex = 62;
            filterComboBox.Text = "OCCUPATION";
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
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
            cancelButton.Location = new Point(9, 10);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(87, 25);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Filters";
            cancelButton.TextAlign = ContentAlignment.MiddleRight;
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // filteronleave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 335);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(640, 385);
            Name = "filteronleave";
            StartPosition = FormStartPosition.Manual;
            Text = "filteronleave";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public ComboBox comboBox3;
        private Button button2;
        private Panel panel4;
        private Panel panel2;
        public ComboBox comboBox2;
        private Button button1;
        public ComboBox filterComboBox;
        private Button cancelButton;
    }
}