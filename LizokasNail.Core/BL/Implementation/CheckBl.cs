using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class CheckBl : ICheckBl
    {
        private readonly IDao<Check> _dao;
        private readonly IDao<Check2Base> _check2BaseDao;

        public CheckBl(IDao<Check> dao, IDao<Check2Base> check2BaseDao)
        {
            _dao = dao;
            _check2BaseDao = check2BaseDao;
        }

        public IEnumerable<CheckDto> Get() => _dao.Get().Select(x => _map(x));

        public CheckDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public CheckDto Add(CheckDto dto)
        {
            var item = new Check()
            {
                RecordId = dto.RecordId,
                Price = dto.Price,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            _check2BaseDao.CreateRange(dto.Check2Base.Select(x=>new Check2Base() { IdCheck = item.Id, IdBase = x.IdBase, Comment = x.Comment}));

            return _map(item);
        }

        public CheckDto Update(CheckDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            _check2BaseDao.DeleteRange(item.Check2Base);
            _check2BaseDao.CreateRange(dto.Check2Base.Select(x => new Check2Base() { IdCheck = item.Id, IdBase = x.IdBase, Comment = x.Comment }));

            item.RecordId = dto.RecordId;
            item.Price = dto.Price;
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

        private CheckDto _map(Check item)
        {
            if (item == null) return null;
            return new CheckDto()
            {
                Id = item.Id,
                RecordId = item.RecordId,
                Price = item.Price,
                Comment = item.Comment,
                Record = new RecordDto(item.Record) { User = new UserDto(item?.Record?.User), Check = new CheckDto(item?.Record?.Check) },
                Check2Base = item.Check2Base.Select(x => new Check2BaseDto(x) { Base = new BaseDto(x.Base) }),
                Check2Color = item.Check2Color.Select(x => new Check2ColorDto(x) { Color = new ColorDto(x.Color) }),
                Check2Top = item.Check2Top.Select(x => new Check2TopDto(x) { Top = new TopDto(x.Top) }),
                Check2Design = item.Check2Design.Select(x => new Check2DesignDto(x) { Design = new DesignDto(x.Design) }),
            };
        }
    }
}
