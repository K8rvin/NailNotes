
namespace LizokasNail.Contract.Dto
{
    public interface IIdentity
    {
        int Id { get; set; }
    }

    public abstract class Identity: IIdentity
    {
        public int Id { get; set; }
    }
}
