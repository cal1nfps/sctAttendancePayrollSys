namespace SCTAttendanceSystemUI.Forms
{
    partial class FormViewRecords
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
            labelViewRecords = new Label();
            dataGridView1 = new DataGridView();
            labelViewRecordsSort = new Label();
            sortComboBoxViewRecords = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelViewRecords
            // 
            labelViewRecords.AutoSize = true;
            labelViewRecords.BackColor = Color.Transparent;
            labelViewRecords.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelViewRecords.Location = new Point(38, 32);
            labelViewRecords.Name = "labelViewRecords";
            labelViewRecords.Size = new Size(230, 31);
            labelViewRecords.TabIndex = 4;
            labelViewRecords.Text = "VIEW RECORDS";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1490, 734);
            dataGridView1.TabIndex = 5;
            // 
            // labelViewRecordsSort
            // 
            labelViewRecordsSort.AutoSize = true;
            labelViewRecordsSort.BackColor = Color.WhiteSmoke;
            labelViewRecordsSort.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelViewRecordsSort.Location = new Point(1327, 45);
            labelViewRecordsSort.Name = "labelViewRecordsSort";
            labelViewRecordsSort.Size = new Size(39, 17);
            labelViewRecordsSort.TabIndex = 21;
            labelViewRecordsSort.Text = "Sort:";
            // 
            // sortComboBoxViewRecords
            // 
            sortComboBoxViewRecords.BackColor = SystemColors.Control;
            sortComboBoxViewRecords.Cursor = Cursors.Hand;
            sortComboBoxViewRecords.FlatStyle = FlatStyle.Flat;
            sortComboBoxViewRecords.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortComboBoxViewRecords.FormattingEnabled = true;
            sortComboBoxViewRecords.Items.AddRange(new object[] { "Employee", "None" });
            sortComboBoxViewRecords.Location = new Point(1372, 42);
            sortComboBoxViewRecords.Name = "sortComboBoxViewRecords";
            sortComboBoxViewRecords.Size = new Size(142, 23);
            sortComboBoxViewRecords.TabIndex = 22;
            sortComboBoxViewRecords.Text = "Employee";
            // 
            // FormViewRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(sortComboBoxViewRecords);
            Controls.Add(labelViewRecordsSort);
            Controls.Add(dataGridView1);
            Controls.Add(labelViewRecords);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormViewRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormViewRecords";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelViewRecords;
        private DataGridView dataGridView1;
        private Label labelViewRecordsSort;
        private ComboBox sortComboBoxViewRecords;
    }
}