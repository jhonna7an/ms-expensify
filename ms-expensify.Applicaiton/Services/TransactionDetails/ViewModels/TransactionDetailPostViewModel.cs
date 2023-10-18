namespace ms_expensify.Application.Services.TransactionDetails.ViewModels
{
    public class TransactionDetailPostViewModel
    {
        public int TransactionAmountTypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime? Date { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}
