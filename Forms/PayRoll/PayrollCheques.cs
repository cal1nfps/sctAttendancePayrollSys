using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SCTAttendanceSystemUI.Forms.PayRoll
{
    public partial class PayrollCheques : Form
    {
        private string transferredData1;
        private string transferredData2;
        private string transferredData3;
        private string transferredData4;
        private string transferredData5;
        private string transferredData6;
        private string transferredData7;
        private string transferredData8;
        private string transferredData9;
        private string transferredData10;
        private string transferredData11;
        private string transferredData12;
        private string transferredData13;
        private string transferredData14;
        private string transferredData15;
        private string transferredData16;
        private string transferredData17;
        private string transferredData18;
        private string transferredData19;
        private string transferredData20;




        public PayrollCheques(string department, string occupation, string jobsalary, string accountnum, string hiredate, string dob, string hourlyrate, string date, string deduction,
            string gross, string net, string name, string payrolltype, string overtimehours, string undertime, string late, string totalhours, string allowance, string totalsalary, string contributions)
        {
            InitializeComponent();
            transferredData1 = department;
            transferredData2 = occupation;
            transferredData3 = jobsalary;
            transferredData4 = accountnum;
            transferredData5 = hiredate;
            transferredData6 = dob;
            transferredData7 = hourlyrate;
            transferredData8 = date;
            transferredData9 = deduction;
            transferredData10 = gross;
            transferredData11 = net;
            transferredData12 = name;
            transferredData13 = payrolltype;
            transferredData14 = overtimehours;
            transferredData15 = undertime;
            transferredData16 = late;
            transferredData17 = totalhours;
            transferredData18 = allowance;
            transferredData19 = totalsalary;
            transferredData20 = contributions;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a save file dialog to get the file path to save the PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Export to PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Create a PDF document
                iTextSharp.text.Document document = new iTextSharp.text.Document();

                // Create a PDF writer to write the document to the file
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Open the document
                document.Open();

                // Set up fonts
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 25, iTextSharp.text.Font.BOLDITALIC);
                iTextSharp.text.Font headerFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 20, iTextSharp.text.Font.BOLDITALIC);
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font dataFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);

                // Add the header
                iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph("Siena College of Taytay                   PAYSLIP", headerFont);

                header.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                header.Font.Color = new BaseColor(128, 0, 0); // RGB values for maroon
                document.Add(header);

                // Create the subheader text
                Chunk subHeaderText = new Chunk("Subheader Text", dataFont); 
                subHeaderText.SetBackground(new BaseColor(128, 0, 0)); // Set the background color


                // Create the subheader paragraph
                Paragraph subHeader = new Paragraph(subHeaderText);
                subHeader.Font.Color = new BaseColor(Color.White); // RGB values for maroon
                subHeader.Alignment = Element.ALIGN_LEFT;

                // Add the subheader to the document
                document.Add(subHeader);

                // Add spacing between header and table
                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(new iTextSharp.text.Paragraph(" "));

                string dob = DateTime.Parse(transferredData6).ToString("MMMM dd, yyyy");
                string hod = DateTime.Parse(transferredData5).ToString("MMMM dd, yyyy");



                // Create a table with 2 columns
                PdfPTable table = new PdfPTable(4);

                // Set table properties
                table.WidthPercentage = 100;
                table.DefaultCell.Padding = 10;
                table.DefaultCell.Border = PdfPCell.NO_BORDER;

                // Add employee name cell
                table.AddCell(new PdfPCell(new Phrase("Employee Name:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData12, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Date of Birth:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(dob, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Hire Date:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(hod, dataFont2)));

                // Add department cell
                table.AddCell(new PdfPCell(new Phrase("Department:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData1, dataFont2)));

                // Add occupation cell
                table.AddCell(new PdfPCell(new Phrase("Occupation:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData2, dataFont2)));

                // Add date cell
                table.AddCell(new PdfPCell(new Phrase("Date:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(DateTime.Now.ToString("MMMM dd, yyyy"), dataFont2)));

                // Add account number cell
                table.AddCell(new PdfPCell(new Phrase("Account Number:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData4, dataFont2)));

                // Add hourly rate cell
                table.AddCell(new PdfPCell(new Phrase("Hourly Rate:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData7, dataFont2)));


                // Add basic salary cell
                table.AddCell(new PdfPCell(new Phrase("Basic Salary:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData3, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Deductions:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData9, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Gross Salary:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData10, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Net Pay:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData11, dataFont2)));

                // Add the table to the document
                document.Add(table);

                // Close the document
                document.Close();

                MessageBox.Show("Payslip exported to PDF successfully!");
            }
        }


        private void PayrollCheques_Load(object sender, EventArgs e)
        {

            textBox1.Text = transferredData13; // payrolltype
            textBox2.Text = transferredData1; // department
            textBox6.Text = transferredData2; // occupation
            textBox7.Text = transferredData3; // salary
            textBox9.Text = transferredData4; // accountnum
            textBox3.Text = DateTime.Parse(transferredData5).ToString("MMMM dd, yyyy"); //hired date
            textBox4.Text = DateTime.Parse(transferredData6).ToString("MMMM dd, yyyy"); //dob
            textBox8.Text = transferredData7; // hourlyrate
            textBox5.Text = DateTime.Parse(transferredData8).ToString("MMMM dd, yyyy"); //payroll date
            textBox10.Text = transferredData10; // gross
            textBox11.Text = transferredData11; // net
            textBox12.Text = transferredData12; // name
            textBox13.Text = transferredData9; // deduction


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {
        }
    }
}
