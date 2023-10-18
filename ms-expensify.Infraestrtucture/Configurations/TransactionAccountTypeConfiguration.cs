using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionAccountType> TransactionAccountTypes { get; set; } = null!;
    }

    public class TransactionAccountTypeConfiguration : IEntityTypeConfiguration<TransactionAccountType>
    {
        public void Configure(EntityTypeBuilder<TransactionAccountType> builder)
        {
            builder.ToTable("transaction_account_types");
            DescriptableConfiguration.Configure(builder);
        }

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<TransactionAccountType>().HasData(new TransactionAccountType
            {
                Id = 1,
                Description = "Standard",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionAccountType>().HasData(new TransactionAccountType
            {
                Id = 2,
                Description = "Tarjeta de Crédito",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });
        }
    }
}
