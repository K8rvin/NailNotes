﻿using LizokasNail.Contract.Dto;

namespace LisokasNail.Models
{   
    public class DesignBl : Identity, IDesignDto
    {
        public DesignBl()
        {
        }

        public DesignBl(DesignDto dto)
        {
            if (dto != null)
            {
                Id = dto.Id;
                Name = dto.Name;
                Comment = dto.Comment;
                Price = dto.Price;
                PriceVip = dto.PriceVip;
            }
        }

        public DesignBl(Check2DesignDto dto)
        {
            if (dto != null)
            {
                Id = dto.Design.Id;
                Name = dto.Design.Name;
                Comment = dto.Comment;
                Count = dto.Count;
                Price = dto.Design.Price;
                PriceVip = dto.Design.PriceVip;
            }
        }

        public string Name { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }
        public double PriceVip { get; set; }
        public int Count { get; set; }

        public double PriceFull => Price * Count;
        public double PriceVipFull => PriceVip * Count;

        public DesignDto ToDto() => new DesignDto()
        {
            Id = Id,
            Name = Name,
            Comment = Comment,
            Price = Price,
            PriceVip = PriceVip,
        };
    }
}
