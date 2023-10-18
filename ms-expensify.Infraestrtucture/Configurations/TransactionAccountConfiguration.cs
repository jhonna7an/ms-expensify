using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionAccount> TransactionAccounts { get; set; } = null!;
    }

    public class TransactionAccountConfiguration : IEntityTypeConfiguration<TransactionAccount>
    {
        public void Configure(EntityTypeBuilder<TransactionAccount> builder)
        {
            builder.ToTable("transaction_accounts");
            DescriptableConfiguration.Configure(builder);
        }
    }
}
