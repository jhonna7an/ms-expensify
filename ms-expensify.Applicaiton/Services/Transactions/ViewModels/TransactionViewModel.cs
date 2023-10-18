using ms_expensify.Application.Services.TransactionDetails.ViewModels;
using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.Transactions.ViewModels
{
    public class TransactionViewModel : IdentifiableViewModel
    {
        public int TransactionAccountId { get; set; }
        public int TransactionCategoryId { get; set; }
        public string TransactionCategoryDescription { get; set; }
        public int TransactionTypeId { get; set; }
        public string TransactionTypeDescription { get; set; }
        public int TransactionStateId { get; set; }
        public string TransactionStateDescription { get; set; }
        public int? PlanningId { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
        public List<TransactionDetailViewModel> TransactionDetails { get; set; }

    }
}
