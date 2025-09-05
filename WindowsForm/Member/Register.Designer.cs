namespace WindowsForm.Member
{
    partial class Register
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
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.TextBox();
            this.pwdBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.Success = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.idBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.idBox.Location = new System.Drawing.Point(416, 607);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(89, 36);
            this.idBox.TabIndex = 23;
            this.idBox.UseSystemPasswordChar = true;
            this.idBox.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(392, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 50);
            this.label1.TabIndex = 22;
            this.label1.Text = "新會員註冊";
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox.Location = new System.Drawing.Point(511, 466);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(255, 36);
            this.checkBox.TabIndex = 3;
            this.checkBox.UseSystemPasswordChar = true;
            // 
            // pwdBox
            // 
            this.pwdBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pwdBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pwdBox.Location = new System.Drawing.Point(511, 395);
            this.pwdBox.Name = "pwdBox";
            this.pwdBox.Size = new System.Drawing.Size(255, 36);
            this.pwdBox.TabIndex = 2;
            this.pwdBox.UseSystemPasswordChar = true;
            // 
            // emailBox
            // 
            this.emailBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.emailBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.emailBox.Location = new System.Drawing.Point(511, 316);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(255, 36);
            this.emailBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nameBox.Location = new System.Drawing.Point(511, 244);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(255, 36);
            this.nameBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(395, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "密碼";
            // 
            // pwd
            // 
            this.pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.Transparent;
            this.pwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pwd.Location = new System.Drawing.Point(395, 321);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(62, 31);
            this.pwd.TabIndex = 20;
            this.pwd.Text = "信箱";
            // 
            // email
            // 
            this.email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.email.Location = new System.Drawing.Point(395, 249);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(110, 31);
            this.email.TabIndex = 21;
            this.email.Text = "用戶名稱";
            // 
            // Success
            // 
            this.Success.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Success.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Success.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Success.Location = new System.Drawing.Point(656, 641);
            this.Success.Margin = new System.Windows.Forms.Padding(0);
            this.Success.Name = "Success";
            this.Success.Size = new System.Drawing.Size(110, 40);
            this.Success.TabIndex = 4;
            this.Success.Text = "註冊";
            this.Success.UseVisualStyleBackColor = false;
            this.Success.Click += new System.EventHandler(this.Success_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Delete.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delete.Location = new System.Drawing.Point(656, 575);
            this.Delete.Margin = new System.Windows.Forms.Padding(0);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(110, 40);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "清除重填";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._1088a8df45a62beec8a138bd60930d30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1169, 909);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.pwdBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.email);
            this.Controls.Add(this.Success);
            this.Controls.Add(this.Delete);
            this.Name = "Register";
            this.Text = "會員註冊";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox checkBox;
        private System.Windows.Forms.TextBox pwdBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button Success;
        private System.Windows.Forms.Button Delete;
    }
}