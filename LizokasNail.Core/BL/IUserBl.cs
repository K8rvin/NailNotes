using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IUserBl
    {
        IEnumerable<UserDto> Get();

        UserDto GetById(int id);
        UserDto Add(UserDto dto);
    }
}
