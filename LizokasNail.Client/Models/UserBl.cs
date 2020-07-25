using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Enum;

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
                CommunicationType = dto.CommunicationType;
                Comment = dto.Comment;
            }
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Comment { get; set; }

        public UserDto ToDto() => new UserDto()
        {
            Id = Id,
            Name = Name,
            Phone = Phone,
            CommunicationType = CommunicationType,
            Comment = Comment,
        };
    }
}
