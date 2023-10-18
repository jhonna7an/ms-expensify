using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.TransactionCategories.ViewModels
{
    public class TransactionCategoryViewModel: IdentifiableViewModel
    {
        public string Description { get; set; }
        public int TransactionTypeId { get; set; }
        public string TransactionTypeDescription { get; set; }
    }
}
