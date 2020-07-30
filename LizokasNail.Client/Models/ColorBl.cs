using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class ColorBl : Identity, IColorDto
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
                Comment = dto.Comment;
            }
        }

        public ColorBl(Check2ColorDto item)
        {
            Id = item.IdColor;
            Name = item.Color?.Name;
            Comment = item.Comment;
        }

        public string Name { get; set; }
        public string Comment { get; set; }

        public ColorDto ToDto() => new ColorDto()
        {
            Id = Id,
            Name = Name,
            Comment = Comment,
        };
    }
}
