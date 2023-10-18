using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record TransactionAmountType : DescriptableEntity
    {
        public ICollection<TransactionDetail> TransactionDetails { get; set; }

        public TransactionAmountType()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }
    }
}
