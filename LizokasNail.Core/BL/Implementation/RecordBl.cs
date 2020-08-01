using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class RecordBl : IRecordBl
    {
        private readonly IDao<Record> _dao;
        private readonly IUserBl _userBl;

        public RecordBl(IDao<Record> dao, IUserBl userBl)
        {
            _dao = dao;
            _userBl = userBl;
        }

        public IEnumerable<RecordDto> Get() => _dao.Get().OrderBy(x => x.RecordDate).Select(x => _map(x));

        public IEnumerable<RecordDto> GetWithoutCheck() => _dao.Get(x => x.Check == null).OrderBy(x => x.RecordDate).Select(x => _map(x));

        public IEnumerable<RecordDto> GetByPeriod(DateTime dateStart, DateTime dateEnd)
        {
            return _dao.Get(x => x.RecordDate >= dateStart && x.RecordDate <= dateEnd).OrderBy(x => x.RecordDate).Select(x => _map(x));
        }

        public RecordDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public RecordDto Add(RecordDto dto)
        {
            var item = new Record()
            {
                UserId = dto.UserId,
                RecordDate = dto.RecordDate,
            };

            _dao.Create(item);
            return _map(item);
        }

        public RecordDto AddNewUserRecord(RecordDto dto)
        {
            var user = _userBl.Add(dto.User);

            var item = new Record()
            {
                UserId = user.Id,
                RecordDate = dto.RecordDate,
            };

            _dao.Create(item);
            return _map(item);
        }

        public RecordDto Update(RecordDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.UserId = dto.UserId;
            item.RecordDate = dto.RecordDate;
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

        private RecordDto _map(Record item)
        {
            if (item == null) return null;
            return new RecordDto()
            {
                Id = item.Id,
                UserId = item.UserId,
                RecordDate = item.RecordDate,
                User = new UserDto(item.User),
                Check = new CheckDto(item.Check),
                Record2Procedure = item.Record2Procedure.Select(x => new Record2ProcedureDto(x) { Procedure = new ProcedureDto(x.Procedure)}),
            };
        }
    }
}
