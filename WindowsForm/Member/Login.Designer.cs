namespace WindowsForm.Member
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginpwd = new System.Windows.Forms.TextBox();
            this.loginemail = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Forget = new System.Windows.Forms.Button();
            this.Sucesslogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(435, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "會員登入";
            // 
            // loginpwd
            // 
            this.loginpwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginpwd.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginpwd.Location = new System.Drawing.Point(536, 345);
            this.loginpwd.Name = "loginpwd";
            this.loginpwd.Size = new System.Drawing.Size(229, 31);
            this.loginpwd.TabIndex = 1;
            this.loginpwd.Tag = "";
            this.loginpwd.Text = "00000000";
            this.loginpwd.UseSystemPasswordChar = true;
            // 
            // loginemail
            // 
            this.loginemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginemail.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginemail.Location = new System.Drawing.Point(536, 257);
            this.loginemail.Name = "loginemail";
            this.loginemail.Size = new System.Drawing.Size(229, 34);
            this.loginemail.TabIndex = 0;
            this.loginemail.Text = "zero@gmail.com";
            // 
            // pwd
            // 
            this.pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.Transparent;
            this.pwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pwd.Location = new System.Drawing.Point(437, 350);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(62, 31);
            this.pwd.TabIndex = 7;
            this.pwd.Text = "密碼";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(437, 255);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(62, 31);
            this.email.TabIndex = 8;
            this.email.Text = "信箱";
            // 
            // Forget
            // 
            this.Forget.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Forget.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Forget.Location = new System.Drawing.Point(655, 560);
            this.Forget.Margin = new System.Windows.Forms.Padding(0);
            this.Forget.Name = "Forget";
            this.Forget.Size = new System.Drawing.Size(110, 40);
            this.Forget.TabIndex = 3;
            this.Forget.Text = "忘記密碼?";
            this.Forget.UseVisualStyleBackColor = false;
            this.Forget.Click += new System.EventHandler(this.Forget_Click);
            // 
            // Sucesslogin
            // 
            this.Sucesslogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sucesslogin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sucesslogin.Location = new System.Drawing.Point(655, 494);
            this.Sucesslogin.Margin = new System.Windows.Forms.Padding(0);
            this.Sucesslogin.Name = "Sucesslogin";
            this.Sucesslogin.Size = new System.Drawing.Size(110, 40);
            this.Sucesslogin.TabIndex = 2;
            this.Sucesslogin.Text = "登入";
            this.Sucesslogin.UseVisualStyleBackColor = false;
            this.Sucesslogin.Click += new System.EventHandler(this.Sucesslogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._1088a8df45a62beec8a138bd60930d30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1217, 824);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginpwd);
            this.Controls.Add(this.loginemail);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Forget);
            this.Controls.Add(this.Sucesslogin);
            this.Name = "Login";
            this.Text = "會員登入";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginpwd;
        private System.Windows.Forms.TextBox loginemail;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button Forget;
        private System.Windows.Forms.Button Sucesslogin;
    }
}