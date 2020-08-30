using LisokasNail.Models;
using System;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface ICheckRepo
    {
        CheckBl Get(int id);
        List<CheckBl> Get();
        List<CheckBl> GetByPeriod(DateTime DateStart, DateTime DateEnd);
        CheckBl Add(CheckBl item);
        CheckBl Update(CheckBl item);
        void Delete(int id);
    }
}
