using LizokasNail.Contract.Dto;
using System;

namespace LisokasNail.Models
{   
    public class PriceCostBl : Identity, IPriceCostDto
    {
        public PriceCostBl()
        {
        }

        public PriceCostBl(PriceCostDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Type = dto.Type;
                Procedure = dto.Procedure;
                Value = dto.Value;
                DateEnd = dto.DateEnd;
            }
        }

        public string Type { get; set; }
        public string Procedure { get; set; }
        public double Value { get; set; }
        public DateTime DateEnd { get; set; }

        public PriceCostDto ToDto() => new PriceCostDto()
        {
            Id = Id,
            Type = Type,
            Procedure = Procedure,
            Value = Value,
            DateEnd = DateEnd,
        };
    }
}
