using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Domain.Enums;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionState> TransactionStates { get; set; } = null!;
    }

    public class TransactionStateConfiguration : IEntityTypeConfiguration<TransactionState>
    {
        public void Configure(EntityTypeBuilder<TransactionState> builder)
        {
            builder.ToTable("transaction_states");
            DescriptableConfiguration.Configure(builder);
        }

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<TransactionState>().HasData(new TransactionState
            {
                Id = 1,
                Description = "Vigente",
                Status = (int)StatusEnum.Active,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionState>().HasData(new TransactionState
            {
                Id = 2,
                Description = "Presupuesto",
                Status = (int)StatusEnum.Active,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionState>().HasData(new TransactionState
            {
                Id = 3,
                Description = "Pendiente",
                Status = (int)StatusEnum.Active,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });
        }
    }
}
