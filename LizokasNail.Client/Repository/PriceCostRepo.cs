using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class PriceCostRepo : IPriceCostRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IPriceCostService _service;

        public PriceCostRepo(IUnityContainer uc, IPriceCostService service)
        {
            _uc = uc;
            _service = service;
        }

        public PriceCostBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new PriceCostBl(dto) : null;
        }

        public virtual List<PriceCostBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<PriceCostBl>(new ParameterOverride("dto", x))).ToList();
        }

        public PriceCostBl Add(PriceCostBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new PriceCostBl(dto) : null;
        }

        public PriceCostBl Update(PriceCostBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new PriceCostBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
