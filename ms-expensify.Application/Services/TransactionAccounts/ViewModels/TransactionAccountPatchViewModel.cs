namespace ms_expensify.Application.Services.TransactionAccounts.ViewModels
{
    public class TransactionAccountPatchViewModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? CurrencyId { get; set; }
        public bool? HideBalance { get; set; }
        public decimal? Amount { get; set; }
        public string? IconLink { get; set; }
        public string? ColorPicked { get; set; }

        private int _userId;
        public int UserId
        {
            get { return _userId; }
        }

        public void AddUser(int userId) => _userId = userId;
    }
}
