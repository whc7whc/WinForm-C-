namespace WindowsForm.PAGE
{
    partial class Calender
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
            this.Update = new System.Windows.Forms.Button();
            this.Review = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Topic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.UserId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture = new Krypton.Toolkit.KryptonPictureBox();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.panelmain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.White;
            this.Update.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Update.Location = new System.Drawing.Point(376, 654);
            this.Update.Margin = new System.Windows.Forms.Padding(0);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(129, 39);
            this.Update.TabIndex = 3;
            this.Update.Text = "修改";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // Review
            // 
            this.Review.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Review.BackColor = System.Drawing.Color.White;
            this.Review.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Review.Location = new System.Drawing.Point(232, 711);
            this.Review.Margin = new System.Windows.Forms.Padding(0);
            this.Review.Name = "Review";
            this.Review.Size = new System.Drawing.Size(129, 39);
            this.Review.TabIndex = 4;
            this.Review.Text = "回顧檢視";
            this.Review.UseVisualStyleBackColor = false;
            this.Review.Click += new System.EventHandler(this.Review_Click_1);
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add.BackColor = System.Drawing.Color.White;
            this.Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Add.Location = new System.Drawing.Point(232, 654);
            this.Add.Margin = new System.Windows.Forms.Padding(0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(129, 39);
            this.Add.TabIndex = 2;
            this.Add.Text = "新增";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(73, 297);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 31);
            this.email.TabIndex = 10;
            this.email.Text = "標題";
            // 
            // Button1
            // 
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button1.Location = new System.Drawing.Point(376, 711);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(129, 39);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "進階查詢";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Topic
            // 
            this.Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Topic.BackColor = System.Drawing.Color.White;
            this.Topic.Font = new System.Drawing.Font("微軟正黑體 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Topic.ForeColor = System.Drawing.Color.Gray;
            this.Topic.Location = new System.Drawing.Point(70, 355);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(435, 34);
            this.Topic.TabIndex = 0;
            this.Topic.Text = "請輸入標題....";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(73, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "內容";
            // 
            // TimePicker
            // 
            this.TimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimePicker.AutoRoundedCorners = true;
            this.TimePicker.BackColor = System.Drawing.Color.Transparent;
            this.TimePicker.BorderColor = System.Drawing.Color.Transparent;
            this.TimePicker.BorderRadius = 21;
            this.TimePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TimePicker.Checked = true;
            this.TimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(94)))), ((int)(((byte)(141)))));
            this.TimePicker.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.TimePicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicker.Location = new System.Drawing.Point(17, 28);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(252, 45);
            this.TimePicker.TabIndex = 21;
            this.TimePicker.Value = new System.DateTime(2025, 5, 22, 19, 12, 54, 481);
            // 
            // TextBox1
            // 
            this.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox1.AutoScroll = true;
            this.TextBox1.BackColor = System.Drawing.Color.White;
            this.TextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1.DefaultText = "請輸入內容....";
            this.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1.Location = new System.Drawing.Point(70, 463);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(435, 136);
            this.TextBox1.TabIndex = 1;
            // 
            // UserId
            // 
            this.UserId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserId.Location = new System.Drawing.Point(105, 162);
            this.UserId.Name = "UserId";
            this.UserId.Size = new System.Drawing.Size(121, 29);
            this.UserId.TabIndex = 15;
            this.UserId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.Picture);
            this.panel1.Location = new System.Drawing.Point(285, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 258);
            this.panel1.TabIndex = 19;
            // 
            // Picture
            // 
            this.Picture.BackgroundImage = global::WindowsForm.Properties.Resources._838600ef998eeee2807fb1b9e0332a99;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(220, 258);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 21;
            this.Picture.TabStop = false;
            this.Picture.Click += new System.EventHandler(this.Picture_Click);
            // 
            // panelmain
            // 
            this.panelmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelmain.BackColor = System.Drawing.Color.Transparent;
            this.panelmain.Controls.Add(this.TextBox1);
            this.panelmain.Controls.Add(this.TimePicker);
            this.panelmain.Controls.Add(this.label1);
            this.panelmain.Controls.Add(this.panel1);
            this.panelmain.Controls.Add(this.Topic);
            this.panelmain.Controls.Add(this.UserId);
            this.panelmain.Controls.Add(this.Button1);
            this.panelmain.Controls.Add(this.email);
            this.panelmain.Controls.Add(this.Add);
            this.panelmain.Controls.Add(this.Review);
            this.panelmain.Controls.Add(this.Update);
            this.panelmain.Location = new System.Drawing.Point(423, 1);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(538, 835);
            this.panelmain.TabIndex = 19;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._1088a8df45a62beec8a138bd60930d30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1380, 910);
            this.Controls.Add(this.panelmain);
            this.Name = "Calender";
            this.Text = "資料新增";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Calender_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.panelmain.ResumeLayout(false);
            this.panelmain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Review;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicker;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private System.Windows.Forms.TextBox UserId;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonPictureBox Picture;
        private System.Windows.Forms.Panel panelmain;
    }
}