using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISeyhatBilgiService
    {
        SeyhatBilgi GetId(int kullaniciId);
        List<SeyhatBilgi> GetAll();
        void add(SeyhatBilgi seyhatBilgi);
        void delete(SeyhatBilgi seyhatBilgi);
        void update(SeyhatBilgi seyhatBilgi);
    }
}
