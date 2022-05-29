using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class RezervasyonEkrani : Form
    {
        public RezervasyonEkrani()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        private void btn_Rezervasyon_Click(object sender, EventArgs e)
        {
                frmKonaklamaEkrani konaklamaEkrani = new frmKonaklamaEkrani()
                {
                    Konaklama = cmb_Konaklama.Text,
                    Ulasim = cmb_Ulasim.Text,
                    Varis = cmb_GideceegiIl.Text,
                    Kalkis = cmb_BulunduguIl.Text,
                    KullaniciAdi = KullaniciAdi,
                    Sifre = Sifre,
                    DonusTarihi = dateTimeDonus.Value,
                    GidisTarihi = dateTimeGidis.Value
                };
                konaklamaEkrani.Show();
                this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
