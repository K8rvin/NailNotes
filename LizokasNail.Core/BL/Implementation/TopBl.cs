using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class TopBl : ITopBl
    {
        private readonly IDao<Top> _dao;

        public TopBl(IDao<Top> dao)
        {
            _dao = dao;
        }

        public IEnumerable<TopDto> Get() => _dao.Get().Select(x => _map(x));

        public TopDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public TopDto Add(TopDto dto)
        {
            var item = new Top()
            {
                Name = dto.Name,
                Comment = dto.Comment,
            };

            _dao.Create(item);
            return _map(item);
        }

        public TopDto Update(TopDto dto)
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

        private TopDto _map(ITopDto item)
        {
            return new TopDto(item);
        }
    }
}
