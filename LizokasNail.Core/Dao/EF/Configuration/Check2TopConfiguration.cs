using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class Check2TopConfiguration : IEntityTypeConfiguration<Check2Top>
    {
        public void Configure(EntityTypeBuilder<Check2Top> builder)
        {
            builder.ToTable("Check2Top").HasKey(d => d.Id);
            builder.HasOne(x => x.Check).WithMany(x => x.Check2Top).HasForeignKey(x=>x.IdCheck);
            builder.HasOne(x => x.Top).WithMany().HasForeignKey(x => x.IdTop);
        }
    }
}
