using Amazon.SecurityToken.Model;
using Microsoft.Azure.Management.ContainerInstance.Fluent.Models;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (textBoxCurrentPassword.Text == textBoxNewPassword.Text)
            {
                //This is my connection string i have assigned the database file address path
                string MyConnection2 = "datasource=localhost;port=3306;uid=root;pwd=root;";
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string Query = "update login_attendancesystem.user set password='" + this.textBoxNewPassword.Text + "' where username='" + this.textBoxIDNo.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                if (MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("Sucessfully saved!", "Confirmation", MessageBoxButtons.OK);
                    textBoxCurrentPassword.Text = String.Empty;
                    textBoxNewPassword.Text = String.Empty;
                    textBoxIDNo.Text = String.Empty;
                }
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();//Connection closed here
            }
            else
            {
                MessageBox.Show("Password do not match");
            }
        }

        private void labelCurrentPassword_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void verifyBtn_Click(object sender, EventArgs e)
        {

        }


        private void sendBtn_Click(object sender, EventArgs e)
        {

            /*            static async Task Execute()
                        {
                            var apiKey = Environment.GetEnvironmentVariable("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");
                            var client = new SendGridClient(apiKey);
                            var from = new EmailAddress("charlesgocalin7@gmail.com", "Example User");
                            var subject = "Sending with SendGrid is Fun";
                            var to = new EmailAddress("charlesgocalin7@gmail.com", "Example User");
                            var plainTextContent = "and easy to do anywhere, even with C#";
                            var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
                            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
                            var response = await client.SendEmailAsync(msg);
                        }*/


        }

        private void textBoxIDNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurrentPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
        }

        private void labelNewPassword_Click(object sender, EventArgs e)
        {
        }

        private void labelIDNo_Click(object sender, EventArgs e)
        {
        }

        private void labelAccountNumber_Click(object sender, EventArgs e)
        {
        }
    }
}
