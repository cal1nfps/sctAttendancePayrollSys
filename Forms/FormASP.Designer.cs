namespace SCTAttendanceSystemUI.Forms
{
    partial class FormASP
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
            labelAspDepartment = new Label();
            panelAspDepartment = new Panel();
            buttonExport = new Button();
            label4 = new Label();
            cboSheet = new ComboBox();
            btnBrowse = new Button();
            label3 = new Label();
            txtFilename = new TextBox();
            dataGridView1 = new DataGridView();
            sortComboBox = new ComboBox();
            label1 = new Label();
            labelSort = new Label();
            sortENcomboBox = new ComboBox();
            dataGridView2 = new DataGridView();
            panelAspDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // labelAspDepartment
            // 
            labelAspDepartment.AutoSize = true;
            labelAspDepartment.BackColor = Color.Transparent;
            labelAspDepartment.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAspDepartment.Location = new Point(38, 32);
            labelAspDepartment.Name = "labelAspDepartment";
            labelAspDepartment.Size = new Size(261, 31);
            labelAspDepartment.TabIndex = 6;
            labelAspDepartment.Text = "ASP DEPARTMENT";
            // 
            // panelAspDepartment
            // 
            panelAspDepartment.Controls.Add(buttonExport);
            panelAspDepartment.Controls.Add(label4);
            panelAspDepartment.Controls.Add(cboSheet);
            panelAspDepartment.Controls.Add(btnBrowse);
            panelAspDepartment.Controls.Add(label3);
            panelAspDepartment.Controls.Add(txtFilename);
            panelAspDepartment.Location = new Point(62, 83);
            panelAspDepartment.Name = "panelAspDepartment";
            panelAspDepartment.Size = new Size(1237, 80);
            panelAspDepartment.TabIndex = 15;
            // 
            // buttonExport
            // 
            buttonExport.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExport.Location = new Point(1138, 30);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 42;
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
            label4.TabIndex = 39;
            label4.Text = "Sheet:";
            // 
            // cboSheet
            // 
            cboSheet.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSheet.FormattingEnabled = true;
            cboSheet.Location = new Point(1006, 31);
            cboSheet.Name = "cboSheet";
            cboSheet.Size = new Size(121, 23);
            cboSheet.TabIndex = 37;
            cboSheet.SelectionChangeCommitted += cboSheet_SelectionChangeCommitted;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(858, 31);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 35;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 32);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 36;
            label3.Text = "File Name:";
            // 
            // txtFilename
            // 
            txtFilename.BackColor = SystemColors.Control;
            txtFilename.Cursor = Cursors.IBeam;
            txtFilename.Location = new Point(108, 29);
            txtFilename.Name = "txtFilename";
            txtFilename.ReadOnly = true;
            txtFilename.Size = new Size(740, 23);
            txtFilename.TabIndex = 38;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1237, 514);
            dataGridView1.TabIndex = 16;
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
            sortComboBox.TabIndex = 40;
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
            label1.TabIndex = 39;
            label1.Text = "Sort:";
            label1.Click += label1_Click;
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.BackColor = Color.WhiteSmoke;
            labelSort.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSort.Location = new Point(875, 41);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(39, 17);
            labelSort.TabIndex = 38;
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
            sortENcomboBox.TabIndex = 37;
            sortENcomboBox.Text = "EMPLOYEE NO.";
            sortENcomboBox.SelectedIndexChanged += sortENcomboBox_SelectedIndexChanged;
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
            dataGridView2.TabIndex = 41;
            dataGridView2.CellFormatting += dataGridView2_CellFormatting;
            // 
            // FormASP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView2);
            Controls.Add(sortComboBox);
            Controls.Add(label1);
            Controls.Add(labelSort);
            Controls.Add(sortENcomboBox);
            Controls.Add(dataGridView1);
            Controls.Add(panelAspDepartment);
            Controls.Add(labelAspDepartment);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormASP";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormASP";
            panelAspDepartment.ResumeLayout(false);
            panelAspDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAspDepartment;
        private Panel panelAspDepartment;
        private DataGridView dataGridView1;
        private Label label4;
        private ComboBox cboSheet;
        private Button btnBrowse;
        private Label label3;
        private TextBox txtFilename;
        private ComboBox sortComboBox;
        private Label label1;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private DataGridView dataGridView2;
        private Button buttonExport;
    }
}