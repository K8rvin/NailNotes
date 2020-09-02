using LisokasNail.Models;
using System;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IReportRepo
    {
        List<MonthReportBl> GetMonthReport(DateTime dateStart, DateTime dateEnd);
    }
}
