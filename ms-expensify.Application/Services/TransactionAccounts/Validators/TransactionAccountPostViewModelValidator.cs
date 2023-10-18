using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccounts.Validators
{
    public class TransactionAccountPostViewModelValidator : AbstractValidator<TransactionAccountPostViewModel>
    {
        public TransactionAccountPostViewModelValidator(
            ITransactionAccountTypesRepository transactionAccountTypesRepository,
            ICurrenciesRepository currenciesRepository
        )
        {
            RuleFor(p => p.TransactionAccountTypeId)
                .Must(p => transactionAccountTypesRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es inválido");

            RuleFor(p => p.CurrencyId)
                .Must(p => currenciesRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es inválido");
        }
    }
}
