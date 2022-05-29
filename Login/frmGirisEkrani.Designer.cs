
namespace WindowsUI
{
    partial class frmGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGirisEkrani));
            this.txt_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.Giris = new System.Windows.Forms.Button();
            this.linkLbl_KayitOl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_KullaniciAdi
            // 
            this.txt_KullaniciAdi.Location = new System.Drawing.Point(279, 123);
            this.txt_KullaniciAdi.Name = "txt_KullaniciAdi";
            this.txt_KullaniciAdi.Size = new System.Drawing.Size(125, 27);
            this.txt_KullaniciAdi.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(279, 173);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(125, 27);
            this.txt_Sifre.TabIndex = 1;
            // 
            // Giris
            // 
            this.Giris.BackColor = System.Drawing.Color.White;
            this.Giris.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Giris.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Giris.Location = new System.Drawing.Point(279, 224);
            this.Giris.Name = "Giris";
            this.Giris.Size = new System.Drawing.Size(127, 42);
            this.Giris.TabIndex = 2;
            this.Giris.Text = "Giriş";
            this.Giris.UseVisualStyleBackColor = false;
            this.Giris.UseWaitCursor = true;
            this.Giris.Click += new System.EventHandler(this.Giris_Click);
            // 
            // linkLbl_KayitOl
            // 
            this.linkLbl_KayitOl.AutoSize = true;
            this.linkLbl_KayitOl.Location = new System.Drawing.Point(343, 288);
            this.linkLbl_KayitOl.Name = "linkLbl_KayitOl";
            this.linkLbl_KayitOl.Size = new System.Drawing.Size(61, 20);
            this.linkLbl_KayitOl.TabIndex = 3;
            this.linkLbl_KayitOl.TabStop = true;
            this.linkLbl_KayitOl.Text = "Kayıt Ol";
            this.linkLbl_KayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_KayitOl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre :";
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLbl_KayitOl);
            this.Controls.Add(this.Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisEkrani";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_KullaniciAdi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Button Giris;
        private System.Windows.Forms.LinkLabel linkLbl_KayitOl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}