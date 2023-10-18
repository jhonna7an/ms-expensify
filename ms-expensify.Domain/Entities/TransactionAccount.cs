using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionAccount : DescriptableEntity
    {
        public int UserId { get; set; }
        public int TransactionAccountTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrencyId { get; set; }
        public bool HideBalance { get; set; }
        public decimal InitialAmount { get; set; }
        public string IconLink { get; set; }
        public string ColorPicked { get; set; }

        public TransactionAccountType TransactionAccountType { get; set; }
        public Currency Currency { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<Planning> Plannings { get; set; }

        public TransactionAccount()
        {
            Transactions = new HashSet<Transaction>();
            Plannings = new HashSet<Planning>();
        }

    }
}
