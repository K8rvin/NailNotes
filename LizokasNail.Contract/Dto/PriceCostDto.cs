using System;

namespace LizokasNail.Contract.Dto
{
    /// <summary>
    /// Себестоимость со сроком действия
    /// </summary>
    public interface IPriceCostDto : IIdentity
    {
        /// <summary>
        /// Тип расхода
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Процедура
        /// </summary>
        string Procedure { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        double Value { get; set; }

        /// <summary>
        /// Срок действия
        /// </summary>
        DateTime DateEnd { get; set; }
    }

    public class PriceCostDto : Identity, IPriceCostDto
    {
        public PriceCostDto()
        {
        }

        public PriceCostDto(IPriceCostDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Type = item.Type;
                Procedure = item.Procedure;
                Value = item.Value;
                DateEnd = item.DateEnd;
            }
        }

        public string Type { get; set; }
        public string Procedure { get; set; }
        public double Value { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
