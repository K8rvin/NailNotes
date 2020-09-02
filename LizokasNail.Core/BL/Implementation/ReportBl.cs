using LizokasNail.Contract.Dto;
using LizokasNail.Core.Dao;
using LizokasNail.Core.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LizokasNail.Core.BL.Implementation
{
    public class ReportBl : IReportBl
    {
        private readonly IDao<Check> _dao;

        public ReportBl(IDao<Check> dao)
        {
            _dao = dao;
        }

        public IEnumerable<MonthReportDto> GetMonthReport(DateTime dateStart, DateTime dateEnd)
        {
            var checksByPeriod = _dao.Get(x => x.Record.RecordDate >= dateStart && x.Record.RecordDate <= dateEnd);

            var checksByPeriodGroupedByProcedure = checksByPeriod.Where(x => x.Record.Record2Procedure.Any()).GroupBy(x => x.Record.Record2Procedure.FirstOrDefault().Procedure);

            var report = checksByPeriodGroupedByProcedure.Select(x => new MonthReportDto("ОДНОРАЗОВЫЕ", x.Key.Name, x.Count(), x.Sum(p => p.Price))).OrderBy(x => x.Procedure).ToList();

            report.AddRange(report.Select(x => new MonthReportDto("ЖИДКОСТИ", x.Procedure, x.ClientCount)).ToList());
            report.Add(new MonthReportDto("МНОГОРАЗОВЫЕ", "МАНИКЮР", report.Any(x => x.Procedure.ToUpper().Contains("МАНИКЮР")) ? 1 : 0));
            report.Add(new MonthReportDto("МНОГОРАЗОВЫЕ", "ПЕДИКЮР", report.Any(x => x.Procedure.ToUpper().Contains("ПЕДИКЮР")) ? 1 : 0));
            report.Add(new MonthReportDto("ПРОЧЕЕ", "ЕЖЕМЕСЯЧНЫЕ", 1));

            //var row1 = checksByPeriod.Where(x=>x.Record.Record2Procedure.Any(r2p=>r2p.Procedure.Id == 1))

            return report;
        }
    }
}
