using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class Check2BaseConfiguration : IEntityTypeConfiguration<Check2Base>
    {
        public void Configure(EntityTypeBuilder<Check2Base> builder)
        {
            builder.ToTable("Check2Base").HasKey(d => d.Id);
            builder.HasOne(x => x.Check).WithMany(x => x.Check2Base).HasForeignKey(x=>x.IdCheck);
            builder.HasOne(x => x.Base).WithMany().HasForeignKey(x => x.IdBase);
        }
    }
}
