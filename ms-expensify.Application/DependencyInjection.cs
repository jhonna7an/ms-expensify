using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using ms_expensify.Application.Services.Currencies;
using ms_expensify.Application.Services.Plannings;
using ms_expensify.Application.Services.TransactionAccounts;
using ms_expensify.Application.Services.TransactionAccountTypes;
using ms_expensify.Application.Services.TransactionAmountTypes;
using ms_expensify.Application.Services.TransactionCategories;
using ms_expensify.Application.Services.TransactionDetails;
using ms_expensify.Application.Services.Transactions;
using ms_expensify.Application.Services.TransactionTypes;

namespace ms_expensify.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DependencyInjection));

            services.AddFluentValidationAutoValidation()
                .AddValidatorsFromAssembly(typeof(DependencyInjection).Assembly);

            services.AddScoped<ICurrenciesService, CurrenciesService>();
            services.AddScoped<ITransactionAccountsService, TransactionAccountsService>();
            services.AddScoped<ITransactionTypesService, TransactionTypesService>();
            services.AddScoped<ITransactionAccountTypesService, TransactionAccountTypesService>();
            services.AddScoped<ITransactionCategoriesService, TransactionCategoriesService>();
            services.AddScoped<ITransactionAmountTypesService, TransactionAmountTypesService>();
            services.AddScoped<ITransactionDetailsService, TransactionDetailsService>();
            services.AddScoped<ITransactionsService, TransactionsService>();
            services.AddScoped<IPlanningsService, PlanningsService>();

            return services;
        }
    }
}
