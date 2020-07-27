using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class RecordRepo : IRecordRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IRecordService _service;

        public RecordRepo(IUnityContainer uc, IRecordService service)
        {
            _uc = uc;
            _service = service;
        }

        public RecordBl Get(int id)
        {
            var dto = _service.Get(id);
            return dto != null ? new RecordBl(dto) : null;
        }

        public virtual List<RecordBl> Get()
        {
            var dtos = _service.Get();
            return dtos?.Select(x => _uc.Resolve<RecordBl>(new ParameterOverride("dto", x))).ToList();
        }

        public virtual List<RecordBl> GetWithoutCheck()
        {
            var dtos = _service.GetWithoutCheck();
            return dtos?.Select(x => _uc.Resolve<RecordBl>(new ParameterOverride("dto", x))).ToList();
        }

        public RecordBl Add(RecordBl item)
        {
            var dto = _service.Add(item?.ToDto());
            return dto != null ? new RecordBl(dto) : null;
        }

        public RecordBl Update(RecordBl item)
        {
            var dto = _service.Update(item?.ToDto());
            return dto != null ? new RecordBl(dto) : null;
        }

        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
