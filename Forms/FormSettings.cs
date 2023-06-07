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
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;
        public FormSettings()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

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

        private void labelAccountNumber_Click_1(object sender, EventArgs e)
        {

        }

        private void labelIDNo_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string username = textBoxIDNo.Text;
            string currentPassword = textBoxCurrentPassword.Text;
            string newPassword = textBoxNewPassword.Text;
            string verifyPassword = textBoxCurrentPassword.Text;

            if (currentPassword == verifyPassword)
            {
                // Create a connection to MySQL

                try
                {
                    connection.Open();

                    // Update the password in the adminlogin table
                    string updateQuery = "UPDATE adminlogin SET password = @NewPassword WHERE username = @Username";

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCommand.Parameters.AddWithValue("@Username", username);

                        // Execute the update query
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password changed successfully!");
                            textBoxCurrentPassword.Text = String.Empty;
                            textBoxNewPassword.Text = String.Empty;
                            textBoxCurrentPassword.Text = String.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Failed to change password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        private void labelCurrentPassword_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxIDNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxCurrentPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxNewPassword_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void labelCurrentPassword_Click_2(object sender, EventArgs e)
        {

        }

        private void labelNewPassword_Click_1(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click_1(object sender, EventArgs e)
        {

        }

        private void labelIDNo_Click_2(object sender, EventArgs e)
        {

        }

        private void labelAccountNumber_Click_2(object sender, EventArgs e)
        {

        }
    }
}
