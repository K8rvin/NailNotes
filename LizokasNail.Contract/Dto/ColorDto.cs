using System;

namespace LizokasNail.Contract.Dto
{
    public interface IColorDto : IIdentity
    {
        string Name { get; set; }
    }

    public class ColorDto : Identity, IColorDto
    {
        public ColorDto()
        {
        }

        public ColorDto(IColorDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
            }
        }

        public string Name { get; set; }
    }
}
