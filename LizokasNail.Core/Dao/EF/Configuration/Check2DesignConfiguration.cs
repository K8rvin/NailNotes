using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class Check2DesignConfiguration : IEntityTypeConfiguration<Check2Design>
    {
        public void Configure(EntityTypeBuilder<Check2Design> builder)
        {
            builder.ToTable("Check2Design").HasKey(d => d.Id);
            builder.HasOne(x => x.Check).WithMany(x => x.Check2Design).HasForeignKey(x=>x.IdCheck);
            builder.HasOne(x => x.Design).WithMany().HasForeignKey(x => x.IdDesign);
        }
    }
}
