using ms_expensify.Application.Services.Transactions.ViewModels;
using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.Plannings.ViewModels
{
    public class PlanningViewModel : IdentifiableViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int TransactionAccountId { get; set; }
        public string TransactionAccountDescription { get; set; }
        public decimal TotalAmount { get; set; }
        public List<TransactionViewModel> Transactions { get; set; }
    }
}
