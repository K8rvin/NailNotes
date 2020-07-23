using System.ComponentModel.DataAnnotations;

namespace LizokasNail.Core.Dao
{
    public abstract class EntityData
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
