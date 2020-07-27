﻿using System;

namespace LizokasNail.Contract.Dto
{
    public interface ICheck2DesignDto : IIdentity
    {
        int IdCheck { get; set; }
        int IdDesign { get; set; }
    }

    public class Check2DesignDto : Identity, ICheck2DesignDto
    {
        public Check2DesignDto()
        {
        }

        public Check2DesignDto(ICheck2DesignDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdCheck = item.IdCheck;
                IdDesign = item.IdDesign;
            }
        }

        public int IdCheck { get; set; }
        public int IdDesign { get; set; }
    }
}
