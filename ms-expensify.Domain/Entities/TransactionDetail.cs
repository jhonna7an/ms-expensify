using Goof.Domain.Classes.Entities;

namespace ms_expensify.Domain.Entities
{
    public record TransactionDetail : AuditableEntity
    {
        public int TransactionAmountTypeId { get; set; }
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public TransactionAmountType TransactionAmountType { get; set; }
        public Transaction Transaction { get; set; }
    }
}
