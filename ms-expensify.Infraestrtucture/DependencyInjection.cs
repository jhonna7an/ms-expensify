using Goof.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Infraestructure.Context;
using ms_expensify.Infraestructure.Repositories;

namespace ms_expensify.Infraestructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ExpensifyContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.ConfigureRepository()
                .ConfigureContext<ExpensifyContext>();

            services.AddScoped<ICurrenciesRepository, CurrenciesRepository>();
            services.AddScoped<ITransactionAccountTypesRepository, TransactionAccountTypesRepository>();
            services.AddScoped<ITransactionAccountsRepository, TransactionAccountsRepository>();
            services.AddScoped<ITransactionCategoriesRepository, TransactionCategoriesRepository>();
            services.AddScoped<ITransactionTypesRepository, TransactionTypesRepository>();
            services.AddScoped<ITransactionsRepository, TransactionsRepository>();
            services.AddScoped<ITransactionDetailsRepository, TransactionDetailsRepository>();
            services.AddScoped<ITransactionAmountTypesRepository, TransactionAmountTypesRepository>();
            services.AddScoped<IPlanningsRepository, PlanningsRepository>();
            services.AddScoped<ITransactionStateRepository, TransactionStateRepository>();

            return services;
        }
    }
}
