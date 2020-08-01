using System;
using System.Collections.Generic;

namespace LizokasNail.Contract.Dto
{
    public interface IRecordDto : IIdentity
    {
        int UserId { get; set; }
        DateTime RecordDate { get; set; }
    }

    public class RecordDto : Identity, IRecordDto
    {
        public RecordDto()
        {
        }

        public RecordDto(IRecordDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                UserId = item.UserId;
                RecordDate = item.RecordDate;
            }
        }

        public int UserId { get; set; }
        public DateTime RecordDate { get; set; }
        public UserDto User { get; set; }
        public CheckDto Check { get; set; }
        public IEnumerable<Record2ProcedureDto> Record2Procedure { get; set; }
    }
}
