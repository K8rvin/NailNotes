using LizokasNail.Contract.Dto;
using System;

namespace LizokasNail.Core.Dao.Model
{
    public class Base : EntityData, IBaseDto
    {
        public string Name { get; set; }
    }
}
