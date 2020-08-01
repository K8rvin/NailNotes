using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Contract.Service
{
    public interface IProcedureService
    {
        ProcedureDto Get(int id);
        IEnumerable<ProcedureDto> Get();
        ProcedureDto Add(ProcedureDto item);
        ProcedureDto Update(ProcedureDto item);
        void Delete(int id);
    }
}
