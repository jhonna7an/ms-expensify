using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionDetails.ViewModels;

namespace ms_expensify.Application.Services.TransactionDetails.Validators
{
    public class TransactionDetailPostViewModelValidator : AbstractValidator<TransactionDetailPostViewModel>
    {
        public TransactionDetailPostViewModelValidator(ITransactionAmountTypesRepository transactionAmountTypesRepository)
        {
            RuleFor(p => p.TransactionAmountTypeId)
                .Must(p => transactionAmountTypesRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es inválido");

            RuleFor(p => p.Amount)
                .NotNull()
                .WithMessage("El campo {PropertyName} debe contener un valor válido")
                .Must(p => p > 0)
                .WithMessage("El campo {PropertyName} debe ser mayor que cero (0)");

            RuleFor(p => p.Date)
                .NotNull()
                .WithMessage("El campo {PropertyName} debe contener un valor válido");
        }
    }
}
