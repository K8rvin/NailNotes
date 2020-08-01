using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class ProcedureRepo : IProcedureRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IProcedureService _service;

        public ProcedureRepo(IUnityContainer uc, IProcedureService service)
        {
            _uc = uc;
            _service = service;
        }

        public ProcedureBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new ProcedureBl(dto) : null;
        }

        public virtual List<ProcedureBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<ProcedureBl>(new ParameterOverride("dto", x))).ToList();
        }

        public ProcedureBl Add(ProcedureBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new ProcedureBl(dto) : null;
        }

        public ProcedureBl Update(ProcedureBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new ProcedureBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
