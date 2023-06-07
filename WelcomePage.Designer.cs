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
            this.panelColorBg = new System.Windows.Forms.Panel();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.labelGreet = new System.Windows.Forms.Label();
            this.labelTaytay = new System.Windows.Forms.Label();
            this.labelSiena = new System.Windows.Forms.Label();
            this.panelLogo1 = new System.Windows.Forms.Panel();
            this.panelColorBg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelColorBg
            // 
            this.panelColorBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(16)))), ((int)(((byte)(52)))));
            this.panelColorBg.Controls.Add(this.buttonEmployee);
            this.panelColorBg.Controls.Add(this.buttonAdmin);
            this.panelColorBg.Controls.Add(this.labelGreet);
            this.panelColorBg.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelColorBg.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelColorBg.Location = new System.Drawing.Point(659, 0);
            this.panelColorBg.Name = "panelColorBg";
            this.panelColorBg.Size = new System.Drawing.Size(605, 681);
            this.panelColorBg.TabIndex = 2;
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEmployee.Location = new System.Drawing.Point(360, 375);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(150, 71);
            this.buttonEmployee.TabIndex = 6;
            this.buttonEmployee.Text = "EMPLOYEE";
            this.buttonEmployee.UseVisualStyleBackColor = false;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(208)))), ((int)(((byte)(2)))));
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdmin.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdmin.Location = new System.Drawing.Point(151, 375);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(150, 71);
            this.buttonAdmin.TabIndex = 5;
            this.buttonAdmin.Text = "ADMIN";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // labelGreet
            // 
            this.labelGreet.AutoSize = true;
            this.labelGreet.BackColor = System.Drawing.Color.Transparent;
            this.labelGreet.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGreet.ForeColor = System.Drawing.Color.White;
            this.labelGreet.Location = new System.Drawing.Point(85, 266);
            this.labelGreet.Name = "labelGreet";
            this.labelGreet.Size = new System.Drawing.Size(252, 45);
            this.labelGreet.TabIndex = 0;
            this.labelGreet.Text = "WELCOME!";
            // 
            // labelTaytay
            // 
            this.labelTaytay.AutoSize = true;
            this.labelTaytay.BackColor = System.Drawing.Color.Transparent;
            this.labelTaytay.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTaytay.Location = new System.Drawing.Point(225, 430);
            this.labelTaytay.Name = "labelTaytay";
            this.labelTaytay.Size = new System.Drawing.Size(215, 31);
            this.labelTaytay.TabIndex = 7;
            this.labelTaytay.Text = "TAYTAY, RIZAL";
            // 
            // labelSiena
            // 
            this.labelSiena.AutoSize = true;
            this.labelSiena.BackColor = System.Drawing.Color.Transparent;
            this.labelSiena.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSiena.Location = new System.Drawing.Point(100, 360);
            this.labelSiena.Name = "labelSiena";
            this.labelSiena.Size = new System.Drawing.Size(469, 62);
            this.labelSiena.TabIndex = 6;
            this.labelSiena.Text = "SIENA COLLEGE";
            // 
            // panelLogo1
            // 
            this.panelLogo1.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo1.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.logo1;
            this.panelLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo1.Location = new System.Drawing.Point(240, 190);
            this.panelLogo1.Name = "panelLogo1";
            this.panelLogo1.Size = new System.Drawing.Size(200, 169);
            this.panelLogo1.TabIndex = 16;
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCTAttendanceSystemUI.Properties.Resources.BG_LOW_OPACITY;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelColorBg);
            this.Controls.Add(this.labelTaytay);
            this.Controls.Add(this.panelLogo1);
            this.Controls.Add(this.labelSiena);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCT ATTENDANCE SYSTEM";
            this.panelColorBg.ResumeLayout(false);
            this.panelColorBg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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