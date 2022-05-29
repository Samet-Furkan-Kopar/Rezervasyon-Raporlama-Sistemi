using Business.Concrete;
using DataAccess.Concrete;
using Entities.DTO;
using Entities.Entity;
using SeyhatAcecntasi;
using SeyhatAcecntasi.AbstractSey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class UlasimEkrani : Form
    {

        public int SeyhatId { get; set; }
        public int UlasimID { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public string AracTipi { get; set; }
        public string KonaklamaTipi { get; set; }
        public string kullanici { get; set; }
        public string Sifree { get; set; }
        public int KonaklamaFiyat { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        int UlasimFiyat = 0;

        public UlasimEkrani()
        {
            InitializeComponent();
        }
       // UlasimAracManager ulasimAracManager = new UlasimAracManager(new EFUlasimAracDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgiManager = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        private void button1_Click(object sender, EventArgs e)
        {
            if (UlasimFiyat !=0 )
            {
                int kullaniciID = kullaniciManager.KullaniciAdiVeSifresiIleIdGetir(kullanici, Sifree).Id;
                bool kontrol = true;
                foreach (var item in seyhatBilgiManager.GetAll())
                {
                    if (kullaniciID == item.KullaniciId)
                    {
                        kontrol = false;
                    }
                }
                if (kontrol)
                {
                    SeyhatBilgi seyhatBilgi = new SeyhatBilgi();
                    seyhatBilgi.KullaniciId = kullaniciID;
                    seyhatBilgi.KonaklamaID = SeyhatId;
                    seyhatBilgi.UlasimID = UlasimID;
                    seyhatBilgi.RezervasyonBaslangic = GidisTarihi;
                    seyhatBilgi.RezervasyonBitis = DonusTarihi;
                    seyhatBilgi.ToplamUcret = UlasimFiyat + KonaklamaFiyat;
                    seyhatBilgiManager.add(seyhatBilgi);
                    visible();
                    MessageBox.Show("Rezervasyonunuz başarılı şekilde kaydedildi");

                }
                else
                {
                    btn_RaporAl.Visible = true;
                    btn_RezervasyonSil.Visible = true;
                    MessageBox.Show("Daha önceden rezervasyonunuz var");

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir tane ulaşım seçiniz");
            }
          

        }
        void visible()
        {
            btn_RaporAl.Visible = true;
            btn_RezervasyonSil.Visible = true;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            UlasimFiyat =Convert.ToInt32( dataGridView1.Rows[secilen].Cells[6].Value);
            UlasimID= Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);

        }

        private void RezervasyonEkrani_Load(object sender, EventArgs e)
        {
            if (KonaklamaTipi == "Otel" && AracTipi == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusOtel());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);
            }
            else if (KonaklamaTipi == "Otel" && AracTipi == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakOtel());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);

            }
            else if (KonaklamaTipi == "Cadir" && AracTipi == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusCadir());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);
            }
            else if (KonaklamaTipi == "Cadir" && AracTipi == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakCadir());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);

            }
            else { MessageBox.Show("Girmedi"); }


           
        }

        private void btn_RaporAl_Click(object sender, EventArgs e)
        {
            frmRaporlamaEkrani raporlama = new frmRaporlamaEkrani()
            {
                kullanici = kullanici,
                Sifree = Sifree
            };
            raporlama.Show();
            this.Hide();
        }

        private void btn_RezervasyonSil_Click(object sender, EventArgs e)
        {
            frmRezervasyonIptal frmRezervasyonIptal = new frmRezervasyonIptal()
            {
                kullaniciAdi = kullanici,
                sifre = Sifree

            };
            frmRezervasyonIptal.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
