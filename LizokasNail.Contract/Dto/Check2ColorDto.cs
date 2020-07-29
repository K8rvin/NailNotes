using System;

namespace LizokasNail.Contract.Dto
{
    public interface ICheck2ColorDto : IIdentity
    {
        int IdCheck { get; set; }
        int IdColor { get; set; }
        string Comment { get; set; }
    }

    public class Check2ColorDto : Identity, ICheck2ColorDto
    {
        public Check2ColorDto()
        {
        }

        public Check2ColorDto(ICheck2ColorDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdCheck = item.IdCheck;
                IdColor = item.IdColor;
                Comment = item.Comment;
            }
        }

        public Check2ColorDto(IColorDto item, int checkId)
        {
            IdCheck = checkId;
            IdColor = item.Id;
            Comment = item.Comment;
        }

        public int IdCheck { get; set; }
        public int IdColor { get; set; }
        public string Comment { get; set; }
        public ColorDto Color { get; set; }
    }
}
