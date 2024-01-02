namespace SCTAttendanceSystemUI.Forms.filterButton
{
    partial class filterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filterForm));
            cancelButton = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            jobStatusCMB = new ComboBox();
            clearButton = new Button();
            panel2 = new Panel();
            depCMB = new ComboBox();
            genderCMB = new ComboBox();
            applyButton = new Button();
            occupationCMB = new ComboBox();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Transparent;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderColor = Color.White;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(jobStatusCMB);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(depCMB);
            panel1.Controls.Add(genderCMB);
            panel1.Controls.Add(applyButton);
            panel1.Controls.Add(occupationCMB);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 332);
            panel1.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.Location = new Point(0, 213);
            panel5.Name = "panel5";
            panel5.Size = new Size(212, 2);
            panel5.TabIndex = 68;
            // 
            // jobStatusCMB
            // 
            jobStatusCMB.BackColor = Color.WhiteSmoke;
            jobStatusCMB.Cursor = Cursors.Hand;
            jobStatusCMB.FlatStyle = FlatStyle.Flat;
            jobStatusCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            jobStatusCMB.FormattingEnabled = true;
            jobStatusCMB.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            jobStatusCMB.Location = new Point(36, 160);
            jobStatusCMB.Name = "jobStatusCMB";
            jobStatusCMB.Size = new Size(142, 23);
            jobStatusCMB.TabIndex = 69;
            jobStatusCMB.Text = "JOB STATUS";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.BackgroundImageLayout = ImageLayout.None;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatAppearance.BorderColor = Color.DimGray;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.ForeColor = Color.DimGray;
            clearButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearButton.Location = new Point(130, 292);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(71, 29);
            clearButton.TabIndex = 68;
            clearButton.Text = "Clear";
            clearButton.UseMnemonic = false;
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(-1, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 2);
            panel2.TabIndex = 66;
            // 
            // depCMB
            // 
            depCMB.BackColor = Color.WhiteSmoke;
            depCMB.Cursor = Cursors.Hand;
            depCMB.FlatStyle = FlatStyle.Flat;
            depCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            depCMB.FormattingEnabled = true;
            depCMB.Items.AddRange(new object[] { "IBED", "SED", "ASP" });
            depCMB.Location = new Point(36, 102);
            depCMB.Name = "depCMB";
            depCMB.Size = new Size(142, 23);
            depCMB.TabIndex = 65;
            depCMB.Text = "DEPARTMENT";
            // 
            // genderCMB
            // 
            genderCMB.BackColor = Color.WhiteSmoke;
            genderCMB.Cursor = Cursors.Hand;
            genderCMB.FlatStyle = FlatStyle.Flat;
            genderCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            genderCMB.FormattingEnabled = true;
            genderCMB.Items.AddRange(new object[] { "Male", "Female" });
            genderCMB.Location = new Point(36, 131);
            genderCMB.Name = "genderCMB";
            genderCMB.Size = new Size(142, 23);
            genderCMB.TabIndex = 64;
            genderCMB.Text = "GENDER";
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.White;
            applyButton.BackgroundImageLayout = ImageLayout.None;
            applyButton.Cursor = Cursors.Hand;
            applyButton.FlatAppearance.BorderColor = Color.DimGray;
            applyButton.FlatAppearance.BorderSize = 0;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            applyButton.ForeColor = Color.Black;
            applyButton.ImageAlign = ContentAlignment.MiddleLeft;
            applyButton.Location = new Point(53, 292);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(71, 29);
            applyButton.TabIndex = 63;
            applyButton.Text = "Apply";
            applyButton.UseMnemonic = false;
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += button1_Click;
            // 
            // occupationCMB
            // 
            occupationCMB.BackColor = Color.WhiteSmoke;
            occupationCMB.Cursor = Cursors.Hand;
            occupationCMB.FlatStyle = FlatStyle.Flat;
            occupationCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            occupationCMB.FormattingEnabled = true;
            occupationCMB.Items.AddRange(new object[] { "Teacher", "Sports Coach", "School Nurse", "Maintenance Technician", "Registrar", "Guidance Counselor", "Guard", "Chairperson" });
            occupationCMB.Location = new Point(36, 73);
            occupationCMB.Name = "occupationCMB";
            occupationCMB.Size = new Size(142, 23);
            occupationCMB.TabIndex = 62;
            occupationCMB.Text = "OCCUPATION";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // filterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(216, 335);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 260);
            Name = "filterForm";
            StartPosition = FormStartPosition.Manual;
            Text = "filterForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button cancelButton;
        private Panel panel1;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Button applyButton;
        public ComboBox occupationCMB;
        private Panel panel2;
        public ComboBox depCMB;
        public ComboBox genderCMB;
        private Button clearButton;
        private Panel panel5;
        public ComboBox jobStatusCMB;
    }
}