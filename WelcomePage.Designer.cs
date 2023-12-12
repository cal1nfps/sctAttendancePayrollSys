namespace SCTAttendanceSystemUI
{
    partial class WelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            panelColorBg = new Panel();
            buttonEmployee = new Button();
            buttonAdmin = new Button();
            labelGreet = new Label();
            labelTaytay = new Label();
            labelSiena = new Label();
            panelLogo1 = new Panel();
            panelColorBg.SuspendLayout();
            SuspendLayout();
            // 
            // panelColorBg
            // 
            panelColorBg.BackColor = Color.FromArgb(164, 16, 52);
            panelColorBg.BackgroundImage = (Image)resources.GetObject("panelColorBg.BackgroundImage");
            panelColorBg.BackgroundImageLayout = ImageLayout.Stretch;
            panelColorBg.Controls.Add(buttonEmployee);
            panelColorBg.Controls.Add(buttonAdmin);
            panelColorBg.Controls.Add(labelGreet);
            panelColorBg.Dock = DockStyle.Right;
            panelColorBg.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point);
            panelColorBg.Location = new Point(659, 0);
            panelColorBg.Name = "panelColorBg";
            panelColorBg.Size = new Size(605, 681);
            panelColorBg.TabIndex = 2;
            // 
            // buttonEmployee
            // 
            buttonEmployee.BackColor = Color.FromArgb(247, 208, 2);
            buttonEmployee.Cursor = Cursors.Hand;
            buttonEmployee.FlatStyle = FlatStyle.Flat;
            buttonEmployee.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEmployee.Location = new Point(360, 375);
            buttonEmployee.Name = "buttonEmployee";
            buttonEmployee.Size = new Size(150, 71);
            buttonEmployee.TabIndex = 6;
            buttonEmployee.Text = "EMPLOYEE";
            buttonEmployee.UseVisualStyleBackColor = false;
            buttonEmployee.Click += buttonEmployee_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(247, 208, 2);
            buttonAdmin.Cursor = Cursors.Hand;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdmin.Location = new Point(151, 375);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(150, 71);
            buttonAdmin.TabIndex = 5;
            buttonAdmin.Text = "ADMIN";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // labelGreet
            // 
            labelGreet.AutoSize = true;
            labelGreet.BackColor = Color.Transparent;
            labelGreet.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point);
            labelGreet.ForeColor = Color.White;
            labelGreet.Location = new Point(85, 266);
            labelGreet.Name = "labelGreet";
            labelGreet.Size = new Size(252, 45);
            labelGreet.TabIndex = 0;
            labelGreet.Text = "WELCOME!";
            // 
            // labelTaytay
            // 
            labelTaytay.AutoSize = true;
            labelTaytay.BackColor = Color.Transparent;
            labelTaytay.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTaytay.Location = new Point(225, 430);
            labelTaytay.Name = "labelTaytay";
            labelTaytay.Size = new Size(215, 31);
            labelTaytay.TabIndex = 7;
            labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            labelSiena.AutoSize = true;
            labelSiena.BackColor = Color.Transparent;
            labelSiena.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelSiena.Location = new Point(100, 360);
            labelSiena.Name = "labelSiena";
            labelSiena.Size = new Size(469, 62);
            labelSiena.TabIndex = 6;
            labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelLogo1
            // 
            panelLogo1.BackColor = Color.Transparent;
            panelLogo1.BackgroundImage = (Image)resources.GetObject("panelLogo1.BackgroundImage");
            panelLogo1.BackgroundImageLayout = ImageLayout.Center;
            panelLogo1.Location = new Point(240, 190);
            panelLogo1.Name = "panelLogo1";
            panelLogo1.Size = new Size(200, 169);
            panelLogo1.TabIndex = 16;
            // 
            // WelcomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(panelColorBg);
            Controls.Add(labelTaytay);
            Controls.Add(panelLogo1);
            Controls.Add(labelSiena);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(800, 600);
            Name = "WelcomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SCT ATTENDANCE SYSTEM";
            panelColorBg.ResumeLayout(false);
            panelColorBg.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelColorBg;
        private Button buttonAdmin;
        private Label labelGreet;
        private Label labelTaytay;
        private Label labelSiena;
        private Button buttonEmployee;
        private Panel panelLogo1;
    }
}