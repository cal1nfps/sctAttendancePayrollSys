namespace SCTAttendanceSystemUI.Employee
{
    partial class FormRequestLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRequestLeave));
            HeaderPanel = new Panel();
            label1 = new Label();
            ExitBtn = new Button();
            panel3 = new Panel();
            empname = new Label();
            dateTimePickerLeave = new DateTimePicker();
            labelDuration = new Label();
            comboBoxLeave = new ComboBox();
            labelLeave = new Label();
            labelLeaveInfo = new Label();
            button1 = new Button();
            cancelButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            HeaderPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(164, 16, 52);
            HeaderPanel.Controls.Add(label1);
            HeaderPanel.Controls.Add(ExitBtn);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(800, 45);
            HeaderPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 10);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 1;
            label1.Text = "REQUEST LEAVE";
            // 
            // ExitBtn
            // 
            ExitBtn.FlatAppearance.BorderSize = 0;
            ExitBtn.FlatStyle = FlatStyle.Flat;
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.Location = new Point(742, 3);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(45, 39);
            ExitBtn.TabIndex = 0;
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(empname);
            panel3.Controls.Add(dateTimePickerLeave);
            panel3.Controls.Add(labelDuration);
            panel3.Controls.Add(comboBoxLeave);
            panel3.Controls.Add(labelLeave);
            panel3.Controls.Add(labelLeaveInfo);
            panel3.ForeColor = SystemColors.ControlText;
            panel3.Location = new Point(95, 103);
            panel3.Name = "panel3";
            panel3.Size = new Size(607, 235);
            panel3.TabIndex = 35;
            // 
            // empname
            // 
            empname.AutoSize = true;
            empname.BackColor = Color.Transparent;
            empname.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            empname.ForeColor = Color.Black;
            empname.Location = new Point(415, 11);
            empname.Name = "empname";
            empname.Size = new Size(178, 31);
            empname.TabIndex = 38;
            empname.Text = "EMPLOYEE!";
            empname.Click += empname_Click;
            // 
            // dateTimePickerLeave
            // 
            dateTimePickerLeave.Location = new Point(79, 102);
            dateTimePickerLeave.Name = "dateTimePickerLeave";
            dateTimePickerLeave.Size = new Size(200, 23);
            dateTimePickerLeave.TabIndex = 65;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDuration.ForeColor = SystemColors.ControlDarkDark;
            labelDuration.Location = new Point(162, 82);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(49, 17);
            labelDuration.TabIndex = 64;
            labelDuration.Text = "START";
            labelDuration.Click += labelDuration_Click;
            // 
            // comboBoxLeave
            // 
            comboBoxLeave.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLeave.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLeave.FormattingEnabled = true;
            comboBoxLeave.Items.AddRange(new object[] { "Sick Leave", "Emergency Leave", "Vacation Leave", "Special Leave" });
            comboBoxLeave.Location = new Point(256, 147);
            comboBoxLeave.Name = "comboBoxLeave";
            comboBoxLeave.Size = new Size(147, 28);
            comboBoxLeave.TabIndex = 61;
            // 
            // labelLeave
            // 
            labelLeave.AutoSize = true;
            labelLeave.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeave.ForeColor = SystemColors.ControlDarkDark;
            labelLeave.Location = new Point(179, 150);
            labelLeave.Name = "labelLeave";
            labelLeave.Size = new Size(56, 19);
            labelLeave.TabIndex = 60;
            labelLeave.Text = "LEAVE";
            // 
            // labelLeaveInfo
            // 
            labelLeaveInfo.AutoSize = true;
            labelLeaveInfo.Font = new Font("Bahnschrift", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLeaveInfo.ForeColor = SystemColors.ControlDarkDark;
            labelLeaveInfo.Location = new Point(12, 11);
            labelLeaveInfo.Name = "labelLeaveInfo";
            labelLeaveInfo.Size = new Size(183, 25);
            labelLeaveInfo.TabIndex = 35;
            labelLeaveInfo.Text = "Leave Information";
            labelLeaveInfo.Click += labelLeaveInfo_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(520, 353);
            button1.Name = "button1";
            button1.Size = new Size(88, 34);
            button1.TabIndex = 36;
            button1.Text = "Confirm";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(614, 353);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 37;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(312, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 66;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(395, 82);
            label2.Name = "label2";
            label2.Size = new Size(35, 17);
            label2.TabIndex = 67;
            label2.Text = "END";
            // 
            // FormRequestLeave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(HeaderPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormRequestLeave";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormRequestLeave_Load;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Button ExitBtn;
        private Label label1;
        private Panel panel3;
        private Label labelDuration;
        private ComboBox comboBoxLeave;
        private Label labelLeave;
        private Label labelLeaveInfo;
        private Button button1;
        private Button cancelButton;
        private DateTimePicker dateTimePickerLeave;
        private Label empname;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}