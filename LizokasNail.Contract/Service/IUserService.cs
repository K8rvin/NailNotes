using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IUserService
    {
        UserDto Get(int id);
        IEnumerable<UserDto> Get();
        UserDto Add(UserDto item);
        UserDto Update(UserDto item);
    }
}
