using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface ITopService
    {
        TopDto Get(int id);
        IEnumerable<TopDto> Get();
        TopDto Add(TopDto item);
        TopDto Update(TopDto item);
        void Delete(int id);
    }
}
