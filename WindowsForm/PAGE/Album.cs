using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.LINQ;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsForm.PAGE
{
    public partial class Album : Form
    {
        Image defaultImage;
        public Album()
        {
            InitializeComponent();
            TimePicker.Value = DateTime.Today;
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            var selectedDate = TimePicker.Value.Date;

            using (dbDemoEntities1 db = new dbDemoEntities1())
            {
                var memo = db.tRecord.FirstOrDefault(m => m.rdate == selectedDate);
                if (memo != null &&
           !string.IsNullOrWhiteSpace(memo.rTitle) &&
           !string.IsNullOrWhiteSpace(memo.rContent))
                {
                    ATopic.Text = memo.rTitle;
                    AText.Text = memo.rContent;

                    if (memo.rPhoto != null && memo.rPhoto.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(memo.rPhoto))
                            {
                                PicIcon.Image = Image.FromStream(ms);
                            }
                        }
                        catch
                        {

                            PicIcon.Image = defaultImage;
                        }
                    }
                    else
                    {
                        PicIcon.Image = defaultImage;
                    }
                }
                else
                {
                    ATopic.Text = "";
                    AText.Text = "";
                    PicIcon.Image = defaultImage;

                    MessageBox.Show("查無資料", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Album_Load(object sender, EventArgs e)
        {
            defaultImage = PicIcon.Image;
        }

        private void Pbtn_Click(object sender, EventArgs e)
        {
            DateTime currentDate = TimePicker.Value.Date;
            DateTime searchDate = currentDate.AddDays(-1);
            bool found = false;

            using (dbDemoEntities1 db = new dbDemoEntities1())
            {
                while (searchDate >= DateTime.MinValue) 
                {
                    var memo = db.tRecord.FirstOrDefault(m => m.rdate == searchDate);

                    if (memo != null &&
                        !string.IsNullOrWhiteSpace(memo.rTitle) &&
                        !string.IsNullOrWhiteSpace(memo.rContent))
                    {
                        TimePicker.Value = memo.rdate;
                        ATopic.Text = memo.rTitle;
                        AText.Text = memo.rContent;

                        if (memo.rPhoto != null && memo.rPhoto.Length > 0)
                        {
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(memo.rPhoto))
                                {
                                    PicIcon.Image = Image.FromStream(ms);
                                }
                            }
                            catch
                            {
                                PicIcon.Image = defaultImage;
                            }
                        }
                        else
                        {
                            PicIcon.Image = defaultImage;
                        }

                        found = true;
                        break;
                    }
                    else
                    {
                        searchDate = searchDate.AddDays(-1);
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("沒有更早的資料了", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        





        private void AButton3_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = TimePicker.Value.Date;

            using (dbDemoEntities1 db = new dbDemoEntities1())
            {

                var memo = db.tRecord.FirstOrDefault(m => m.rdate == selectedDate);
                if (memo != null)
                {

                    memo.rTitle = ATopic.Text;
                    memo.rContent = AText.Text;


                    if (PicIcon.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            PicIcon.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            memo.rPhoto = ms.ToArray();
                        }
                    }
                    else
                    {
                        memo.rPhoto = null;
                    }


                    db.SaveChanges();

                    MessageBox.Show("資料已更新", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("找不到該日期的資料，無法修改", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }

        private void PicIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "選擇圖片";
                ofd.Filter = "圖片檔案 (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PicIcon.Image = Image.FromFile(ofd.FileName);
                }
            }

        }

    }
        }

    