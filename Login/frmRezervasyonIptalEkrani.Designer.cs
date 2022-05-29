
namespace WindowsUI
{
    partial class frmRezervasyonIptal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyonIptal));
            this.dataGridViewUlasim = new System.Windows.Forms.DataGridView();
            this.dataGridViewKonaklama = new System.Windows.Forms.DataGridView();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUlasim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonaklama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUlasim
            // 
            this.dataGridViewUlasim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUlasim.Location = new System.Drawing.Point(3, 40);
            this.dataGridViewUlasim.Name = "dataGridViewUlasim";
            this.dataGridViewUlasim.RowHeadersWidth = 51;
            this.dataGridViewUlasim.RowTemplate.Height = 29;
            this.dataGridViewUlasim.Size = new System.Drawing.Size(695, 146);
            this.dataGridViewUlasim.TabIndex = 0;
            this.dataGridViewUlasim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUlasim_CellClick);
            // 
            // dataGridViewKonaklama
            // 
            this.dataGridViewKonaklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonaklama.Location = new System.Drawing.Point(3, 210);
            this.dataGridViewKonaklama.Name = "dataGridViewKonaklama";
            this.dataGridViewKonaklama.RowHeadersWidth = 51;
            this.dataGridViewKonaklama.RowTemplate.Height = 29;
            this.dataGridViewKonaklama.Size = new System.Drawing.Size(695, 146);
            this.dataGridViewKonaklama.TabIndex = 1;
            this.dataGridViewKonaklama.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKonaklama_CellClick);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sil.Location = new System.Drawing.Point(522, 383);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(138, 44);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmRezervasyonIptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 439);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.dataGridViewKonaklama);
            this.Controls.Add(this.dataGridViewUlasim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRezervasyonIptal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRezervasyonIptal";
            this.Load += new System.EventHandler(this.frmRezervasyonIptal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUlasim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonaklama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUlasim;
        private System.Windows.Forms.DataGridView dataGridViewKonaklama;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}