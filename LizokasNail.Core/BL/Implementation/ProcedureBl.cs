using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class ProcedureBl : IProcedureBl
    {
        private readonly IDao<Procedure> _dao;

        public ProcedureBl(IDao<Procedure> dao)
        {
            _dao = dao;
        }

        public IEnumerable<ProcedureDto> Get() => _dao.Get().OrderBy(x=>x.Name).Select(x => _map(x));

        public ProcedureDto GetById(int id) => _map(_dao.Get(x => x.Id == id)?.FirstOrDefault());

        public ProcedureDto Add(ProcedureDto dto)
        {
            var item = new Procedure()
            {
                Name = dto.Name,
                ShortName = dto.ShortName,
                Price = dto.Price,
                PriceVip = dto.PriceVip,
            };

            _dao.Create(item);
            return _map(item);
        }

        public ProcedureDto Update(ProcedureDto dto)
        {
            var item = _dao.Get(dto.Id);
            if (item == null)
                throw new KeyNotFoundException();

            item.Name = dto.Name;
            item.ShortName = dto.ShortName;
            item.Price = dto.Price;
            item.PriceVip = dto.PriceVip;
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

        private ProcedureDto _map(IProcedureDto item)
        {
            return new ProcedureDto(item);
        }
    }
}
