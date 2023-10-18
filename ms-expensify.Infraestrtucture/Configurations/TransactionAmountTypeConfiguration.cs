using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionAmountType> TransactionAmountTypes { get; set; } = null!;
    }

    public class TransactionAmountTypeConfiguration : IEntityTypeConfiguration<TransactionAmountType>
    {
        public void Configure(EntityTypeBuilder<TransactionAmountType> builder)
        {
            builder.ToTable("transaction_amount_types");
            DescriptableConfiguration.Configure(builder);
        }

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<TransactionAmountType>().HasData(new TransactionAmountType
            {
                Id = 1,
                Description = "Total",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionAmountType>().HasData(new TransactionAmountType
            {
                Id = 2,
                Description = "Parcial",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });
        }
    }
}
