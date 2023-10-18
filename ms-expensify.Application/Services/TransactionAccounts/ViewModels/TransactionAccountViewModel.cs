using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.TransactionAccounts.ViewModels
{
    public class TransactionAccountViewModel : IdentifiableViewModel
    {
        public int UserId { get; set; }
        public int TransactionAccountTypeId { get; set; }
        public string TransactionAccountTypeDescription { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public bool HideBalance { get; set; }
        public decimal TotalAmount { get; set; }
        public string IconLink { get; set; }
        public string ColorPicked { get; set; }
    }
}
