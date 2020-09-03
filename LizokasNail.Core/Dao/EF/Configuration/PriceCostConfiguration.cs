using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class PriceCostConfiguration : IEntityTypeConfiguration<PriceCost>
    {
        public void Configure(EntityTypeBuilder<PriceCost> builder)
        {
            builder.ToTable("PriceCost").HasKey(d => d.Id);
        }
    }
}
