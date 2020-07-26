using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IColorBl
    {
        IEnumerable<ColorDto> Get();

        ColorDto GetById(int id);
        ColorDto Add(ColorDto dto);
        ColorDto Update(ColorDto dto);
    }
}
