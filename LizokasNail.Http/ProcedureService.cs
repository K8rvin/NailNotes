using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class ProcedureService : ServiceBase, IProcedureService
    {
        public ProcedureDto Get(int Id)
        {
            return Url.AppendPathSegment("Procedure/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<ProcedureDto>().Result;
        }

        public IEnumerable<ProcedureDto> Get()
        {
            return Url.AppendPathSegment("Procedure")
                .GetJsonAsync<IEnumerable<ProcedureDto>>().Result;
        }

        public ProcedureDto Add(ProcedureDto item)
        {
            return Url.AppendPathSegment("Procedure")
                .PostJsonAsync(item).ReceiveJson<ProcedureDto>().Result;
        }

        public ProcedureDto Update(ProcedureDto item)
        {
            return Url.AppendPathSegment("Procedure")
                .PutJsonAsync(item).ReceiveJson<ProcedureDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("Procedure")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
