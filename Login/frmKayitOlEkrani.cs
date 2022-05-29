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
    public partial class frmKayitOlEkrani : Form
    {
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        public frmKayitOlEkrani()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = txt_Ad.Text;
            kullanici.Soyadi = txt_Soyad.Text;
            kullanici.KullaniciAdi = txt_KullaniciAd.Text;
            kullanici.Sifre = txt_Sifre.Text;
            foreach (var item in kullaniciManager.GetAll())
            {
                if (txt_KullaniciAd.Text==item.KullaniciAdi)
                {
                    kontrol = false;
                }
            }
            if (kontrol)
            {
                kullaniciManager.add(kullanici);
                MessageBox.Show("Kaydetme başarılı");
                frmGirisEkrani girisEkrani = new frmGirisEkrani();
                girisEkrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici Adi Aynı olamaz");
                txt_KullaniciAd.Clear();
            }

        }
    }
}
