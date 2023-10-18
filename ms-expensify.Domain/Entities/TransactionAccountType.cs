using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionAccountType : DescriptableEntity
    {
        public ICollection<TransactionAccount> Accounts { get; set; }

        public TransactionAccountType()
        {
            Accounts = new HashSet<TransactionAccount>();
        }
    }
}
