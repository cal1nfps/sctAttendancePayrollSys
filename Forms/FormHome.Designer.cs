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
            sortENcomboBox = new ComboBox();
            labelSort = new Label();
            label1 = new Label();
            sortComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.Location = new Point(38, 32);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(370, 31);
            labelDashboard.TabIndex = 3;
            labelDashboard.Text = "ATTENDANCE FOR TODAY";
            // 
            // labelDashboardDate
            // 
            labelDashboardDate.AutoSize = true;
            labelDashboardDate.BackColor = Color.Transparent;
            labelDashboardDate.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboardDate.Location = new Point(414, 34);
            labelDashboardDate.Name = "labelDashboardDate";
            labelDashboardDate.Size = new Size(84, 25);
            labelDashboardDate.TabIndex = 17;
            labelDashboardDate.Text = "DATE: ";
            labelDashboardDate.Click += labelDashboardDate_Click_1;
            // 
            // sortENcomboBox
            // 
            sortENcomboBox.BackColor = SystemColors.Control;
            sortENcomboBox.Cursor = Cursors.Hand;
            sortENcomboBox.FlatStyle = FlatStyle.Flat;
            sortENcomboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortENcomboBox.FormattingEnabled = true;
            sortENcomboBox.Items.AddRange(new object[] { "None", "A - Z", "Z - A" });
            sortENcomboBox.Location = new Point(1059, 65);
            sortENcomboBox.Name = "sortENcomboBox";
            sortENcomboBox.Size = new Size(142, 23);
            sortENcomboBox.TabIndex = 18;
            sortENcomboBox.Text = "NAME";
            sortENcomboBox.SelectedIndexChanged += sortENcomboBox_SelectedIndexChanged_1;
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.BackColor = Color.WhiteSmoke;
            labelSort.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSort.Location = new Point(1015, 65);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(39, 17);
            labelSort.TabIndex = 19;
            labelSort.Text = "Sort:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(823, 65);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 20;
            label1.Text = "Sort:";
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = SystemColors.Control;
            sortComboBox.Cursor = Cursors.Hand;
            sortComboBox.FlatStyle = FlatStyle.Flat;
            sortComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "None", "Highest - Lowest", "Lowest - Highest" });
            sortComboBox.Location = new Point(867, 65);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(142, 23);
            sortComboBox.TabIndex = 21;
            sortComboBox.Text = "EMPLOYEE NUMBER";
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Location = new Point(103, 94);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1177, 514);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
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
            button4.Location = new Point(1233, 58);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 30);
            button4.TabIndex = 65;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(sortComboBox);
            Controls.Add(label1);
            Controls.Add(labelSort);
            Controls.Add(sortENcomboBox);
            Controls.Add(labelDashboardDate);
            Controls.Add(labelDashboard);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1680, 821);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHome";
            Load += FormHome_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDashboard;
        private Label labelDashboardDate;
        private ComboBox sortENcomboBox;
        private Label labelSort;
        private Label label1;
        private ComboBox sortComboBox;
        public DataGridView dataGridView1;
        private Button button4;
    }
}