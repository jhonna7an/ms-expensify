using Goof.Domain.Classes.Entities;

namespace ms_expensify.Domain.Entities.Base
{
    public record DescriptableEntity : AuditableEntity
    {
        public string Description { get; set; }
    }
}
