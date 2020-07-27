using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LisokasNail.Models
{
    public class CheckBl : Identity, ICheckDto
    {
        public CheckBl()
        {
        }

        public CheckBl(CheckDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                RecordId = dto.RecordId;
                BaseId = dto.BaseId;
                ColorId = dto.ColorId;
                TopId = dto.TopId;
                Price = dto.Price;
                Comment = dto.Comment;
                Record = new RecordBl(dto.Record);
                Base = new BaseBl(dto.Base);
                Color = new ColorBl(dto.Color);
                Top = new TopBl(dto.Top);
                Check2Design = dto.Check2Design;
            }
        }

        public int RecordId { get; set; }
        public int? BaseId { get; set; }
        public int? ColorId { get; set; }
        public int? TopId { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }
        public RecordBl Record { get; set; }
        public BaseBl Base { get; set; }
        public ColorBl Color { get; set; }
        public TopBl Top { get; set; }
        public IEnumerable<Check2DesignDto> Check2Design { get; set; }

        public string RecordDate => Record?.RecordDate.ToString();
        public string UserName => Record?.UserName;
        public string BaseName => Base?.Name;
        public string ColorName => Color?.Name;
        public string TopName => Top?.Name;

        public CheckDto ToDto() => new CheckDto()
        {
            Id = Id,
            RecordId = RecordId,
            BaseId = BaseId,
            ColorId = ColorId,
            TopId = TopId,
            Price = Price,
            Comment = Comment,
        };
    }
}
