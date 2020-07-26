using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class TopBl : Identity, ITopDto
    {
        public TopBl()
        {
        }

        public TopBl(TopDto dto)
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

        public TopDto ToDto() => new TopDto()
        {
            Id = Id,
            Name = Name,
            Comment = Comment,
        };
    }
}
