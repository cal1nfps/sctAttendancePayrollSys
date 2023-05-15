namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    partial class PayrollCheques
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
            button1 = new Button();
            cancelButton = new Button();
            panel1 = new Panel();
            personalButton = new Button();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(588, 404);
            button1.Name = "button1";
            button1.Size = new Size(88, 34);
            button1.TabIndex = 10;
            button1.Text = "Confirm";
            button1.UseMnemonic = false;
            button1.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.WhiteSmoke;
            cancelButton.BackgroundImageLayout = ImageLayout.None;
            cancelButton.FlatAppearance.BorderColor = Color.DimGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(700, 404);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(88, 34);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseMnemonic = false;
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label12);
            panel1.Location = new Point(0, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 349);
            panel1.TabIndex = 11;
            // 
            // personalButton
            // 
            personalButton.BackColor = Color.White;
            personalButton.BackgroundImageLayout = ImageLayout.None;
            personalButton.FlatAppearance.BorderColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.BorderSize = 2;
            personalButton.FlatAppearance.CheckedBackColor = Color.FromArgb(164, 31, 52);
            personalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(247, 209, 10);
            personalButton.FlatStyle = FlatStyle.Flat;
            personalButton.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            personalButton.ForeColor = SystemColors.ControlText;
            personalButton.Location = new Point(0, -1);
            personalButton.Name = "personalButton";
            personalButton.Size = new Size(121, 41);
            personalButton.TabIndex = 10;
            personalButton.Text = "Payroll Cheques";
            personalButton.UseMnemonic = false;
            personalButton.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlDarkDark;
            label12.Location = new Point(14, 18);
            label12.Name = "label12";
            label12.Size = new Size(37, 14);
            label12.TabIndex = 58;
            label12.Text = "Name";
            // 
            // PayrollCheques
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(personalButton);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(cancelButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PayrollCheques";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PayrollCheques";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button cancelButton;
        private Panel panel1;
        private Button personalButton;
        private Label label12;
    }
}