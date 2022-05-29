using Business.Concrete;
using DataAccess.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractKonakla
{
    public class Otel : AbstractKonaklama
    {

        KonaklamaBilgiManager konaklamaBilgiManager = new KonaklamaBilgiManager(new EFKonaklamaDal());

        public override List<KonaklamaDetailDto> konaklamaListele(string konaklamaYeri, string konaklamaTipi)
        {
            return konaklamaBilgiManager.konaklamaDetailDtos(konaklamaYeri, konaklamaTipi);
        }
    }
}
