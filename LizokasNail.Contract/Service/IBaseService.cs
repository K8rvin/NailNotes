using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IBaseService
    {
        BaseDto Get(int id);
        IEnumerable<BaseDto> Get();
        BaseDto Add(BaseDto item);
        BaseDto Update(BaseDto item);
    }
}
