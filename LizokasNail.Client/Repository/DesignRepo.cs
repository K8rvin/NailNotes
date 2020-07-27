using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class DesignRepo : IDesignRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IDesignService _service;

        public DesignRepo(IUnityContainer uc, IDesignService service)
        {
            _uc = uc;
            _service = service;
        }

        public DesignBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new DesignBl(dto) : null;
        }

        public virtual List<DesignBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<DesignBl>(new ParameterOverride("dto", x))).ToList();
        }

        public DesignBl Add(DesignBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new DesignBl(dto) : null;
        }

        public DesignBl Update(DesignBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new DesignBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
