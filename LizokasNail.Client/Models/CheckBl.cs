﻿using LizokasNail.Contract.Dto;
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
                Designs = new BindingList<DesignBl>(dto.Check2Design.Select(x => new DesignBl(x.Design)).ToList());
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
        public BindingList<DesignBl> Designs { get; set; }

        public CheckDto ToDto() => new CheckDto()
        {
            Id = Id,
            RecordId = RecordId,
            Price = Price,
            Comment = Comment,
            Check2Base = Check2Base,
            Check2Color = Check2Color,
            Check2Top = Check2Top,
            Check2Design = Designs?.Select(x => new Check2DesignDto(x, Id)),
        };


    }
}
