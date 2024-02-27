using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SCTAttendanceSystemUI.Forms.filterButton;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Drawing.Drawing2D;
using LiveCharts;
using LiveCharts.Wpf;
using Microsoft.Graph.Models.Security;

namespace SCTAttendanceSystemUI.Forms
{
    public partial class FormDashboard : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable table;

        public FormDashboard()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            connection = new MySqlConnection(connectionString);
            ApplyRoundedCorners(panelTimeIn, 20);
            ApplyRoundedCorners(panelTimeOut, 20);
            ApplyRoundedCorners(panelPresent, 20);
            ApplyRoundedCorners(panelLate, 20);
            ApplyRoundedCorners(panelAbsent, 20);
            ApplyRoundedCorners(panelLateToday, 20);

            UpdatePresentCount();
            UpdateAbsentCount();
            UpdateLateCount();

            SetDataGridViewStyle(dataGridViewRecentTimeIn, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed
            SetDataGridViewStyle(dataGridViewRecentTimeOut, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed
            SetDataGridViewStyle(dataGridViewLateToday, new Padding(10, 5, 10, 5), 30, 10); // Adjust the Padding values, cell height, and font size as needed




        }

        private void SetDataGridViewStyle(DataGridView dataGridView, Padding cellPadding, int cellHeight, float fontSize)
        {
            // Set the cell padding, height, and font size for the default cell style
            dataGridView.DefaultCellStyle.Padding = cellPadding;
            dataGridView.RowTemplate.Height = cellHeight;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);

            // Set the height and font size for the column headers
            dataGridView.ColumnHeadersHeight = cellHeight;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);


            // If you want to set the font size for the header cells as well, uncomment the following line
            // dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", fontSize);
        }

        private void UpdatePresentCount()
        {
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM empattendance WHERE status IN ('Present/On-Time');";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int returnedItemCount = Convert.ToInt32(command.ExecuteScalar());

                        labelPresentCount.Text = returnedItemCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating present count: {ex.Message}");
            }
        }

        private void UpdateLateCount()
        {
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM empattendance WHERE status IN ('Present/Late');";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        int returnedItemCount = Convert.ToInt32(command.ExecuteScalar());

                        labelLateCounter.Text = returnedItemCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating present count: {ex.Message}");
            }
        }

        private void UpdateAbsentCount()
        {
            string connectionString = "server=localhost;user=root;password=root;database=payrollsys";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve absent employees for today
                    string query = "SELECT COUNT(*) FROM employee WHERE employeenum NOT IN (SELECT empnum FROM empattendance WHERE DATE(date) = @today)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@today", DateTime.Today);

                        int absentCount = Convert.ToInt32(command.ExecuteScalar());

                        labelAbsentCounter.Text = absentCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating absent count: {ex.Message}");
            }
        }


        private void ApplyRoundedCorners(Panel panel, int cornerRadius)
        {


            using (GraphicsPath path = new GraphicsPath())
            {
                // Define the rounded rectangle by specifying arcs for the corners and lines for the sides
                path.StartFigure();

                // Top left corner
                path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);

                // Top side
                path.AddLine(cornerRadius, 0, panel.Width - cornerRadius, 0);

                // Top right corner
                path.AddArc(panel.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);

                // Right side
                path.AddLine(panel.Width, cornerRadius, panel.Width, panel.Height - cornerRadius);

                // Bottom right corner
                path.AddArc(panel.Width - cornerRadius * 2, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);

                // Bottom side
                path.AddLine(cornerRadius, panel.Height, panel.Width - cornerRadius, panel.Height);

                // Bottom left corner
                path.AddArc(0, panel.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);

                // Left side
                path.AddLine(0, cornerRadius, 0, panel.Height - cornerRadius);

                path.CloseFigure();

                // Create a new region based on the path
                Region region = new Region(path);

                // Apply the region to the panel, making its corners rounded
                panel.Region = region;
            }
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            adapter = new MySqlDataAdapter("SELECT * FROM empattendance", connection);


            // Create a DataTable to hold the data
            table = new DataTable();

            // Fill the DataTable with the data retrieved by the adapter
            adapter.Fill(table);


            // TIMEIN
            dataGridViewRecentTimeIn.DataSource = table;

            dataGridViewRecentTimeIn.Columns["name"].HeaderText = "Name";
            dataGridViewRecentTimeIn.Columns["occupation"].HeaderText = "Occupation";
            dataGridViewRecentTimeIn.Columns["timein"].HeaderText = "Time-In";

            dataGridViewRecentTimeIn.Sort(dataGridViewRecentTimeIn.Columns["timein"], ListSortDirection.Descending);



            dataGridViewRecentTimeIn.Columns["id"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["empnum"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["department"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["jobstatus"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["jobhours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["jobtimein"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["jobtimeout"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["date"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["timeout"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["totalhours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["overtimehours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["status"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["undertime"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeIn.Columns["late"].Visible = false;    //Hide a specific column



            // Create a DataView and apply a filter
            DataView dataView = new DataView(table);
            dataView.RowFilter = "NOT (timeout IS NULL OR timeout = '1900-01-01 00:00:00')";

            // Set the DataSource of the DataGridView to the DataView
            dataGridViewRecentTimeOut.DataSource = dataView;

            dataGridViewRecentTimeOut.Columns["name"].HeaderText = "Name";
            dataGridViewRecentTimeOut.Columns["occupation"].HeaderText = "Occupation";
            dataGridViewRecentTimeOut.Columns["timeout"].HeaderText = "Time-Out";

            dataGridViewRecentTimeOut.Sort(dataGridViewRecentTimeOut.Columns["timeout"], ListSortDirection.Descending);


            dataGridViewRecentTimeOut.Columns["id"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["empnum"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["department"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["jobstatus"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["jobhours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["jobtimein"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["jobtimeout"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["date"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["timein"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["totalhours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["overtimehours"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["status"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["undertime"].Visible = false;    //Hide a specific column
            dataGridViewRecentTimeOut.Columns["late"].Visible = false;    //Hide a specific column


            // Assuming your DataTable is named 'table'
            DataView lateTodayView = new DataView(table);

            // Set the filter to only show rows with 'Present/Late' status
            lateTodayView.RowFilter = "status = 'Present/Late'";

            // Bind the DataView to the DataGridView
            dataGridViewLateToday.DataSource = lateTodayView;

            // Set the columns you want to display
            dataGridViewLateToday.Columns["name"].HeaderText = "Name";
            dataGridViewLateToday.Columns["department"].HeaderText = "Department";
            dataGridViewLateToday.Columns["occupation"].HeaderText = "Occupation";
            dataGridViewLateToday.Columns["timein"].HeaderText = "Time-In";
            dataGridViewLateToday.Columns["late"].HeaderText = "Late";

            dataGridViewLateToday.Sort(dataGridViewLateToday.Columns["timein"], ListSortDirection.Descending);

            // Set columns to be hidden
            dataGridViewLateToday.Columns["id"].Visible = false;
            dataGridViewLateToday.Columns["empnum"].Visible = false;
            dataGridViewLateToday.Columns["jobstatus"].Visible = false;
            dataGridViewLateToday.Columns["jobhours"].Visible = false;
            dataGridViewLateToday.Columns["jobtimein"].Visible = false;
            dataGridViewLateToday.Columns["jobtimeout"].Visible = false;
            dataGridViewLateToday.Columns["date"].Visible = false;
            dataGridViewLateToday.Columns["timeout"].Visible = false;
            dataGridViewLateToday.Columns["totalhours"].Visible = false;
            dataGridViewLateToday.Columns["overtimehours"].Visible = false;
            dataGridViewLateToday.Columns["status"].Visible = false;
            dataGridViewLateToday.Columns["undertime"].Visible = false;




        }

        private void dataGridViewRecentTimeIn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is the "Time-In" column and the cell value is a valid DateTime
            if (dataGridViewRecentTimeIn.Columns[e.ColumnIndex].Name == "timein" && e.Value != null && e.Value != DBNull.Value && e.Value is DateTime)
            {
                DateTime timeIn = (DateTime)e.Value;
                TimeSpan timeDifference = DateTime.Now - timeIn;

                // Format the time difference
                string formattedTimeDifference = FormatTimeDifference(timeDifference);

                // Set the formatted string to the cell
                e.Value = formattedTimeDifference;
                e.FormattingApplied = true;
            }
        }

        private string FormatTimeDifference(TimeSpan timeDifference)
        {
            // Format the time difference as needed (e.g., '25 minutes ago')
            if (timeDifference.TotalSeconds < 60)
            {
                return $"{(int)timeDifference.TotalSeconds}s Ago";
            }
            else if (timeDifference.TotalMinutes < 1)
            {
                return "Just now";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes}m Ago";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours}h Ago";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays}d Ago";
            }
        }


        private void dataGridViewRecentTimeOut_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the column is the "Time-In" column and the cell value is a valid DateTime
            if (dataGridViewRecentTimeIn.Columns[e.ColumnIndex].Name == "timeout" && e.Value != null && e.Value != DBNull.Value && e.Value is DateTime)
            {
                DateTime timeIn = (DateTime)e.Value;
                TimeSpan timeDifference = DateTime.Now - timeIn;

                // Format the time difference
                string formattedTimeDifference = FormatTimeDifference(timeDifference);

                // Set the formatted string to the cell
                e.Value = formattedTimeDifference;
                e.FormattingApplied = true;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewLateToday_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current cell belongs to the "DateColumn" and has a datetime value
            if (dataGridViewLateToday.Columns[e.ColumnIndex].Name == "timein" && e.Value != null && e.Value is DateTime)
            {
                // Format the datetime value to the desired format
                DateTime dateValue = (DateTime)e.Value;
                e.Value = dateValue.ToString("hh:mm:ss tt");
                e.FormattingApplied = true;
            }
        }
    }
}
