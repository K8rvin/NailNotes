
namespace LizokasNail.Contract.Dto
{
    public interface IMonthReportDto
    {
        /// <summary>
        /// Тип расходника
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Процедура
        /// </summary>
        string Procedure { get; set; }

        /// <summary>
        /// Себестоимость
        /// </summary>
        double CostPrice { get; set; }

        /// <summary>
        /// Кол-во клиентов
        /// </summary>
        int ClientCount { get; set; }

        /// <summary>
        /// Доход
        /// </summary>
        double PriceSumm { get; set; }
    }

    public class MonthReportDto : IMonthReportDto
    {
        public MonthReportDto()
        {
        }

        public MonthReportDto(string type, string procedure, int clientCount, double priceSumm = 0)
        {
            Type = type;
            Procedure = procedure;
            ClientCount = clientCount;
            PriceSumm = priceSumm;
        }

        public MonthReportDto(IMonthReportDto item)
        {
            if (item != null)
            {
                Type = item.Type;
                Procedure = item.Procedure;
                CostPrice = item.CostPrice;
                ClientCount = item.ClientCount;
                PriceSumm = item.PriceSumm;
            }
        }

        public string Type { get; set; }
        public string Procedure { get; set; }
        public double CostPrice { get; set; }
        public int ClientCount { get; set; }
        public double PriceSumm { get; set; }
    }
}
