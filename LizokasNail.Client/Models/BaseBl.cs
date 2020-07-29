using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class BaseBl : Identity, IBaseDto
    {
        public BaseBl()
        {
        }

        public BaseBl(BaseDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
                Comment = dto.Comment;
            }
        }

        public BaseBl(Check2BaseDto item)
        {
            Id = item.IdBase;
            Name = item.Base?.Name;
            Comment = item.Comment;
        }

        public string Name { get; set; }
        public string Comment { get; set; }

        public BaseDto ToDto() => new BaseDto()
        {
            Id = Id,
            Name = Name,
            Comment = Comment,
        };
    }
}
