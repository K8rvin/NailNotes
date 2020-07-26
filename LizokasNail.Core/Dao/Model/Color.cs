using LizokasNail.Contract.Dto;
using System;

namespace LizokasNail.Core.Dao.Model
{
    public class Color : EntityData, IColorDto
    {
        public string Name { get; set; }
    }
}
