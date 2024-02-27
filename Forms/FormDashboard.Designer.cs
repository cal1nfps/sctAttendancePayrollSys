namespace SCTAttendanceSystemUI.Forms
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panelTimeIn = new Panel();
            panelHeader = new Panel();
            TimeInHeader = new Label();
            dataGridViewRecentTimeIn = new DataGridView();
            panelTimeOut = new Panel();
            panelHeader2 = new Panel();
            TimeOutHeader = new Label();
            dataGridViewRecentTimeOut = new DataGridView();
            panelPresent = new Panel();
            labelPresentCount = new Label();
            panelHeader3 = new Panel();
            presentHeader = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelAbsent = new Panel();
            labelLateCounter = new Label();
            panelHeader4 = new Panel();
            lateHeader = new Label();
            panelLate = new Panel();
            labelAbsentCounter = new Label();
            panelHeder5 = new Panel();
            absentHeader = new Label();
            panelLateToday = new Panel();
            panelHeader6 = new Panel();
            LateTodayHeader = new Label();
            dataGridViewLateToday = new DataGridView();
            labelDashboard = new Label();
            panelTimeIn.SuspendLayout();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTimeIn).BeginInit();
            panelTimeOut.SuspendLayout();
            panelHeader2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTimeOut).BeginInit();
            panelPresent.SuspendLayout();
            panelHeader3.SuspendLayout();
            panelAbsent.SuspendLayout();
            panelHeader4.SuspendLayout();
            panelLate.SuspendLayout();
            panelHeder5.SuspendLayout();
            panelLateToday.SuspendLayout();
            panelHeader6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLateToday).BeginInit();
            SuspendLayout();
            // 
            // panelTimeIn
            // 
            panelTimeIn.BackColor = Color.FromArgb(240, 243, 247);
            panelTimeIn.Controls.Add(panelHeader);
            panelTimeIn.Controls.Add(dataGridViewRecentTimeIn);
            panelTimeIn.Location = new Point(958, 99);
            panelTimeIn.Name = "panelTimeIn";
            panelTimeIn.Size = new Size(345, 711);
            panelTimeIn.TabIndex = 4;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader.Controls.Add(TimeInHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(345, 73);
            panelHeader.TabIndex = 5;
            // 
            // TimeInHeader
            // 
            TimeInHeader.AutoSize = true;
            TimeInHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeInHeader.ForeColor = Color.White;
            TimeInHeader.Image = (Image)resources.GetObject("TimeInHeader.Image");
            TimeInHeader.ImageAlign = ContentAlignment.MiddleLeft;
            TimeInHeader.Location = new Point(55, 16);
            TimeInHeader.Name = "TimeInHeader";
            TimeInHeader.Size = new Size(237, 42);
            TimeInHeader.TabIndex = 1;
            TimeInHeader.Text = "      Recent Time-In";
            TimeInHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRecentTimeIn
            // 
            dataGridViewRecentTimeIn.AllowUserToAddRows = false;
            dataGridViewRecentTimeIn.AllowUserToResizeRows = false;
            dataGridViewRecentTimeIn.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecentTimeIn.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewRecentTimeIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecentTimeIn.Enabled = false;
            dataGridViewRecentTimeIn.Location = new Point(3, 79);
            dataGridViewRecentTimeIn.Name = "dataGridViewRecentTimeIn";
            dataGridViewRecentTimeIn.ReadOnly = true;
            dataGridViewRecentTimeIn.RowHeadersVisible = false;
            dataGridViewRecentTimeIn.RowTemplate.Height = 25;
            dataGridViewRecentTimeIn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecentTimeIn.Size = new Size(337, 619);
            dataGridViewRecentTimeIn.TabIndex = 54;
            dataGridViewRecentTimeIn.CellFormatting += dataGridViewRecentTimeIn_CellFormatting;
            // 
            // panelTimeOut
            // 
            panelTimeOut.BackColor = Color.FromArgb(240, 243, 247);
            panelTimeOut.Controls.Add(panelHeader2);
            panelTimeOut.Controls.Add(dataGridViewRecentTimeOut);
            panelTimeOut.Location = new Point(1309, 99);
            panelTimeOut.Name = "panelTimeOut";
            panelTimeOut.Size = new Size(345, 711);
            panelTimeOut.TabIndex = 55;
            // 
            // panelHeader2
            // 
            panelHeader2.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader2.Controls.Add(TimeOutHeader);
            panelHeader2.Dock = DockStyle.Top;
            panelHeader2.Location = new Point(0, 0);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Size = new Size(345, 73);
            panelHeader2.TabIndex = 5;
            // 
            // TimeOutHeader
            // 
            TimeOutHeader.AutoSize = true;
            TimeOutHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            TimeOutHeader.ForeColor = Color.White;
            TimeOutHeader.Image = (Image)resources.GetObject("TimeOutHeader.Image");
            TimeOutHeader.ImageAlign = ContentAlignment.MiddleLeft;
            TimeOutHeader.Location = new Point(44, 16);
            TimeOutHeader.Name = "TimeOutHeader";
            TimeOutHeader.Size = new Size(254, 42);
            TimeOutHeader.TabIndex = 1;
            TimeOutHeader.Text = "      Recent Time-Out";
            TimeOutHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewRecentTimeOut
            // 
            dataGridViewRecentTimeOut.AllowUserToAddRows = false;
            dataGridViewRecentTimeOut.AllowUserToResizeRows = false;
            dataGridViewRecentTimeOut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRecentTimeOut.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewRecentTimeOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecentTimeOut.Enabled = false;
            dataGridViewRecentTimeOut.Location = new Point(3, 79);
            dataGridViewRecentTimeOut.Name = "dataGridViewRecentTimeOut";
            dataGridViewRecentTimeOut.ReadOnly = true;
            dataGridViewRecentTimeOut.RowHeadersVisible = false;
            dataGridViewRecentTimeOut.RowTemplate.Height = 25;
            dataGridViewRecentTimeOut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecentTimeOut.Size = new Size(337, 619);
            dataGridViewRecentTimeOut.TabIndex = 54;
            dataGridViewRecentTimeOut.CellFormatting += dataGridViewRecentTimeOut_CellFormatting;
            // 
            // panelPresent
            // 
            panelPresent.BackColor = Color.FromArgb(240, 243, 247);
            panelPresent.Controls.Add(labelPresentCount);
            panelPresent.Controls.Add(panelHeader3);
            panelPresent.Location = new Point(22, 99);
            panelPresent.Name = "panelPresent";
            panelPresent.Size = new Size(277, 152);
            panelPresent.TabIndex = 56;
            // 
            // labelPresentCount
            // 
            labelPresentCount.AutoSize = true;
            labelPresentCount.BackColor = Color.Transparent;
            labelPresentCount.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPresentCount.ForeColor = Color.Black;
            labelPresentCount.ImageAlign = ContentAlignment.MiddleLeft;
            labelPresentCount.Location = new Point(122, 91);
            labelPresentCount.Name = "labelPresentCount";
            labelPresentCount.Size = new Size(0, 42);
            labelPresentCount.TabIndex = 7;
            labelPresentCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader3
            // 
            panelHeader3.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader3.Controls.Add(presentHeader);
            panelHeader3.Dock = DockStyle.Top;
            panelHeader3.Location = new Point(0, 0);
            panelHeader3.Name = "panelHeader3";
            panelHeader3.Size = new Size(277, 73);
            panelHeader3.TabIndex = 6;
            // 
            // presentHeader
            // 
            presentHeader.AutoSize = true;
            presentHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            presentHeader.ForeColor = Color.White;
            presentHeader.Image = (Image)resources.GetObject("presentHeader.Image");
            presentHeader.ImageAlign = ContentAlignment.MiddleLeft;
            presentHeader.Location = new Point(54, 16);
            presentHeader.Name = "presentHeader";
            presentHeader.Size = new Size(161, 42);
            presentHeader.TabIndex = 1;
            presentHeader.Text = "      PRESENT";
            presentHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // panelAbsent
            // 
            panelAbsent.BackColor = Color.FromArgb(240, 243, 247);
            panelAbsent.Controls.Add(labelLateCounter);
            panelAbsent.Controls.Add(panelHeader4);
            panelAbsent.Location = new Point(323, 99);
            panelAbsent.Name = "panelAbsent";
            panelAbsent.Size = new Size(277, 152);
            panelAbsent.TabIndex = 57;
            // 
            // labelLateCounter
            // 
            labelLateCounter.AutoSize = true;
            labelLateCounter.BackColor = Color.Transparent;
            labelLateCounter.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLateCounter.ForeColor = Color.Black;
            labelLateCounter.ImageAlign = ContentAlignment.MiddleLeft;
            labelLateCounter.Location = new Point(120, 91);
            labelLateCounter.Name = "labelLateCounter";
            labelLateCounter.Size = new Size(0, 42);
            labelLateCounter.TabIndex = 8;
            labelLateCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeader4
            // 
            panelHeader4.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader4.Controls.Add(lateHeader);
            panelHeader4.Dock = DockStyle.Top;
            panelHeader4.Location = new Point(0, 0);
            panelHeader4.Name = "panelHeader4";
            panelHeader4.Size = new Size(277, 73);
            panelHeader4.TabIndex = 6;
            // 
            // lateHeader
            // 
            lateHeader.AutoSize = true;
            lateHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lateHeader.ForeColor = Color.White;
            lateHeader.Image = (Image)resources.GetObject("lateHeader.Image");
            lateHeader.ImageAlign = ContentAlignment.MiddleLeft;
            lateHeader.Location = new Point(78, 16);
            lateHeader.Name = "lateHeader";
            lateHeader.Size = new Size(113, 42);
            lateHeader.TabIndex = 1;
            lateHeader.Text = "      LATE";
            lateHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLate
            // 
            panelLate.BackColor = Color.FromArgb(240, 243, 247);
            panelLate.Controls.Add(labelAbsentCounter);
            panelLate.Controls.Add(panelHeder5);
            panelLate.Location = new Point(630, 99);
            panelLate.Name = "panelLate";
            panelLate.Size = new Size(277, 152);
            panelLate.TabIndex = 58;
            // 
            // labelAbsentCounter
            // 
            labelAbsentCounter.AutoSize = true;
            labelAbsentCounter.BackColor = Color.Transparent;
            labelAbsentCounter.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelAbsentCounter.ForeColor = Color.Black;
            labelAbsentCounter.ImageAlign = ContentAlignment.MiddleLeft;
            labelAbsentCounter.Location = new Point(122, 91);
            labelAbsentCounter.Name = "labelAbsentCounter";
            labelAbsentCounter.Size = new Size(0, 42);
            labelAbsentCounter.TabIndex = 9;
            labelAbsentCounter.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelHeder5
            // 
            panelHeder5.BackColor = Color.FromArgb(164, 16, 48);
            panelHeder5.Controls.Add(absentHeader);
            panelHeder5.Dock = DockStyle.Top;
            panelHeder5.Location = new Point(0, 0);
            panelHeder5.Name = "panelHeder5";
            panelHeder5.Size = new Size(277, 73);
            panelHeder5.TabIndex = 6;
            // 
            // absentHeader
            // 
            absentHeader.AutoSize = true;
            absentHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            absentHeader.ForeColor = Color.White;
            absentHeader.Image = (Image)resources.GetObject("absentHeader.Image");
            absentHeader.ImageAlign = ContentAlignment.MiddleLeft;
            absentHeader.Location = new Point(64, 16);
            absentHeader.Name = "absentHeader";
            absentHeader.Size = new Size(146, 42);
            absentHeader.TabIndex = 1;
            absentHeader.Text = "      ABSENT";
            absentHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLateToday
            // 
            panelLateToday.BackColor = Color.FromArgb(240, 243, 247);
            panelLateToday.Controls.Add(panelHeader6);
            panelLateToday.Controls.Add(dataGridViewLateToday);
            panelLateToday.Location = new Point(22, 297);
            panelLateToday.Name = "panelLateToday";
            panelLateToday.Size = new Size(885, 513);
            panelLateToday.TabIndex = 59;
            // 
            // panelHeader6
            // 
            panelHeader6.BackColor = Color.FromArgb(164, 16, 48);
            panelHeader6.Controls.Add(LateTodayHeader);
            panelHeader6.Dock = DockStyle.Top;
            panelHeader6.Location = new Point(0, 0);
            panelHeader6.Name = "panelHeader6";
            panelHeader6.Size = new Size(885, 73);
            panelHeader6.TabIndex = 5;
            // 
            // LateTodayHeader
            // 
            LateTodayHeader.AutoSize = true;
            LateTodayHeader.Font = new Font("Bahnschrift Condensed", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            LateTodayHeader.ForeColor = Color.White;
            LateTodayHeader.Image = (Image)resources.GetObject("LateTodayHeader.Image");
            LateTodayHeader.ImageAlign = ContentAlignment.MiddleLeft;
            LateTodayHeader.Location = new Point(15, 15);
            LateTodayHeader.Name = "LateTodayHeader";
            LateTodayHeader.Size = new Size(180, 42);
            LateTodayHeader.TabIndex = 1;
            LateTodayHeader.Text = "      Late Today";
            LateTodayHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridViewLateToday
            // 
            dataGridViewLateToday.AllowUserToAddRows = false;
            dataGridViewLateToday.AllowUserToResizeRows = false;
            dataGridViewLateToday.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLateToday.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewLateToday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLateToday.Enabled = false;
            dataGridViewLateToday.Location = new Point(3, 79);
            dataGridViewLateToday.Name = "dataGridViewLateToday";
            dataGridViewLateToday.ReadOnly = true;
            dataGridViewLateToday.RowHeadersVisible = false;
            dataGridViewLateToday.RowTemplate.Height = 25;
            dataGridViewLateToday.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLateToday.Size = new Size(879, 421);
            dataGridViewLateToday.TabIndex = 54;
            dataGridViewLateToday.CellFormatting += dataGridViewLateToday_CellFormatting;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.Transparent;
            labelDashboard.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.Location = new Point(22, 29);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(187, 31);
            labelDashboard.TabIndex = 55;
            labelDashboard.Text = "DASHBOARD";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1666, 822);
            Controls.Add(labelDashboard);
            Controls.Add(panelLateToday);
            Controls.Add(panelLate);
            Controls.Add(panelAbsent);
            Controls.Add(panelPresent);
            Controls.Add(panelTimeIn);
            Controls.Add(panelTimeOut);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            panelTimeIn.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTimeIn).EndInit();
            panelTimeOut.ResumeLayout(false);
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecentTimeOut).EndInit();
            panelPresent.ResumeLayout(false);
            panelPresent.PerformLayout();
            panelHeader3.ResumeLayout(false);
            panelHeader3.PerformLayout();
            panelAbsent.ResumeLayout(false);
            panelAbsent.PerformLayout();
            panelHeader4.ResumeLayout(false);
            panelHeader4.PerformLayout();
            panelLate.ResumeLayout(false);
            panelLate.PerformLayout();
            panelHeder5.ResumeLayout(false);
            panelHeder5.PerformLayout();
            panelLateToday.ResumeLayout(false);
            panelHeader6.ResumeLayout(false);
            panelHeader6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLateToday).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTimeIn;
        private Panel panelHeader;
        private Label TimeInHeader;
        public DataGridView dataGridViewRecentTimeIn;
        private Panel panelTimeOut;
        private Panel panelHeader2;
        private Label TimeOutHeader;
        public DataGridView dataGridViewRecentTimeOut;
        private Panel panelPresent;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private Panel panelHeader3;
        private Label presentHeader;
        private Panel panelAbsent;
        private Panel panelHeader4;
        private Label lateHeader;
        private Panel panelLate;
        private Panel panelHeder5;
        private Label absentHeader;
        private Label labelPresentCount;
        private Label labelLateCounter;
        private Label labelAbsentCounter;
        private Panel panelLateToday;
        private Panel panelHeader6;
        private Label LateTodayHeader;
        public DataGridView dataGridViewLateToday;
        private Label labelDashboard;
    }
}