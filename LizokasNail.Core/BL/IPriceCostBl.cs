using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IPriceCostBl
    {
        IEnumerable<PriceCostDto> Get();

        PriceCostDto GetById(int id);
        PriceCostDto Add(PriceCostDto dto);
        PriceCostDto Update(PriceCostDto dto);
        void Delete(int id);
    }
}
