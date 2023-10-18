using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<TransactionCategory> TransactionCategories { get; set; } = null!;
    }

    public class TransactionCategoryConfiguration : IEntityTypeConfiguration<TransactionCategory>
    {
        public void Configure(EntityTypeBuilder<TransactionCategory> builder)
        {
            builder.ToTable("transaction_categories");
            DescriptableConfiguration.Configure(builder);
        }

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 1,
                Description = "Salud",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 2,
                Description = "Ocio",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 3,
                Description = "Hogar",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 4,
                Description = "Educación",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 5,
                Description = "Regalos",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<TransactionCategory>().HasData(new TransactionCategory
            {
                Id = 6,
                Description = "Comidas",
                TransactionTypeId = 1,
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });
        }
    }
}
