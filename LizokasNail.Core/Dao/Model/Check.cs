using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.Dao.Model
{
    public class Check : EntityData, ICheckDto
    {
        public int RecordId { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }

        public virtual Record Record { get; set; }
        public virtual ICollection<Check2Base> Check2Base { get; set; }
        public virtual ICollection<Check2Color> Check2Color { get; set; }
        public virtual ICollection<Check2Top> Check2Top { get; set; }
        public virtual ICollection<Check2Design> Check2Design { get; set; }
    }
}
