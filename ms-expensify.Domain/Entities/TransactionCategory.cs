using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionCategory : DescriptableEntity
    {
        public int TransactionTypeId { get; set; }

        public TransactionType TransactionType { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        public TransactionCategory()
        {
            Transactions = new HashSet<Transaction>();
        }
    }
}
