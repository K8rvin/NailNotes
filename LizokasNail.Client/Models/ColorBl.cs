using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class ColorBl : Identity
    {
        public ColorBl()
        {
        }

        public ColorBl(ColorDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
            }
        }

        public string Name { get; set; }

        public ColorDto ToDto() => new ColorDto()
        {
            Id = Id,
            Name = Name,
        };
    }
}
