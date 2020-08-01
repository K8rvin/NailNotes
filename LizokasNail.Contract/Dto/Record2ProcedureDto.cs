using System;

namespace LizokasNail.Contract.Dto
{
    public interface IRecord2ProcedureDto : IIdentity
    {
        int IdRecord { get; set; }
        int IdProcedure { get; set; }
    }

    public class Record2ProcedureDto : Identity, IRecord2ProcedureDto
    {
        public Record2ProcedureDto()
        {
        }

        public Record2ProcedureDto(IRecord2ProcedureDto item)
        {
            if (item != null)
            {
                Id = item.Id;
                IdRecord = item.IdRecord;
                IdProcedure = item.IdProcedure;
            }
        }

        public int IdRecord { get; set; }
        public int IdProcedure { get; set; }
        public ProcedureDto Procedure { get; set; }
    }
}
