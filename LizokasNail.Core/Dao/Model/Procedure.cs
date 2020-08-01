using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Procedure : EntityData, IProcedureDto
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
    }
}
