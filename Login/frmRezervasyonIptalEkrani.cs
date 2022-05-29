using Business.Concrete;
using DataAccess.Concrete;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class frmRezervasyonIptal : Form
    {
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }

        int ulasimSecilenId, konaklamaSecilenId;

        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgiManager = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        KonaklamaBilgiManager konaklamaBilgiManager = new KonaklamaBilgiManager(new EFKonaklamaDal());
        UlasimAracManager ulasimAracManager = new UlasimAracManager(new EFUlasimAracDal());
        public frmRezervasyonIptal()
        {
            InitializeComponent();
        }

        private void dataGridViewUlasim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ulasimSecilenId = dataGridViewUlasim.SelectedCells[0].RowIndex;
        }

        private void dataGridViewKonaklama_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            konaklamaSecilenId = dataGridViewKonaklama.SelectedCells[0].RowIndex;
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int KullaniciID = kullaniciManager.KullaniciAdiVeSifresiIleIdGetir(kullaniciAdi, sifre).Id;
            if (ulasimSecilenId==0)
            {
                DialogResult secenek = MessageBox.Show("Ulaşım bilgileri silinirse konaklama bilgileride silinecek?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    int silinecekID=seyhatBilgiManager.GetId(KullaniciID).SeyhatBilgisiID;
                    SeyhatBilgi seyhatBilgi = new SeyhatBilgi();
                    seyhatBilgi.SeyhatBilgisiID = silinecekID;
                    seyhatBilgiManager.delete(seyhatBilgi);
                    DialogResult secenek1 = MessageBox.Show("Tekrardan rezervasyon yapmak istermisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek1== DialogResult.Yes)
                    {
                        RezervasyonEkrani rezervasyonEkrani = new RezervasyonEkrani()
                        {
                            KullaniciAdi = kullaniciAdi,
                            Sifre = sifre
                        };
                        rezervasyonEkrani.Show();
                        this.Hide();
                    }
                    else if (secenek1 == DialogResult.No)
                    {
                        MessageBox.Show("Bir daha görüşmek üzere");
                        Environment.Exit(0);
                    }

                }
                else if (secenek == DialogResult.No)
                {
                    ulasimSecilenId = 1;
                }
            }
            else if (konaklamaSecilenId==0)
            {
                DialogResult secenek = MessageBox.Show("Konaklama bilgileri silinirse ulasim bilgileride silinecek?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (secenek == DialogResult.Yes)
                {
                    int silinecekID = seyhatBilgiManager.GetId(KullaniciID).SeyhatBilgisiID;
                    SeyhatBilgi seyhatBilgi = new SeyhatBilgi();
                    seyhatBilgi.SeyhatBilgisiID = silinecekID;
                    seyhatBilgiManager.delete(seyhatBilgi);
                    DialogResult secenek1 = MessageBox.Show("Tekrardan rezervasyon yapmak istermisiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (secenek1 == DialogResult.Yes)
                    {
                        RezervasyonEkrani rezervasyonEkrani = new RezervasyonEkrani()
                        {
                            KullaniciAdi=kullaniciAdi,
                            Sifre=sifre
                        };

                        rezervasyonEkrani.Show();
                        this.Hide();
                    }
                    else if (secenek1 == DialogResult.No) 
                    {
                        MessageBox.Show("Bir daha görüşmek üzere");
                        Environment.Exit(0);
                    }

                }
                else if (secenek == DialogResult.No)
                {
                    konaklamaSecilenId = 1;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UlasimEkrani ulasimEkrani = new UlasimEkrani();
            ulasimEkrani.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRezervasyonIptal_Load(object sender, EventArgs e)
        {

            int KullaniciID = kullaniciManager.KullaniciAdiVeSifresiIleIdGetir(kullaniciAdi, sifre).Id;
            int konaklamaID = seyhatBilgiManager.GetId(KullaniciID).KonaklamaID;
            int ulasimID = seyhatBilgiManager.GetId(KullaniciID).UlasimID;
            dataGridViewKonaklama.DataSource = konaklamaBilgiManager.GetAllKonaklamaId(konaklamaID);
            dataGridViewUlasim.DataSource = ulasimAracManager.GetAllUlasimId(ulasimID);
        }

    }
}
