using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.TransactionDetails.Validators;
using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Application.Services.TransactionStates.Enums;

namespace ms_expensify.Application.Services.Transactions.Validators
{
    public class TransactionPostViewModelValidator : AbstractValidator<TransactionPostViewModel>
    {
        private readonly int[] _statesEnable = new[] { (int)TransactionStatesEnum.Active, (int)TransactionStatesEnum.Budget, (int)TransactionStatesEnum.Pending };

        public TransactionPostViewModelValidator(
            ITransactionAccountsRepository transactionAccountsRepository,
            ITransactionTypesRepository transactionTypesRepository,
            ITransactionCategoriesRepository transactionCategoriesRepository,
            ITransactionAmountTypesRepository transactionAmountTypesRepository,
            IPlanningsRepository planningsRepository
        )
        {
            ClassLevelCascadeMode = CascadeMode.Stop;

            RuleFor(p => p.TransactionDetails)
                .Must(p => p is not null && p.Any())
                .WithMessage("Se necesita almenos un detalle para crear la transacción");

            When(p => p.TransactionDetails is not null && p.TransactionDetails.Any(), () =>
            {
                RuleForEach(p => p.TransactionDetails)
                .SetValidator(new TransactionDetailPostViewModelValidator(transactionAmountTypesRepository));
            });

            RuleFor(p => p.TransactionAccountId)
                .NotNull()
                .Must(p => transactionAccountsRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es obligatorio");

            RuleFor(p => p.TransactionTypeId)
                .NotNull()
                .Must(p => transactionTypesRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es obligatorio");

            RuleFor(p => p.TransactionCategoryId)
                .NotNull()
                .Must(p => transactionCategoriesRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es obligatorio");

            RuleFor(p => p.PlanningId)
                .NotNull()
                .Must(p => planningsRepository.ExistById(p.Value).Result)
                .WithMessage("El {PropertyName} es obligatorio")
                .When(p => p.PlanningId.HasValue);

            RuleFor(p => p.TransactionStateId)
                .NotNull()
                .Must(p => _statesEnable.Contains(p))
                .WithMessage("El {PropertyName} debe contener un valor válido");

            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull();
        }
    }
}
