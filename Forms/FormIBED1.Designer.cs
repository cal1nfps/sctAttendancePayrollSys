﻿namespace SCTAttendanceSystemUI.Forms
{
    partial class FormIBED1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIBED1));
            dataGridViewIBED = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            clearLabel = new Label();
            deleteButton = new Button();
            searchBox = new TextBox();
            button4 = new Button();
            buttonBackBtn = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIBED).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewIBED
            // 
            dataGridViewIBED.AllowUserToAddRows = false;
            dataGridViewIBED.AllowUserToDeleteRows = false;
            dataGridViewIBED.AllowUserToResizeRows = false;
            dataGridViewIBED.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewIBED.BackgroundColor = Color.FromArgb(239, 243, 246);
            dataGridViewIBED.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIBED.Location = new Point(33, 165);
            dataGridViewIBED.Margin = new Padding(3, 2, 3, 2);
            dataGridViewIBED.Name = "dataGridViewIBED";
            dataGridViewIBED.ReadOnly = true;
            dataGridViewIBED.RowHeadersVisible = false;
            dataGridViewIBED.RowTemplate.Height = 28;
            dataGridViewIBED.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIBED.Size = new Size(1587, 593);
            dataGridViewIBED.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(99, 27, 75);
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(220, 25);
            label1.Name = "label1";
            label1.Size = new Size(38, 45);
            label1.TabIndex = 60;
            label1.Text = "1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(99, 27, 75);
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 50);
            label4.Name = "label4";
            label4.Size = new Size(202, 20);
            label4.TabIndex = 59;
            label4.Text = "Total Attendance for today:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(99, 27, 75);
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 13);
            label5.Name = "label5";
            label5.Size = new Size(77, 37);
            label5.TabIndex = 62;
            label5.Text = "IBED";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(clearLabel);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(buttonBackBtn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridViewIBED);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(1920, 1080);
            panel1.MinimumSize = new Size(800, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(1682, 861);
            panel1.TabIndex = 63;
            // 
            // clearLabel
            // 
            clearLabel.AutoSize = true;
            clearLabel.BackColor = Color.Transparent;
            clearLabel.Cursor = Cursors.Hand;
            clearLabel.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            clearLabel.Location = new Point(1509, 760);
            clearLabel.Name = "clearLabel";
            clearLabel.Size = new Size(111, 15);
            clearLabel.TabIndex = 76;
            clearLabel.Text = "CLEAR ALL DATA";
            clearLabel.Click += clearLabel_Click;
            clearLabel.MouseEnter += clearLabel_MouseEnter;
            clearLabel.MouseLeave += clearLabel_MouseLeave;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(219, 20, 62);
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageAlign = ContentAlignment.MiddleLeft;
            deleteButton.Location = new Point(1573, 128);
            deleteButton.Name = "deleteButton";
            deleteButton.Padding = new Padding(10, 0, 0, 0);
            deleteButton.Size = new Size(47, 32);
            deleteButton.TabIndex = 64;
            deleteButton.TextAlign = ContentAlignment.MiddleLeft;
            deleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.Location = new Point(33, 128);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search";
            searchBox.Size = new Size(310, 32);
            searchBox.TabIndex = 75;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(219, 20, 62);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(349, 128);
            button4.Name = "button4";
            button4.Padding = new Padding(10, 0, 0, 0);
            button4.Size = new Size(47, 32);
            button4.TabIndex = 71;
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonBackBtn
            // 
            buttonBackBtn.BackColor = Color.Transparent;
            buttonBackBtn.Cursor = Cursors.Hand;
            buttonBackBtn.FlatAppearance.BorderSize = 0;
            buttonBackBtn.FlatStyle = FlatStyle.Flat;
            buttonBackBtn.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonBackBtn.Image = (Image)resources.GetObject("buttonBackBtn.Image");
            buttonBackBtn.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBackBtn.Location = new Point(33, 20);
            buttonBackBtn.Name = "buttonBackBtn";
            buttonBackBtn.Size = new Size(45, 48);
            buttonBackBtn.TabIndex = 58;
            buttonBackBtn.UseVisualStyleBackColor = false;
            buttonBackBtn.Click += buttonBackBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(99, 27, 75);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(84, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 85);
            panel2.TabIndex = 53;
            // 
            // FormIBED1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1682, 861);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1598, 821);
            Name = "FormIBED1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIBED1";
            Load += FormIBED1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewIBED).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button buttonBackBtn;
        public DataGridView dataGridViewIBED;
        private Button button4;
        private TextBox searchBox;
        private Button deleteButton;
        private Label clearLabel;
    }
}