using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class RecordBl : IRecordBl
    {
        private readonly IDao<Record> _dao;
        private readonly IDao<User> _userDao;

        public RecordBl(IDao<Record> dao, IDao<User> userDao)
        {
            _dao = dao;
            _userDao = userDao;
        }

        public IEnumerable<RecordDto> Get() => _dao.Get().Select(x => toDto(x));

        public RecordDto GetById(int id) => toDto(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public RecordDto Add(RecordDto dto)
        {
            var item = new Record()
            {
                UserId = dto.UserId,
                RecordDate = dto.RecordDate,
                User = _userDao.Get(dto.UserId),
            };

            _dao.Create(item);
            return toDto(item);
        }

        public RecordDto Update(RecordDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.UserId = dto.UserId;
            item.RecordDate = dto.RecordDate;
            item.User = _userDao.Get(dto.UserId);
            _dao.Update(item);

            return toDto(item);
        }

        private RecordDto toDto(Record item)
        {
            if (item == null) return null;
            return new RecordDto()
            {
                Id = item.Id,
                UserId = item.UserId,
                RecordDate = item.RecordDate,
                User = new UserDto(_userDao.Get(item.UserId)),
            };
        }
    }
}
