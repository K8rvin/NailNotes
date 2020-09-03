using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IPriceCostService
    {
        PriceCostDto Get(int id);
        IEnumerable<PriceCostDto> Get();
        PriceCostDto Add(PriceCostDto item);
        PriceCostDto Update(PriceCostDto item);
        void Delete(int id);
    }
}
