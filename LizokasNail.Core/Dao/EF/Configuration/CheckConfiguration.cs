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
            builder.HasOne(x => x.Base).WithMany().HasForeignKey(p => p.BaseId);
            builder.HasOne(x => x.Color).WithMany().HasForeignKey(p => p.ColorId);
            builder.HasOne(x => x.Top).WithMany().HasForeignKey(p => p.TopId);
            builder.HasMany(x => x.Check2Design).WithOne(x => x.Check).IsRequired();
        }
    }
}
