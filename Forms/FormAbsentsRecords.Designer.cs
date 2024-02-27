namespace SCTAttendanceSystemUI.Forms
{
    partial class FormAbsentsRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbsentsRecords));
            filterButton = new Button();
            searchBox = new TextBox();
            cancelButton = new Button();
            applyButton = new Button();
            dateTimePickerFilter = new DateTimePicker();
            dateFilterButton = new Button();
            clearLabel = new Label();
            deleteButton = new Button();
            button2 = new Button();
            labelAbsenteesForToday = new Label();
            dataGridViewAbsentsRecords = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsentsRecords).BeginInit();
            SuspendLayout();
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.FromArgb(219, 20, 62);
            filterButton.Cursor = Cursors.Hand;
            filterButton.FlatAppearance.BorderSize = 0;
            filterButton.FlatStyle = FlatStyle.Flat;
            filterButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            filterButton.Image = (Image)resources.GetObject("filterButton.Image");
            filterButton.ImageAlign = ContentAlignment.MiddleLeft;
            filterButton.Location = new Point(356, 96);
            filterButton.Name = "filterButton";
            filterButton.Padding = new Padding(10, 0, 0, 0);
            filterButton.Size = new Size(47, 32);
            filterButton.TabIndex = 77;
            filterButton.TextAlign = ContentAlignment.MiddleLeft;
            filterButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(40, 96);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 75;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.DimGray;
            cancelButton.ImageAlign = ContentAlignment.MiddleLeft;
            cancelButton.Location = new Point(668, 96);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(71, 29);
            cancelButton.TabIndex = 86;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
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
            applyButton.Location = new Point(745, 94);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(71, 29);
            applyButton.TabIndex = 85;
            applyButton.Text = "Apply";
            applyButton.UseMnemonic = false;
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // dateTimePickerFilter
            // 
            dateTimePickerFilter.Location = new Point(462, 100);
            dateTimePickerFilter.MaxDate = new DateTime(2099, 12, 31, 0, 0, 0, 0);
            dateTimePickerFilter.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePickerFilter.Name = "dateTimePickerFilter";
            dateTimePickerFilter.Size = new Size(200, 23);
            dateTimePickerFilter.TabIndex = 84;
            // 
            // dateFilterButton
            // 
            dateFilterButton.BackColor = Color.FromArgb(219, 20, 62);
            dateFilterButton.Cursor = Cursors.Hand;
            dateFilterButton.FlatAppearance.BorderSize = 0;
            dateFilterButton.FlatStyle = FlatStyle.Flat;
            dateFilterButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dateFilterButton.Image = (Image)resources.GetObject("dateFilterButton.Image");
            dateFilterButton.ImageAlign = ContentAlignment.MiddleLeft;
            dateFilterButton.Location = new Point(409, 96);
            dateFilterButton.Name = "dateFilterButton";
            dateFilterButton.Padding = new Padding(10, 0, 0, 0);
            dateFilterButton.Size = new Size(47, 32);
            dateFilterButton.TabIndex = 83;
            dateFilterButton.TextAlign = ContentAlignment.MiddleLeft;
            dateFilterButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            dateFilterButton.UseVisualStyleBackColor = false;
            dateFilterButton.Click += dateFilterButton_Click;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Cursor = Cursors.Hand;
            clearLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearLabel.Location = new Point(1516, 730);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 89;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(219, 20, 62);
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(1527, 96);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10, 0, 0, 0);
            deleteButton.Size = new Size(47, 32);
            deleteButton.TabIndex = 88;
            deleteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(219, 20, 62);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1580, 96);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 32);
            button2.TabIndex = 87;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelAbsenteesForToday
            // 
            labelAbsenteesForToday.AutoSize = true;
            labelAbsenteesForToday.BackColor = Color.Transparent;
            labelAbsenteesForToday.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesForToday.Location = new Point(40, 39);
            labelAbsenteesForToday.Name = "labelAbsenteesForToday";
            labelAbsenteesForToday.Size = new Size(314, 31);
            labelAbsenteesForToday.TabIndex = 90;
            labelAbsenteesForToday.Text = "ABSENTEES RECORDS";
            // 
            // dataGridViewAbsentsRecords
            // 
            dataGridViewAbsentsRecords.AllowUserToAddRows = false;
            dataGridViewAbsentsRecords.AllowUserToResizeRows = false;
            dataGridViewAbsentsRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAbsentsRecords.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewAbsentsRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAbsentsRecords.Location = new Point(40, 134);
            dataGridViewAbsentsRecords.Name = "dataGridViewAbsentsRecords";
            dataGridViewAbsentsRecords.ReadOnly = true;
            dataGridViewAbsentsRecords.RowHeadersVisible = false;
            dataGridViewAbsentsRecords.RowTemplate.Height = 25;
            dataGridViewAbsentsRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAbsentsRecords.Size = new Size(1587, 593);
            dataGridViewAbsentsRecords.TabIndex = 91;
            dataGridViewAbsentsRecords.CellFormatting += dataGridViewAbsentsRecords_CellFormatting;
            // 
            // FormAbsentsRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(dataGridViewAbsentsRecords);
            Controls.Add(labelAbsenteesForToday);
            Controls.Add(clearLabel);
            Controls.Add(deleteButton);
            Controls.Add(button2);
            Controls.Add(cancelButton);
            Controls.Add(applyButton);
            Controls.Add(dateTimePickerFilter);
            Controls.Add(dateFilterButton);
            Controls.Add(filterButton);
            Controls.Add(searchBox);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormAbsentsRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbsentsRecords";
            Load += FormAbsentsRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsentsRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button filterButton;
        private TextBox searchBox;
        private Button cancelButton;
        private Button applyButton;
        private DateTimePicker dateTimePickerFilter;
        private Button dateFilterButton;
        private Label clearLabel;
        private Button deleteButton;
        private Button button2;
        private Label labelAbsenteesForToday;
        public DataGridView dataGridViewAbsentsRecords;
    }
}