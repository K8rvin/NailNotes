using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IReportBl
    {
        IEnumerable<MonthReportDto> GetMonthReport(DateTime dateStart, DateTime dateEnd);
    }
}
