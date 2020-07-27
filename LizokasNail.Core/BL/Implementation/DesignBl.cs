using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class DesignBl : IDesignBl
    {
        private readonly IDao<Design> _dao;

        public DesignBl(IDao<Design> dao)
        {
            _dao = dao;
        }

        public IEnumerable<DesignDto> Get() => _dao.Get().Select(x => _map(x));

        public DesignDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public DesignDto Add(DesignDto dto)
        {
            var item = new Design()
            {
                Name = dto.Name,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            return _map(item);
        }

        public DesignDto Update(DesignDto dto)
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

        private DesignDto _map(IDesignDto item)
        {
            return new DesignDto(item);
        }
    }
}
