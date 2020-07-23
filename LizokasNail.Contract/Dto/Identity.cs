
namespace LizokasNail.Contract.Dto
{
    public interface IIdentity
    {
        public int Id { get; set; }
    }

    public abstract class Identity: IIdentity
    {
        public int Id { get; set; }
    }
}
