using System;

namespace LizokasNail.Contract.Dto
{
    public interface ICheck2BaseDto : IIdentity
    {
        int IdCheck { get; set; }
        int IdBase { get; set; }
        string Comment { get; set; }
    }

    public class Check2BaseDto : Identity, ICheck2BaseDto
    {
        public Check2BaseDto()
        {
        }

        public Check2BaseDto(ICheck2BaseDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdCheck = item.IdCheck;
                IdBase = item.IdBase;
                Comment = item.Comment;
            }
        }

        public Check2BaseDto(IBaseDto item, int checkId)
        {
            IdCheck = checkId;
            IdBase = item.Id;
            Comment = item.Comment;
        }

        public int IdCheck { get; set; }
        public int IdBase { get; set; }
        public string Comment { get; set; }
        public BaseDto Base { get; set; }
    }
}
