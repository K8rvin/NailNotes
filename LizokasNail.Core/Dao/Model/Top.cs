using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Top : EntityData, ITopDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
