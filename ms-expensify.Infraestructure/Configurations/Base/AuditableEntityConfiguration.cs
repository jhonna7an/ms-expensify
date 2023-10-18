using Goof.Domain.Classes.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Enums;

namespace ms_expensify.Infraestructure.Configurations.Base
{
    public class AuditableEntityConfiguration
    {
        public static void Configure<T>(EntityTypeBuilder<T> builder) where T : AuditableEntity
        {
            IdentifiableEntityConfiguration.Configure(builder);

            builder.Property(property => property.Status)
                .IsRequired()
                .HasColumnType("smallint")
                .HasDefaultValue((int)RecordStatusEnum.Active);

            builder.Property(property => property.CreatedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder.Property(property => property.CreatedBy)
                .IsRequired();

            builder.Property(property => property.LastModifiedAt)
                .IsRequired()
                .HasDefaultValue(DateTime.Now);

            builder.Property(property => property.LastModifiedBy)
                .IsRequired();
        }
    }
}
