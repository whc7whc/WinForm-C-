namespace WindowsForm.PAGE
{
    partial class Album
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
            this.TimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ATopic = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.AButton3 = new System.Windows.Forms.Button();
            this.Pbtn = new System.Windows.Forms.Button();
            this.PicIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TimePicker
            // 
            this.TimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimePicker.AutoRoundedCorners = true;
            this.TimePicker.BackColor = System.Drawing.Color.Transparent;
            this.TimePicker.BorderColor = System.Drawing.Color.Transparent;
            this.TimePicker.BorderRadius = 23;
            this.TimePicker.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.TimePicker.Checked = true;
            this.TimePicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(147)))), ((int)(((byte)(210)))));
            this.TimePicker.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.TimePicker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.TimePicker.Location = new System.Drawing.Point(995, 84);
            this.TimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(234, 49);
            this.TimePicker.TabIndex = 36;
            this.TimePicker.Value = new System.DateTime(2025, 5, 22, 19, 12, 54, 481);
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // AText
            // 
            this.AText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AText.AutoScroll = true;
            this.AText.BackColor = System.Drawing.Color.White;
            this.AText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AText.DefaultText = "";
            this.AText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AText.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.AText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AText.Location = new System.Drawing.Point(640, 245);
            this.AText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AText.Multiline = true;
            this.AText.Name = "AText";
            this.AText.PasswordChar = '\0';
            this.AText.PlaceholderText = "";
            this.AText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AText.SelectedText = "";
            this.AText.Size = new System.Drawing.Size(615, 403);
            this.AText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(634, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 33;
            this.label1.Text = "內容";
            // 
            // ATopic
            // 
            this.ATopic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ATopic.BackColor = System.Drawing.Color.White;
            this.ATopic.Font = new System.Drawing.Font("微軟正黑體 Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ATopic.ForeColor = System.Drawing.Color.Gray;
            this.ATopic.Location = new System.Drawing.Point(640, 152);
            this.ATopic.Name = "ATopic";
            this.ATopic.Size = new System.Drawing.Size(615, 34);
            this.ATopic.TabIndex = 1;
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(634, 102);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 31);
            this.email.TabIndex = 34;
            this.email.Text = "標題";
            // 
            // AButton3
            // 
            this.AButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AButton3.BackColor = System.Drawing.Color.Transparent;
            this.AButton3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AButton3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AButton3.Location = new System.Drawing.Point(1105, 683);
            this.AButton3.Name = "AButton3";
            this.AButton3.Size = new System.Drawing.Size(150, 47);
            this.AButton3.TabIndex = 3;
            this.AButton3.Text = "修改";
            this.AButton3.UseVisualStyleBackColor = false;
            this.AButton3.Click += new System.EventHandler(this.AButton3_Click);
            // 
            // Pbtn
            // 
            this.Pbtn.BackColor = System.Drawing.Color.Transparent;
            this.Pbtn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pbtn.ForeColor = System.Drawing.Color.Transparent;
            this.Pbtn.Image = global::WindowsForm.Properties.Resources._9022891_rewind_circle_duotone_icon;
            this.Pbtn.Location = new System.Drawing.Point(419, 678);
            this.Pbtn.Name = "Pbtn";
            this.Pbtn.Size = new System.Drawing.Size(189, 52);
            this.Pbtn.TabIndex = 37;
            this.Pbtn.UseVisualStyleBackColor = false;
            this.Pbtn.Click += new System.EventHandler(this.Pbtn_Click);
            // 
            // PicIcon
            // 
            this.PicIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicIcon.Image = global::WindowsForm.Properties.Resources._65495e54958337166fd27220ee52e098;
            this.PicIcon.Location = new System.Drawing.Point(28, 84);
            this.PicIcon.Name = "PicIcon";
            this.PicIcon.Size = new System.Drawing.Size(580, 578);
            this.PicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIcon.TabIndex = 28;
            this.PicIcon.TabStop = false;
            this.PicIcon.Click += new System.EventHandler(this.PicIcon_Click);
            // 
            // Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 932);
            this.Controls.Add(this.AButton3);
            this.Controls.Add(this.Pbtn);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.AText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ATopic);
            this.Controls.Add(this.email);
            this.Controls.Add(this.PicIcon);
            this.Name = "Album";
            this.Text = "Album";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Album_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker TimePicker;
        private Guna.UI2.WinForms.Guna2TextBox AText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ATopic;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.PictureBox PicIcon;
        private System.Windows.Forms.Button Pbtn;
        private System.Windows.Forms.Button AButton3;
    }
}