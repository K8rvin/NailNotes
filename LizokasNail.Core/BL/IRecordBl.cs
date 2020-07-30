using LizokasNail.Contract.Dto;
using System;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IRecordBl
    {
        IEnumerable<RecordDto> Get();
        IEnumerable<RecordDto> GetWithoutCheck();
        IEnumerable<RecordDto> GetByPeriod(DateTime dateStart, DateTime dateEnd);
        RecordDto GetById(int id);
        RecordDto Add(RecordDto dto);
        RecordDto Update(RecordDto dto);
        void Delete(int id);
    }
}
