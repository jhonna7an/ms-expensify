using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Application.Services.TransactionStates.Enums;

namespace ms_expensify.Application.Services.Transactions.Validators
{
    public class TransactionPatchViewModelValidator : AbstractValidator<TransactionPatchViewModel>
    {
        private readonly int[] _statesEnable = new[] { (int)TransactionStatesEnum.Active, (int)TransactionStatesEnum.Budget, (int)TransactionStatesEnum.Pending };

        public TransactionPatchViewModelValidator(ITransactionCategoriesRepository transactionCategoriesRepository)
        {
            RuleFor(p => p.TransactionCategoryId)
                .Must(p => transactionCategoriesRepository.ExistById(p.Value).Result)
                .When(p => p.TransactionCategoryId.HasValue);

            RuleFor(p => p.TransactionStateId)
                .NotNull()
                .Must(p => _statesEnable.Contains(p.Value))
                .When(p => p.TransactionStateId.HasValue)
                .WithMessage("El {PropertyName} debe contener un valor válido");
        }
    }
}
