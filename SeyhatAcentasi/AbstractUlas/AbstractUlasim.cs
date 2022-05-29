using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractUlas
{
    public abstract class AbstractUlasim
    {
        public abstract List<UlasimDetailDto> UlasimListele(string kalkis, string varis, string aracTipi);
    }
}
