using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Procedure : EntityData, IProcedureDto
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Price { get; set; }
        public double PriceVip { get; set; }
    }
}
