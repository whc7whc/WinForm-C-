using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.CLASS;

namespace WindowsForm.Member
{

    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }
        private Account _account;

        public Account CurrentAccount
        {
            get
            {
                if (_account == null)
                    _account = new Account();
                _account.FPassword = pwdBox.Text;
                _account.FName = nameBox.Text;
                _account.FEmail = emailBox.Text;

                return _account;
            }
            set
            {
                _account = value ?? new Account();

                pwdBox.Text = _account.FPassword ?? "";
                nameBox.Text = _account.FName ?? "";
                emailBox.Text = _account.FEmail ?? "";
                idBox.Text = _account.FId > 0 ? _account.FId.ToString() : "尚未建立";

                idBox.ReadOnly = true;
            }
        }

        private bool Isvalidated()
        {
            string s = "";
            if (string.IsNullOrEmpty(nameBox.Text))
                s += "\r\n用戶名稱是必填欄位";
            if (string.IsNullOrEmpty(emailBox.Text))
                s += "\r\n信箱是必填欄位";
            if (string.IsNullOrEmpty(pwdBox.Text))
                s += "\r\n密碼是必填欄位";
            if (string.IsNullOrEmpty(checkBox.Text))
                s += "\r\n請再次輸入密碼";
            if (!string.IsNullOrEmpty(emailBox.Text) &&
    !System.Text.RegularExpressions.Regex.IsMatch(emailBox.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                s += "\r\n信箱格式不正確";
            }
            if (!string.IsNullOrEmpty(pwdBox.Text) && pwdBox.Text.Length < 6)
                s += "\r\n密碼長度必須至少6個字元";
            if (!string.IsNullOrEmpty(pwdBox.Text) &&
       !string.IsNullOrEmpty(checkBox.Text) &&
       pwdBox.Text != checkBox.Text)
            {
                s += "\r\n兩次輸入的密碼不一致";
            }

            if (!string.IsNullOrEmpty(s))
            {
                MessageBox.Show(s);
                return false;
            }
            return true;
        }


        private bool IsEmailExists(string email)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;"))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM tAccount WHERE fEmail = @email";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void CreateAccount(Account p)
        {
            if (IsEmailExists(p.FEmail))
            {
                MessageBox.Show("此 Email 已被註冊，請使用其他信箱");
                return;
            }

            string sql = @"
        INSERT INTO tAccount (fName, fEmail, fPassword) 
        OUTPUT INSERTED.fId
        VALUES (@k_fName, @k_fEmail, @k_fPassword)";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;Encrypt=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@k_fName", p.FName));
                    cmd.Parameters.Add(new SqlParameter("@k_fEmail", p.FEmail));
                    cmd.Parameters.Add(new SqlParameter("@k_fPassword", p.FPassword));

                    object result = cmd.ExecuteScalar();
                    p.FId = Convert.ToInt32(result);
                }
            }

            MessageBox.Show("註冊成功！");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            emailBox.Clear();
            pwdBox.Clear();
            checkBox.Clear();
        }

        private void Success_Click(object sender, EventArgs e)
        {
            if (!Isvalidated())
                return;

            if (IsEmailExists(CurrentAccount.FEmail))
            {
                MessageBox.Show("此 Email 已被註冊，請使用其他信箱");
                return;
            }


            Success.Enabled = false;

            CreateAccount(CurrentAccount);

            MessageBox.Show("註冊成功, 會員登入");

            Login editor = new Login();
            editor.ShowDialog();
            this.Hide();


            Success.Enabled = true;

        }
    }
}