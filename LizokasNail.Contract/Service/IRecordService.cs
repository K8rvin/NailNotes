using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IRecordService
    {
        RecordDto Get(int id);
        IEnumerable<RecordDto> Get();
        RecordDto Add(RecordDto item);
        RecordDto Update(RecordDto item);
    }
}
