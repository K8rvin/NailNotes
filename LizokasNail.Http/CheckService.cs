using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class CheckService : ServiceBase, ICheckService
    {
        public CheckDto Get(int Id)
        {
            return Url.AppendPathSegment("Check/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<CheckDto>().Result;
        }

        public IEnumerable<CheckDto> Get()
        {
            return Url.AppendPathSegment("Check")
                .GetJsonAsync<IEnumerable<CheckDto>>().Result;
        }

        public IEnumerable<CheckDto> GetByPeriod(DateTime DateStart, DateTime DateEnd)
        {
            return Url.AppendPathSegment("Check/GetByPeriod")
                .SetQueryParam("DateStart", DateStart)
                .SetQueryParam("DateEnd", DateEnd)
                .GetJsonAsync<IEnumerable<CheckDto>>().Result;
        }

        public CheckDto Add(CheckDto item)
        {
            return Url.AppendPathSegment("Check")
                    .PostJsonAsync(item).ReceiveJson<CheckDto>().Result;
        }

        public CheckDto Update(CheckDto item)
        {
            return Url.AppendPathSegment("Check")
                .PutJsonAsync(item).ReceiveJson<CheckDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("Check")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
