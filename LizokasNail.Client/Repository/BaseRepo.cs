using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class BaseRepo : IBaseRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IBaseService _service;

        public BaseRepo(IUnityContainer uc, IBaseService service)
        {
            _uc = uc;
            _service = service;
        }

        public BaseBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new BaseBl(dto) : null;
        }

        public virtual List<BaseBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<BaseBl>(new ParameterOverride("dto", x))).ToList();
        }

        public BaseBl Add(BaseBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new BaseBl(dto) : null;
        }

        public BaseBl Update(BaseBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new BaseBl(dto) : null;
        }
    }
}
