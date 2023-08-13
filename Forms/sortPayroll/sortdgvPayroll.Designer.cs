namespace SCTAttendanceSystemUI.Forms.sortPayroll
{
    partial class sortdgvPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sortdgvPayroll));
            cancelButton = new Button();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            filterComboBox = new ComboBox();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            panel1.SuspendLayout();
            SuspendLayout();
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
            cancelButton.Text = "Sort";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(filterComboBox);
            panel1.Controls.Add(cancelButton);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(213, 332);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Location = new Point(3, 176);
            panel4.Name = "panel4";
            panel4.Size = new Size(212, 2);
            panel4.TabIndex = 67;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Location = new Point(0, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 2);
            panel3.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Location = new Point(-1, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 2);
            panel2.TabIndex = 66;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.WhiteSmoke;
            comboBox2.Cursor = Cursors.Hand;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "None", "A - Z", "Z - A" });
            comboBox2.Location = new Point(25, 132);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(153, 23);
            comboBox2.TabIndex = 65;
            comboBox2.Text = "NAME";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Recent - Oldest", "Oldest - Recent" });
            comboBox1.Location = new Point(25, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 23);
            comboBox1.TabIndex = 64;
            comboBox1.Text = "DATE";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // filterComboBox
            // 
            filterComboBox.BackColor = Color.WhiteSmoke;
            filterComboBox.Cursor = Cursors.Hand;
            filterComboBox.FlatStyle = FlatStyle.Flat;
            filterComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "None", "Highest - Lowest", "Lowest - Highest" });
            filterComboBox.Location = new Point(25, 65);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(153, 23);
            filterComboBox.TabIndex = 62;
            filterComboBox.Text = "EMPLOYEE NUMBER";
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // sortdgvPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(216, 335);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(1160, 218);
            Name = "sortdgvPayroll";
            StartPosition = FormStartPosition.Manual;
            Text = "sortdgvPayroll";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button cancelButton;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        public ComboBox comboBox2;
        public ComboBox comboBox1;
        public ComboBox filterComboBox;
        private MySqlConnector.MySqlCommand mySqlCommand1;
    }
}