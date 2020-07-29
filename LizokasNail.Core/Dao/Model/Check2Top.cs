using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Check2Top : EntityData, ICheck2TopDto
    {
        public int IdCheck { get; set; }
        public int IdTop { get; set; }
        public string Comment { get; set; }

        public virtual Check Check { get; set; }
        public virtual Top Top { get; set; }
    }
}
