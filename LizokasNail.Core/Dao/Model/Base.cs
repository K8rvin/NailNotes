using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Base : EntityData, IBaseDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
