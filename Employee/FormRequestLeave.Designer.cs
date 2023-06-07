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
            ExitBtn = new Button();
            label1 = new Label();
            HeaderPanel.SuspendLayout();
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
            ExitBtn.Click += ExitBtn_Click;
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
            // FormRequestLeave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOW_OPACITY;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(HeaderPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Name = "FormRequestLeave";
            StartPosition = FormStartPosition.CenterScreen;
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel HeaderPanel;
        private Button ExitBtn;
        private Label label1;
    }
}