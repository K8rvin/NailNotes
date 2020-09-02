using LizokasNail.Contract.Dto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LisokasNail.Models
{
    public class CheckBl : Identity, ICheckDto, INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

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
        public double PriceDynamic => Record.Record2Procedure.Sum(x => x.Procedure.Price) + Designs.Sum(x => x.PriceFull);
        public string PriceFormula => $"({string.Join("+", Record.Record2Procedure.Select(x => x.Procedure.Price))}) + ({string.Join("+", Designs.Select(x => x.PriceFull))}) = {PriceDynamic} р";
        public string Comment { get; set; }
        public RecordBl Record { get; set; }
        public IEnumerable<Check2BaseDto> Check2Base { get; set; }
        public IEnumerable<Check2ColorDto> Check2Color { get; set; }
        public IEnumerable<Check2TopDto> Check2Top { get; set; }
        public IEnumerable<Check2DesignDto> Check2Design { get; set; }

        public string UserName => Record?.UserName;
        public string BaseNames => string.Join(", ", Check2Base.Select(x => $"{x?.Base?.Name}({x.Comment})"));
        public string ColorNames => string.Join(", ", Check2Color.Select(x => $"{x?.Color?.Name}({x.Comment})"));
        public string TopNames => string.Join(", ", Check2Top.Select(x => $"{x?.Top?.Name}({x.Comment})"));
        public string DesignNames => string.Join(", ", Check2Design.Select(x => $"{x?.Design?.Name}({x.Count} шт)"));

        private BindingList<DesignBl> designs = new BindingList<DesignBl>();
        public BindingList<DesignBl> Designs
        {
            get
            {
                return designs;
            }
            set
            {
                designs = value;
                OnPropertyChanged(nameof(PriceDynamic));
            }
        }

        public CheckDto ToDto() => new CheckDto()
        {
            Id = Id,
            RecordId = RecordId,
            Price = PriceDynamic,
            Comment = Comment,
            Check2Base = Check2Base,
            Check2Color = Check2Color,
            Check2Top = Check2Top,
            Check2Design = Designs?.Select(x => new Check2DesignDto(x, Id, x.Count)),
        };


    }
}
