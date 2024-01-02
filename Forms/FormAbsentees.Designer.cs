namespace SCTAttendanceSystemUI.Forms
{
    partial class FormAbsentees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbsentees));
            labelAbsenteesForToday = new Label();
            labelAbsenteesDate = new Label();
            dataGridViewAbsentees = new DataGridView();
            searchBox = new TextBox();
            filterButton = new Button();
            button2 = new Button();
            deleteButton = new Button();
            clearLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsentees).BeginInit();
            SuspendLayout();
            // 
            // labelAbsenteesForToday
            // 
            labelAbsenteesForToday.AutoSize = true;
            labelAbsenteesForToday.BackColor = Color.Transparent;
            labelAbsenteesForToday.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesForToday.Location = new Point(38, 32);
            labelAbsenteesForToday.Name = "labelAbsenteesForToday";
            labelAbsenteesForToday.Size = new Size(238, 31);
            labelAbsenteesForToday.TabIndex = 6;
            labelAbsenteesForToday.Text = "ABSENTEES FOR";
            // 
            // labelAbsenteesDate
            // 
            labelAbsenteesDate.AutoSize = true;
            labelAbsenteesDate.BackColor = Color.Transparent;
            labelAbsenteesDate.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesDate.Location = new Point(271, 32);
            labelAbsenteesDate.Name = "labelAbsenteesDate";
            labelAbsenteesDate.Size = new Size(87, 31);
            labelAbsenteesDate.TabIndex = 16;
            labelAbsenteesDate.Text = "DATE";
            labelAbsenteesDate.Click += labelAbsenteesDate_Click;
            // 
            // dataGridViewAbsentees
            // 
            dataGridViewAbsentees.AllowUserToAddRows = false;
            dataGridViewAbsentees.AllowUserToDeleteRows = false;
            dataGridViewAbsentees.AllowUserToResizeRows = false;
            dataGridViewAbsentees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAbsentees.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewAbsentees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAbsentees.Location = new Point(38, 127);
            dataGridViewAbsentees.Name = "dataGridViewAbsentees";
            dataGridViewAbsentees.ReadOnly = true;
            dataGridViewAbsentees.RowHeadersVisible = false;
            dataGridViewAbsentees.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAbsentees.RowTemplate.Height = 25;
            dataGridViewAbsentees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAbsentees.ShowCellErrors = false;
            dataGridViewAbsentees.ShowCellToolTips = false;
            dataGridViewAbsentees.ShowEditingIcon = false;
            dataGridViewAbsentees.ShowRowErrors = false;
            dataGridViewAbsentees.Size = new Size(1587, 593);
            dataGridViewAbsentees.TabIndex = 33;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(38, 89);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += searchBox_TextChanged;
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
            filterButton.Location = new Point(354, 89);
            filterButton.Name = "filterButton";
            filterButton.Padding = new Padding(10, 0, 0, 0);
            filterButton.Size = new Size(47, 32);
            filterButton.TabIndex = 74;
            filterButton.TextAlign = ContentAlignment.MiddleLeft;
            filterButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += button4_Click;
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
            button2.Location = new Point(1578, 91);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 32);
            button2.TabIndex = 76;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            deleteButton.Location = new Point(1525, 91);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10, 0, 0, 0);
            deleteButton.Size = new Size(47, 32);
            deleteButton.TabIndex = 77;
            deleteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Cursor = Cursors.Hand;
            clearLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearLabel.Location = new Point(1514, 723);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 78;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
            // 
            // FormAbsentees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(clearLabel);
            Controls.Add(deleteButton);
            Controls.Add(button2);
            Controls.Add(filterButton);
            Controls.Add(searchBox);
            Controls.Add(dataGridViewAbsentees);
            Controls.Add(labelAbsenteesDate);
            Controls.Add(labelAbsenteesForToday);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormAbsentees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbsentees";
            Load += FormAbsentees_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAbsentees).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAbsenteesForToday;
        private Label labelAbsenteesDate;
        private DataGridView dataGridViewAbsentees;
        private TextBox searchBox;
        private Button filterButton;
        private Button button2;
        private Button deleteButton;
        private Label clearLabel;
    }
}