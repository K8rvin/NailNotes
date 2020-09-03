using LisokasNail.Models;
using System;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IReportRepo
    {
        List<MonthReportBl> GetMonthReport(DateTime dateStart, DateTime dateEnd);
        PriceCostBl UpdatePriceCost(MonthReportBl monthReport, int year, int month);
    }
}
