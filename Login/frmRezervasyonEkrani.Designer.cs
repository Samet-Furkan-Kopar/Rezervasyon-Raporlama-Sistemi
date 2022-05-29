
namespace WindowsUI
{
    partial class RezervasyonEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_GideceegiIl = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_BulunduguIl = new System.Windows.Forms.ComboBox();
            this.btn_Rezervasyon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Konaklama = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Ulasim = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeGidis = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDonus = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gideceğin İl:";
            // 
            // cmb_GideceegiIl
            // 
            this.cmb_GideceegiIl.FormattingEnabled = true;
            this.cmb_GideceegiIl.Items.AddRange(new object[] {
            "İzmir",
            "Eskişehir",
            "Çanakkale",
            "Balıkesir"});
            this.cmb_GideceegiIl.Location = new System.Drawing.Point(213, 123);
            this.cmb_GideceegiIl.Name = "cmb_GideceegiIl";
            this.cmb_GideceegiIl.Size = new System.Drawing.Size(151, 28);
            this.cmb_GideceegiIl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bulunduğun İl:";
            // 
            // cmb_BulunduguIl
            // 
            this.cmb_BulunduguIl.FormattingEnabled = true;
            this.cmb_BulunduguIl.Items.AddRange(new object[] {
            "İstanbul",
            "Mersin",
            "Ankara",
            "Gaziantep"});
            this.cmb_BulunduguIl.Location = new System.Drawing.Point(213, 70);
            this.cmb_BulunduguIl.Name = "cmb_BulunduguIl";
            this.cmb_BulunduguIl.Size = new System.Drawing.Size(151, 28);
            this.cmb_BulunduguIl.TabIndex = 4;
            // 
            // btn_Rezervasyon
            // 
            this.btn_Rezervasyon.BackColor = System.Drawing.Color.White;
            this.btn_Rezervasyon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Rezervasyon.Location = new System.Drawing.Point(295, 390);
            this.btn_Rezervasyon.Name = "btn_Rezervasyon";
            this.btn_Rezervasyon.Size = new System.Drawing.Size(150, 45);
            this.btn_Rezervasyon.TabIndex = 6;
            this.btn_Rezervasyon.Text = "DEVAM EDİNİZ";
            this.btn_Rezervasyon.UseVisualStyleBackColor = false;
            this.btn_Rezervasyon.Click += new System.EventHandler(this.btn_Rezervasyon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Konaklama :";
            // 
            // cmb_Konaklama
            // 
            this.cmb_Konaklama.FormattingEnabled = true;
            this.cmb_Konaklama.Items.AddRange(new object[] {
            "Otel",
            "Cadir"});
            this.cmb_Konaklama.Location = new System.Drawing.Point(213, 177);
            this.cmb_Konaklama.Name = "cmb_Konaklama";
            this.cmb_Konaklama.Size = new System.Drawing.Size(151, 28);
            this.cmb_Konaklama.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ulaşım :";
            // 
            // cmb_Ulasim
            // 
            this.cmb_Ulasim.FormattingEnabled = true;
            this.cmb_Ulasim.Items.AddRange(new object[] {
            "Otobus",
            "Ucak"});
            this.cmb_Ulasim.Location = new System.Drawing.Point(213, 232);
            this.cmb_Ulasim.Name = "cmb_Ulasim";
            this.cmb_Ulasim.Size = new System.Drawing.Size(151, 28);
            this.cmb_Ulasim.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gidiş Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dönüş Tarihi:";
            // 
            // dateTimeGidis
            // 
            this.dateTimeGidis.Location = new System.Drawing.Point(213, 290);
            this.dateTimeGidis.Name = "dateTimeGidis";
            this.dateTimeGidis.Size = new System.Drawing.Size(250, 27);
            this.dateTimeGidis.TabIndex = 13;
            // 
            // dateTimeDonus
            // 
            this.dateTimeDonus.Location = new System.Drawing.Point(213, 345);
            this.dateTimeDonus.Name = "dateTimeDonus";
            this.dateTimeDonus.Size = new System.Drawing.Size(250, 27);
            this.dateTimeDonus.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(826, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RezervasyonEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimeDonus);
            this.Controls.Add(this.dateTimeGidis);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_Konaklama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Ulasim);
            this.Controls.Add(this.btn_Rezervasyon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_BulunduguIl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_GideceegiIl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezervasyonEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_GideceegiIl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_BulunduguIl;
        private System.Windows.Forms.Button btn_Rezervasyon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Konaklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Ulasim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeGidis;
        private System.Windows.Forms.DateTimePicker dateTimeDonus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}