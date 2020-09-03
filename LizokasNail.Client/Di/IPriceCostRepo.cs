using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IPriceCostRepo
    {
        PriceCostBl Get(int id);
        List<PriceCostBl> Get();
        PriceCostBl Add(PriceCostBl item);
        PriceCostBl Update(PriceCostBl item);
        void Delete(int id);
    }
}
