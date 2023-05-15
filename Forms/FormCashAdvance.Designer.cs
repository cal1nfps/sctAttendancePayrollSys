namespace SCTAttendanceSystemUI.Forms
{
    partial class FormCashAdvance
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
            labelCashAdvance = new Label();
            SuspendLayout();
            // 
            // labelCashAdvance
            // 
            labelCashAdvance.AutoSize = true;
            labelCashAdvance.BackColor = Color.Transparent;
            labelCashAdvance.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelCashAdvance.Location = new Point(38, 32);
            labelCashAdvance.Name = "labelCashAdvance";
            labelCashAdvance.Size = new Size(227, 31);
            labelCashAdvance.TabIndex = 10;
            labelCashAdvance.Text = "CASH ADVANCE";
            // 
            // FormCashAdvance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelCashAdvance);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormCashAdvance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCashAdvance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCashAdvance;
    }
}