using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class PriceCostBl : IPriceCostBl
    {
        private readonly IDao<PriceCost> _dao;

        public PriceCostBl(IDao<PriceCost> dao)
        {
            _dao = dao;
        }

        public IEnumerable<PriceCostDto> Get() => _dao.Get().Select(x => _map(x));

        public PriceCostDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public PriceCostDto Add(PriceCostDto dto)
        {
            var item = new PriceCost()
            {
                Procedure = dto.Procedure,
                Type = dto.Type,
                Value = dto.Value,
                DateEnd = dto.DateEnd,
            };

            _dao.Create(item);
            return _map(item);
        }

        public PriceCostDto Update(PriceCostDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.Procedure = dto.Procedure;
            item.Type = dto.Type;
            item.Value = dto.Value;
            item.DateEnd = dto.DateEnd;
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

        private PriceCostDto _map(IPriceCostDto item)
        {
            return new PriceCostDto(item);
        }
    }
}
