using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Color : EntityData, IColorDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
