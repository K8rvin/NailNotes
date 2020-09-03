using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LisokasNail.Models
{   
    public class UserBl : Identity, IUserDto
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
                Vip = dto.Vip;
                Records = dto.Records;
            }
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public CommunicationType CommunicationType { get; set; }
        public string Comment { get; set; }
        public bool Vip { get; set; }
        public IEnumerable<RecordDto> Records { get; set; }

        public DateTime? LastRecordDate => Records?.Any() == true ?  Records?.Select(x=>x.RecordDate)?.OrderByDescending(x => x)?.FirstOrDefault() : null;

        public UserDto ToDto() => new UserDto()
        {
            Id = Id,
            Name = Name,
            Phone = Phone,
            CommunicationType = CommunicationType,
            Comment = Comment,
            Vip = Vip,
        };
    }
}
