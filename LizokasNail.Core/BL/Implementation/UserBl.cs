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

        public IEnumerable<UserDto> Get() => _dao.Get().Select(x => _map(x));

        public UserDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public UserDto Add(UserDto dto)
        {
            var item = new User()
            {
                Name = dto.Name,
                Phone = dto.Phone,
                CommunicationType = dto.CommunicationType,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            return _map(item);
        }

        public UserDto Update(UserDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.Name = dto.Name;
            item.Phone = dto.Phone;
            item.CommunicationType = dto.CommunicationType;
            item.Comment = dto.Comment;
            _dao.Update(item);

            return _map(item);
        }

        public void Delete(int id)
        {
            var entity = _dao.Get(id);
            if (entity == null)
            {
                throw new KeyNotFoundException();
            }
            else
            {
                _dao.Delete(id);
            }
        }

        private UserDto _map(User item)
        {
            return new UserDto(item) { Records = item.Records.Select(x=> new RecordDto(x))};
        }
    }
}
