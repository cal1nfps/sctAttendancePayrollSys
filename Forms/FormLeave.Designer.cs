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
            this.labelLeave = new System.Windows.Forms.Label();
            this.panelFormLeave = new System.Windows.Forms.Panel();
            this.dataGridViewLeave = new System.Windows.Forms.DataGridView();
            this.labelSort = new System.Windows.Forms.Label();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLeave
            // 
            this.labelLeave.AutoSize = true;
            this.labelLeave.BackColor = System.Drawing.Color.Transparent;
            this.labelLeave.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLeave.Location = new System.Drawing.Point(38, 32);
            this.labelLeave.Name = "labelLeave";
            this.labelLeave.Size = new System.Drawing.Size(103, 31);
            this.labelLeave.TabIndex = 7;
            this.labelLeave.Text = "LEAVE";
            // 
            // panelFormLeave
            // 
            this.panelFormLeave.Location = new System.Drawing.Point(51, 83);
            this.panelFormLeave.Name = "panelFormLeave";
            this.panelFormLeave.Size = new System.Drawing.Size(1237, 80);
            this.panelFormLeave.TabIndex = 15;
            // 
            // dataGridViewLeave
            // 
            this.dataGridViewLeave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLeave.Location = new System.Drawing.Point(62, 186);
            this.dataGridViewLeave.Name = "dataGridViewLeave";
            this.dataGridViewLeave.RowTemplate.Height = 25;
            this.dataGridViewLeave.Size = new System.Drawing.Size(1226, 476);
            this.dataGridViewLeave.TabIndex = 16;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelSort.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSort.Location = new System.Drawing.Point(900, 34);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(47, 17);
            this.labelSort.TabIndex = 23;
            this.labelSort.Text = "Filter:";
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortComboBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "DEPARTMENT"});
            this.sortComboBox.Location = new System.Drawing.Point(950, 34);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(124, 23);
            this.sortComboBox.TabIndex = 22;
            // 
            // FormLeave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 698);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.sortComboBox);
            this.Controls.Add(this.dataGridViewLeave);
            this.Controls.Add(this.panelFormLeave);
            this.Controls.Add(this.labelLeave);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormLeave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLeave";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelLeave;
        private Panel panelFormLeave;
        private DataGridView dataGridViewLeave;
        private Label labelSort;
        private ComboBox sortComboBox;
    }
}