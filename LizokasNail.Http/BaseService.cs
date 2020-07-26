using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class BaseService : ServiceBase, IBaseService
    {
        public BaseDto Get(int Id)
        {
            return Url.AppendPathSegment("base/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<BaseDto>().Result;
        }

        public IEnumerable<BaseDto> Get()
        {
            return Url.AppendPathSegment("base")
                .GetJsonAsync<IEnumerable<BaseDto>>().Result;
        }

        public BaseDto Add(BaseDto item)
        {
            return Url.AppendPathSegment("base")
                .PostJsonAsync(item).ReceiveJson<BaseDto>().Result;
        }

        public BaseDto Update(BaseDto item)
        {
            return Url.AppendPathSegment("base")
                .PutJsonAsync(item).ReceiveJson<BaseDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("base")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
