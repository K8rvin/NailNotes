using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface ICheckBl
    {
        IEnumerable<CheckDto> Get();
        CheckDto GetById(int id);
        CheckDto Add(CheckDto dto);
        CheckDto Update(CheckDto dto);
        void Delete(int id);
    }
}
