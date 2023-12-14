namespace SCTAttendanceSystemUI.Forms
{
    partial class FormSED1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSED1));
            dataGridViewSED = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            labelDepartmentSED = new Label();
            panel1 = new Panel();
            clearLabel = new Label();
            deleteButton = new Button();
            searchBox = new TextBox();
            button4 = new Button();
            panel2 = new Panel();
            buttonBackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSED).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewSED
            // 
            dataGridViewSED.AllowUserToAddRows = false;
            dataGridViewSED.AllowUserToDeleteRows = false;
            dataGridViewSED.AllowUserToResizeRows = false;
            dataGridViewSED.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSED.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewSED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSED.Location = new Point(33, 165);
            dataGridViewSED.Margin = new Padding(3, 2, 3, 2);
            dataGridViewSED.Name = "dataGridViewSED";
            dataGridViewSED.ReadOnly = true;
            dataGridViewSED.RowHeadersVisible = false;
            dataGridViewSED.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewSED.RowTemplate.Height = 28;
            dataGridViewSED.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSED.Size = new Size(1587, 593);
            dataGridViewSED.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 121, 0);
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(223, 29);
            label3.Name = "label3";
            label3.Size = new Size(38, 45);
            label3.TabIndex = 54;
            label3.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 121, 0);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 49);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 53;
            label4.Text = "Total Attendance for today:";
            // 
            // labelDepartmentSED
            // 
            labelDepartmentSED.AutoSize = true;
            labelDepartmentSED.BackColor = Color.FromArgb(255, 121, 0);
            labelDepartmentSED.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDepartmentSED.ForeColor = Color.White;
            labelDepartmentSED.Location = new Point(15, 10);
            labelDepartmentSED.Name = "labelDepartmentSED";
            labelDepartmentSED.Size = new Size(66, 37);
            labelDepartmentSED.TabIndex = 48;
            labelDepartmentSED.Text = "SED";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(clearLabel);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonBackBtn);
            panel1.Controls.Add(dataGridViewSED);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1920, 1080);
            panel1.MinimumSize = new Size(800, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 861);
            panel1.TabIndex = 55;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Cursor = Cursors.Hand;
            clearLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearLabel.Location = new Point(1509, 760);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 77;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Firebrick;
            deleteButton.BackgroundImage = (Image)resources.GetObject("deleteButton.BackgroundImage");
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(1573, 128);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10, 0, 0, 0);
            deleteButton.Size = new Size(47, 32);
            deleteButton.TabIndex = 76;
            deleteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(33, 128);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 75;
            searchBox.TextChanged += searchBox_TextChanged;
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
            button4.Location = new Point(349, 128);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 32);
            button4.TabIndex = 73;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 121, 0);
            panel2.Controls.Add(labelDepartmentSED);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(84, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 85);
            panel2.TabIndex = 58;
            // 
            // buttonBackBtn
            // 
            buttonBackBtn.BackColor = Color.Transparent;
            buttonBackBtn.Cursor = Cursors.Hand;
            buttonBackBtn.FlatAppearance.BorderSize = 0;
            buttonBackBtn.FlatStyle = FlatStyle.Flat;
            buttonBackBtn.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBackBtn.Image = (Image)resources.GetObject("buttonBackBtn.Image");
            buttonBackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBackBtn.Location = new Point(33, 20);
            buttonBackBtn.Name = "buttonBackBtn";
            buttonBackBtn.Size = new Size(45, 48);
            buttonBackBtn.TabIndex = 57;
            buttonBackBtn.UseVisualStyleBackColor = false;
            buttonBackBtn.Click += buttonBackBtn_Click;
            // 
            // FormSED1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1682, 861);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormSED1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSED1";
            Load += FormSED1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSED).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label labelDepartmentSED;
        private Panel panel1;
        private Button buttonBackBtn;
        private Panel panel2;
        public DataGridView dataGridViewSED;
        private Button button4;
        private TextBox searchBox;
        private Button deleteButton;
        private Label clearLabel;
    }
}