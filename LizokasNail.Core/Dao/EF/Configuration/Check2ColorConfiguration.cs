using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class Check2ColorConfiguration : IEntityTypeConfiguration<Check2Color>
    {
        public void Configure(EntityTypeBuilder<Check2Color> builder)
        {
            builder.ToTable("Check2Color").HasKey(d => d.Id);
            builder.HasOne(x => x.Check).WithMany(x => x.Check2Color).HasForeignKey(x=>x.IdCheck);
            builder.HasOne(x => x.Color).WithMany().HasForeignKey(x => x.IdColor);
        }
    }
}
