using Microsoft.EntityFrameworkCore;

namespace LizokasNail.Core.Dao.EF
{
    /// <summary>
    /// Реализация получения DbContext для EfContext
    /// </summary>
    public class EfDataSource : IDataSource
    {
        private EfContext _context;

        public EfDataSource(EfContext context)
        {
            _context = context;
        }

        public DbContext GetContext()
        {
            return _context;
        }
    }
}
