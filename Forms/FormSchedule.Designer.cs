namespace SCTAttendanceSystemUI.Forms
{
    partial class FormSchedule
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
            labelSchedule = new Label();
            SuspendLayout();
            // 
            // labelSchedule
            // 
            labelSchedule.AutoSize = true;
            labelSchedule.BackColor = Color.Transparent;
            labelSchedule.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelSchedule.Location = new Point(38, 32);
            labelSchedule.Name = "labelSchedule";
            labelSchedule.Size = new Size(164, 31);
            labelSchedule.TabIndex = 8;
            labelSchedule.Text = "SCHEDULE";
            // 
            // FormSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1904, 1041);
            Controls.Add(labelSchedule);
            DoubleBuffered = true;
            MaximumSize = new Size(1920, 1080);
            Name = "FormSchedule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSchedule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSchedule;
    }
}