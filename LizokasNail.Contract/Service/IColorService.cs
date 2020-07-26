using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IColorService
    {
        ColorDto Get(int id);
        IEnumerable<ColorDto> Get();
        ColorDto Add(ColorDto item);
        ColorDto Update(ColorDto item);
        void Delete(int id);
    }
}
