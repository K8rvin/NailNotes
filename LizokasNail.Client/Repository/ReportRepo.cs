using LisokasNail.Models;
using LizokasNail.Client.Di;
using LizokasNail.Contract.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;

namespace LizokasNail.Client.Repository
{
    public class ReportRepo : IReportRepo
    {
        private readonly IUnityContainer _uc;
        private readonly IReportService _service;

        public ReportRepo(IUnityContainer uc, IReportService service)
        {
            _uc = uc;
            _service = service;
        }

        public List<MonthReportBl> GetMonthReport(DateTime dateStart, DateTime dateEnd)
        {
            var dtos = _service.GetMonthReport(dateStart, dateEnd);
            return dtos?.Select(x => _uc.Resolve<MonthReportBl>(new ParameterOverride("dto", x))).ToList();
        }
    }
}
