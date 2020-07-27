using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface ICheckRepo
    {
        CheckBl Get(int id);
        List<CheckBl> Get();
        CheckBl Add(CheckBl item);
        CheckBl Update(CheckBl item);
        void Delete(int id);
    }
}
