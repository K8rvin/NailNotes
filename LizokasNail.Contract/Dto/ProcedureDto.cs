namespace LizokasNail.Contract.Dto
{
    public interface IProcedureDto : IIdentity
    {
        string Name { get; set; }
        string ShortName { get; set; }
        double Price { get; set; }
        double PriceVip { get; set; }
    }

    public class ProcedureDto : Identity, IProcedureDto
    {
        public ProcedureDto()
        {
        }

        public ProcedureDto(IProcedureDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                ShortName = item.ShortName;
                Price = item.Price;
                PriceVip = item.PriceVip;
            }
        }

        public string Name { get; set; }
        public string ShortName { get; set; }
        public double Price { get; set; }
        public double PriceVip { get; set; }
    }
}
