using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsForm.CLASS;
using WindowsForm.LINQ;

namespace WindowsForm.PAGE
{
    public partial class Calender : Form
    {
  
        public static class Session
        {
            public static int UserId { get; set; } = -1;
        }
        public Calender()
        {
     
       
            InitializeComponent();
            TimePicker.Value = DateTime.Today; 
        }




        private Record _record;
        private byte[] selectedImageBytes = null;

        public Record CurrentRecord
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Topic.Text) || string.IsNullOrWhiteSpace(TextBox1.Text))
                {
                    MessageBox.Show("請填寫標題與內容");
                    return null;
                }

                if (_record == null)
                    _record = new Record();

                _record.Rtitle = Topic.Text;
                _record.Rcontent = TextBox1.Text;
                _record.Rdate = TimePicker.Value.Date;
                _record.AccountId = Session.UserId;

                return _record;
            }

            set
            {
                _record = value;
                TextBox1.Text = _record.Rcontent;
                Topic.Text = _record.Rtitle;
                UserId.Text = _record.Rid.ToString();
                TimePicker.Value = _record.Rdate;
            }
        }

        private void CreateRecord(Record p)
        {
            if (p == null)
            {
                MessageBox.Show("資料不完整，無法儲存！");
                return;
            }

            if (Session.UserId <= 0)
            {
                MessageBox.Show("尚未登入，請重新登入後再操作！");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;"))
                {
                    conn.Open();

         
                    string checkSql = "SELECT COUNT(*) FROM tRecord WHERE rDate = @rDate AND account_id = @account_id";
                    using (SqlCommand checkCmd = new SqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@rDate", p.Rdate.Date);
                        checkCmd.Parameters.AddWithValue("@account_id", p.AccountId);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("該日期已經有記錄，無法重複新增！");
                            return;
                        }
                    }

                    string sql = "INSERT INTO tRecord (rDate, rTitle, rContent, account_id, rPhoto) " +
                                 "VALUES (@rDate, @rTitle, @rContent, @account_id, @rPhoto)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@rDate", p.Rdate);
                        cmd.Parameters.AddWithValue("@rTitle", p.Rtitle);
                        cmd.Parameters.AddWithValue("@rContent", p.Rcontent);
                        cmd.Parameters.AddWithValue("@account_id", p.AccountId);

                        if (selectedImageBytes != null)
                            cmd.Parameters.AddWithValue("@rPhoto", selectedImageBytes);
                        else
                            cmd.Parameters.Add("@rPhoto", SqlDbType.VarBinary).Value = DBNull.Value;

                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "成功儲存記錄！" : "儲存失敗，請再試一次！");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("資料庫錯誤：" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤：" + ex.Message);
            }
        }
        


        private void Add_Click(object sender, EventArgs e)
        {
            CreateRecord(CurrentRecord);
        }
        private void UpdateRecord(Record p)
        {
            if (p == null)
            {
                MessageBox.Show("資料不完整，無法更新！");
                return;
            }

            using (dbDemoEntities1 db = new dbDemoEntities1())
            {
                var memo = db.tRecord.FirstOrDefault(m => m.rdate == p.Rdate && m.account_id == p.AccountId);
                if (memo != null)
                {
                    memo.rTitle = p.Rtitle;
                    memo.rContent = p.Rcontent;

                   
                    memo.rPhoto = selectedImageBytes ?? null;

                    db.SaveChanges();
                    MessageBox.Show("資料已更新", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("找不到該日期的資料，無法修改", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
        }


        private void LoadRecordByDate(DateTime date)
        {
            string sql = @"SELECT TOP 1 * 
                   FROM tRecord 
                   WHERE rDate = @rDate AND account_id = @account_id 
                   ORDER BY rid DESC";

            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=dbDemo;Integrated Security=True;"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@rDate", date);
                    cmd.Parameters.AddWithValue("@account_id", Session.UserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            try
                            {
                                
                                _record = new Record
                                {
                                    Rid = Convert.ToInt32(reader["rid"]),
                                    Rdate = Convert.ToDateTime(reader["rDate"]),
                                    Rtitle = reader["rTitle"].ToString(),
                                    Rcontent = reader["rContent"].ToString(),
                                    AccountId = Convert.ToInt32(reader["account_id"])
                                };


                                Topic.Text = _record.Rtitle;
                                TextBox1.Text = _record.Rcontent;
                                TimePicker.Value = _record.Rdate;

                                if (reader["rPhoto"] != DBNull.Value)
                                {
                                    selectedImageBytes = (byte[])reader["rPhoto"];

                                    using (MemoryStream ms = new MemoryStream(selectedImageBytes))
                                    {
                                      
                                        Picture.SizeMode = PictureBoxSizeMode.Zoom;
                                        Picture.Image = System.Drawing.Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    selectedImageBytes = null;
                                    Picture.Image = null;
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("資料載入發生錯誤: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("此日期沒有記錄。");
                      
                            Topic.Text = "";
                            TextBox1.Text = "";
                            selectedImageBytes = null;
                            Picture.Image = null;
                        }
                    }
                }
            }
        }




        private void Review_Click_1(object sender, EventArgs e)
        {
            LoadRecordByDate(TimePicker.Value.Date);

        }

        private void Update_Click_1(object sender, EventArgs e)
        {
            UpdateRecord(CurrentRecord);
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "選擇一張圖片",
                Filter = "圖片檔案 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Picture.Image = System.Drawing.Image.FromFile(filePath);
                selectedImageBytes = File.ReadAllBytes(filePath);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Search f = new Search();
            f.Show();
        }

        private void Calender_Load(object sender, EventArgs e)
        {
     

        }
    }
}