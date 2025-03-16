using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Security
{
    internal class LegalUserConfiguration : IEntityTypeConfiguration<LegalUser>
    {
        public void Configure(EntityTypeBuilder<LegalUser> builder)
        {
            builder.ToTable("User").HasKey(x => x.Id);
        }
    }
}
