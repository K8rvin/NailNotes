using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class TopConfiguration : IEntityTypeConfiguration<Top>
    {
        public void Configure(EntityTypeBuilder<Top> builder)
        {
            builder.ToTable("Top").HasKey(d => d.Id);
            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}
