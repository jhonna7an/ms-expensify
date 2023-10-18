using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionState : DescriptableEntity
    {
        public ICollection<Transaction> Transactions { get; set; }

        public TransactionState()
        {
            Transactions = new HashSet<Transaction>();
        }
    }
}
