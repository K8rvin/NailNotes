using LizokasNail.Contract.Dto;
using System.Collections.Generic;

namespace LizokasNail.Core.BL
{
    public interface IProcedureBl
    {
        IEnumerable<ProcedureDto> Get();

        ProcedureDto GetById(int id);
        ProcedureDto Add(ProcedureDto dto);
        ProcedureDto Update(ProcedureDto dto);
        void Delete(int id);
    }
}
