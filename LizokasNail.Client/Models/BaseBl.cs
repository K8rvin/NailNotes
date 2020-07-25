using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class BaseBl : Identity
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
            }
        }

        public string Name { get; set; }

        public BaseDto ToDto() => new BaseDto()
        {
            Id = Id,
            Name = Name,
        };
    }
}
