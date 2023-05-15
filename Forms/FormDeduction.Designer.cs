namespace SCTAttendanceSystemUI.Forms
{
    partial class FormDeduction
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
            this.labelDeduction = new System.Windows.Forms.Label();
            this.labelDeductionSort = new System.Windows.Forms.Label();
            this.labelDeductionSort1 = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.sortENcomboBox = new System.Windows.Forms.ComboBox();
            this.buttonDeductionAdd = new System.Windows.Forms.Button();
            this.panelFormDeduction = new System.Windows.Forms.Panel();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelFormDeduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDeduction
            // 
            this.labelDeduction.AutoSize = true;
            this.labelDeduction.BackColor = System.Drawing.Color.Transparent;
            this.labelDeduction.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeduction.Location = new System.Drawing.Point(38, 32);
            this.labelDeduction.Name = "labelDeduction";
            this.labelDeduction.Size = new System.Drawing.Size(181, 31);
            this.labelDeduction.TabIndex = 12;
            this.labelDeduction.Text = "DEDUCTION";
            // 
            // labelDeductionSort
            // 
            this.labelDeductionSort.AutoSize = true;
            this.labelDeductionSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDeductionSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeductionSort.Location = new System.Drawing.Point(1094, 13);
            this.labelDeductionSort.Name = "labelDeductionSort";
            this.labelDeductionSort.Size = new System.Drawing.Size(39, 17);
            this.labelDeductionSort.TabIndex = 22;
            this.labelDeductionSort.Text = "Sort:";
            // 
            // labelDeductionSort1
            // 
            this.labelDeductionSort1.AutoSize = true;
            this.labelDeductionSort1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelDeductionSort1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeductionSort1.Location = new System.Drawing.Point(1094, 42);
            this.labelDeductionSort1.Name = "labelDeductionSort1";
            this.labelDeductionSort1.Size = new System.Drawing.Size(39, 17);
            this.labelDeductionSort1.TabIndex = 23;
            this.labelDeductionSort1.Text = "Sort:";
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
            this.sortComboBox.TabIndex = 24;
            this.sortComboBox.Text = "NAME";
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
            this.sortENcomboBox.TabIndex = 25;
            this.sortENcomboBox.Text = "EMPLOYEE NUMBER";
            // 
            // buttonDeductionAdd
            // 
            this.buttonDeductionAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.buttonDeductionAdd.FlatAppearance.BorderSize = 0;
            this.buttonDeductionAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeductionAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDeductionAdd.Image = global::SCTAttendanceSystemUI.Properties.Resources.add;
            this.buttonDeductionAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeductionAdd.Location = new System.Drawing.Point(92, 91);
            this.buttonDeductionAdd.Name = "buttonDeductionAdd";
            this.buttonDeductionAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDeductionAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonDeductionAdd.TabIndex = 26;
            this.buttonDeductionAdd.Text = "   ADD";
            this.buttonDeductionAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeductionAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeductionAdd.UseVisualStyleBackColor = false;
            // 
            // panelFormDeduction
            // 
            this.panelFormDeduction.Controls.Add(this.labelAmount);
            this.panelFormDeduction.Controls.Add(this.labelDescription);
            this.panelFormDeduction.Location = new System.Drawing.Point(62, 140);
            this.panelFormDeduction.Name = "panelFormDeduction";
            this.panelFormDeduction.Size = new System.Drawing.Size(1237, 80);
            this.panelFormDeduction.TabIndex = 27;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.ForeColor = System.Drawing.Color.Gray;
            this.labelAmount.Location = new System.Drawing.Point(544, 30);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(82, 21);
            this.labelAmount.TabIndex = 26;
            this.labelAmount.Text = "AMOUNT";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.BackColor = System.Drawing.Color.Transparent;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.ForeColor = System.Drawing.Color.Gray;
            this.labelDescription.Location = new System.Drawing.Point(117, 30);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(114, 21);
            this.labelDescription.TabIndex = 25;
            this.labelDescription.Text = "DESCRIPTION";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 427);
            this.dataGridView1.TabIndex = 28;
            // 
            // FormDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1378, 756);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFormDeduction);
            this.Controls.Add(this.buttonDeductionAdd);
            this.Controls.Add(this.sortENcomboBox);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.labelDeductionSort1);
            this.Controls.Add(this.labelDeductionSort);
            this.Controls.Add(this.labelDeduction);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormDeduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDeduction";
            this.panelFormDeduction.ResumeLayout(false);
            this.panelFormDeduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelDeduction;
        private Label labelDeductionSort;
        private Label labelDeductionSort1;
        private ComboBox sortComboBox;
        private ComboBox sortENcomboBox;
        private Button buttonDeductionAdd;
        private Panel panelFormDeduction;
        private DataGridView dataGridView1;
        private Label labelAmount;
        private Label labelDescription;
    }
}