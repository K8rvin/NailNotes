using LizokasNail.Contract.Dto;

namespace LizokasNail.Core.Dao.Model
{
    public class Design : EntityData, IDesignDto
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }
    }
}
