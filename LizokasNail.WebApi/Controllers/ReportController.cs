using LizokasNail.Contract.Dto;
using LizokasNail.Core.BL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace LizokasNail.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportBl _bl;

        public ReportController(IReportBl bl)
        {
            _bl = bl;
        }


        [HttpGet("GetMonthReport")]
        public IEnumerable<MonthReportDto> GetMonthReport([FromQuery] DateTime dateStart, DateTime dateEnd)
        {
            return _bl.GetMonthReport(dateStart, dateEnd);
        }
    }
}
