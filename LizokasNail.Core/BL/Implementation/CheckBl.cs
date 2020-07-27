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

        public CheckBl(IDao<Check> dao)
        {
            _dao = dao;
        }

        public IEnumerable<CheckDto> Get() => _dao.Get().Select(x => _map(x));

        public CheckDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public CheckDto Add(CheckDto dto)
        {
            var item = new Check()
            {
                RecordId = dto.RecordId,
                BaseId = dto.BaseId,
                ColorId = dto.ColorId,
                TopId = dto.TopId,
                Price = dto.Price,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            return _map(item);
        }

        public CheckDto Update(CheckDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.RecordId = dto.RecordId;
            item.BaseId = dto.BaseId;
            item.ColorId = dto.ColorId;
            item.TopId = dto.TopId;
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
                BaseId = item.BaseId,
                ColorId = item.ColorId,
                TopId = item.TopId,
                Price = item.Price,
                Comment = item.Comment,
                Record = new RecordDto(item.Record) { User = new UserDto(item?.Record?.User), Check = new CheckDto(item?.Record?.Check) },                
                Base = new BaseDto(item.Base),
                Color = new ColorDto(item.Color),
                Top = new TopDto(item.Top),
                Check2Design = item.Check2Design.Select(x => new Check2DesignDto(x)),
            };
        }
    }
}
