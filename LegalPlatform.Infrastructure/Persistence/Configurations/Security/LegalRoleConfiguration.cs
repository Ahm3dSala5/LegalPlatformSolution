using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Security
{
    internal class LegalRoleConfiguration : IEntityTypeConfiguration<LegalRole>
    {
        public void Configure(EntityTypeBuilder<LegalRole> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(x => x.Id);

            builder.HasMany<IdentityUserRole<Guid>>()
                   .WithOne()
                   .HasForeignKey(ur => ur.RoleId)
                   .IsRequired();

            builder.HasMany<IdentityRoleClaim<Guid>>()
                   .WithOne()
                   .HasForeignKey(rc => rc.RoleId)
                   .IsRequired();
        }
    }
}
