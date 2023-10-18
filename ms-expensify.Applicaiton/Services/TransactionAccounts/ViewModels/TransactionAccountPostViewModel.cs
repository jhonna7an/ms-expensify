namespace ms_expensify.Application.Services.TransactionAccounts.ViewModels
{
    public class TransactionAccountPostViewModel
    {
        public int TransactionAccountTypeId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CurrencyId { get; set; }
        public bool HideBalance { get; set; }
        public decimal? InitialAmount { get; set; }
        public string IconLink { get; set; }
        public string ColorPicked { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}
