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
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelDuration = new System.Windows.Forms.Label();
            this.comboBoxLeave = new System.Windows.Forms.ComboBox();
            this.labelLeave = new System.Windows.Forms.Label();
            this.labelLeaveInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.dateTimePickerLeave = new System.Windows.Forms.DateTimePicker();
            this.HeaderPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.ExitBtn);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 45);
            this.HeaderPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "REQUEST LEAVE";
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.Location = new System.Drawing.Point(742, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(45, 39);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dateTimePickerLeave);
            this.panel3.Controls.Add(this.labelDuration);
            this.panel3.Controls.Add(this.comboBoxLeave);
            this.panel3.Controls.Add(this.labelLeave);
            this.panel3.Controls.Add(this.labelLeaveInfo);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(95, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 235);
            this.panel3.TabIndex = 35;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDuration.Location = new System.Drawing.Point(174, 89);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(83, 19);
            this.labelDuration.TabIndex = 64;
            this.labelDuration.Text = "DURATION";
            // 
            // comboBoxLeave
            // 
            this.comboBoxLeave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLeave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxLeave.FormattingEnabled = true;
            this.comboBoxLeave.Items.AddRange(new object[] {
            "Sick Leave",
            "Emergency Leave",
            "Vacation Leave",
            "Special Leave"});
            this.comboBoxLeave.Location = new System.Drawing.Point(297, 147);
            this.comboBoxLeave.Name = "comboBoxLeave";
            this.comboBoxLeave.Size = new System.Drawing.Size(147, 28);
            this.comboBoxLeave.TabIndex = 61;
            // 
            // labelLeave
            // 
            this.labelLeave.AutoSize = true;
            this.labelLeave.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLeave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLeave.Location = new System.Drawing.Point(201, 150);
            this.labelLeave.Name = "labelLeave";
            this.labelLeave.Size = new System.Drawing.Size(56, 19);
            this.labelLeave.TabIndex = 60;
            this.labelLeave.Text = "LEAVE";
            // 
            // labelLeaveInfo
            // 
            this.labelLeaveInfo.AutoSize = true;
            this.labelLeaveInfo.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLeaveInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLeaveInfo.Location = new System.Drawing.Point(211, 22);
            this.labelLeaveInfo.Name = "labelLeaveInfo";
            this.labelLeaveInfo.Size = new System.Drawing.Size(183, 25);
            this.labelLeaveInfo.TabIndex = 35;
            this.labelLeaveInfo.Text = "Leave Information";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(520, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 36;
            this.button1.Text = "Confirm";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelButton.Location = new System.Drawing.Point(614, 353);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 34);
            this.cancelButton.TabIndex = 37;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseMnemonic = false;
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerLeave
            // 
            this.dateTimePickerLeave.Location = new System.Drawing.Point(297, 89);
            this.dateTimePickerLeave.Name = "dateTimePickerLeave";
            this.dateTimePickerLeave.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerLeave.TabIndex = 65;
            // 
            // FormRequestLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.HeaderPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormRequestLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}