using LisokasNail.Models;
using System.Collections.Generic;

namespace LizokasNail.Client.Di
{
    public interface IProcedureRepo
    {
        ProcedureBl Get(int id);
        List<ProcedureBl> Get();
        ProcedureBl Add(ProcedureBl item);
        ProcedureBl Update(ProcedureBl item);
        void Delete(int id);
    }
}
