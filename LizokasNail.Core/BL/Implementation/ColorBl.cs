using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class ColorBl : IColorBl
    {
        private readonly IDao<Color> _dao;

        public ColorBl(IDao<Color> dao)
        {
            _dao = dao;
        }

        public IEnumerable<ColorDto> Get() => _dao.Get().Select(x => _map(x));

        public ColorDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public ColorDto Add(ColorDto dto)
        {
            var item = new Color()
            {
                Name = dto.Name,
            };

            _dao.Create(item);
            return _map(item);
        }

        public ColorDto Update(ColorDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.Name = dto.Name;
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

        private ColorDto _map(IColorDto item)
        {
            return new ColorDto(item);
        }
    }
}
