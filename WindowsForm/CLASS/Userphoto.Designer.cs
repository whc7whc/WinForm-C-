namespace WindowsForm.CLASS
{
    partial class Userphoto
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.PICture = new System.Windows.Forms.PictureBox();
            this.Forword = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Today = new System.Windows.Forms.Button();
            this.TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Topic = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.TimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PICture)).BeginInit();
            this.SuspendLayout();
            // 
            // PICture
            // 
            this.PICture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PICture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PICture.Image = global::WindowsForm.Properties.Resources._65495e54958337166fd27220ee52e098;
            this.PICture.Location = new System.Drawing.Point(16, 61);
            this.PICture.Name = "PICture";
            this.PICture.Size = new System.Drawing.Size(346, 347);
            this.PICture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PICture.TabIndex = 0;
            this.PICture.TabStop = false;
            // 
            // Forword
            // 
            this.Forword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.Forword.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Forword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Forword.Location = new System.Drawing.Point(656, 450);
            this.Forword.Name = "Forword";
            this.Forword.Size = new System.Drawing.Size(149, 47);
            this.Forword.TabIndex = 1;
            this.Forword.Text = "上一篇";
            this.Forword.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.Back.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Back.Location = new System.Drawing.Point(654, 512);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(150, 47);
            this.Back.TabIndex = 2;
            this.Back.Text = "下一篇";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // Today
            // 
            this.Today.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.Today.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Today.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Today.Location = new System.Drawing.Point(656, 565);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(150, 44);
            this.Today.TabIndex = 3;
            this.Today.Text = "修改";
            this.Today.UseVisualStyleBackColor = false;
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
            this.TextBox1.Location = new System.Drawing.Point(379, 272);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.PasswordChar = '\0';
            this.TextBox1.PlaceholderText = "";
            this.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox1.SelectedText = "";
            this.TextBox1.Size = new System.Drawing.Size(435, 136);
            this.TextBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(382, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "內容";
            // 
            // Topic
            // 
            this.Topic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Topic.BackColor = System.Drawing.Color.White;
            this.Topic.Font = new System.Drawing.Font("微軟正黑體 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Topic.ForeColor = System.Drawing.Color.Gray;
            this.Topic.Location = new System.Drawing.Point(379, 164);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(435, 34);
            this.Topic.TabIndex = 23;
            this.Topic.Text = "請輸入標題....";
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(382, 106);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 31);
            this.email.TabIndex = 25;
            this.email.Text = "標題";
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
            this.TimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.TimePicker.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.TimePicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicker.Location = new System.Drawing.Point(553, 61);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(252, 45);
            this.TimePicker.TabIndex = 27;
            this.TimePicker.Value = new System.DateTime(2025, 5, 22, 19, 12, 54, 481);
            // 
            // Userphoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Forword);
            this.Controls.Add(this.PICture);
            this.Name = "Userphoto";
            this.Size = new System.Drawing.Size(829, 632);
            ((System.ComponentModel.ISupportInitialize)(this.PICture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PICture;
        private System.Windows.Forms.Button Forword;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Today;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Topic;
        private System.Windows.Forms.Label email;
        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicker;
    }
}
