using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionType : DescriptableEntity
    {
        public ICollection<Transaction> Transactions { get; set; }
        public ICollection<TransactionCategory> TransactionCategories { get; set; }

        public TransactionType()
        {
            Transactions = new HashSet<Transaction>();
            TransactionCategories = new HashSet<TransactionCategory>();
        }
    }
}
