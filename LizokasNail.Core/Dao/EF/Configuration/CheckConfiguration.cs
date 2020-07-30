using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class CheckConfiguration : IEntityTypeConfiguration<Check>
    {
        public void Configure(EntityTypeBuilder<Check> builder)
        {
            builder.ToTable("Check").HasKey(d => d.Id);
            builder.HasMany(x => x.Check2Base).WithOne(x => x.Check).IsRequired();
            builder.HasMany(x => x.Check2Color).WithOne(x => x.Check).IsRequired();
            builder.HasMany(x => x.Check2Top).WithOne(x => x.Check).IsRequired();
            builder.HasMany(x => x.Check2Design).WithOne(x => x.Check).IsRequired();
        }
    }
}
