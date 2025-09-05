namespace WindowsForm
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button2
            // 
            this.Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button2.Location = new System.Drawing.Point(423, 198);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(209, 52);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "註冊會員";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // Button1
            // 
            this.Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Button1.Location = new System.Drawing.Point(423, 271);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(209, 52);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "會員登入";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._702104f3bc2deb299c87f99fe50e4dfe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1352, 1010);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Welcome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
    }
}

