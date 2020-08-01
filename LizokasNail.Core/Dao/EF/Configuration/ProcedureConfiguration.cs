using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class ProcedureConfiguration : IEntityTypeConfiguration<Procedure>
    {
        public void Configure(EntityTypeBuilder<Procedure> builder)
        {
            builder.ToTable("Procedure").HasKey(d => d.Id);
            builder.HasIndex(p => p.Name).IsUnique();
        }
    }
}
