using FluentValidation;
using ms_expensify.Application.Contracts.Repositories;
using ms_expensify.Application.Services.Plannings.ViewModels;

namespace ms_expensify.Application.Services.Plannings.Validators
{
    public class PlanningPostViewModelValidator : AbstractValidator<PlanningPostViewModel>
    {
        public PlanningPostViewModelValidator(ITransactionAccountsRepository transactionAccountsRepository)
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("El campo {PropertyName} es obligatorio")
                .NotNull()
                .WithMessage("El campo {PropertyName} es obligatorio");

            RuleFor(p => p.Date)
                .NotNull()
                .WithMessage("El campo {PropertyName} debe contener un valor válido");

            RuleFor(p => p.TransactionAccountId)
                .Must(p => transactionAccountsRepository.ExistById(p).Result)
                .WithMessage("El {PropertyName} es inválido");
        }
    }
}
