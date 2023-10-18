using ms_expensify.Application.ViewModels;

namespace ms_expensify.Application.Services.TransactionDetails.ViewModels
{
    public class TransactionDetailViewModel : IdentifiableViewModel
    {
        public int TransactionAmountTypeId { get; set; }
        public string TransactionAmountTypeDescription { get; set; }
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
