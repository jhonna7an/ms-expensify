using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.Plannings.ViewModels
{
    public class PlanningFilterViewModel : IdentifiableViewModel
    {
        public int? TransactionAccountId { get; set; }
        public DateTime? ToCreationDate { get; set; }
        public DateTime? FromCreationDate { get; set; }
    }
}
