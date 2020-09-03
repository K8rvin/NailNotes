using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IReportService
    {
        IEnumerable<MonthReportDto> GetMonthReport(DateTime dateStart, DateTime dateEnd);
        PriceCostDto UpdatePriceCost(MonthReportDto monthReport, int year, int month);
    }
}
