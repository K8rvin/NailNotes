using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class UserBl : Identity
    {
        public UserBl()
        {
        }

        public UserBl(UserDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
                Phone = dto.Phone;
            }
        }

        public string Name { get; set; }
        public string Phone { get; set; }

        public UserDto ToDto() => new UserDto()
        {
            Id = Id,
            Name = Name,
            Phone = Phone,
        };
    }
}
