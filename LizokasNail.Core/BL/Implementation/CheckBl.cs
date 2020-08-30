using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class CheckBl : ICheckBl
    {
        private readonly IDao<Check> _dao;
        private readonly IDao<Check2Base> _check2BaseDao;
        private readonly IDao<Check2Color> _check2ColorDao;
        private readonly IDao<Check2Top> _check2TopDao;
        private readonly IDao<Check2Design> _check2DesignDao;

        public CheckBl(IDao<Check> dao, IDao<Check2Base> check2BaseDao, IDao<Check2Color> check2ColorDao, IDao<Check2Top> check2TopDao, IDao<Check2Design> check2DesignDao)
        {
            _dao = dao;
            _check2BaseDao = check2BaseDao;
            _check2ColorDao = check2ColorDao;
            _check2TopDao = check2TopDao;
            _check2DesignDao = check2DesignDao;
        }

        public IEnumerable<CheckDto> Get() => _dao.Get().Select(x => _map(x));

        public IEnumerable<CheckDto> GetByPeriod(DateTime dateStart, DateTime dateEnd)
            => _dao.Get(x => x.Record.RecordDate >= dateStart && x.Record.RecordDate <= dateEnd.AddDays(1)).Select(x => _map(x));

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
            _check2BaseDao.CreateRange(dto.Check2Base.Select(x => new Check2Base() { IdCheck = item.Id, IdBase = x.IdBase, Comment = x.Comment }));
            _check2ColorDao.CreateRange(dto.Check2Color.Select(x => new Check2Color() { IdCheck = item.Id, IdColor = x.IdColor, Comment = x.Comment }));
            _check2TopDao.CreateRange(dto.Check2Top.Select(x => new Check2Top() { IdCheck = item.Id, IdTop = x.IdTop, Comment = x.Comment }));
            _check2DesignDao.CreateRange(dto.Check2Design.Select(x => new Check2Design() { IdCheck = item.Id, IdDesign = x.IdDesign, Comment = x.Comment, Count = x.Count }));

            return _map(item);
        }

        public CheckDto Update(CheckDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            _check2BaseDao.DeleteRange(item.Check2Base);
            _check2BaseDao.CreateRange(dto.Check2Base.Select(x => new Check2Base() { IdCheck = item.Id, IdBase = x.IdBase, Comment = x.Comment }));

            _check2ColorDao.DeleteRange(item.Check2Color);
            _check2ColorDao.CreateRange(dto.Check2Color.Select(x => new Check2Color() { IdCheck = item.Id, IdColor = x.IdColor, Comment = x.Comment }));

            _check2TopDao.DeleteRange(item.Check2Top);
            _check2TopDao.CreateRange(dto.Check2Top.Select(x => new Check2Top() { IdCheck = item.Id, IdTop = x.IdTop, Comment = x.Comment }));

            _check2DesignDao.DeleteRange(item.Check2Design);
            _check2DesignDao.CreateRange(dto.Check2Design.Select(x => new Check2Design() { IdCheck = item.Id, IdDesign = x.IdDesign, Comment = x.Comment, Count = x.Count }));

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
