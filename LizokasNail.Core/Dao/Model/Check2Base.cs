using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Check2Base : EntityData, ICheck2BaseDto
    {
        public int IdCheck { get; set; }
        public int IdBase { get; set; }
        public string Comment { get; set; }

        public virtual Check Check { get; set; }
        public virtual Base Base { get; set; }
    }
}
