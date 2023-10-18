using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Infraestructure.Configurations.Base
{
    internal class DescriptableConfiguration
    {
        public static void Configure<T>(EntityTypeBuilder<T> builder) where T : DescriptableEntity
        {
            AuditableEntityConfiguration.Configure(builder);

            builder.Property(property => property.Description)
                .HasMaxLength(200);
        }
    }
}
