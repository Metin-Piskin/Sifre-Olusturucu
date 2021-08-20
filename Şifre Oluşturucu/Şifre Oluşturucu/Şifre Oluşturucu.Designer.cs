namespace Şifre_Oluşturucu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmbZorluk = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOluştur = new System.Windows.Forms.Button();
            this.txt_olusan_sfire = new System.Windows.Forms.TextBox();
            this.NudSifreKarakterAdet = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudSifreKarakterAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CmbZorluk
            // 
            this.CmbZorluk.FormattingEnabled = true;
            this.CmbZorluk.Items.AddRange(new object[] {
            "Sadece Büyük Harf",
            "Sadece Küçük Harf",
            "Sadece Rakam",
            "Rakam ve Özel Karakterler",
            "Harfler ve Özel Karakterler",
            "Tamamen Karışık"});
            this.CmbZorluk.Location = new System.Drawing.Point(175, 62);
            this.CmbZorluk.Name = "CmbZorluk";
            this.CmbZorluk.Size = new System.Drawing.Size(254, 32);
            this.CmbZorluk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zorluk Seçin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifreniz Kaç  Karakterden \r\nOluşacak ?";
            // 
            // BtnOluştur
            // 
            this.BtnOluştur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnOluştur.Location = new System.Drawing.Point(16, 162);
            this.BtnOluştur.Name = "BtnOluştur";
            this.BtnOluştur.Size = new System.Drawing.Size(413, 89);
            this.BtnOluştur.TabIndex = 4;
            this.BtnOluştur.Text = "Şifre Oluştur";
            this.BtnOluştur.UseVisualStyleBackColor = true;
            this.BtnOluştur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_olusan_sfire
            // 
            this.txt_olusan_sfire.Location = new System.Drawing.Point(150, 280);
            this.txt_olusan_sfire.Name = "txt_olusan_sfire";
            this.txt_olusan_sfire.Size = new System.Drawing.Size(232, 32);
            this.txt_olusan_sfire.TabIndex = 5;
            // 
            // NudSifreKarakterAdet
            // 
            this.NudSifreKarakterAdet.Location = new System.Drawing.Point(309, 100);
            this.NudSifreKarakterAdet.Name = "NudSifreKarakterAdet";
            this.NudSifreKarakterAdet.Size = new System.Drawing.Size(120, 32);
            this.NudSifreKarakterAdet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifreniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(113, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifre Oluşturucu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(442, 338);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudSifreKarakterAdet);
            this.Controls.Add(this.txt_olusan_sfire);
            this.Controls.Add(this.BtnOluştur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbZorluk);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Oluşturucu";
            ((System.ComponentModel.ISupportInitialize)(this.NudSifreKarakterAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbZorluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOluştur;
        private System.Windows.Forms.TextBox txt_olusan_sfire;
        private System.Windows.Forms.NumericUpDown NudSifreKarakterAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

