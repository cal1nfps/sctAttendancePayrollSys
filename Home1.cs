using SCTAttendanceSystemUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCTAttendanceSystemUI
{
    public partial class Home1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm = null;

        public Home1()
        {
            InitializeComponent();
            customizeDesign();
            random = new Random();
        }

        private void customizeDesign()
        {
            //panelEmployeesSubMenu.Visible = false;
        }

        /*private void hideSubMenu()
        {
            if (panelEmployeesSubMenu.Visible == true)
                panelEmployeesSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }*/

        /*private void customizeDesign()
        {
            panelDepartmentSubmenu.Visible = false;
        }*/

        /*private void hideSubMenu()
        {
            if (panelDepartmentSubmenu.Visible == true)
                panelDepartmentSubmenu.Visible = false;
        }*/

        /*private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }*/

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
        }

        private void ActivateButtonSearch(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    //DisableButtonSearch();

                    currentButton = (Button)buttonSender;
                    currentButton.ForeColor = Color.Gray;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
            /*foreach (Control previousButton in panelDropdownDepartments.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }
            foreach (Control previousButton in panelEmployeesSubMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                }
            }*/
        }

        /*private void DisableButtonSearch()
        {
            foreach (Control previousButton in panelSearch.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(164, 16, 48);
                    previousButton.ForeColor = Color.Gray;
                }
            }
        }*/

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /*public void OpenForm(Form newForm)
        {
            //FormMain.ticketCount.Text = DataManager.LoadTickets("SELECT * FROM TICKETS").Count.ToString();
            //FormMain.openCount.Text = DataManager.LoadTickets("SELECT * FROM TICKETS WHERE resolved=''").Count.ToString();
            //FormMain.closedCount.Text = DataManager.LoadTickets("SELECT * FROM TICKETS WHERE NOT resolved=''").Count.ToString();
            this.panelDesktopPane.Controls.Clear();
            currentForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(currentForm);
            this.panelDesktopPane.Tag = currentForm;
            newForm.BringToFront();
            newForm.Show();
            //HomeLabel.Text = currentForm.Text;
        }*/

        /*private void OpenChildFormSearch(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButtonSearch(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }*/

        private void OpenChildFormDepEmp(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButtonSearch(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        /*private void buttonSetings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
            //hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSED(), sender);
            hideSubMenu();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OpenChildFormSearch(new Forms.FormSearch(), sender);
            hideSubMenu();
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAddAttendance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAddAttendance(), sender);
        }

        private void buttonViewRecords_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormViewRecords(), sender);
        }

        private void buttonDepartments_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDropdownDepartments);
        }

        private void Home1_Load(object sender, EventArgs e)
        {

        }

        private void panelEmployeesSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSettings_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
            hideSubMenu();
        }

        private void buttonPayroll_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPayroll(), sender);
            hideSubMenu();
        }

        private void buttonIbed_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIBED(), sender);
            hideSubMenu();
        }

        private void buttonAsp_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormASP(), sender);
            hideSubMenu();
        }

        private void buttonAbsentees_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbsentees(), sender);
            hideSubMenu();
        }

        private void buttonEmployees_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelEmployeesSubMenu);
            OpenChildFormDepEmp(new Forms.FormLogout(), sender);
        }

        private void buttonEmployeeList_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmployeeList(), sender);
            hideSubMenu();
        }

        private void buttonCashAdvance_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCashAdvance(), sender);
            hideSubMenu();
        }

        private void buttonSchedule1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSchedule(), sender);
            hideSubMenu();
        }

        private void buttonOvertime_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOvertime(), sender);
            hideSubMenu();
        }

        private void buttonDeduction_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDeduction(), sender);
            hideSubMenu();
        }

        private void buttonLeave_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLeave(), sender);
            hideSubMenu();
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form_home1 = new Form1();
                form_home1.ShowDialog();
                this.Close();
            }
        }
        

        /// <summary>
        /// 
        /// </summary>

        private void buttonSed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSED1(), sender);
            //FormSED1 form_sed = new FormSED1();
            //form_sed.ShowDialog();
            hideSubMenu();
        }

        private void buttonHome_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
            //OpenChildForm(new Forms.FormDepartment(), sender);
            //FormDepartment form_dep = new FormDepartment();
            //form_dep.ShowDialog();
            //OpenForm(FormHome);
            //FormHome.asyncPopulate();
            //hideSubMenu();
        }

        private void buttonDepartment_Click_2(object sender, EventArgs e)
        {
            //showSubMenu(panelDropdownDepartments);
            OpenChildForm(new Forms.FormDepartment(), sender);
        }

        private void buttonIbed_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIBED1(), sender);
            hideSubMenu();
        }

        private void buttonAsp_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormASP1(), sender);
            hideSubMenu();
        }

        private void buttonAbsentees_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbsentees(), sender);
            hideSubMenu();
        }

        private void buttonEmployeeList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmployeeList(), sender);
            hideSubMenu();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelEmployeesSubMenu1);
            OpenChildFormDepEmp(new Forms.FormLogout(), sender);
        }

        private void buttonCashAdvance_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCashAdvance(), sender);
            hideSubMenu();
        }

        private void buttonSchedule1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSchedule(), sender);
            hideSubMenu();
        }

        private void buttonOvertime_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOvertime(), sender);
            hideSubMenu();
        }

        private void buttonDeduction_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDeduction(), sender);
            hideSubMenu();
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLeave(), sender);
            hideSubMenu();
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPayroll(), sender);
            hideSubMenu();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
            hideSubMenu();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form1 form_home1 = new Form1();
                form_home1.ShowDialog();
                this.Close();
            }
        }


        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            OpenChildFormSearch(new Forms.FormSearch(), sender);
            hideSubMenu();
        }

        private void Home1_Load_1(object sender, EventArgs e)
        {

        }*/

        /// <summary>
        /// /
        /// </summary>

        /*private void buttonAbsentees_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbsentees(), sender);
            hideSubMenu();
        }

        private void buttonCashAdvance_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCashAdvance(), sender);
            hideSubMenu();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSchedule(), sender);
            hideSubMenu();
        }

        private void buttonLeave_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLeave(), sender);
            hideSubMenu();
        }

        /// <summary>
        /// 
        /// </summary>

        private void buttonOvertime_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOvertime(), sender);
            //hideSubMenu();
        }

        private void buttonDeduction_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDeduction(), sender);
            //hideSubMenu();
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPayroll(), sender);
            //hideSubMenu();
        }*/

        /// <summary>
        /// 
        ///
        /// </summary>

        private void buttonAttendance_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);
        }

        private void buttonDepartment_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDepartment(), sender);
        }

        private void buttonEmployeeList_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormEmployeeList(), sender);
        }

        private void buttonAbsentees_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAbsentees(), sender);
        }

        private void buttonLeave_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLeave(), sender);
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPayroll(), sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                WelcomePage form_home1 = new WelcomePage();
                form_home1.ShowDialog();
                this.Close();
            }
        }
    }
}
