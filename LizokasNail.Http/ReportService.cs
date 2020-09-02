using Flurl;
using Flurl.Http;
using LizokasNail.Contract.Dto;
using LizokasNail.Contract.Service;
using System;
using System.Collections.Generic;

namespace LizokasNail.Http
{
    public class ReportService : ServiceBase, IReportService
    {
        public IEnumerable<MonthReportDto> GetMonthReport(DateTime dateStart, DateTime dateEnd)
        {
            return Url.AppendPathSegment("report/GetMonthReport")
                .SetQueryParam("dateStart", dateStart)
                .SetQueryParam("dateEnd", dateEnd)
                .GetJsonAsync<IEnumerable<MonthReportDto>>().Result;
        }
    }
}
