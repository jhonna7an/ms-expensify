using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionDetail> TransactionDetails { get; set; } = null!;
    }

    public class TransactionDetailConfiguration : IEntityTypeConfiguration<TransactionDetail>
    {
        public void Configure(EntityTypeBuilder<TransactionDetail> builder)
        {
            builder.ToTable("transaction_details");
            AuditableEntityConfiguration.Configure(builder);
        }
    }
}
