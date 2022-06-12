using BuilderRaporlama;
using BuilderRaporlama.Reports;
using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class frmRaporlamaEkrani : Form
    {
        public frmRaporlamaEkrani()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        public string kullanici { get; set; }
        public string Sifree { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = kullaniciManager.KullaniciAdiVeSifresiIleIdGetir(kullanici, Sifree).Id;
            if (comboBox1.Text =="HTML")
            {
                ReportManager reportManager = new ReportManager(new ReportHTML());
                reportManager.HTMLRaporGetir(id);
                reportManager.RaporAl();
                MessageBox.Show("HTML Raporunuz başarılı şekilde oluşturulmuştur");
            }
            else if (comboBox1.Text == "JSON")
            {
                ReportManager reportManager = new ReportManager(new ReportJSON());
                reportManager.JSONRaporGetir(id);
                reportManager.RaporAl();
                MessageBox.Show("JSON Raporunuz başarılı şekilde oluşturulmuştur");

            }
            else if (comboBox1.Text == "XML")
            {
                ReportManager reportManager = new ReportManager(new ReportXML());
                reportManager.JSONRaporGetir(id);
                reportManager.RaporAl();
                MessageBox.Show("XML Raporunuz başarılı şekilde oluşturulmuştur");

            }
            else
            {
                MessageBox.Show("Boş Geçmeyin");
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
    }
}
