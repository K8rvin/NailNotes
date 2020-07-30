using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Check2Color : EntityData, ICheck2ColorDto
    {
        public int IdCheck { get; set; }
        public int IdColor { get; set; }
        public string Comment { get; set; }

        public virtual Check Check { get; set; }
        public virtual Color Color { get; set; }
    }
}
