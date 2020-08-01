using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class Record2ProcedureConfiguration : IEntityTypeConfiguration<Record2Procedure>
    {
        public void Configure(EntityTypeBuilder<Record2Procedure> builder)
        {
            builder.ToTable("Record2Procedure").HasKey(d => d.Id);
            builder.HasOne(x => x.Record).WithMany(x => x.Record2Procedure).HasForeignKey(x=>x.IdRecord);
            builder.HasOne(x => x.Procedure).WithMany().HasForeignKey(x => x.IdProcedure);
        }
    }
}
