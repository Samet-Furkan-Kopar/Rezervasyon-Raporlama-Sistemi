
namespace WindowsUI
{
    partial class frmKayitOlEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKayitOlEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KullaniciAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi:";
            this.label1.UseWaitCursor = true;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(252, 100);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(138, 27);
            this.txt_Ad.TabIndex = 1;
            this.txt_Ad.UseWaitCursor = true;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(252, 232);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(138, 27);
            this.txt_Sifre.TabIndex = 3;
            this.txt_Sifre.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre:";
            this.label2.UseWaitCursor = true;
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.Location = new System.Drawing.Point(252, 186);
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.Size = new System.Drawing.Size(138, 27);
            this.txt_KullaniciAd.TabIndex = 5;
            this.txt_KullaniciAd.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kullanici Adi:";
            this.label3.UseWaitCursor = true;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(252, 142);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(138, 27);
            this.txt_Soyad.TabIndex = 7;
            this.txt_Soyad.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Soyadi:";
            this.label4.UseWaitCursor = true;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Kaydet.BackColor = System.Drawing.Color.White;
            this.btn_Kaydet.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btn_Kaydet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Kaydet.Location = new System.Drawing.Point(267, 286);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(123, 42);
            this.btn_Kaydet.TabIndex = 8;
            this.btn_Kaydet.Text = "Kayıt Ol";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.UseWaitCursor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(746, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // frmKayitOlEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KullaniciAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKayitOlEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKayitOl";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KullaniciAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}