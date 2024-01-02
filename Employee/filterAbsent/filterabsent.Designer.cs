namespace SCTAttendanceSystemUI.Employee.filterAbsent
{
    partial class filterabsent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filterabsent));
            panel1 = new Panel();
            jobStatusCMB = new ComboBox();
            clearButton = new Button();
            panel4 = new Panel();
            panel2 = new Panel();
            depCMB = new ComboBox();
            applyButton = new Button();
            occupationCMB = new ComboBox();
            cancelButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(jobStatusCMB);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(depCMB);
            panel1.Controls.Add(applyButton);
            panel1.Controls.Add(occupationCMB);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 332);
            panel1.TabIndex = 10;
            // 
            // jobStatusCMB
            // 
            jobStatusCMB.BackColor = Color.WhiteSmoke;
            jobStatusCMB.Cursor = Cursors.Hand;
            jobStatusCMB.FlatStyle = FlatStyle.Flat;
            jobStatusCMB.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            jobStatusCMB.FormattingEnabled = true;
            jobStatusCMB.Items.AddRange(new object[] { "FULL-TIME", "PART-TIME" });
            jobStatusCMB.Location = new Point(37, 154);
            jobStatusCMB.Name = "jobStatusCMB";
            jobStatusCMB.Size = new Size(142, 23);
            jobStatusCMB.TabIndex = 70;
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
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(0, 224);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 2);
            panel4.TabIndex = 67;
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
            depCMB.Location = new Point(37, 125);
            depCMB.Name = "depCMB";
            depCMB.Size = new Size(142, 23);
            depCMB.TabIndex = 65;
            depCMB.Text = "DEPARTMENT";
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
            occupationCMB.Location = new Point(37, 96);
            occupationCMB.Name = "occupationCMB";
            occupationCMB.Size = new Size(142, 23);
            occupationCMB.TabIndex = 62;
            occupationCMB.Text = "OCCUPATION";
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
            // filterabsent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 335);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(400, 258);
            Name = "filterabsent";
            StartPosition = FormStartPosition.Manual;
            Text = "filterabsent";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public ComboBox jobStatusCMB;
        private Button clearButton;
        private Panel panel4;
        private Panel panel2;
        public ComboBox depCMB;
        private Button applyButton;
        public ComboBox occupationCMB;
        private Button cancelButton;
    }
}