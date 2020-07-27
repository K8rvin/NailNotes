using LizokasNail.Core.Dao.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LizokasNail.Core.Dao.EF.Configuration
{
    internal class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.ToTable("Record").HasKey(d => d.Id);
            builder.HasOne(x => x.User).WithMany(x => x.Records).HasForeignKey(p => p.UserId);
            builder.HasOne(x => x.Check).WithOne(x => x.Record).HasForeignKey<Check>(p => p.RecordId);
        }
    }
}
