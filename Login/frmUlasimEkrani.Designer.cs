
namespace WindowsUI
{
    partial class UlasimEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UlasimEkrani));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_RaporAl = new System.Windows.Forms.Button();
            this.btn_RezervasyonSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(932, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rezervasyonu Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RaporAl
            // 
            this.btn_RaporAl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RaporAl.Location = new System.Drawing.Point(932, 342);
            this.btn_RaporAl.Name = "btn_RaporAl";
            this.btn_RaporAl.Size = new System.Drawing.Size(159, 44);
            this.btn_RaporAl.TabIndex = 2;
            this.btn_RaporAl.Text = "Rapor Al";
            this.btn_RaporAl.UseVisualStyleBackColor = true;
            this.btn_RaporAl.Visible = false;
            this.btn_RaporAl.Click += new System.EventHandler(this.btn_RaporAl_Click);
            // 
            // btn_RezervasyonSil
            // 
            this.btn_RezervasyonSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_RezervasyonSil.Location = new System.Drawing.Point(932, 392);
            this.btn_RezervasyonSil.Name = "btn_RezervasyonSil";
            this.btn_RezervasyonSil.Size = new System.Drawing.Size(159, 61);
            this.btn_RezervasyonSil.TabIndex = 3;
            this.btn_RezervasyonSil.Text = "Rezervasyonu İptal Et";
            this.btn_RezervasyonSil.UseVisualStyleBackColor = true;
            this.btn_RezervasyonSil.Visible = false;
            this.btn_RezervasyonSil.Click += new System.EventHandler(this.btn_RezervasyonSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1150, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UlasimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1208, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_RezervasyonSil);
            this.Controls.Add(this.btn_RaporAl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UlasimEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.RezervasyonEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_RaporAl;
        private System.Windows.Forms.Button btn_RezervasyonSil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}