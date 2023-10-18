using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities;
using ms_expensify.Infraestructure.Configurations.Base;

namespace ms_expensify.Infraestructure.Configurations
{
    internal partial class ExtensifyContext
    {
        public DbSet<Currency> Currencies { get; set; } = null!;
    }

    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.ToTable("currencies");
            DescriptableConfiguration.Configure(builder);
        }

        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<Currency>().HasData(new Currency
            {
                Id = 1,
                Description = "Peso Argentino",
                Symbol = "ARS",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });

            builder.Entity<Currency>().HasData(new Currency
            {
                Id = 2,
                Description = "Dólar Estadounidense",
                Symbol = "USD",
                Status = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                LastModifiedAt = DateTime.Now,
                LastModifiedBy = 1
            });
        }
    }
}
