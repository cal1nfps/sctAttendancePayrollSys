namespace SCTAttendanceSystemUI.Forms
{
    partial class FormLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLeave));
            this.labelLeave = new System.Windows.Forms.Label();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.panelLeaveForToday = new System.Windows.Forms.Panel();
            this.labelOccupation = new System.Windows.Forms.Label();
            this.labelLeave1 = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelDep = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmpNum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            this.panelLeaveForToday.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLeave
            // 
            this.labelLeave.AutoSize = true;
            this.labelLeave.BackColor = System.Drawing.Color.Transparent;
            this.labelLeave.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLeave.Location = new System.Drawing.Point(38, 32);
            this.labelLeave.Name = "labelLeave";
            this.labelLeave.Size = new System.Drawing.Size(328, 31);
            this.labelLeave.TabIndex = 7;
            this.labelLeave.Text = "EMPLOYEES ON LEAVE";
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Location = new System.Drawing.Point(38, 130);
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.RowTemplate.Height = 25;
            this.dataGridViewLeave.Size = new System.Drawing.Size(951, 392);
            this.dataGridViewLeave.TabIndex = 16;
            // 
            // panelLeaveForToday
            // 
            this.panelLeaveForToday.BackColor = System.Drawing.Color.White;
            this.panelLeaveForToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeaveForToday.Controls.Add(this.labelOccupation);
            this.panelLeaveForToday.Controls.Add(this.labelLeave1);
            this.panelLeaveForToday.Controls.Add(this.labelDuration);
            this.panelLeaveForToday.Controls.Add(this.labelDep);
            this.panelLeaveForToday.Controls.Add(this.labelName);
            this.panelLeaveForToday.Controls.Add(this.labelEmpNum);
            this.panelLeaveForToday.Location = new System.Drawing.Point(38, 94);
            this.panelLeaveForToday.Name = "panelLeaveForToday";
            this.panelLeaveForToday.Size = new System.Drawing.Size(951, 30);
            this.panelLeaveForToday.TabIndex = 72;
            // 
            // labelOccupation
            // 
            this.labelOccupation.AutoSize = true;
            this.labelOccupation.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOccupation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelOccupation.Location = new System.Drawing.Point(305, 7);
            this.labelOccupation.Name = "labelOccupation";
            this.labelOccupation.Size = new System.Drawing.Size(68, 14);
            this.labelOccupation.TabIndex = 67;
            this.labelOccupation.Text = "Occupation";
            // 
            // labelLeave1
            // 
            this.labelLeave1.AutoSize = true;
            this.labelLeave1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLeave1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLeave1.Location = new System.Drawing.Point(594, 7);
            this.labelLeave1.Name = "labelLeave1";
            this.labelLeave1.Size = new System.Drawing.Size(38, 14);
            this.labelLeave1.TabIndex = 65;
            this.labelLeave1.Text = "Leave";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDuration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDuration.Location = new System.Drawing.Point(453, 7);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(54, 14);
            this.labelDuration.TabIndex = 64;
            this.labelDuration.Text = "Duration";
            // 
            // labelDep
            // 
            this.labelDep.AutoSize = true;
            this.labelDep.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDep.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDep.Location = new System.Drawing.Point(171, 7);
            this.labelDep.Name = "labelDep";
            this.labelDep.Size = new System.Drawing.Size(70, 14);
            this.labelDep.TabIndex = 61;
            this.labelDep.Text = "Department";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelName.Location = new System.Drawing.Point(59, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 14);
            this.labelName.TabIndex = 60;
            this.labelName.Text = "Name";
            // 
            // labelEmpNum
            // 
            this.labelEmpNum.AutoSize = true;
            this.labelEmpNum.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmpNum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEmpNum.Location = new System.Drawing.Point(15, 7);
            this.labelEmpNum.Name = "labelEmpNum";
            this.labelEmpNum.Size = new System.Drawing.Size(14, 14);
            this.labelEmpNum.TabIndex = 58;
            this.labelEmpNum.Text = "#";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "Search Employee Number or Name";
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
            this.button1.Location = new System.Drawing.Point(836, 58);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(47, 30);
            this.button1.TabIndex = 74;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(889, 58);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(47, 30);
            this.button4.TabIndex = 75;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(942, 58);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(47, 30);
            this.button3.TabIndex = 76;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelLeaveForToday);
            this.Controls.Add(this.dataGridViewLeave);
            this.Controls.Add(this.labelLeave);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLeave";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            this.panelLeaveForToday.ResumeLayout(false);
            this.panelLeaveForToday.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLeave;
        private DataGridView dataGridViewLeave;
        private Panel panelLeaveForToday;
        private Label labelOccupation;
        private Label labelLeave1;
        private Label labelDuration;
        private Label labelDep;
        private Label labelName;
        private Label labelEmpNum;
        private TextBox textBox1;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}