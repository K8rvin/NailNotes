using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class TopService : ServiceBase, ITopService
    {
        public TopDto Get(int Id)
        {
            return Url.AppendPathSegment("Top/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<TopDto>().Result;
        }

        public IEnumerable<TopDto> Get()
        {
            return Url.AppendPathSegment("Top")
                .GetJsonAsync<IEnumerable<TopDto>>().Result;
        }

        public TopDto Add(TopDto item)
        {
            return Url.AppendPathSegment("Top")
                .PostJsonAsync(item).ReceiveJson<TopDto>().Result;
        }

        public TopDto Update(TopDto item)
        {
            return Url.AppendPathSegment("Top")
                .PutJsonAsync(item).ReceiveJson<TopDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("Top")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
