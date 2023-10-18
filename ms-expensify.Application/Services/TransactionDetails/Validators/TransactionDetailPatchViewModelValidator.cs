using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;

namespace ms_expensify.Application.Services.TransactionDetails.Validators
{
    public class TransactionDetailPatchViewModelValidator : AbstractValidator<TransactionDetailPatchViewModel>
    {
        public TransactionDetailPatchViewModelValidator(ITransactionAmountTypesRepository transactionAmountTypesRepository)
        {
            RuleFor(p => p.TransactionAmountTypeId)
                .Must(p => transactionAmountTypesRepository.ExistById(p.Value).Result)
                .WithMessage("El {PropertyName} es inválido")
                .When(p => p.TransactionAmountTypeId.HasValue);

            RuleFor(p => p.Amount)
                .Must(p => p.Value > 0)
                .WithMessage("El campo {PropertyName} debe ser mayor que cero (0)")
                .When(p => p.Amount.HasValue);

            RuleFor(p => p.Date)
                .NotNull()
                .WithMessage("El campo {PropertyName} debe contener un valor válido");
        }
    }
}
