using System.Collections.Generic;

namespace LizokasNail.Contract.Dto
{
    public interface ICheckDto : IIdentity
    {
        int RecordId { get; set; }
        int? BaseId { get; set; }
        int? ColorId { get; set; }
        int? TopId { get; set; }
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
                BaseId = item.BaseId;
                ColorId = item.ColorId;
                TopId = item.TopId;
                Price = item.Price;
                Comment = item.Comment;
            }
        }

        public int RecordId { get; set; }
        public int? BaseId { get; set; }
        public int? ColorId { get; set; }
        public int? TopId { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }
        public RecordDto Record { get; set; }
        public BaseDto Base { get; set; }
        public ColorDto Color { get; set; }
        public TopDto Top { get; set; }
        public IEnumerable<Check2DesignDto> Check2Design { get; set; }
    }
}
