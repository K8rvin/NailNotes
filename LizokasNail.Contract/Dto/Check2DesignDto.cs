
namespace LizokasNail.Contract.Dto
{
    public interface ICheck2DesignDto : IIdentity
    {
        int IdCheck { get; set; }
        int IdDesign { get; set; }
        string Comment { get; set; }
        int Count { get; set; }
    }

    public class Check2DesignDto : Identity, ICheck2DesignDto
    {
        public Check2DesignDto()
        {
        }

        public Check2DesignDto(ICheck2DesignDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdCheck = item.IdCheck;
                IdDesign = item.IdDesign;
                Comment = item.Comment;
                Count = item.Count;
            }
        }

        public Check2DesignDto(IDesignDto design, int checkId, int count)
        {
            IdCheck = checkId;
            IdDesign = design.Id;
            Comment = design.Comment;
            Count = count;
        }

        public int IdCheck { get; set; }
        public int IdDesign { get; set; }
        public string Comment { get; set; }
        public int Count { get; set; }
        public DesignDto Design { get; set; }
    }
}
