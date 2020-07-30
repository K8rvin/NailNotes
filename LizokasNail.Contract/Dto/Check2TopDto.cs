using System;

namespace LizokasNail.Contract.Dto
{
    public interface ICheck2TopDto : IIdentity
    {
        int IdCheck { get; set; }
        int IdTop { get; set; }
        string Comment { get; set; }
    }

    public class Check2TopDto : Identity, ICheck2TopDto
    {
        public Check2TopDto()
        {
        }

        public Check2TopDto(ICheck2TopDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdCheck = item.IdCheck;
                IdTop = item.IdTop;
                Comment = item.Comment;
            }
        }

        public Check2TopDto(ITopDto item, int checkId)
        {
            IdCheck = checkId;
            IdTop = item.Id;
            Comment = item.Comment;
        }

        public int IdCheck { get; set; }
        public int IdTop { get; set; }
        public string Comment { get; set; }
        public TopDto Top { get; set; }
    }
}
