using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.Transactions.ViewModels
{
    public class TransactionFilterViewModel : IdentifiableViewModel
    {
        public int? TransactionAccountId { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? PlanningId { get; set; }
    }
}
