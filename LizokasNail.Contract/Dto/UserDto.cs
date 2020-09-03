using LizokasNail.Contract.Enum;
using System.Collections.Generic;

namespace LizokasNail.Contract.Dto
{
    public interface IUserDto : IIdentity
    {
        string Name { get; set; }
        string Phone { get; set; }
        CommunicationType CommunicationType { get; set; }
        string Comment { get; set; }
        bool Vip { get; set; }
    }

    public class UserDto : Identity, IUserDto
    {
        public UserDto()
        {
        }

        public UserDto(IUserDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                Phone = item.Phone;
                CommunicationType = item.CommunicationType;
                Comment = item.Comment;
                Vip = item.Vip;
            }
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Comment { get; set; }
        public bool Vip { get; set; } = false;
        public IEnumerable<RecordDto> Records { get; set; }
    }
}
