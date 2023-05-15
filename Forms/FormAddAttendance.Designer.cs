namespace SCTAttendanceSystemUI.Forms
{
    partial class FormAddAttendance
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
            panelManualInputs = new Panel();
            textBoxManualClockOut = new TextBox();
            labelManualClockOut = new Label();
            buttonSaveManualInput = new Button();
            textBoxManualClockIn = new TextBox();
            labelManualClockIn = new Label();
            textBoxManualDate = new TextBox();
            labelManualDate = new Label();
            textBoxManualDepartment = new TextBox();
            labelManualName = new Label();
            textBoxManualName = new TextBox();
            labelManualDepartment = new Label();
            labelManualEmployeeNumber = new Label();
            textBoxManualEmployeeNumber = new TextBox();
            labelManualInput = new Label();
            panelAutomaticInputs = new Panel();
            labelAutomaticInputDate = new Label();
            buttonSaveAutomaticInput = new Button();
            label2 = new Label();
            textBoxAutomaticClockOut = new TextBox();
            labelAutomaticClockOut = new Label();
            textBoxAutomaticClockIn = new TextBox();
            labelAutomaticClockIn = new Label();
            labelAutomaticDate = new Label();
            textBoxAutomaticDepartment = new TextBox();
            labelAutomaticName = new Label();
            textBoxAutomaticName = new TextBox();
            labelAutomaticDepartment = new Label();
            labelAutomaticEmployeeNumber = new Label();
            textBoxAutomaticEmployeeNumber = new TextBox();
            labelAutomaticInput = new Label();
            panelManualInputs.SuspendLayout();
            panelAutomaticInputs.SuspendLayout();
            SuspendLayout();
            // 
            // panelManualInputs
            // 
            panelManualInputs.AutoScroll = true;
            panelManualInputs.BackColor = Color.FromArgb(207, 207, 207);
            panelManualInputs.Controls.Add(textBoxManualClockOut);
            panelManualInputs.Controls.Add(labelManualClockOut);
            panelManualInputs.Controls.Add(buttonSaveManualInput);
            panelManualInputs.Controls.Add(textBoxManualClockIn);
            panelManualInputs.Controls.Add(labelManualClockIn);
            panelManualInputs.Controls.Add(textBoxManualDate);
            panelManualInputs.Controls.Add(labelManualDate);
            panelManualInputs.Controls.Add(textBoxManualDepartment);
            panelManualInputs.Controls.Add(labelManualName);
            panelManualInputs.Controls.Add(textBoxManualName);
            panelManualInputs.Controls.Add(labelManualDepartment);
            panelManualInputs.Controls.Add(labelManualEmployeeNumber);
            panelManualInputs.Controls.Add(textBoxManualEmployeeNumber);
            panelManualInputs.Location = new Point(66, 162);
            panelManualInputs.Name = "panelManualInputs";
            panelManualInputs.Size = new Size(717, 462);
            panelManualInputs.TabIndex = 3;
            panelManualInputs.Paint += panelManualInputs_Paint;
            // 
            // textBoxManualClockOut
            // 
            textBoxManualClockOut.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualClockOut.Location = new Point(280, 300);
            textBoxManualClockOut.Name = "textBoxManualClockOut";
            textBoxManualClockOut.Size = new Size(358, 34);
            textBoxManualClockOut.TabIndex = 16;
            // 
            // labelManualClockOut
            // 
            labelManualClockOut.AutoSize = true;
            labelManualClockOut.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualClockOut.Location = new Point(80, 300);
            labelManualClockOut.Name = "labelManualClockOut";
            labelManualClockOut.Size = new Size(102, 28);
            labelManualClockOut.TabIndex = 15;
            labelManualClockOut.Text = "Clock Out:";
            // 
            // buttonSaveManualInput
            // 
            buttonSaveManualInput.BackColor = Color.FromArgb(247, 208, 2);
            buttonSaveManualInput.Cursor = Cursors.Hand;
            buttonSaveManualInput.FlatStyle = FlatStyle.Flat;
            buttonSaveManualInput.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveManualInput.Location = new Point(270, 376);
            buttonSaveManualInput.Name = "buttonSaveManualInput";
            buttonSaveManualInput.Size = new Size(150, 40);
            buttonSaveManualInput.TabIndex = 11;
            buttonSaveManualInput.Text = "SAVE";
            buttonSaveManualInput.UseVisualStyleBackColor = false;
            buttonSaveManualInput.Click += buttonSaveManualInput_Click;
            // 
            // textBoxManualClockIn
            // 
            textBoxManualClockIn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualClockIn.Location = new Point(280, 250);
            textBoxManualClockIn.Name = "textBoxManualClockIn";
            textBoxManualClockIn.Size = new Size(358, 34);
            textBoxManualClockIn.TabIndex = 14;
            // 
            // labelManualClockIn
            // 
            labelManualClockIn.AutoSize = true;
            labelManualClockIn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualClockIn.Location = new Point(80, 250);
            labelManualClockIn.Name = "labelManualClockIn";
            labelManualClockIn.Size = new Size(85, 28);
            labelManualClockIn.TabIndex = 13;
            labelManualClockIn.Text = "Clock In:";
            // 
            // textBoxManualDate
            // 
            textBoxManualDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualDate.Location = new Point(280, 200);
            textBoxManualDate.Name = "textBoxManualDate";
            textBoxManualDate.Size = new Size(358, 34);
            textBoxManualDate.TabIndex = 8;
            // 
            // labelManualDate
            // 
            labelManualDate.AutoSize = true;
            labelManualDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualDate.Location = new Point(80, 200);
            labelManualDate.Name = "labelManualDate";
            labelManualDate.Size = new Size(57, 28);
            labelManualDate.TabIndex = 7;
            labelManualDate.Text = "Date:";
            // 
            // textBoxManualDepartment
            // 
            textBoxManualDepartment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualDepartment.Location = new Point(280, 150);
            textBoxManualDepartment.Name = "textBoxManualDepartment";
            textBoxManualDepartment.Size = new Size(358, 34);
            textBoxManualDepartment.TabIndex = 6;
            // 
            // labelManualName
            // 
            labelManualName.AutoSize = true;
            labelManualName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualName.Location = new Point(80, 100);
            labelManualName.Name = "labelManualName";
            labelManualName.Size = new Size(68, 28);
            labelManualName.TabIndex = 5;
            labelManualName.Text = "Name:";
            // 
            // textBoxManualName
            // 
            textBoxManualName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualName.Location = new Point(280, 100);
            textBoxManualName.Name = "textBoxManualName";
            textBoxManualName.Size = new Size(358, 34);
            textBoxManualName.TabIndex = 4;
            // 
            // labelManualDepartment
            // 
            labelManualDepartment.AutoSize = true;
            labelManualDepartment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualDepartment.Location = new Point(80, 150);
            labelManualDepartment.Name = "labelManualDepartment";
            labelManualDepartment.Size = new Size(121, 28);
            labelManualDepartment.TabIndex = 3;
            labelManualDepartment.Text = "Department:";
            // 
            // labelManualEmployeeNumber
            // 
            labelManualEmployeeNumber.AutoSize = true;
            labelManualEmployeeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelManualEmployeeNumber.Location = new Point(80, 50);
            labelManualEmployeeNumber.Name = "labelManualEmployeeNumber";
            labelManualEmployeeNumber.Size = new Size(179, 28);
            labelManualEmployeeNumber.TabIndex = 2;
            labelManualEmployeeNumber.Text = "Employee Number:";
            labelManualEmployeeNumber.Click += label1_Click;
            // 
            // textBoxManualEmployeeNumber
            // 
            textBoxManualEmployeeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxManualEmployeeNumber.Location = new Point(280, 50);
            textBoxManualEmployeeNumber.Name = "textBoxManualEmployeeNumber";
            textBoxManualEmployeeNumber.Size = new Size(358, 34);
            textBoxManualEmployeeNumber.TabIndex = 1;
            textBoxManualEmployeeNumber.TextChanged += textBoxManualEmployeeNumber_TextChanged;
            // 
            // labelManualInput
            // 
            labelManualInput.AutoSize = true;
            labelManualInput.BackColor = Color.Transparent;
            labelManualInput.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelManualInput.Location = new Point(66, 101);
            labelManualInput.Name = "labelManualInput";
            labelManualInput.Size = new Size(176, 31);
            labelManualInput.TabIndex = 0;
            labelManualInput.Text = "Manual Input";
            // 
            // panelAutomaticInputs
            // 
            panelAutomaticInputs.BackColor = Color.FromArgb(207, 207, 207);
            panelAutomaticInputs.Controls.Add(labelAutomaticInputDate);
            panelAutomaticInputs.Controls.Add(buttonSaveAutomaticInput);
            panelAutomaticInputs.Controls.Add(label2);
            panelAutomaticInputs.Controls.Add(textBoxAutomaticClockOut);
            panelAutomaticInputs.Controls.Add(labelAutomaticClockOut);
            panelAutomaticInputs.Controls.Add(textBoxAutomaticClockIn);
            panelAutomaticInputs.Controls.Add(labelAutomaticClockIn);
            panelAutomaticInputs.Controls.Add(labelAutomaticDate);
            panelAutomaticInputs.Controls.Add(textBoxAutomaticDepartment);
            panelAutomaticInputs.Controls.Add(labelAutomaticName);
            panelAutomaticInputs.Controls.Add(textBoxAutomaticName);
            panelAutomaticInputs.Controls.Add(labelAutomaticDepartment);
            panelAutomaticInputs.Controls.Add(labelAutomaticEmployeeNumber);
            panelAutomaticInputs.Controls.Add(textBoxAutomaticEmployeeNumber);
            panelAutomaticInputs.Location = new Point(869, 162);
            panelAutomaticInputs.Name = "panelAutomaticInputs";
            panelAutomaticInputs.Size = new Size(717, 462);
            panelAutomaticInputs.TabIndex = 4;
            // 
            // labelAutomaticInputDate
            // 
            labelAutomaticInputDate.AutoSize = true;
            labelAutomaticInputDate.BackColor = Color.Transparent;
            labelAutomaticInputDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticInputDate.Location = new Point(295, 200);
            labelAutomaticInputDate.Name = "labelAutomaticInputDate";
            labelAutomaticInputDate.Size = new Size(67, 28);
            labelAutomaticInputDate.TabIndex = 18;
            labelAutomaticInputDate.Text = "DATE: ";
            // 
            // buttonSaveAutomaticInput
            // 
            buttonSaveAutomaticInput.BackColor = Color.FromArgb(247, 208, 2);
            buttonSaveAutomaticInput.Cursor = Cursors.Hand;
            buttonSaveAutomaticInput.FlatStyle = FlatStyle.Flat;
            buttonSaveAutomaticInput.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveAutomaticInput.Location = new Point(295, 376);
            buttonSaveAutomaticInput.Name = "buttonSaveAutomaticInput";
            buttonSaveAutomaticInput.Size = new Size(150, 40);
            buttonSaveAutomaticInput.TabIndex = 12;
            buttonSaveAutomaticInput.Text = "SAVE";
            buttonSaveAutomaticInput.UseVisualStyleBackColor = false;
            buttonSaveAutomaticInput.Click += buttonSaveAutomaticInput_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 850);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 33;
            // 
            // textBoxAutomaticClockOut
            // 
            textBoxAutomaticClockOut.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutomaticClockOut.Location = new Point(295, 300);
            textBoxAutomaticClockOut.Name = "textBoxAutomaticClockOut";
            textBoxAutomaticClockOut.Size = new Size(358, 34);
            textBoxAutomaticClockOut.TabIndex = 16;
            // 
            // labelAutomaticClockOut
            // 
            labelAutomaticClockOut.AutoSize = true;
            labelAutomaticClockOut.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticClockOut.Location = new Point(80, 300);
            labelAutomaticClockOut.Name = "labelAutomaticClockOut";
            labelAutomaticClockOut.Size = new Size(102, 28);
            labelAutomaticClockOut.TabIndex = 15;
            labelAutomaticClockOut.Text = "Clock Out:";
            // 
            // textBoxAutomaticClockIn
            // 
            textBoxAutomaticClockIn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutomaticClockIn.Location = new Point(295, 250);
            textBoxAutomaticClockIn.Name = "textBoxAutomaticClockIn";
            textBoxAutomaticClockIn.Size = new Size(358, 34);
            textBoxAutomaticClockIn.TabIndex = 14;
            // 
            // labelAutomaticClockIn
            // 
            labelAutomaticClockIn.AutoSize = true;
            labelAutomaticClockIn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticClockIn.Location = new Point(80, 250);
            labelAutomaticClockIn.Name = "labelAutomaticClockIn";
            labelAutomaticClockIn.Size = new Size(85, 28);
            labelAutomaticClockIn.TabIndex = 13;
            labelAutomaticClockIn.Text = "Clock In:";
            // 
            // labelAutomaticDate
            // 
            labelAutomaticDate.AutoSize = true;
            labelAutomaticDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticDate.Location = new Point(80, 200);
            labelAutomaticDate.Name = "labelAutomaticDate";
            labelAutomaticDate.Size = new Size(57, 28);
            labelAutomaticDate.TabIndex = 7;
            labelAutomaticDate.Text = "Date:";
            // 
            // textBoxAutomaticDepartment
            // 
            textBoxAutomaticDepartment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutomaticDepartment.Location = new Point(295, 150);
            textBoxAutomaticDepartment.Name = "textBoxAutomaticDepartment";
            textBoxAutomaticDepartment.Size = new Size(358, 34);
            textBoxAutomaticDepartment.TabIndex = 6;
            // 
            // labelAutomaticName
            // 
            labelAutomaticName.AutoSize = true;
            labelAutomaticName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticName.Location = new Point(80, 100);
            labelAutomaticName.Name = "labelAutomaticName";
            labelAutomaticName.Size = new Size(68, 28);
            labelAutomaticName.TabIndex = 5;
            labelAutomaticName.Text = "Name:";
            // 
            // textBoxAutomaticName
            // 
            textBoxAutomaticName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutomaticName.Location = new Point(295, 100);
            textBoxAutomaticName.Name = "textBoxAutomaticName";
            textBoxAutomaticName.Size = new Size(358, 34);
            textBoxAutomaticName.TabIndex = 4;
            // 
            // labelAutomaticDepartment
            // 
            labelAutomaticDepartment.AutoSize = true;
            labelAutomaticDepartment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticDepartment.Location = new Point(80, 150);
            labelAutomaticDepartment.Name = "labelAutomaticDepartment";
            labelAutomaticDepartment.Size = new Size(121, 28);
            labelAutomaticDepartment.TabIndex = 3;
            labelAutomaticDepartment.Text = "Department:";
            // 
            // labelAutomaticEmployeeNumber
            // 
            labelAutomaticEmployeeNumber.AutoSize = true;
            labelAutomaticEmployeeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAutomaticEmployeeNumber.Location = new Point(80, 50);
            labelAutomaticEmployeeNumber.Name = "labelAutomaticEmployeeNumber";
            labelAutomaticEmployeeNumber.Size = new Size(179, 28);
            labelAutomaticEmployeeNumber.TabIndex = 2;
            labelAutomaticEmployeeNumber.Text = "Employee Number:";
            // 
            // textBoxAutomaticEmployeeNumber
            // 
            textBoxAutomaticEmployeeNumber.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAutomaticEmployeeNumber.Location = new Point(295, 40);
            textBoxAutomaticEmployeeNumber.Name = "textBoxAutomaticEmployeeNumber";
            textBoxAutomaticEmployeeNumber.Size = new Size(358, 34);
            textBoxAutomaticEmployeeNumber.TabIndex = 1;
            // 
            // labelAutomaticInput
            // 
            labelAutomaticInput.AutoSize = true;
            labelAutomaticInput.BackColor = Color.Transparent;
            labelAutomaticInput.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelAutomaticInput.Location = new Point(869, 101);
            labelAutomaticInput.Name = "labelAutomaticInput";
            labelAutomaticInput.Size = new Size(207, 31);
            labelAutomaticInput.TabIndex = 13;
            labelAutomaticInput.Text = "Automatic Input";
            // 
            // FormAddAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelAutomaticInput);
            Controls.Add(panelAutomaticInputs);
            Controls.Add(panelManualInputs);
            Controls.Add(labelManualInput);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormAddAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAddAttendance";
            Load += FormAddAttendance_Load;
            panelManualInputs.ResumeLayout(false);
            panelManualInputs.PerformLayout();
            panelAutomaticInputs.ResumeLayout(false);
            panelAutomaticInputs.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelManualInput;
        private Label labelManualEmployeeNumber;
        private TextBox textBoxManualEmployeeNumber;
        private Panel panelManualInputs;
        private Label labelManualDepartment;
        private Label labelManualName;
        private TextBox textBoxManualName;
        private TextBox textBoxManualDate;
        private Label labelManualDate;
        private TextBox textBoxManualClockIn;
        private Label labelManualClockIn;
        private TextBox textBoxManualClockOut;
        private Label labelManualClockOut;
        private Panel panelAutomaticInputs;
        private Label label2;
        private TextBox textBoxAutomaticClockOut;
        private Label labelAutomaticClockOut;
        private TextBox textBoxAutomaticClockIn;
        private Label labelAutomaticClockIn;
        private Label labelAutomaticDate;
        private Label labelAutomaticName;
        private TextBox textBoxAutomaticName;
        private Label labelAutomaticDepartment;
        private Label labelAutomaticEmployeeNumber;
        private TextBox textBoxAutomaticEmployeeNumber;
        private Button buttonSaveManualInput;
        private Button buttonSaveAutomaticInput;
        private Label labelAutomaticInput;
        private Label labelAutomaticInputDate;
        private TextBox textBoxAutomaticDepartment;
        private TextBox textBoxManualDepartment;
    }
}