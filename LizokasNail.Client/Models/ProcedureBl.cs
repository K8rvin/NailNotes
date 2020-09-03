using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class ProcedureBl : Identity, IProcedureDto
    {
        public ProcedureBl()
        {
        }

        public ProcedureBl(ProcedureDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
                ShortName = dto.ShortName;
                Price = dto.Price;
                PriceVip = dto.PriceVip;
            }
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Price { get; set; }
        public double PriceVip { get; set; }

        public ProcedureDto ToDto() => new ProcedureDto()
        {
            Id = Id,
            Name = Name,
            ShortName = ShortName,
            Price = Price,
            PriceVip = PriceVip,
        };
    }
}
