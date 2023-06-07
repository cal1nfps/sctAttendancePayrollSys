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
            this.labelPayroll = new System.Windows.Forms.Label();
            this.buttonOvertimeAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelFormOvertime = new System.Windows.Forms.Panel();
            this.labelCashAdvance = new System.Windows.Forms.Label();
            this.labelDeduction = new System.Windows.Forms.Label();
            this.labelGrossPay = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelEmployeeNo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelFormOvertime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPayroll
            // 
            this.labelPayroll.AutoSize = true;
            this.labelPayroll.BackColor = System.Drawing.Color.Transparent;
            this.labelPayroll.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPayroll.Location = new System.Drawing.Point(38, 32);
            this.labelPayroll.Name = "labelPayroll";
            this.labelPayroll.Size = new System.Drawing.Size(143, 31);
            this.labelPayroll.TabIndex = 8;
            this.labelPayroll.Text = "PAYROLL";
            // 
            // buttonOvertimeAdd
            // 
            this.buttonOvertimeAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(221)))), ((int)(((byte)(132)))));
            this.buttonOvertimeAdd.FlatAppearance.BorderSize = 0;
            this.buttonOvertimeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOvertimeAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOvertimeAdd.Image = global::SCTAttendanceSystemUI.Properties.Resources.export;
            this.buttonOvertimeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.Location = new System.Drawing.Point(726, 26);
            this.buttonOvertimeAdd.Name = "buttonOvertimeAdd";
            this.buttonOvertimeAdd.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonOvertimeAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonOvertimeAdd.TabIndex = 45;
            this.buttonOvertimeAdd.Text = "  PAYROLL";
            this.buttonOvertimeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOvertimeAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOvertimeAdd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(191)))), ((int)(((byte)(227)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::SCTAttendanceSystemUI.Properties.Resources.export;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(832, 26);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(100, 30);
            this.button2.TabIndex = 46;
            this.button2.Text = "   PAYSLIP";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // panelFormOvertime
            // 
            this.panelFormOvertime.BackColor = System.Drawing.Color.White;
            this.panelFormOvertime.Controls.Add(this.labelCashAdvance);
            this.panelFormOvertime.Controls.Add(this.labelDeduction);
            this.panelFormOvertime.Controls.Add(this.labelGrossPay);
            this.panelFormOvertime.Controls.Add(this.button2);
            this.panelFormOvertime.Controls.Add(this.buttonOvertimeAdd);
            this.panelFormOvertime.Controls.Add(this.labelFullName);
            this.panelFormOvertime.Controls.Add(this.labelEmployeeNo);
            this.panelFormOvertime.Location = new System.Drawing.Point(51, 90);
            this.panelFormOvertime.Name = "panelFormOvertime";
            this.panelFormOvertime.Size = new System.Drawing.Size(958, 80);
            this.panelFormOvertime.TabIndex = 47;
            // 
            // labelCashAdvance
            // 
            this.labelCashAdvance.AutoSize = true;
            this.labelCashAdvance.BackColor = System.Drawing.Color.Transparent;
            this.labelCashAdvance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCashAdvance.ForeColor = System.Drawing.Color.Gray;
            this.labelCashAdvance.Location = new System.Drawing.Point(608, 29);
            this.labelCashAdvance.Name = "labelCashAdvance";
            this.labelCashAdvance.Size = new System.Drawing.Size(74, 21);
            this.labelCashAdvance.TabIndex = 27;
            this.labelCashAdvance.Text = "NET PAY";
            // 
            // labelDeduction
            // 
            this.labelDeduction.AutoSize = true;
            this.labelDeduction.BackColor = System.Drawing.Color.Transparent;
            this.labelDeduction.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeduction.ForeColor = System.Drawing.Color.Gray;
            this.labelDeduction.Location = new System.Drawing.Point(466, 29);
            this.labelDeduction.Name = "labelDeduction";
            this.labelDeduction.Size = new System.Drawing.Size(104, 21);
            this.labelDeduction.TabIndex = 26;
            this.labelDeduction.Text = "DEDUCTION";
            // 
            // labelGrossPay
            // 
            this.labelGrossPay.AutoSize = true;
            this.labelGrossPay.BackColor = System.Drawing.Color.Transparent;
            this.labelGrossPay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGrossPay.ForeColor = System.Drawing.Color.Gray;
            this.labelGrossPay.Location = new System.Drawing.Point(329, 29);
            this.labelGrossPay.Name = "labelGrossPay";
            this.labelGrossPay.Size = new System.Drawing.Size(94, 21);
            this.labelGrossPay.TabIndex = 25;
            this.labelGrossPay.Text = "GROSS PAY";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.BackColor = System.Drawing.Color.Transparent;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFullName.ForeColor = System.Drawing.Color.Gray;
            this.labelFullName.Location = new System.Drawing.Point(186, 29);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(98, 21);
            this.labelFullName.TabIndex = 24;
            this.labelFullName.Text = "FULL NAME";
            // 
            // labelEmployeeNo
            // 
            this.labelEmployeeNo.AutoSize = true;
            this.labelEmployeeNo.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmployeeNo.ForeColor = System.Drawing.Color.Gray;
            this.labelEmployeeNo.Location = new System.Drawing.Point(28, 29);
            this.labelEmployeeNo.Name = "labelEmployeeNo";
            this.labelEmployeeNo.Size = new System.Drawing.Size(124, 21);
            this.labelEmployeeNo.TabIndex = 23;
            this.labelEmployeeNo.Text = "EMPLOYEE NO.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(51, 176);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(958, 353);
            this.dataGridView1.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(962, 54);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(47, 30);
            this.button1.TabIndex = 70;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelFormOvertime);
            this.Controls.Add(this.labelPayroll);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayroll";
            this.Load += new System.EventHandler(this.FormPayroll_Load_1);
            this.panelFormOvertime.ResumeLayout(false);
            this.panelFormOvertime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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