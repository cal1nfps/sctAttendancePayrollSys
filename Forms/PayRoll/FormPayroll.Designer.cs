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
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            labelCashAdvance = new Label();
            labelDeduction = new Label();
            labelGrossPay = new Label();
            labelFullName = new Label();
            labelEmployeeNo = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            button5 = new Button();
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
            buttonOvertimeAdd.Location = new Point(848, 54);
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
            button2.Location = new Point(954, 54);
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
            panelFormOvertime.Controls.Add(label4);
            panelFormOvertime.Controls.Add(label3);
            panelFormOvertime.Controls.Add(label1);
            panelFormOvertime.Controls.Add(label2);
            panelFormOvertime.Controls.Add(labelCashAdvance);
            panelFormOvertime.Controls.Add(labelDeduction);
            panelFormOvertime.Controls.Add(labelGrossPay);
            panelFormOvertime.Controls.Add(labelFullName);
            panelFormOvertime.Controls.Add(labelEmployeeNo);
            panelFormOvertime.Location = new Point(51, 90);
            panelFormOvertime.Name = "panelFormOvertime";
            panelFormOvertime.Size = new Size(1162, 80);
            panelFormOvertime.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(1059, 29);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 31;
            label4.Text = "DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(915, 29);
            label3.Name = "label3";
            label3.Size = new Size(119, 21);
            label3.TabIndex = 30;
            label3.Text = "PAYROLL TYPE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(451, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 29;
            label1.Text = "OCCUPATION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(314, 29);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 28;
            label2.Text = "DEPARTMENT";
            // 
            // labelCashAdvance
            // 
            labelCashAdvance.AutoSize = true;
            labelCashAdvance.BackColor = Color.Transparent;
            labelCashAdvance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCashAdvance.ForeColor = Color.Gray;
            labelCashAdvance.Location = new Point(819, 29);
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
            labelDeduction.Location = new Point(696, 29);
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
            labelGrossPay.Location = new Point(583, 29);
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
            dataGridView1.Size = new Size(1162, 353);
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
            button1.Location = new Point(1113, 54);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(47, 30);
            button1.TabIndex = 70;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Green;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(1166, 54);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(47, 30);
            button3.TabIndex = 72;
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Green;
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1060, 54);
            button5.Name = "button5";
            button5.Padding = new Padding(10, 0, 0, 0);
            button5.Size = new Size(47, 30);
            button5.TabIndex = 81;
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // FormPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(buttonOvertimeAdd);
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
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Button button5;
    }
}