using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record Planning : DescriptableEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TransactionAccountId { get; set; }

        public TransactionAccount TransactionAccount { get; set; }
        public ICollection<Transaction> Transactions { get; set; }

        public Planning()
        {
            Transactions = new HashSet<Transaction>();
        }
    }
}
