using FluentValidation;
using ms_expensify.Application.Services.Plannings.ViewModels;

namespace ms_expensify.Application.Services.Plannings.Validators
{
    public class PlanningPatchViewModelValidator : AbstractValidator<PlanningPatchViewModel>
    {
        public PlanningPatchViewModelValidator()
        {
            //RuleFor(p => p.Date)
            //    .NotNull()
            //    .WithMessage("El campo {PropertyName} debe contener un valor válido");
        }
    }
}
