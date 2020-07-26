using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class BaseBl : IBaseBl
    {
        private readonly IDao<Base> _dao;

        public BaseBl(IDao<Base> dao)
        {
            _dao = dao;
        }

        public IEnumerable<BaseDto> Get() => _dao.Get().Select(x => _map(x));

        public BaseDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public BaseDto Add(BaseDto dto)
        {
            var item = new Base()
            {
                Name = dto.Name,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            return _map(item);
        }

        public BaseDto Update(BaseDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.Name = dto.Name;
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

        private BaseDto _map(IBaseDto item)
        {
            return new BaseDto(item);
        }
    }
}
