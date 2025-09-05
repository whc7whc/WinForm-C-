using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsForm.PAGE; 

namespace WindowsForm.Member
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginAccount()
        {
            string email = loginemail.Text.Trim();
            string password = loginpwd.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入帳號和密碼");
                return;
            }


            string connectionString = @"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT fId, fPassword, fName FROM tAccount WHERE fEmail = @email";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("帳號輸入錯誤");
                        return;
                    }

                    string dbPassword = reader["fPassword"].ToString();
                    string userName = reader["fName"].ToString();
                    int userId = Convert.ToInt32(reader["fId"]);

                    if (dbPassword != password)
                    {
                        MessageBox.Show("密碼錯誤");
                        return;
                    }

                    Calender.Session.UserId = userId;
                    MessageBox.Show($"歡迎 {userName} 用戶登入！");

                    Calender calendarForm = new Calender();
                    calendarForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("登入失敗：" + ex.Message);
            }
        }



        private void Sucesslogin_Click(object sender, EventArgs e)
        {
            LoginAccount();
        }

        private void Forget_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
