using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface ITopBl
    {
        IEnumerable<TopDto> Get();

        TopDto GetById(int id);
        TopDto Add(TopDto dto);
        TopDto Update(TopDto dto);
        void Delete(int id);
    }
}
