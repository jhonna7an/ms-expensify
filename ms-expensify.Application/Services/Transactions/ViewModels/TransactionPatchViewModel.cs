namespace ms_expensify.Application.Services.Transactions.ViewModels
{
    public class TransactionPatchViewModel
    {
        public int? TransactionCategoryId { get; set; }
        public int? TransactionStateId { get; set; }
        public string? Description { get; set; }
        public int? PlanningId { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}
