using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class UserBl : IUserBl
    {
        private readonly IDao<User> _dao;

        public UserBl(IDao<User> dao)
        {
            _dao = dao;
        }

        public IEnumerable<UserDto> Get() => _dao.Get().Select(x => toDto(x));

        public UserDto GetById(int id) => toDto(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        private UserDto toDto(User item)
        {
            if (item == null) return null;
            return new UserDto()
            {
                Id = item.Id,
                Name = item.Name,
                Phone = item.Phone,
            };
        }
    }
}
