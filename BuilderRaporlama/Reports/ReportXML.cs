using BuilderRaporlama.ReportBuilderBas;
using System;
using System.Collections.Generic;
using System.Text;
using BuilderRaporlama;
using DataAccess.Concrete;
using Business.Concrete;
using System.Xml;

namespace BuilderRaporlama.Reports
{
    public class ReportXML : ReportBuilderBase
    {
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgiManager = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        UlasimAracManager ulasim = new UlasimAracManager(new EFUlasimAracDal());
        KonaklamaBilgiManager konaklama = new KonaklamaBilgiManager(new EFKonaklamaDal());
        private const string filename = @"C:\Users\EMRE\Desktop\\XML.xml";
        XmlTextWriter writer1 = new XmlTextWriter(filename, null);
        

        public override void RaporKaydet()
        {
            writer1.WriteEndElement();
            writer1.WriteEndDocument();
            writer1.Flush();
            writer1.Close();
            XmlDocument doc = new XmlDocument();

            doc.PreserveWhitespace = true;

            doc.Load(filename);
        }

        public override void SeyehatBilgileriniGetir(int id)
        {
            var kaldigiGunSayisi = seyhatBilgiManager.GetId(id).RezervasyonBitis.Day - seyhatBilgiManager.GetId(id).RezervasyonBaslangic.Day;
            var konaklamaId = seyhatBilgiManager.GetId(id).KonaklamaID;

            string Adi = kullaniciManager.GetId(id).Adi;
            string Soyadi = kullaniciManager.GetId(id).Soyadi;
            string Sirket_Adi = konaklama.GetId(konaklamaId).SirketAdi;
            string Konaklama_Tipi= konaklama.GetId(konaklamaId).KonaklamaTipi;
            string Tatil_Yeri = konaklama.GetId(konaklamaId).TatilYeri;
            DateTime BaslangicTarihi= seyhatBilgiManager.GetId(id).RezervasyonBaslangic;
            DateTime BitisTarihi= seyhatBilgiManager.GetId(id).RezervasyonBitis;
            var ucret= konaklama.GetId(konaklamaId).ucret * kaldigiGunSayisi;

            writer1.Formatting = Formatting.Indented;
            writer1.WriteStartDocument();
            writer1.WriteDocType("SeyehatUlasim", null, null, "<!ENTITY h 'hardcover'>");
            writer1.WriteComment("sample XML");
            writer1.WriteStartElement("SEYEHAT");
            writer1.WriteAttributeString("Bilgi", "SEYEHAT BİLGİ");
            writer1.WriteElementString("title", "-----KONAKLAMA BİLGİLERİ------");
                  
            writer1.WriteElementString("Adi", Adi);
            writer1.WriteElementString("Soyadi", Soyadi);
            writer1.WriteElementString("Sirket_Adi", Sirket_Adi);
            writer1.WriteElementString("Konaklama_Tipi", Konaklama_Tipi);
            writer1.WriteElementString("Tatil_Yeri", Tatil_Yeri);
            writer1.WriteElementString("BaslangicTarihi", BaslangicTarihi.ToString());
            writer1.WriteElementString("BitisTarihi", BitisTarihi.ToString());
            writer1.WriteElementString("Ucret", ucret.ToString());
                  
        }

        public override void UlasimBilgileriniGetir(int id)
        {
            var kalkisYeriID = seyhatBilgiManager.GetId(id).UlasimID;

            var adi = kullaniciManager.GetId(id).Adi;
            var soyadi = kullaniciManager.GetId(id).Soyadi;
            var ulasimTipi = ulasim.GetId(kalkisYeriID).AracTipi;
            var kalkisYeri = ulasim.GetId(kalkisYeriID).KalkisYeri;
            var VarisYeri = ulasim.GetId(kalkisYeriID).VarisYeri;
            var KalkisSaati = ulasim.GetId(kalkisYeriID).KalkisSaati;
            var VarisSaati = ulasim.GetId(kalkisYeriID).VarisSaati;
            var ucret = ulasim.GetId(kalkisYeriID).Ucret*2;
           
            writer1.WriteElementString("title", "-----Ulaşım BİLGİLERİ----");
            
            writer1.WriteElementString("Adi", adi);
            writer1.WriteElementString("Soyadi", soyadi);
            writer1.WriteElementString("UlasimTipi", ulasimTipi);
            writer1.WriteElementString("KalkisYeri", kalkisYeri);
            writer1.WriteElementString("VarisYeri", VarisYeri);
            writer1.WriteElementString("KalkisSaati", KalkisSaati);
            writer1.WriteElementString("VarisSaati", VarisSaati);
            writer1.WriteElementString("Ucret", ucret.ToString());
          ;
        }
    }
}
