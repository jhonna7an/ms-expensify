using ms_expensify.Application.Services.TransactionDetails.ViewModels;

namespace ms_expensify.Application.Services.Transactions.ViewModels
{
    public class TransactionPostViewModel
    {
        public int TransactionAccountId { get; set; }
        public int TransactionCategoryId { get; set; }
        public int TransactionTypeId { get; set; }
        public int TransactionStateId { get; set; }
        public int? PlanningId { get; set; }
        public string Description { get; set; }
        public List<TransactionDetailPostViewModel>? TransactionDetails { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}
