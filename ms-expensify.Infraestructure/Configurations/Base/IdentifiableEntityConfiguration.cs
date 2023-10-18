using Goof.Domain.Classes.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ms_expensify.Domain.Entities.Base;

namespace ms_expensify.Infraestructure.Configurations.Base
{
    internal class IdentifiableEntityConfiguration
    {
        public static void Configure<T>(EntityTypeBuilder<T> builder) where T : IdentifiableEntity
        {
            builder.HasKey(x => x.Id);
        }
    }
}
