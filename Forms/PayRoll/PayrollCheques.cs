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


        public void AddImageToPDF(Document document, PdfWriter writer, string imagePath)
        {
            try
            {
                // Load the image
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imagePath);

                // Set image position and size
                image.SetAbsolutePosition(20, 730); // Adjust the X and Y coordinates as needed
                image.ScaleToFit(100, 100); // Adjust the width and height as needed

                // Add the image to the document
                document.Add(image);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
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

                string imagePath = "siena-college-of-taytay-logo.png"; // Replace with the actual image path
                AddImageToPDF(document, writer, imagePath);

                // Set up fonts
                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 25, iTextSharp.text.Font.BOLDITALIC);
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font dataFont2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12);
                iTextSharp.text.Font dataFont3 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK);
                iTextSharp.text.Font dataFont4 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK);



                // Add the header
                iTextSharp.text.Paragraph header = new iTextSharp.text.Paragraph("            Siena College of Taytay            PAYSLIP", headerFont);

                header.Alignment = iTextSharp.text.Element.ALIGN_LEFT;
                header.Font.Color = new BaseColor(128, 0, 0); // RGB values for maroon
                document.Add(header);

                // Add spacing between header and table
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

                // Create a table with 2 columns
                PdfPTable table2 = new PdfPTable(1);
                // Set table properties
                table2.WidthPercentage = 100;

                // Create a cell with background color
                PdfPCell cell = new PdfPCell(new Phrase("PAYROLL", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE)));
                cell.BackgroundColor = new BaseColor(128, 0, 0); // Set your desired background color here
                cell.Padding = 10; // Add padding for content
                cell.Border = PdfPCell.NO_BORDER; // Remove cell border
                cell.HorizontalAlignment = Element.ALIGN_CENTER; // Center the content horizontally
                cell.VerticalAlignment = Element.ALIGN_MIDDLE; // Center the content vertically

                PdfPTable table3 = new PdfPTable(1);
                // Set table properties
                table3.WidthPercentage = 100;

                // Create a cell with background color
                PdfPCell cell2 = new PdfPCell(new Phrase("EMPLOYEE INFORMATION", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.WHITE)));
                cell2.BackgroundColor = new BaseColor(128, 0, 0); // Set your desired background color here
                cell2.Padding = 10; // Add padding for content
                cell2.Border = PdfPCell.NO_BORDER; // Remove cell border
                cell2.HorizontalAlignment = Element.ALIGN_CENTER; // Center the content horizontally
                cell2.VerticalAlignment = Element.ALIGN_MIDDLE; // Center the content vertically

                PdfPTable table4 = new PdfPTable(1);
                // Set table properties
                table4.WidthPercentage = 100;

                // Create a cell with background color
                PdfPCell cell3 = new PdfPCell(new Phrase("DETAILS                                                                       AMOUNT", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 12, iTextSharp.text.Font.BOLDITALIC, BaseColor.BLACK)));
                cell3.Padding = 10; // Add padding for content
                cell3.Border = PdfPCell.NO_BORDER; // Remove cell border

                // Create a table with 4 columns
                PdfPTable table5 = new PdfPTable(2);

                // Set table properties
                table5.WidthPercentage = 100;
                table5.DefaultCell.Padding = 10;

                // Create a table with 4 columns
                PdfPTable table6 = new PdfPTable(2);

                // Set table properties
                table6.WidthPercentage = 100;
                table6.DefaultCell.Padding = 10;

                // Create a table with 4 columns
                PdfPTable table7 = new PdfPTable(2);

                // Set table properties
                table7.WidthPercentage = 100;
                table7.DefaultCell.Padding = 10;


                // Create a table with 4 columns
                PdfPTable table8 = new PdfPTable(2);

                // Set table properties
                table8.WidthPercentage = 100;
                table8.DefaultCell.Padding = 10;


                // Add employee name cell
                table.AddCell(new PdfPCell(new Phrase("Employee Name:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData12, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Birth Date:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(dob, dataFont2)));

                // Add deductions cell
                table.AddCell(new PdfPCell(new Phrase("Date Hired:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(hod, dataFont2)));

                // Add department cell
                table.AddCell(new PdfPCell(new Phrase("Department:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData1, dataFont2)));

                // Add occupation cell
                table.AddCell(new PdfPCell(new Phrase("Occupation:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData2, dataFont2)));

                // Add date cell
                table.AddCell(new PdfPCell(new Phrase("Payroll Date:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(DateTime.Now.ToString("MMMM dd, yyyy"), dataFont2)));

                // Add account number cell
                table.AddCell(new PdfPCell(new Phrase("Account Number:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData4, dataFont2)));

                // Add hourly rate cell
                table.AddCell(new PdfPCell(new Phrase("Payroll Type:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData13, dataFont2)));

                // Add hourly rate cell
                table.AddCell(new PdfPCell(new Phrase("Hourly Rate:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData7, dataFont2)));


                // Add basic salary cell
                table.AddCell(new PdfPCell(new Phrase("Basic Salary:", dataFont)));
                table.AddCell(new PdfPCell(new Phrase(transferredData3, dataFont2)));

                //CONTRIBUTIONS
                table5.AddCell(new PdfPCell(new Phrase("SSS", dataFont3)));
                table5.AddCell(new PdfPCell(new Phrase("675.00", dataFont2)));
                table5.AddCell(new PdfPCell(new Phrase("Philhealth", dataFont3)));
                table5.AddCell(new PdfPCell(new Phrase("300.00", dataFont2)));
                table5.AddCell(new PdfPCell(new Phrase("Pag-IBIG", dataFont3)));
                table5.AddCell(new PdfPCell(new Phrase("100.00", dataFont2)));
                table5.AddCell(new PdfPCell(new Phrase("CONTRIBUTIONS TOTAL", dataFont3)));
                table5.AddCell(new PdfPCell(new Phrase(transferredData20, dataFont3)));

                //DEDUCTION
                table6.AddCell(new PdfPCell(new Phrase("Late Hours", dataFont3)));
                table6.AddCell(new PdfPCell(new Phrase(transferredData16, dataFont2)));
                table6.AddCell(new PdfPCell(new Phrase("Undertime Hours", dataFont3)));
                table6.AddCell(new PdfPCell(new Phrase(transferredData15, dataFont2)));
                table6.AddCell(new PdfPCell(new Phrase("Contribution", dataFont3)));
                table6.AddCell(new PdfPCell(new Phrase(transferredData20, dataFont2)));
                table6.AddCell(new PdfPCell(new Phrase("DEDUCTIONS TOTAL", dataFont3)));
                table6.AddCell(new PdfPCell(new Phrase(transferredData9, dataFont3)));

                //Gross
                table7.AddCell(new PdfPCell(new Phrase("Total Salary", dataFont3)));
                table7.AddCell(new PdfPCell(new Phrase(transferredData19, dataFont2)));
                table7.AddCell(new PdfPCell(new Phrase("Allowance", dataFont3)));
                table7.AddCell(new PdfPCell(new Phrase(transferredData18, dataFont2)));
                table7.AddCell(new PdfPCell(new Phrase("GROSS SALARY", dataFont3)));
                table7.AddCell(new PdfPCell(new Phrase(transferredData10, dataFont3)));

                //NET PAY
                table8.AddCell(new PdfPCell(new Phrase("Gross Salary", dataFont3)));
                table8.AddCell(new PdfPCell(new Phrase(transferredData10, dataFont2)));
                table8.AddCell(new PdfPCell(new Phrase("Deductions", dataFont3)));
                table8.AddCell(new PdfPCell(new Phrase(transferredData9, dataFont2)));
                table8.AddCell(new PdfPCell(new Phrase("NET PAY", dataFont3)));
                table8.AddCell(new PdfPCell(new Phrase(transferredData11, dataFont3)));

                table2.AddCell(cell);
                table3.AddCell(cell2);
                table4.AddCell(cell3);



                // Add the table to the document
                document.Add(table3);
                document.Add(table);
                document.Add(new iTextSharp.text.Paragraph(" "));

                document.Add(table2);

                document.Add(table4);
                document.Add(table5);

                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(table6);

                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(table7);

                document.Add(new iTextSharp.text.Paragraph(" "));
                document.Add(table8);


                // Close the document
                document.Close();

                MessageBox.Show("Payslip exported to PDF successfully!");
                this.Close();

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
            textBox17.Text = transferredData18; // allowance
            textBox14.Text = transferredData15; // undertime
            textBox15.Text = transferredData16; // late
            textBox16.Text = transferredData20; // contributions
            textBox18.Text = transferredData19; // totalsalary

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
