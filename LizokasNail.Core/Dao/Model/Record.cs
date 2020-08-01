using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Core.Dao.Model
{
    public class Record : EntityData, IRecordDto
    {
        public Record()
        {
            Record2Procedure = new HashSet<Record2Procedure>();
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public virtual User User { get; set; }
        public virtual Check Check { get; set; }
        public virtual ICollection<Record2Procedure> Record2Procedure { get; set; }
    }
}
