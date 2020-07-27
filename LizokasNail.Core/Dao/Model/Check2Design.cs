using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Check2Design : EntityData, ICheck2DesignDto
    {
        public int IdCheck { get; set; }
        public int IdDesign { get; set; }

        public virtual Check Check { get; set; }
        public virtual Design Design { get; set; }
    }
}
