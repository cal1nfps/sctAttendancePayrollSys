using MySql.Data.MySqlClient;

namespace SCTAttendanceSystemUI
{
    public partial class WelcomePage : Form
    {

        string username, password;


        public WelcomePage()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /*string cs = "server=localhost;database=login_attendancesystem;uid=root;pwd=root;";
            var con = new MySqlConnection(cs);
            try
            {
                if(textBoxIDNum.Text != "" && textBoxPassword.Text != "")
                {
                con.Open();
                string stm = "select username,password from user WHERE username='" + textBoxIDNum.Text + "' AND password ='" + textBoxPassword.Text + "'";
                var cmd = new MySqlCommand(stm, con);
                    MySqlDataReader row;
                    row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            username = row["username"].ToString();
                            password = row["password"].ToString();
                        }
                        main_form();
                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
            con.Close();*/
        }

        /*private void main_form()
        {
            this.Hide();
            Home1 form_home1 = new Home1();
            form_home1.ShowDialog();
            this.Close();
        }

        private void textBoxIDNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin form_home2 = new EmployeeLogin();
            form_home2.ShowDialog();
            this.Close();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin form_admin = new AdminLogin();
            form_admin.ShowDialog();
            this.Close();
        }*/

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin form_admin = new AdminLogin();
            form_admin.ShowDialog();
            this.Close();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin form_home2 = new EmployeeLogin();
            form_home2.ShowDialog();
            this.Close();
        }
    }
}