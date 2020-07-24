using LizokasNail.Contract.Dto;
using System;

namespace LizokasNail.Core.Dao.Model
{
    public class Record : EntityData, IRecordDto
    {
        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public User User { get; set; }
    }
}
