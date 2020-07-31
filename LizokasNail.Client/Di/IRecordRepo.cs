using LisokasNail.Models;
using System;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IRecordRepo
    {
        RecordBl Get(int id);
        List<RecordBl> Get();
        List<RecordBl> GetWithoutCheck();
        List<RecordBl> GetByPeriod(DateTime dateStart, DateTime dateEnd);
        RecordBl Add(RecordBl item);
        RecordBl AddNewUserRecord(RecordBl item);
        RecordBl Update(RecordBl item);
        void Delete(int id);
    }
}
