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
        private readonly IDao<PriceCost> _priceCostDao;

        public ReportBl(IDao<Check> dao, IDao<PriceCost> priceCostDao)
        {
            _dao = dao;
            _priceCostDao = priceCostDao;
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

            foreach (var row in report)
            {
                var currentMonthPriceCost = _priceCostDao.Get(x => x.Procedure.ToUpper() == row.Procedure.ToUpper() && x.Type.ToUpper() == row.Type.ToUpper() && x.DateEnd == dateEnd)?.FirstOrDefault();
                if (currentMonthPriceCost != null)
                {
                    row.CostPrice = currentMonthPriceCost.Value;
                }
                else
                {
                    var closestPriceCost = _priceCostDao.Get(x => x.Procedure.ToUpper() == row.Procedure.ToUpper() && x.Type.ToUpper() == row.Type.ToUpper())?.OrderByDescending(x=>x.DateEnd)?.FirstOrDefault();
                    if (closestPriceCost != null)
                    {
                        row.CostPrice = closestPriceCost.Value;
                    }
                }
            }

            return report;
        }

        public PriceCostDto UpdatePriceCost(MonthReportDto monthReport, int year, int month)
        {
            var newPriceCost = new PriceCost()
            {
                Type = monthReport.Type,
                Procedure = monthReport.Procedure,
                DateEnd = new DateTime(year, month, 1).AddMonths(1).AddDays(-1),
                Value = monthReport.CostPrice,
            };

            var dbPriceCost = _priceCostDao.Get(
                x=>x.Procedure == newPriceCost.Procedure && x.Type == newPriceCost.Type && x.DateEnd == newPriceCost.DateEnd);

            if (dbPriceCost.Any())
            {
                if (dbPriceCost.Count == 1)
                {
                    var dbPriceCostOld = dbPriceCost.First();
                    dbPriceCostOld.Value = newPriceCost.Value;
                    _priceCostDao.Update(dbPriceCostOld);
                    return _map(dbPriceCostOld);
                }
                else
                {
                    throw new Exception("Найдено больше одной себестоимости!");
                }
            }
            else
            {
                _priceCostDao.Create(newPriceCost);
                return _map(newPriceCost);
            }
        }

        private PriceCostDto _map(PriceCost dbPriceCostOld)
        {
            return new PriceCostDto(dbPriceCostOld);
        }
    }
}
