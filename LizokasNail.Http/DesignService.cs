using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class DesignService : ServiceBase, IDesignService
    {
        public DesignDto Get(int Id)
        {
            return Url.AppendPathSegment("Design/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<DesignDto>().Result;
        }

        public IEnumerable<DesignDto> Get()
        {
            return Url.AppendPathSegment("Design")
                .GetJsonAsync<IEnumerable<DesignDto>>().Result;
        }

        public DesignDto Add(DesignDto item)
        {
            return Url.AppendPathSegment("Design")
                    .PostJsonAsync(item).ReceiveJson<DesignDto>().Result;
        }

        public DesignDto Update(DesignDto item)
        {
            return Url.AppendPathSegment("Design")
                .PutJsonAsync(item).ReceiveJson<DesignDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("Design")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
