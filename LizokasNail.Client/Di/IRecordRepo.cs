using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IRecordRepo
    {
        RecordBl Get(int id);
        List<RecordBl> Get();
        RecordBl Add(RecordBl item);
        RecordBl Update(RecordBl item);
    }
}
