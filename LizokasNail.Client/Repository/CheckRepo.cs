using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class CheckRepo : ICheckRepo
    {
        private readonly IUnityContainer _uc;
        private readonly ICheckService _service;

        public CheckRepo(IUnityContainer uc, ICheckService service)
        {
            _uc = uc;
            _service = service;
        }

        public CheckBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new CheckBl(dto) : null;
        }

        public virtual List<CheckBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<CheckBl>(new ParameterOverride("dto", x))).ToList();
        }

        public CheckBl Add(CheckBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new CheckBl(dto) : null;
        }

        public CheckBl Update(CheckBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new CheckBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
