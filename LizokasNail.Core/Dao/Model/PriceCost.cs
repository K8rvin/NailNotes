using LizokasNail.Contract.Dto;
using System;

namespace LizokasNail.Core.Dao.Model
{
    public class PriceCost : EntityData, IPriceCostDto
    {
        public string Type { get; set; }
        public string Procedure { get; set; }
        public double Value { get; set; }
        public DateTime DateEnd { get; set; }
    }
}
