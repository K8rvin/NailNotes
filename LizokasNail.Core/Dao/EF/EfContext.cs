using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using LizokasNail.Core.Dao.EF.Configuration;

namespace LizokasNail.Core.Dao.EF
{
    /// <summary>
    /// EF реализация DbContext
    /// </summary>
    public class EfContext : DbContext
    {
        private readonly IHttpContextAccessor _hcontext;
        public EfContext(DbContextOptions options, IHttpContextAccessor hcontext) : base(options)
        {
            Database.Migrate(); // проверять и создавать недостающие миграции
            this._hcontext = hcontext;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        /// <summary>
        /// Fluent API конфигурация БД 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RecordConfiguration());
            modelBuilder.ApplyConfiguration(new BaseConfiguration());
            modelBuilder.ApplyConfiguration(new ColorConfiguration());
            modelBuilder.ApplyConfiguration(new TopConfiguration());
            modelBuilder.ApplyConfiguration(new DesignConfiguration());
            modelBuilder.ApplyConfiguration(new CheckConfiguration());
            modelBuilder.ApplyConfiguration(new Check2DesignConfiguration());
            modelBuilder.ApplyConfiguration(new Check2BaseConfiguration());
            modelBuilder.ApplyConfiguration(new Check2ColorConfiguration());
            modelBuilder.ApplyConfiguration(new Check2TopConfiguration());

            //...
        }
    }
}
