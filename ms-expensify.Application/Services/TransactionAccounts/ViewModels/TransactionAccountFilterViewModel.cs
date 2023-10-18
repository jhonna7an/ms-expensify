using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccounts.ViewModels
{
    public class TransactionAccountFilterViewModel : IdentifiableViewModel
    {
        public int? UserId { get; set; }
    }
}
