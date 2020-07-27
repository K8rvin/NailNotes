using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IRecordService
    {
        RecordDto Get(int id);
        IEnumerable<RecordDto> Get();
        IEnumerable<RecordDto> GetWithoutCheck();
        RecordDto Add(RecordDto item);
        RecordDto Update(RecordDto item);
        void Delete(int id);
    }
}
