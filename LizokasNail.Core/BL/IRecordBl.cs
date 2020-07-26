using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IRecordBl
    {
        IEnumerable<RecordDto> Get();

        RecordDto GetById(int id);
        RecordDto Add(RecordDto dto);
        RecordDto Update(RecordDto dto);
        void Delete(int id);
    }
}
