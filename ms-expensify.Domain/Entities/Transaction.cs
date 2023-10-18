using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Domain.Entities
{
    public record Transaction : DescriptableEntity
    {
        public int TransactionAccountId { get; set; }
        public int TransactionCategoryId { get; set; }
        public int TransactionTypeId { get; set; }
        public int TransactionStateId { get; set; }
        public int? PlanningId { get; set; }
        public decimal TotalAmount { get; set; }

        public TransactionAccount TransactionAccount { get; set; }
        public TransactionCategory TransactionCategory { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionState TransactionState { get; set; }
        public Planning? Planning { get; set; }
        public ICollection<TransactionDetail> TransactionDetails { get; set; }


        public Transaction()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }
    }
}
