using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IReportBl
    {
        /// <summary>
        /// Вернуть данные для отчета по расходам
        /// </summary>
        /// <param name="dateStart">дата начала</param>
        /// <param name="dateEnd">дата окончания</param>
        /// <returns></returns>
        IEnumerable<MonthReportDto> GetMonthReport(DateTime dateStart, DateTime dateEnd);

        /// <summary>
        /// Обновить/создать себестоимость
        /// </summary>
        /// <param name="monthReport">строка отчета</param>
        /// <param name="year">год</param>
        /// <param name="month">месяц</param>
        /// <returns></returns>
        PriceCostDto UpdatePriceCost(MonthReportDto monthReport, int year, int month);
    }
}
