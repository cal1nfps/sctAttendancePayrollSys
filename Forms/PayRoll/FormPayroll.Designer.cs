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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            labelPayroll = new Label();
            buttonOvertimeAdd = new Button();
            button2 = new Button();
            panelFormOvertime = new Panel();
            labelCashAdvance = new Label();
            labelDeduction = new Label();
            labelGrossPay = new Label();
            labelFullName = new Label();
            labelEmployeeNo = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
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
            // buttonOvertimeAdd
            // 
            buttonOvertimeAdd.BackColor = Color.FromArgb(145, 221, 132);
            buttonOvertimeAdd.FlatAppearance.BorderSize = 0;
            buttonOvertimeAdd.FlatStyle = FlatStyle.Flat;
            buttonOvertimeAdd.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOvertimeAdd.Image = Properties.Resources.export;
            buttonOvertimeAdd.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOvertimeAdd.Location = new Point(726, 26);
            buttonOvertimeAdd.Name = "buttonOvertimeAdd";
            buttonOvertimeAdd.Padding = new Padding(10, 0, 0, 0);
            buttonOvertimeAdd.Size = new Size(100, 30);
            buttonOvertimeAdd.TabIndex = 45;
            buttonOvertimeAdd.Text = "  PAYROLL";
            buttonOvertimeAdd.TextAlign = ContentAlignment.MiddleLeft;
            buttonOvertimeAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonOvertimeAdd.UseVisualStyleBackColor = false;
            buttonOvertimeAdd.Click += buttonOvertimeAdd_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(150, 191, 227);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources.export;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(832, 26);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(100, 30);
            button2.TabIndex = 46;
            button2.Text = "   PAYSLIP";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panelFormOvertime
            // 
            panelFormOvertime.BackColor = Color.White;
            panelFormOvertime.Controls.Add(labelCashAdvance);
            panelFormOvertime.Controls.Add(labelDeduction);
            panelFormOvertime.Controls.Add(labelGrossPay);
            panelFormOvertime.Controls.Add(button2);
            panelFormOvertime.Controls.Add(buttonOvertimeAdd);
            panelFormOvertime.Controls.Add(labelFullName);
            panelFormOvertime.Controls.Add(labelEmployeeNo);
            panelFormOvertime.Location = new Point(51, 90);
            panelFormOvertime.Name = "panelFormOvertime";
            panelFormOvertime.Size = new Size(958, 80);
            panelFormOvertime.TabIndex = 47;
            // 
            // labelCashAdvance
            // 
            labelCashAdvance.AutoSize = true;
            labelCashAdvance.BackColor = Color.Transparent;
            labelCashAdvance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCashAdvance.ForeColor = Color.Gray;
            labelCashAdvance.Location = new Point(608, 29);
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
            labelDeduction.Location = new Point(466, 29);
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
            labelGrossPay.Location = new Point(329, 29);
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
            labelFullName.Location = new Point(186, 29);
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
            labelEmployeeNo.Location = new Point(28, 29);
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
            dataGridView1.Location = new Point(51, 176);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(958, 353);
            dataGridView1.TabIndex = 54;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(962, 54);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 30);
            button1.TabIndex = 70;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panelFormOvertime);
            Controls.Add(labelPayroll);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "FormPayroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPayroll";
            Load += FormPayroll_Load_1;
            panelFormOvertime.ResumeLayout(false);
            panelFormOvertime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPayroll;
        private Button buttonOvertimeAdd;
        private Button button2;
        private Panel panelFormOvertime;
        private Label labelEmployeeNo;
        private Label labelCashAdvance;
        private Label labelDeduction;
        private Label labelGrossPay;
        private Label labelFullName;
        private DataGridView dataGridView1;
        private Button button1;
    }
}