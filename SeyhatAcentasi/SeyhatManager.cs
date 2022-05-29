using Entities.DTO;
using SeyhatAcecntasi.AbstractKonakla;
using SeyhatAcecntasi.AbstractKSey;
using SeyhatAcecntasi.AbstractUlas;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeyhatAcecntasi
{
    public class SeyhatManager
    {
        private AbstractKonaklama _abstractKonaklama;
        private AbstractSeyhat _abstractSeyhat;
        private AbstractUlasim _abstractUlasim;
        public SeyhatManager(AbstractSeyhat abstractSeyhat)
        {
            _abstractSeyhat = abstractSeyhat;
            _abstractKonaklama = abstractSeyhat.Konaklama();
            _abstractUlasim = abstractSeyhat.Ulasim();
        }
        
       
        public List<UlasimDetailDto> UlasimListele(string kalkis, string varis, string aracTipi)
        {
            return _abstractUlasim.UlasimListele(kalkis, varis, aracTipi);
        }
        public List<KonaklamaDetailDto> Konaklamaistele(string konaklamaYeri, string konaklamaTipi)
        {
            return _abstractKonaklama.konaklamaListele(konaklamaYeri, konaklamaTipi);
        }
    }
}
