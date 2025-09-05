namespace WindowsForm.PAGE
{
    partial class Search
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.End = new Krypton.Toolkit.KryptonDateTimePicker();
            this.Start = new Krypton.Toolkit.KryptonDateTimePicker();
            this.XML = new System.Windows.Forms.Button();
            this.Tidy = new System.Windows.Forms.Button();
            this.Searchdata = new System.Windows.Forms.Button();
            this.Sdelete = new System.Windows.Forms.Button();
            this.Sadd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.ASearch = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.DataGridView1.Location = new System.Drawing.Point(246, 122);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 31;
            this.DataGridView1.Size = new System.Drawing.Size(694, 733);
            this.DataGridView1.TabIndex = 25;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 20;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 31;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // End
            // 
            this.End.Location = new System.Drawing.Point(974, 180);
            this.End.Name = "End";
            this.End.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueDarkMode;
            this.End.Size = new System.Drawing.Size(218, 30);
            this.End.TabIndex = 32;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(974, 122);
            this.Start.Name = "Start";
            this.Start.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.Start.Size = new System.Drawing.Size(218, 30);
            this.Start.TabIndex = 31;
            // 
            // XML
            // 
            this.XML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.XML.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XML.Image = global::WindowsForm.Properties.Resources._103802_xml_document_icon;
            this.XML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XML.Location = new System.Drawing.Point(974, 351);
            this.XML.Name = "XML";
            this.XML.Size = new System.Drawing.Size(251, 57);
            this.XML.TabIndex = 30;
            this.XML.Text = "匯出XML";
            this.XML.UseVisualStyleBackColor = false;
            this.XML.Click += new System.EventHandler(this.XML_Click);
            // 
            // Tidy
            // 
            this.Tidy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.Tidy.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Tidy.Image = global::WindowsForm.Properties.Resources._9104189_replay_repeat_refresh_update_reload_icon__1_;
            this.Tidy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tidy.Location = new System.Drawing.Point(974, 571);
            this.Tidy.Name = "Tidy";
            this.Tidy.Size = new System.Drawing.Size(251, 57);
            this.Tidy.TabIndex = 29;
            this.Tidy.Text = "重新整理";
            this.Tidy.UseVisualStyleBackColor = false;
            this.Tidy.Click += new System.EventHandler(this.Tidy_Click);
            // 
            // Searchdata
            // 
            this.Searchdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.Searchdata.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Searchdata.Image = global::WindowsForm.Properties.Resources._115695_magnifying_glass_zoom_find_search_icon;
            this.Searchdata.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchdata.Location = new System.Drawing.Point(973, 426);
            this.Searchdata.Name = "Searchdata";
            this.Searchdata.Size = new System.Drawing.Size(251, 57);
            this.Searchdata.TabIndex = 28;
            this.Searchdata.Text = "區間檢視";
            this.Searchdata.UseVisualStyleBackColor = false;
            this.Searchdata.Click += new System.EventHandler(this.Searchdata_Click);
            // 
            // Sdelete
            // 
            this.Sdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.Sdelete.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sdelete.Image = global::WindowsForm.Properties.Resources._9004673_trash_delete_bin_remove_icon;
            this.Sdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sdelete.Location = new System.Drawing.Point(974, 499);
            this.Sdelete.Name = "Sdelete";
            this.Sdelete.Size = new System.Drawing.Size(251, 57);
            this.Sdelete.TabIndex = 27;
            this.Sdelete.Text = "刪除資料";
            this.Sdelete.UseVisualStyleBackColor = false;
            this.Sdelete.Click += new System.EventHandler(this.Sdelete_Click);
            // 
            // Sadd
            // 
            this.Sadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.Sadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sadd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Sadd.Image = global::WindowsForm.Properties.Resources._9044416_face_add_icon__1_;
            this.Sadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sadd.Location = new System.Drawing.Point(974, 643);
            this.Sadd.Name = "Sadd";
            this.Sadd.Size = new System.Drawing.Size(251, 62);
            this.Sadd.TabIndex = 26;
            this.Sadd.Text = "新增資料";
            this.Sadd.UseVisualStyleBackColor = false;
            this.Sadd.Click += new System.EventHandler(this.Sadd_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Image = global::WindowsForm.Properties.Resources._185061_pictures_photo_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(974, 722);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 57);
            this.button1.TabIndex = 33;
            this.button1.Text = "編輯瀏覽";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView.ColumnHeadersHeight = 20;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.title,
            this.content,
            this.photo});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.DataGridView.Location = new System.Drawing.Point(49, 51);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 62;
            this.DataGridView.RowTemplate.Height = 31;
            this.DataGridView.Size = new System.Drawing.Size(867, 804);
            this.DataGridView.TabIndex = 35;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(227)))), ((int)(((byte)(237)))));
            this.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(227)))), ((int)(((byte)(242)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.DataGridView.ThemeStyle.ReadOnly = false;
            this.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.ThemeStyle.RowsStyle.Height = 31;
            this.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_RowEnter);
            // 
            // EEnd
            // 
            this.EEnd.Location = new System.Drawing.Point(974, 109);
            this.EEnd.Name = "EEnd";
            this.EEnd.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlueDarkMode;
            this.EEnd.Size = new System.Drawing.Size(218, 30);
            this.EEnd.TabIndex = 43;
            // 
            // SStart
            // 
            this.SStart.Location = new System.Drawing.Point(974, 51);
            this.SStart.Name = "SStart";
            this.SStart.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.SStart.Size = new System.Drawing.Size(218, 30);
            this.SStart.TabIndex = 42;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TxtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtSearch.Location = new System.Drawing.Point(973, 798);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(170, 39);
            this.TxtSearch.TabIndex = 45;
            this.TxtSearch.Text = "請輸入關鍵字";
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ASearch
            // 
            this.ASearch.Image = global::WindowsForm.Properties.Resources._4918933_explore_find_magnifier_magnifying_glass_search_icon;
            this.ASearch.Location = new System.Drawing.Point(1149, 798);
            this.ASearch.Name = "ASearch";
            this.ASearch.Size = new System.Drawing.Size(76, 39);
            this.ASearch.TabIndex = 46;
            this.ASearch.UseVisualStyleBackColor = true;
            this.ASearch.Click += new System.EventHandler(this.ASearch_Click);
            // 
            // date
            // 
            this.date.HeaderText = "日期";
            this.date.MinimumWidth = 10;
            this.date.Name = "date";
            this.date.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "標題";
            this.title.MinimumWidth = 10;
            this.title.Name = "title";
            this.title.Visible = false;
            // 
            // content
            // 
            this.content.HeaderText = "內容";
            this.content.MinimumWidth = 8;
            this.content.Name = "content";
            this.content.Visible = false;
            // 
            // photo
            // 
            this.photo.HeaderText = "相片";
            this.photo.MinimumWidth = 8;
            this.photo.Name = "photo";
            this.photo.Visible = false;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::WindowsForm.Properties.Resources._93607c9e494729ed0e8df4d4ba2032a0;
            this.ClientSize = new System.Drawing.Size(1373, 897);
            this.Controls.Add(this.ASearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.EEnd);
            this.Controls.Add(this.SStart);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.XML);
            this.Controls.Add(this.Tidy);
            this.Controls.Add(this.Searchdata);
            this.Controls.Add(this.Sdelete);
            this.Controls.Add(this.Sadd);
            this.Name = "Search";
            this.Text = "進階查詢";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XML;
        private System.Windows.Forms.Button Tidy;
        private System.Windows.Forms.Button Searchdata;
        private System.Windows.Forms.Button Sdelete;
        private System.Windows.Forms.Button Sadd;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private Krypton.Toolkit.KryptonDateTimePicker End;
        private Krypton.Toolkit.KryptonDateTimePicker Start;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Krypton.Toolkit.KryptonDateTimePicker EEnd;
        private Krypton.Toolkit.KryptonDateTimePicker SStart;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button ASearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn content;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
    }
}