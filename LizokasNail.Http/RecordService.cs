﻿using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class RecordService : ServiceBase, IRecordService
    {
        public RecordDto Get(int Id)
        {
            return Url.AppendPathSegment("record/GetById")
                .SetQueryParam("Id", Id)
                .GetJsonAsync<RecordDto>().Result;
        }

        public IEnumerable<RecordDto> Get()
        {
            return Url.AppendPathSegment("record")
                .GetJsonAsync<IEnumerable<RecordDto>>().Result;
        }

        public IEnumerable<RecordDto> GetWithoutCheck()
        {
            return Url.AppendPathSegment("record/GetWithoutCheck")
                .GetJsonAsync<IEnumerable<RecordDto>>().Result;
        }

        public IEnumerable<RecordDto> GetByPeriod(DateTime dateStart, DateTime dateEnd)
        {
            return Url.AppendPathSegment("record/GetByPeriod")
                .SetQueryParam("dateStart", dateStart)
                .SetQueryParam("dateEnd", dateEnd)
                .GetJsonAsync<IEnumerable<RecordDto>>().Result;
        }

        public RecordDto Add(RecordDto item)
        {
            return Url.AppendPathSegment("record")
                .PostJsonAsync(item).ReceiveJson<RecordDto>().Result;
        }

        public RecordDto AddNewUserRecord(RecordDto item)
        {
            return Url.AppendPathSegment("record/AddNewUserRecord")
                .PostJsonAsync(item).ReceiveJson<RecordDto>().Result;
        }

        public RecordDto Update(RecordDto item)
        {
            return Url.AppendPathSegment("record")
                .PutJsonAsync(item).ReceiveJson<RecordDto>().Result;
        }

        public void Delete(int Id)
        {
            Url.AppendPathSegment("record")
                .SetQueryParam("Id", Id).DeleteAsync();
        }
    }
}
