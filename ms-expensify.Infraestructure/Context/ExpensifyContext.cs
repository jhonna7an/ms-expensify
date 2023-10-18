using Goof.Domain.Classes.Entities;
using Goof.Infraestructure.Repository.Context;
using Microsoft.EntityFrameworkCore;
using ms_expensify.Infraestructure.Configurations;
using System.Reflection;

namespace ms_expensify.Infraestructure.Context
{
    public class ExpensifyContext : DbContext, IDbContext
    {
        public ExpensifyContext()
        {

        }

        public ExpensifyContext(DbContextOptions<ExpensifyContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly(),
                type => type.GetInterfaces().Any(x => x.IsGenericType &&
                        x.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>) &&
                        typeof(BaseEntity).IsAssignableFrom(x.GenericTypeArguments[0])));

            TransactionTypeConfiguration.Seed(builder);
            TransactionCategoryConfiguration.Seed(builder);
            TransactionAmountTypeConfiguration.Seed(builder);
            CurrencyConfiguration.Seed(builder);
            TransactionAccountTypeConfiguration.Seed(builder);
            TransactionStateConfiguration.Seed(builder);

            base.OnModelCreating(builder);
        }
    }
}
