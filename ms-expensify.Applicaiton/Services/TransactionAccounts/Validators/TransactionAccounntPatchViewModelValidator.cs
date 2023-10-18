using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionAccounts.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccounts.Validators
{
    public class TransactionAccounntPatchViewModelValidator : AbstractValidator<TransactionAccountPatchViewModel>
    {
        public TransactionAccounntPatchViewModelValidator(
            ICurrenciesRepository currenciesRepository    
        )
        {
            RuleFor(P => P.CurrencyId)
                .Must(p => currenciesRepository.ExistById(p.Value).Result)
                .WithMessage("El {PropertyName} es inválido")
                .When(p => p.CurrencyId.HasValue);
        }
    }
}
