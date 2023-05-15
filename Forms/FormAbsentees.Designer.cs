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
            this.labelAbsenteesForToday = new System.Windows.Forms.Label();
            this.panelFormAbsentees = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cboSheet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.dataGridViewAbsentees = new System.Windows.Forms.DataGridView();
            this.labelAbsenteesDate = new System.Windows.Forms.Label();
            this.labelSort = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFormAbsentees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsentees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAbsenteesForToday
            // 
            this.labelAbsenteesForToday.AutoSize = true;
            this.labelAbsenteesForToday.BackColor = System.Drawing.Color.Transparent;
            this.labelAbsenteesForToday.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbsenteesForToday.Location = new System.Drawing.Point(38, 32);
            this.labelAbsenteesForToday.Name = "labelAbsenteesForToday";
            this.labelAbsenteesForToday.Size = new System.Drawing.Size(341, 31);
            this.labelAbsenteesForToday.TabIndex = 6;
            this.labelAbsenteesForToday.Text = "ABSENTEES FOR TODAY";
            // 
            // panelFormAbsentees
            // 
            this.panelFormAbsentees.Controls.Add(this.buttonExport);
            this.panelFormAbsentees.Controls.Add(this.label4);
            this.panelFormAbsentees.Controls.Add(this.txtFilename);
            this.panelFormAbsentees.Controls.Add(this.cboSheet);
            this.panelFormAbsentees.Controls.Add(this.label3);
            this.panelFormAbsentees.Controls.Add(this.btnBrowse);
            this.panelFormAbsentees.Location = new System.Drawing.Point(62, 83);
            this.panelFormAbsentees.Name = "panelFormAbsentees";
            this.panelFormAbsentees.Size = new System.Drawing.Size(1237, 80);
            this.panelFormAbsentees.TabIndex = 14;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExport.Location = new System.Drawing.Point(1138, 32);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(75, 23);
            this.buttonExport.TabIndex = 43;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(962, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Sheet:";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilename.Location = new System.Drawing.Point(108, 32);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(726, 23);
            this.txtFilename.TabIndex = 38;
            // 
            // cboSheet
            // 
            this.cboSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSheet.FormattingEnabled = true;
            this.cboSheet.Location = new System.Drawing.Point(1006, 32);
            this.cboSheet.Name = "cboSheet";
            this.cboSheet.Size = new System.Drawing.Size(121, 23);
            this.cboSheet.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "File Name:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(858, 32);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 35;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAbsentees
            // 
            this.dataGridViewAbsentees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsentees.Location = new System.Drawing.Point(62, 186);
            this.dataGridViewAbsentees.Name = "dataGridViewAbsentees";
            this.dataGridViewAbsentees.RowTemplate.Height = 25;
            this.dataGridViewAbsentees.Size = new System.Drawing.Size(1237, 469);
            this.dataGridViewAbsentees.TabIndex = 15;
            // 
            // labelAbsenteesDate
            // 
            this.labelAbsenteesDate.AutoSize = true;
            this.labelAbsenteesDate.BackColor = System.Drawing.Color.Transparent;
            this.labelAbsenteesDate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAbsenteesDate.Location = new System.Drawing.Point(385, 32);
            this.labelAbsenteesDate.Name = "labelAbsenteesDate";
            this.labelAbsenteesDate.Size = new System.Drawing.Size(84, 25);
            this.labelAbsenteesDate.TabIndex = 16;
            this.labelAbsenteesDate.Text = "DATE: ";
            this.labelAbsenteesDate.Click += new System.EventHandler(this.labelAbsenteesDate_Click);
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.Location = new System.Drawing.Point(900, 34);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(47, 17);
            this.labelSort.TabIndex = 21;
            this.labelSort.Text = "Filter:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "All"});
            this.sortComboBox.Location = new System.Drawing.Point(950, 34);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(124, 23);
            this.sortComboBox.TabIndex = 20;
            this.sortComboBox.Text = "ABSENTS";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(62, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1237, 469);
            this.dataGridView2.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1100, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAbsentees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.labelAbsenteesDate);
            this.Controls.Add(this.dataGridViewAbsentees);
            this.Controls.Add(this.panelFormAbsentees);
            this.Controls.Add(this.labelAbsenteesForToday);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormAbsentees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbsentees";
            this.Load += new System.EventHandler(this.FormAbsentees_Load_1);
            this.panelFormAbsentees.ResumeLayout(false);
            this.panelFormAbsentees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsentees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelAbsenteesForToday;
        private Panel panelFormAbsentees;
        private DataGridView dataGridViewAbsentees;
        private Label labelAbsenteesDate;
        private Label labelSort;
        private ComboBox sortComboBox;
        private Label label4;
        private TextBox txtFilename;
        private ComboBox cboSheet;
        private Label label3;
        private Button btnBrowse;
        private DataGridView dataGridView2;
        private Button buttonExport;
        private Button button1;
    }
}