using Business.Concrete;
using DataAccess.Abstact;
using DataAccess.Concrete;
using SeyhatAcecntasi;
using SeyhatAcecntasi.AbstractSey;
using SeyhatAcecntasi.AbstractUlas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class frmKonaklamaEkrani : Form
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Kalkis { get; set; }
        public string Varis { get; set; }
        public string Konaklama { get; set; }
        public string Ulasim { get; set; }
        public int SeyhatID { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        int konaklamaFiyat=0;
        KonaklamaBilgiManager konaklamaBilgi = new KonaklamaBilgiManager(new EFKonaklamaDal());

        public frmKonaklamaEkrani()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            konaklamaFiyat = Convert.ToInt32( dataGridView1.Rows[secilen].Cells[3].Value);
            SeyhatID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (konaklamaFiyat != 0) 
            {
                UlasimEkrani ulasimEkrani = new UlasimEkrani()
                {
                    KonaklamaFiyat = konaklamaFiyat,
                    VarisYeri = Varis,
                    KalkisYeri = Kalkis,
                    AracTipi = Ulasim,
                    KonaklamaTipi = Konaklama,
                    Sifree = Sifre,
                    kullanici = KullaniciAdi,
                    SeyhatId = SeyhatID,
                    GidisTarihi = GidisTarihi,
                    DonusTarihi = DonusTarihi

                };
                ulasimEkrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("lütfen Bir Konaklama Şeciniz");
            }
            
        }

        private void KonaklamaEkrani_Load(object sender, EventArgs e)
        {
            if (Konaklama == "Otel" && Ulasim == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusOtel());
                dataGridView1.DataSource = seyhatManager.Konaklamaistele(Varis, Konaklama);

            }
            else if (Konaklama == "Otel" && Ulasim == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakOtel());
                dataGridView1.DataSource = seyhatManager.Konaklamaistele(Varis, Konaklama);
            }
            else if (Konaklama == "Cadir" && Ulasim == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusCadir());
                dataGridView1.DataSource = seyhatManager.Konaklamaistele(Varis, Konaklama);
            }
            else if (Konaklama == "Cadir" && Ulasim == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakCadir());
                dataGridView1.DataSource = seyhatManager.Konaklamaistele(Varis, Konaklama);
            }
            
        }
    }
}
