using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.CLASS;
using WindowsForm.LINQ;

namespace WindowsForm.PAGE
{
    public partial class Search : Form
    {
        private Record _record = new Record();

        private int _position = -1;
        private List<tRecord> _listRecord = null;
        public Search()
        {
            InitializeComponent();
        }

        private void Sadd_Click(object sender, EventArgs e)
        {
            Calender f = new Calender();
            f.Show();

        }
        private void RefreshData()
        {
            using (var db = new dbDemoEntities1())
            {
                _listRecord = db.tRecord
                    .ToList();

                var display = _listRecord
                    .Select(p => new { 日期 = p.rdate, 標題 = p.rTitle })
                    .ToList();

                DataGridView1.DataSource = display;
            }

            _position = -1;
        }
        private void Way()
        {
            using (var db = new dbDemoEntities1())
            {
                _listRecord = db.tRecord
                    .OrderBy(p => p.rdate)
                    .ToList();

                var display = _listRecord
                    .Select(p => new { 日期 = p.rdate, 標題 = p.rTitle })
                    .ToList();

                DataGridView1.DataSource = display;
            }

            _position = -1;
        }


        private void Sdelete_Click(object sender, EventArgs e)
        {

            if (_listRecord == null || _position < 0 || _position >= _listRecord.Count)
            {
                MessageBox.Show("請先選擇要刪除的資料列。");
                return;
            }

            var selected = _listRecord[_position];

            DialogResult result = MessageBox.Show($"確定要刪除標題「{selected.rTitle}」的資料嗎？", "刪除確認", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes) return;

            using (var db = new dbDemoEntities1())
            {
                var target = db.tRecord.FirstOrDefault(p => p.rId == selected.rId);
                if (target != null)
                {
                    db.tRecord.Remove(target);
                    db.SaveChanges();
                    MessageBox.Show("刪除成功！");
                }
                else
                {
                    MessageBox.Show("找不到要刪除的資料。");
                }
            }

            Way();
        }

        private void Searchdata_Click(object sender, EventArgs e)
        {

            using (var db = new dbDemoEntities1())
            {
                _listRecord = db.tRecord
                    .Where(p => p.rdate >= SStart.Value && p.rdate <= EEnd.Value)
                    .ToList();

                var display = _listRecord
                    .Select(p => new
                    {
                        日期 = p.rdate,
                        標題 = p.rTitle,
                        內容 = p.rContent,
                        相片 = p.rPhoto
                    })
                    .ToList();

                DataGridView.DataSource = display;
            }

            _position = -1;
        }

        private void XML_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tRecord WHERE account_id=@K_account_id AND rTitle = @K_rTitle AND rContent=@K_rContent AND rdate BETWEEN @K_START AND @k_END ORDER BY rDate ASC";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.;Initial Catalog=dbDemo;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);

            DateTime startDate = SStart.Value.Date;
            DateTime endDate = EEnd.Value.Date.AddDays(1).AddTicks(-1);


            cmd.Parameters.AddWithValue("@K_account_id", (object)_record.AccountId ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@K_START ", (object)startDate);
            cmd.Parameters.AddWithValue("@k_END", (object)endDate);
            cmd.Parameters.AddWithValue("@K_rTitle", (object)_record.Rtitle ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@K_rContent", (object)_record.Rcontent ?? DBNull.Value);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            ds.WriteXml(@"C:\Users\jay\Desktop\NEW\rcord.XMl");
            MessageBox.Show("資料成功匯出為 XML 檔案！", "匯出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                _position = e.RowIndex;
            }
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Album f = new Album();
            f.Show();
        }

        private void Tidy_Click(object sender, EventArgs e)
        {
            using (var db = new dbDemoEntities1())
            {
                _listRecord = db.tRecord
                    .Where(p => p.rdate >= SStart.Value && p.rdate <= EEnd.Value)
                    .OrderBy(p => p.rdate)
                    .ToList();

                var display = _listRecord
                    .Select(p => new { 日期 = p.rdate, 標題 = p.rTitle })
                    .ToList();

                DataGridView.DataSource = display;
            }

            _position = -1;


        }



        private void ASearch_Click(object sender, EventArgs e)
        {
            dbDemoEntities1 db = new dbDemoEntities1();

            var datas = from p in db.tRecord
                        where p.rTitle.Contains(TxtSearch.Text)
                         ||
                      p.rdate.ToString().Contains(TxtSearch.Text)
                        select new
                        {
                            標題 = p.rTitle,
                            內容 = p.rContent,
                            日期 = p.rdate,
                            相片 = p.rPhoto
                        };

            DataGridView.DataSource = datas.ToList();
            if (DataGridView.Columns["照片"] is DataGridViewImageColumn imgCol)
            {
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
        }

       


        }
    }


    
            
                   


    
   
