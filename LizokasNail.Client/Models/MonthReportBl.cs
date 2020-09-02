using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class MonthReportBl : IMonthReportDto
    {
        public MonthReportBl()
        {
        }

        public MonthReportBl(MonthReportDto dto)
        {
            if (dto != null)
            {
                Type = dto.Type;
                Procedure = dto.Procedure;
                CostPrice = dto.CostPrice;
                ClientCount = dto.ClientCount;
                PriceSumm = dto.PriceSumm;
            }
        }

        public string Type { get; set; }
        public string Procedure { get; set; }
        public double CostPrice { get; set; }
        public int ClientCount { get; set; }
        public double PriceSumm { get; set; }
        public double CostSumm => CostPrice * ClientCount;
    }
}
