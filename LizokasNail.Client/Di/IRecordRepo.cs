using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IRecordRepo
    {
        RecordBl Get(int id);
        List<RecordBl> Get();
        List<RecordBl> GetWithoutCheck();
        RecordBl Add(RecordBl item);
        RecordBl Update(RecordBl item);
        void Delete(int id);
    }
}
