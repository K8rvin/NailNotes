using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class TopRepo : ITopRepo
    {
        private readonly IUnityContainer _uc;
        private readonly ITopService _service;

        public TopRepo(IUnityContainer uc, ITopService service)
        {
            _uc = uc;
            _service = service;
        }

        public TopBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new TopBl(dto) : null;
        }

        public virtual List<TopBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<TopBl>(new ParameterOverride("dto", x))).ToList();
        }

        public TopBl Add(TopBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new TopBl(dto) : null;
        }

        public TopBl Update(TopBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new TopBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
