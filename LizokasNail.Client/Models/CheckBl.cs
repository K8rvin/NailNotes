using LizokasNail.Contract.Dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
                Price = dto.Price;
                Comment = dto.Comment;
                Record = new RecordBl(dto.Record);                
                Check2Base = dto.Check2Base;
                Check2Color = dto.Check2Color;
                Check2Top = dto.Check2Top;
                Check2Design = dto.Check2Design;
                Designs = dto.Check2Design != null ? new BindingList<DesignBl>(dto.Check2Design.Select(x => new DesignBl(x)).ToList()) : new BindingList<DesignBl>();
            }
        }

        public int RecordId { get; set; }        
        public double Price { get; set; }
        public string Comment { get; set; }
        public RecordBl Record { get; set; }
        public IEnumerable<Check2BaseDto> Check2Base { get; set; }
        public IEnumerable<Check2ColorDto> Check2Color { get; set; }
        public IEnumerable<Check2TopDto> Check2Top { get; set; }
        public IEnumerable<Check2DesignDto> Check2Design { get; set; }

        public string RecordDate => Record?.RecordDate.ToString();
        public string UserName => Record?.UserName;
        public string BaseNames => string.Join(", ", Check2Base.Select(x => $"{x?.Base?.Name}({x.Comment})"));
        public string ColorNames => string.Join(", ", Check2Color.Select(x => $"{x?.Color?.Name}({x.Comment})"));
        public string TopNames => string.Join(", ", Check2Top.Select(x => $"{x?.Top?.Name}({x.Comment})"));
        public string DesignNames => string.Join(", ", Check2Design.Select(x => $"{x?.Design?.Name}({x.Count} шт)"));
        public BindingList<DesignBl> Designs { get; set; } = new BindingList<DesignBl>();

        public CheckDto ToDto() => new CheckDto()
        {
            Id = Id,
            RecordId = RecordId,
            Price = Price,
            Comment = Comment,
            Check2Base = Check2Base,
            Check2Color = Check2Color,
            Check2Top = Check2Top,
            Check2Design = Designs?.Select(x => new Check2DesignDto(x, Id, x.Count)),
        };


    }
}
