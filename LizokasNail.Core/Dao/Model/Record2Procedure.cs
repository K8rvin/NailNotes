using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Record2Procedure : EntityData, IRecord2ProcedureDto
    {
        public int IdRecord { get; set; }
        public int IdProcedure { get; set; }

        public virtual Record Record { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
