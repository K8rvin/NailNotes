using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.Dao.Model
{
    public class Check : EntityData, ICheckDto
    {
        public int RecordId { get; set; }
        public int? BaseId { get; set; }
        public int? ColorId { get; set; }
        public int? TopId { get; set; }
        public double Price { get; set; }
        public string Comment { get; set; }

        public virtual Record Record { get; set; }
        public virtual Base Base { get; set; }
        public virtual Color Color { get; set; }
        public virtual Top Top { get; set; }
        public virtual ICollection<Check2Design> Check2Design { get; set; }
    }
}
