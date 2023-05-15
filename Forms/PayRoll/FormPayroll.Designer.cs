namespace SCTAttendanceSystemUI.Forms
{
    partial class FormPayroll
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
            labelPayroll = new Label();
            labelFrom = new Label();
            labelTo = new Label();
            fromDateTimePicker = new DateTimePicker();
            toDateTimePicker = new DateTimePicker();
            buttonDateTimePicker = new Button();
            button1 = new Button();
            label1 = new Label();
            sortComboBox = new ComboBox();
            labelSort = new Label();
            sortENcomboBox = new ComboBox();
            buttonOvertimeAdd = new Button();
            button2 = new Button();
            panelFormOvertime = new Panel();
            labelNetPay = new Label();
            labelCashAdvance = new Label();
            labelDeduction = new Label();
            labelGrossPay = new Label();
            labelFullName = new Label();
            labelEmployeeNo = new Label();
            dataGridView1 = new DataGridView();
            panelFormOvertime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelPayroll
            // 
            labelPayroll.AutoSize = true;
            labelPayroll.BackColor = Color.Transparent;
            labelPayroll.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelPayroll.Location = new Point(38, 32);
            labelPayroll.Name = "labelPayroll";
            labelPayroll.Size = new Size(143, 31);
            labelPayroll.TabIndex = 8;
            labelPayroll.Text = "PAYROLL";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.BackColor = Color.WhiteSmoke;
            labelFrom.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFrom.Location = new Point(870, 16);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(46, 17);
            labelFrom.TabIndex = 35;
            labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.BackColor = Color.WhiteSmoke;
            labelTo.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelTo.Location = new Point(870, 48);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(27, 17);
            labelTo.TabIndex = 36;
            labelTo.Text = "To:";
            // 
            // fromDateTimePicker
            // 
            fromDateTimePicker.CustomFormat = "MM/dd/yyyy";
            fromDateTimePicker.Format = DateTimePickerFormat.Custom;
            fromDateTimePicker.Location = new Point(919, 13);
            fromDateTimePicker.Name = "fromDateTimePicker";
            fromDateTimePicker.Size = new Size(88, 23);
            fromDateTimePicker.TabIndex = 37;
            fromDateTimePicker.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // toDateTimePicker
            // 
            toDateTimePicker.CustomFormat = "MM/dd/yyyy";
            toDateTimePicker.Format = DateTimePickerFormat.Custom;
            toDateTimePicker.Location = new Point(919, 42);
            toDateTimePicker.Name = "toDateTimePicker";
            toDateTimePicker.Size = new Size(88, 23);
            toDateTimePicker.TabIndex = 38;
            toDateTimePicker.Value = new DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // buttonDateTimePicker
            // 
            buttonDateTimePicker.BackColor = Color.White;
            buttonDateTimePicker.BackgroundImageLayout = ImageLayout.None;
            buttonDateTimePicker.FlatStyle = FlatStyle.Popup;
            buttonDateTimePicker.Location = new Point(1015, 13);
            buttonDateTimePicker.Name = "buttonDateTimePicker";
            buttonDateTimePicker.Size = new Size(49, 23);
            buttonDateTimePicker.TabIndex = 39;
            buttonDateTimePicker.Text = "Filter";
            buttonDateTimePicker.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(1015, 42);
            button1.Name = "button1";
            button1.Size = new Size(50, 23);
            button1.TabIndex = 40;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1094, 13);
            label1.Name = "label1";
            label1.Size = new Size(39, 17);
            label1.TabIndex = 41;
            label1.Text = "Sort:";
            // 
            // sortComboBox
            // 
            sortComboBox.BackColor = SystemColors.Control;
            sortComboBox.Cursor = Cursors.Hand;
            sortComboBox.FlatStyle = FlatStyle.Flat;
            sortComboBox.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point);
            sortComboBox.FormattingEnabled = true;
            sortComboBox.Items.AddRange(new object[] { "None", "A - Z", "Z - A" });
            sortComboBox.Location = new Point(1138, 13);
            sortComboBox.Name = "sortComboBox";
            sortComboBox.Size = new Size(142, 23);
            sortComboBox.TabIndex = 42;
            sortComboBox.Text = "NAME";
            // 
            // labelSort
            // 
            labelSort.AutoSize = true;
            labelSort.BackColor = Color.WhiteSmoke;
            labelSort.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSort.Location = new Point(1094, 42);
            labelSort.Name = "labelSort";
            labelSort.Size = new Size(39, 17);
            labelSort.TabIndex = 43;
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
            sortENcomboBox.Location = new Point(1138, 42);
            sortENcomboBox.Name = "sortENcomboBox";
            sortENcomboBox.Size = new Size(142, 23);
            sortENcomboBox.TabIndex = 44;
            sortENcomboBox.Text = "EMPLOYEE NUMBER";
            // 
            // buttonOvertimeAdd
            // 
            buttonOvertimeAdd.BackColor = Color.FromArgb(145, 221, 132);
            buttonOvertimeAdd.FlatAppearance.BorderSize = 0;
            buttonOvertimeAdd.FlatStyle = FlatStyle.Flat;
            buttonOvertimeAdd.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOvertimeAdd.Image = Properties.Resources.export;
            buttonOvertimeAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOvertimeAdd.Location = new Point(609, 29);
            buttonOvertimeAdd.Name = "buttonOvertimeAdd";
            buttonOvertimeAdd.Padding = new Padding(10, 0, 0, 0);
            buttonOvertimeAdd.Size = new Size(100, 30);
            buttonOvertimeAdd.TabIndex = 45;
            buttonOvertimeAdd.Text = "  PAYROLL";
            buttonOvertimeAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonOvertimeAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOvertimeAdd.UseVisualStyleBackColor = false;
            buttonOvertimeAdd.Click += buttonOvertimeAdd_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(150, 191, 227);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.export;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(732, 29);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(100, 30);
            button2.TabIndex = 46;
            button2.Text = "   PAYSLIP";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            // 
            // panelFormOvertime
            // 
            panelFormOvertime.BackColor = Color.White;
            panelFormOvertime.Controls.Add(labelNetPay);
            panelFormOvertime.Controls.Add(labelCashAdvance);
            panelFormOvertime.Controls.Add(labelDeduction);
            panelFormOvertime.Controls.Add(labelGrossPay);
            panelFormOvertime.Controls.Add(labelFullName);
            panelFormOvertime.Controls.Add(labelEmployeeNo);
            panelFormOvertime.Location = new Point(51, 90);
            panelFormOvertime.Name = "panelFormOvertime";
            panelFormOvertime.Size = new Size(1237, 80);
            panelFormOvertime.TabIndex = 47;
            // 
            // labelNetPay
            // 
            labelNetPay.AutoSize = true;
            labelNetPay.BackColor = Color.Transparent;
            labelNetPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNetPay.ForeColor = Color.Gray;
            labelNetPay.Location = new Point(1032, 29);
            labelNetPay.Name = "labelNetPay";
            labelNetPay.Size = new Size(132, 21);
            labelNetPay.TabIndex = 28;
            labelNetPay.Text = "CASH ADVANCE";
            // 
            // labelCashAdvance
            // 
            labelCashAdvance.AutoSize = true;
            labelCashAdvance.BackColor = Color.Transparent;
            labelCashAdvance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCashAdvance.ForeColor = Color.Gray;
            labelCashAdvance.Location = new Point(857, 29);
            labelCashAdvance.Name = "labelCashAdvance";
            labelCashAdvance.Size = new Size(74, 21);
            labelCashAdvance.TabIndex = 27;
            labelCashAdvance.Text = "NET PAY";
            // 
            // labelDeduction
            // 
            labelDeduction.AutoSize = true;
            labelDeduction.BackColor = Color.Transparent;
            labelDeduction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDeduction.ForeColor = Color.Gray;
            labelDeduction.Location = new Point(652, 29);
            labelDeduction.Name = "labelDeduction";
            labelDeduction.Size = new Size(104, 21);
            labelDeduction.TabIndex = 26;
            labelDeduction.Text = "DEDUCTION";
            // 
            // labelGrossPay
            // 
            labelGrossPay.AutoSize = true;
            labelGrossPay.BackColor = Color.Transparent;
            labelGrossPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrossPay.ForeColor = Color.Gray;
            labelGrossPay.Location = new Point(448, 29);
            labelGrossPay.Name = "labelGrossPay";
            labelGrossPay.Size = new Size(94, 21);
            labelGrossPay.TabIndex = 25;
            labelGrossPay.Text = "GROSS PAY";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.BackColor = Color.Transparent;
            labelFullName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFullName.ForeColor = Color.Gray;
            labelFullName.Location = new Point(255, 29);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(98, 21);
            labelFullName.TabIndex = 24;
            labelFullName.Text = "FULL NAME";
            // 
            // labelEmployeeNo
            // 
            labelEmployeeNo.AutoSize = true;
            labelEmployeeNo.BackColor = Color.Transparent;
            labelEmployeeNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmployeeNo.ForeColor = Color.Gray;
            labelEmployeeNo.Location = new Point(54, 29);
            labelEmployeeNo.Name = "labelEmployeeNo";
            labelEmployeeNo.Size = new Size(124, 21);
            labelEmployeeNo.TabIndex = 23;
            labelEmployeeNo.Text = "EMPLOYEE NO.";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(51, 198);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1237, 419);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting_1;
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridView1);
            Controls.Add(panelFormOvertime);
            Controls.Add(button2);
            Controls.Add(buttonOvertimeAdd);
            Controls.Add(sortENcomboBox);
            Controls.Add(labelSort);
            Controls.Add(sortComboBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonDateTimePicker);
            Controls.Add(toDateTimePicker);
            Controls.Add(fromDateTimePicker);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Controls.Add(labelPayroll);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormPayroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPayroll";
            Load += FormPayroll_Load;
            panelFormOvertime.ResumeLayout(false);
            panelFormOvertime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPayroll;
        private Label labelFrom;
        private Label labelTo;
        private DateTimePicker fromDateTimePicker;
        private DateTimePicker toDateTimePicker;
        private Button buttonDateTimePicker;
        private Button button1;
        private Label label1;
        private ComboBox sortComboBox;
        private Label labelSort;
        private ComboBox sortENcomboBox;
        private Button buttonOvertimeAdd;
        private Button button2;
        private Panel panelFormOvertime;
        private Label labelEmployeeNo;
        private Label labelNetPay;
        private Label labelCashAdvance;
        private Label labelDeduction;
        private Label labelGrossPay;
        private Label labelFullName;
        private DataGridView dataGridView1;
    }
}