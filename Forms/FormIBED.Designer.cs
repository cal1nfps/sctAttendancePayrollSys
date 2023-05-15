namespace SCTAttendanceSystemUI.Forms
{
    partial class FormIBED
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
            labelIbedDepartment = new Label();
            dataGridView1 = new DataGridView();
            panelIbedDepartment = new Panel();
            buttonExport = new Button();
            label4 = new Label();
            cboSheet = new ComboBox();
            btnBrowse = new Button();
            label3 = new Label();
            txtFilename = new TextBox();
            dataGridView2 = new DataGridView();
            sortComboBox = new ComboBox();
            label1 = new Label();
            labelSort = new Label();
            sortENcomboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelIbedDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelIbedDepartment
            // 
            labelIbedDepartment.AutoSize = true;
            labelIbedDepartment.BackColor = Color.Transparent;
            labelIbedDepartment.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelIbedDepartment.Location = new Point(38, 32);
            labelIbedDepartment.Name = "labelIbedDepartment";
            labelIbedDepartment.Size = new Size(277, 31);
            labelIbedDepartment.TabIndex = 8;
            labelIbedDepartment.Text = "IBED DEPARTMENT";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1237, 514);
            dataGridView1.TabIndex = 10;
            // 
            // panelIbedDepartment
            // 
            panelIbedDepartment.Controls.Add(buttonExport);
            panelIbedDepartment.Controls.Add(label4);
            panelIbedDepartment.Controls.Add(cboSheet);
            panelIbedDepartment.Controls.Add(btnBrowse);
            panelIbedDepartment.Controls.Add(label3);
            panelIbedDepartment.Controls.Add(txtFilename);
            panelIbedDepartment.Location = new Point(62, 83);
            panelIbedDepartment.Name = "panelIbedDepartment";
            panelIbedDepartment.Size = new Size(1237, 80);
            panelIbedDepartment.TabIndex = 13;
            // 
            // buttonExport
            // 
            buttonExport.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.Location = new Point(1138, 30);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 39;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(962, 35);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 34;
            label4.Text = "Sheet:";
            // 
            // cboSheet
            // 
            cboSheet.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(1006, 31);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(121, 23);
            cboSheet.TabIndex = 32;
            cboSheet.SelectionChangeCommitted += cboSheet_SelectionChangeCommitted;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(858, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 30;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 35);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 31;
            label3.Text = "File Name:";
            // 
            // txtFilename
            // 
            txtFilename.BackColor = SystemColors.Control;
            txtFilename.Cursor = Cursors.IBeam;
            txtFilename.Location = new Point(111, 32);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(736, 23);
            txtFilename.TabIndex = 33;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(62, 186);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1237, 514);
            dataGridView2.TabIndex = 32;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = SystemColors.Control;
            sortComboBox.Cursor = Cursors.Hand;
            sortComboBox.FlatStyle = FlatStyle.Flat;
            sortComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "None", "A - Z", "Z - A" });
            sortComboBox.Location = new Point(919, 12);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(124, 23);
            sortComboBox.TabIndex = 36;
            sortComboBox.Text = "NAME";
            sortComboBox.SelectedIndexChanged += sortComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(875, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 35;
            label1.Text = "Sort:";
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.BackColor = Color.WhiteSmoke;
            labelSort.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSort.Location = new Point(875, 44);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(39, 17);
            labelSort.TabIndex = 34;
            labelSort.Text = "Sort:";
            // 
            // sortENcomboBox
            // 
            sortENcomboBox.BackColor = SystemColors.Control;
            sortENcomboBox.Cursor = Cursors.Hand;
            sortENcomboBox.FlatStyle = FlatStyle.Flat;
            sortENcomboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortENcomboBox.FormattingEnabled = true;
            sortENcomboBox.Items.AddRange(new object[] { "None", "Highest", "Lowest" });
            sortENcomboBox.Location = new Point(919, 41);
            sortENcomboBox.Name = "sortENcomboBox";
            sortENcomboBox.Size = new Size(124, 23);
            sortENcomboBox.TabIndex = 33;
            sortENcomboBox.Text = "EMPLOYEE NO.";
            sortENcomboBox.SelectedIndexChanged += sortENcomboBox_SelectedIndexChanged;
            // 
            // FormIBED
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(sortComboBox);
            Controls.Add(label1);
            Controls.Add(labelSort);
            Controls.Add(sortENcomboBox);
            Controls.Add(dataGridView2);
            Controls.Add(panelIbedDepartment);
            Controls.Add(dataGridView1);
            Controls.Add(labelIbedDepartment);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormIBED";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIBED";
            Load += FormIBED_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelIbedDepartment.ResumeLayout(false);
            panelIbedDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIbedDepartment;
        private DataGridView dataGridView1;
        private Panel panelIbedDepartment;
        private Label label4;
        private ComboBox cboSheet;
        private Button btnBrowse;
        private Label label3;
        private TextBox txtFilename;
        private DataGridView dataGridView2;
        private ComboBox sortComboBox;
        private Label label1;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private Button buttonExport;
    }
}