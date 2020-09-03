
namespace LizokasNail.Contract.Dto
{
    public interface IDesignDto : IIdentity
    {
        string Name { get; set; }
        string Comment { get; set; }
        double Price { get; set; }
        double PriceVip { get; set; }
    }

    public class DesignDto : Identity, IDesignDto
    {
        public DesignDto()
        {
        }

        public DesignDto(IDesignDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                Name = item.Name;
                Comment = item.Comment;
                Price = item.Price;
                PriceVip = item.PriceVip;
            }
        }

        public string Name { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }
        public double PriceVip { get; set; }
    }
}
