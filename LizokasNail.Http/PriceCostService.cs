using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class PriceCostService : ServiceBase, IPriceCostService
    {
        public PriceCostDto Get(int Id)
        {
            return Url.AppendPathSegment("pricecost/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<PriceCostDto>().Result;
        }

        public IEnumerable<PriceCostDto> Get()
        {
            return Url.AppendPathSegment("pricecost")
                .GetJsonAsync<IEnumerable<PriceCostDto>>().Result;
        }

        public PriceCostDto Add(PriceCostDto item)
        {
            return Url.AppendPathSegment("pricecost")
                .PostJsonAsync(item).ReceiveJson<PriceCostDto>().Result;
        }

        public PriceCostDto Update(PriceCostDto item)
        {
            return Url.AppendPathSegment("pricecost")
                .PutJsonAsync(item).ReceiveJson<PriceCostDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("pricecost")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
