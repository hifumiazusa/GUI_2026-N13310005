namespace N13310005
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
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.攝氏 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.華氏 = new System.Windows.Forms.Label();
            this.請輸入華氏後轉換按鈕 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(125, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "N13310005- HAHAHA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(586, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12345678";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(206, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(193, 302);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "按我複製字串到label";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(222, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體 Light", 15F);
            this.button2.Location = new System.Drawing.Point(304, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 79);
            this.button2.TabIndex = 6;
            this.button2.Text = "計算機";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // 攝氏
            // 
            this.攝氏.AutoSize = true;
            this.攝氏.ForeColor = System.Drawing.Color.CadetBlue;
            this.攝氏.Location = new System.Drawing.Point(583, 276);
            this.攝氏.Name = "攝氏";
            this.攝氏.Size = new System.Drawing.Size(31, 16);
            this.攝氏.TabIndex = 7;
            this.攝氏.Text = "攝氏";
            this.攝氏.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(618, 293);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(643, 324);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(75, 23);
            this.Button.TabIndex = 9;
            this.Button.Text = "轉換";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.轉換_Click);
            // 
            // 華氏
            // 
            this.華氏.AutoSize = true;
            this.華氏.Location = new System.Drawing.Point(626, 350);
            this.華氏.Name = "華氏";
            this.華氏.Size = new System.Drawing.Size(37, 16);
            this.華氏.TabIndex = 10;
            this.華氏.Text = "華氏F";
            // 
            // 請輸入華氏後轉換按鈕
            // 
            this.請輸入華氏後轉換按鈕.AutoSize = true;
            this.請輸入華氏後轉換按鈕.Location = new System.Drawing.Point(689, 350);
            this.請輸入華氏後轉換按鈕.Name = "請輸入華氏後轉換按鈕";
            this.請輸入華氏後轉換按鈕.Size = new System.Drawing.Size(31, 16);
            this.請輸入華氏後轉換按鈕.TabIndex = 11;
            this.請輸入華氏後轉換按鈕.Text = "華氏";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(933, 600);
            this.Controls.Add(this.請輸入華氏後轉換按鈕);
            this.Controls.Add(this.華氏);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.攝氏);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label 請輸入華氏後轉換按鈕;
        private System.Windows.Forms.Label 華氏;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label 攝氏;
    }
}

