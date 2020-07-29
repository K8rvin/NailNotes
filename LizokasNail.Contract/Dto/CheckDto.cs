using System.Collections.Generic;

namespace LizokasNail.Contract.Dto
{
    public interface ICheckDto : IIdentity
    {
        int RecordId { get; set; }
        double Price { get; set; }
        string Comment { get; set; }
    }

    public class CheckDto : Identity, ICheckDto
    {
        public CheckDto()
        {
        }

        public CheckDto(ICheckDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                RecordId = item.RecordId;
                Price = item.Price;
                Comment = item.Comment;
            }
        }

        public int RecordId { get; set; }        
        public double Price { get; set; }
        public string Comment { get; set; }
        public RecordDto Record { get; set; }
        public IEnumerable<Check2BaseDto> Check2Base { get; set; }
        public IEnumerable<Check2ColorDto> Check2Color { get; set; }
        public IEnumerable<Check2TopDto> Check2Top { get; set; }
        public IEnumerable<Check2DesignDto> Check2Design { get; set; }
    }
}
