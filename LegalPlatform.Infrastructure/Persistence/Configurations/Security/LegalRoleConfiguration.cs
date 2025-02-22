using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Security
{
    internal class LegalRoleConfiguration : IEntityTypeConfiguration<LegalRole>
    {
        public void Configure(EntityTypeBuilder<LegalRole> builder)
        {
            builder.ToTable("Role").HasKey(x=>x.Id);
        }
    }
}
