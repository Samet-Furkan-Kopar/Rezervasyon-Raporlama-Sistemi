﻿using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
namespace Business.Abstract
{
    public interface IKonaklamaBİlgiService
    {
        List<KonaklamaDetailDto> konaklamaDetailDtos(string konaklamaYeri, string konaklamaTipi);
        List<KonaklamaDetailDto> GetAllKonaklamaId(int konaklamaID);
        KonaklamaDetailDto GetId(int id);
    }
}
