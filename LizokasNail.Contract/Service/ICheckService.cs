using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface ICheckService
    {
        CheckDto Get(int id);
        IEnumerable<CheckDto> Get();
        CheckDto Add(CheckDto item);
        CheckDto Update(CheckDto item);
        void Delete(int id);
    }
}
