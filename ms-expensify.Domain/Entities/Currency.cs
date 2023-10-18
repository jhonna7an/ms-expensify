using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record Currency : DescriptableEntity
    {
        public string Symbol { get; set; }

        public ICollection<TransactionAccount> Accounts { get; set; }

        public Currency()
        {
            Accounts = new HashSet<TransactionAccount>();
        }
    }
}
