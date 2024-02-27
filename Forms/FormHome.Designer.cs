namespace SCTAttendanceSystemUI.Forms
{
    partial class FormHome
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            labelDashboard = new Label();
            labelDashboardDate = new Label();
            dataGridViewAttendance = new DataGridView();
            filterButton = new Button();
            searchBox = new TextBox();
            exportButton = new Button();
            deleteButton = new Button();
            clearLabel = new Label();
            refreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.ForeColor = Color.Black;
            labelDashboard.Location = new Point(38, 32);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(267, 31);
            labelDashboard.TabIndex = 3;
            labelDashboard.Text = "ATTENDANCE FOR";
            // 
            // labelDashboardDate
            // 
            labelDashboardDate.AutoSize = true;
            labelDashboardDate.BackColor = Color.Transparent;
            labelDashboardDate.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboardDate.Location = new Point(296, 32);
            labelDashboardDate.Name = "labelDashboardDate";
            labelDashboardDate.Size = new Size(87, 31);
            labelDashboardDate.TabIndex = 17;
            labelDashboardDate.Text = "DATE";
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.AllowUserToAddRows = false;
            dataGridViewAttendance.AllowUserToDeleteRows = false;
            dataGridViewAttendance.AllowUserToResizeRows = false;
            dataGridViewAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAttendance.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewAttendance.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAttendance.Location = new Point(38, 131);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.ReadOnly = true;
            dataGridViewAttendance.RowHeadersVisible = false;
            dataGridViewAttendance.RowTemplate.Height = 25;
            dataGridViewAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAttendance.ShowCellErrors = false;
            dataGridViewAttendance.ShowCellToolTips = false;
            dataGridViewAttendance.ShowEditingIcon = false;
            dataGridViewAttendance.ShowRowErrors = false;
            dataGridViewAttendance.Size = new Size(1587, 593);
            dataGridViewAttendance.TabIndex = 22;
            dataGridViewAttendance.CellFormatting += dataGridView1_CellFormatting_1;
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
            filterButton.Location = new Point(354, 94);
            filterButton.Name = "filterButton";
            filterButton.Padding = new Padding(10, 0, 0, 0);
            filterButton.Size = new Size(47, 30);
            filterButton.TabIndex = 65;
            filterButton.TextAlign = ContentAlignment.MiddleLeft;
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += button4_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(38, 93);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.FromArgb(219, 20, 62);
            exportButton.Cursor = Cursors.Hand;
            exportButton.FlatAppearance.BorderSize = 0;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            exportButton.Image = (Image)resources.GetObject("exportButton.Image");
            exportButton.ImageAlign = ContentAlignment.MiddleLeft;
            exportButton.Location = new Point(1578, 95);
            exportButton.Name = "exportButton";
            exportButton.Padding = new Padding(10, 0, 0, 0);
            exportButton.Size = new Size(47, 30);
            exportButton.TabIndex = 71;
            exportButton.TextAlign = ContentAlignment.MiddleLeft;
            exportButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += button2_Click;
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
            deleteButton.Location = new Point(1525, 95);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10, 0, 0, 0);
            deleteButton.Size = new Size(47, 30);
            deleteButton.TabIndex = 72;
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
            clearLabel.Location = new Point(1514, 727);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 73;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(219, 20, 62);
            refreshButton.Cursor = Cursors.Hand;
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            refreshButton.Image = (Image)resources.GetObject("refreshButton.Image");
            refreshButton.ImageAlign = ContentAlignment.MiddleLeft;
            refreshButton.Location = new Point(407, 95);
            refreshButton.Name = "refreshButton";
            refreshButton.Padding = new Padding(10, 0, 0, 0);
            refreshButton.Size = new Size(47, 30);
            refreshButton.TabIndex = 74;
            refreshButton.TextAlign = ContentAlignment.MiddleLeft;
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Visible = false;
            refreshButton.Click += refreshButton_Click_1;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(refreshButton);
            Controls.Add(clearLabel);
            Controls.Add(deleteButton);
            Controls.Add(exportButton);
            Controls.Add(searchBox);
            Controls.Add(filterButton);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(labelDashboardDate);
            Controls.Add(labelDashboard);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            Load += FormHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDashboard;
        private Label labelDashboardDate;
        public DataGridView dataGridViewAttendance;
        private Button filterButton;
        private TextBox searchBox;
        private Button exportButton;
        private Button deleteButton;
        private Label clearLabel;
        private Button refreshButton;
    }
}