using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class DesignBl : Identity, IDesignDto
    {
        public DesignBl()
        {
        }

        public DesignBl(DesignDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
                Comment = dto.Comment;
            }
        }

        public string Name { get; set; }
        public string Comment { get; set; }

        public DesignDto ToDto() => new DesignDto()
        {
            Id = Id,
            Name = Name,
            Comment = Comment,
        };
    }
}
