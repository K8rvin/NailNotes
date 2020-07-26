using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("Color").HasKey(d => d.Id);
            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}
