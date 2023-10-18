using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<Transaction> Transactions { get; set; } = null!;
    }

    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("transactions");
            AuditableEntityConfiguration.Configure(builder);
        }
    }
}
