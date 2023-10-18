using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.TransactionCategories.ViewModels
{
    public class TransactionCategoryFilterViewModel : IdentifiableViewModel
    {
        public int? TransactionTypeId { get; set; }
    }
}
