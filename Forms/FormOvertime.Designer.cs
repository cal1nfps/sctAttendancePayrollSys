namespace SCTAttendanceSystemUI.Forms
{
    partial class FormOvertime
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
            this.labelOvertime = new System.Windows.Forms.Label();
            this.panelFormOvertime = new System.Windows.Forms.Panel();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelNoHours = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelOvertimeSort = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.labelOvertimeSort1 = new System.Windows.Forms.Label();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            this.buttonOvertimeAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFormOvertime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOvertime
            // 
            this.labelOvertime.AutoSize = true;
            this.labelOvertime.BackColor = System.Drawing.Color.Transparent;
            this.labelOvertime.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOvertime.Location = new System.Drawing.Point(38, 32);
            this.labelOvertime.Name = "labelOvertime";
            this.labelOvertime.Size = new System.Drawing.Size(162, 31);
            this.labelOvertime.TabIndex = 11;
            this.labelOvertime.Text = "OVERTIME";
            // 
            // panelFormOvertime
            // 
            this.panelFormOvertime.Controls.Add(this.labelRate);
            this.panelFormOvertime.Controls.Add(this.labelNoHours);
            this.panelFormOvertime.Controls.Add(this.labelName);
            this.panelFormOvertime.Controls.Add(this.labelEmployeeID);
            this.panelFormOvertime.Controls.Add(this.labelDate);
            this.panelFormOvertime.Location = new System.Drawing.Point(62, 140);
            this.panelFormOvertime.Name = "panelFormOvertime";
            this.panelFormOvertime.Size = new System.Drawing.Size(1237, 80);
            this.panelFormOvertime.TabIndex = 12;
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.BackColor = System.Drawing.Color.Transparent;
            this.labelRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRate.ForeColor = System.Drawing.Color.Gray;
            this.labelRate.Location = new System.Drawing.Point(890, 31);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(48, 21);
            this.labelRate.TabIndex = 28;
            this.labelRate.Text = "RATE";
            // 
            // labelNoHours
            // 
            this.labelNoHours.AutoSize = true;
            this.labelNoHours.BackColor = System.Drawing.Color.Transparent;
            this.labelNoHours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNoHours.ForeColor = System.Drawing.Color.Gray;
            this.labelNoHours.Location = new System.Drawing.Point(645, 31);
            this.labelNoHours.Name = "labelNoHours";
            this.labelNoHours.Size = new System.Drawing.Size(121, 21);
            this.labelNoHours.TabIndex = 27;
            this.labelNoHours.Text = "NO. OF HOURS";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.Gray;
            this.labelName.Location = new System.Drawing.Point(458, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 21);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "NAME";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoEllipsis = true;
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeID.ForeColor = System.Drawing.Color.Gray;
            this.labelEmployeeID.Location = new System.Drawing.Point(222, 31);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(113, 21);
            this.labelEmployeeID.TabIndex = 25;
            this.labelEmployeeID.Text = "EMPLOYEE ID";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.Gray;
            this.labelDate.Location = new System.Drawing.Point(59, 31);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(50, 21);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "DATE";
            // 
            // labelOvertimeSort
            // 
            this.labelOvertimeSort.AutoSize = true;
            this.labelOvertimeSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelOvertimeSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOvertimeSort.Location = new System.Drawing.Point(1094, 13);
            this.labelOvertimeSort.Name = "labelOvertimeSort";
            this.labelOvertimeSort.Size = new System.Drawing.Size(39, 17);
            this.labelOvertimeSort.TabIndex = 21;
            this.labelOvertimeSort.Text = "Sort:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "None",
            "A - Z",
            "Z - A"});
            this.sortComboBox.Location = new System.Drawing.Point(1138, 13);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(142, 23);
            this.sortComboBox.TabIndex = 22;
            this.sortComboBox.Text = "NAME";
            // 
            // labelOvertimeSort1
            // 
            this.labelOvertimeSort1.AutoSize = true;
            this.labelOvertimeSort1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelOvertimeSort1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOvertimeSort1.Location = new System.Drawing.Point(1094, 42);
            this.labelOvertimeSort1.Name = "labelOvertimeSort1";
            this.labelOvertimeSort1.Size = new System.Drawing.Size(39, 17);
            this.labelOvertimeSort1.TabIndex = 23;
            this.labelOvertimeSort1.Text = "Sort:";
            // 
            // sortENcomboBox
            // 
            this.sortENcomboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortENcomboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortENcomboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortENcomboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortENcomboBox.FormattingEnabled = true;
            this.sortENcomboBox.Items.AddRange(new object[] {
            "None",
            "Highest",
            "Lowest"});
            this.sortENcomboBox.Location = new System.Drawing.Point(1138, 42);
            this.sortENcomboBox.Name = "sortENcomboBox";
            this.sortENcomboBox.Size = new System.Drawing.Size(142, 23);
            this.sortENcomboBox.TabIndex = 24;
            this.sortENcomboBox.Text = "EMPLOYEE NUMBER";
            // 
            // buttonOvertimeAdd
            // 
            this.buttonOvertimeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.buttonOvertimeAdd.FlatAppearance.BorderSize = 0;
            this.buttonOvertimeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOvertimeAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOvertimeAdd.Image = global::SCTAttendanceSystemUI.Properties.Resources.add;
            this.buttonOvertimeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.Location = new System.Drawing.Point(92, 91);
            this.buttonOvertimeAdd.Name = "buttonOvertimeAdd";
            this.buttonOvertimeAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOvertimeAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonOvertimeAdd.TabIndex = 25;
            this.buttonOvertimeAdd.Text = "   ADD";
            this.buttonOvertimeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOvertimeAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 421);
            this.dataGridView1.TabIndex = 26;
            // 
            // FormOvertime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 755);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOvertimeAdd);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.labelOvertimeSort1);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.labelOvertimeSort);
            this.Controls.Add(this.panelFormOvertime);
            this.Controls.Add(this.labelOvertime);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormOvertime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOvertime";
            this.panelFormOvertime.ResumeLayout(false);
            this.panelFormOvertime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelOvertime;
        private Panel panelFormOvertime;
        private Label labelOvertimeSort;
        private ComboBox sortComboBox;
        private Label labelOvertimeSort1;
        private ComboBox sortENcomboBox;
        private Button buttonOvertimeAdd;
        private DataGridView dataGridView1;
        private Label labelNoHours;
        private Label labelName;
        private Label labelEmployeeID;
        private Label labelDate;
        private Label labelRate;
    }
}