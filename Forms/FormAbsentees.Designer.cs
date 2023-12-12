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
            button4 = new Button();
            button2 = new Button();
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
            labelAbsenteesForToday.Size = new Size(341, 31);
            labelAbsenteesForToday.TabIndex = 6;
            labelAbsenteesForToday.Text = "ABSENTEES FOR TODAY";
            // 
            // labelAbsenteesDate
            // 
            labelAbsenteesDate.AutoSize = true;
            labelAbsenteesDate.BackColor = Color.Transparent;
            labelAbsenteesDate.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelAbsenteesDate.Location = new Point(1267, 38);
            labelAbsenteesDate.Name = "labelAbsenteesDate";
            labelAbsenteesDate.Size = new Size(71, 25);
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
            // button4
            // 
            button4.BackColor = Color.Green;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1525, 91);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 74;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(1578, 91);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(47, 30);
            button2.TabIndex = 76;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            Controls.Add(button2);
            Controls.Add(button4);
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
        private Button button4;
        private Button button2;
    }
}