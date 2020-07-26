using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IBaseBl
    {
        IEnumerable<BaseDto> Get();

        BaseDto GetById(int id);
        BaseDto Add(BaseDto dto);
        BaseDto Update(BaseDto dto);
        void Delete(int id);
    }
}
