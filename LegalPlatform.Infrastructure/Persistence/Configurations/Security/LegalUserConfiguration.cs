using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Security
{
    internal class LegalUserConfiguration : IEntityTypeConfiguration<LegalUser>
    {
        public void Configure(EntityTypeBuilder<LegalUser> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);


            builder.HasMany<IdentityUserClaim<Guid>>()
                   .WithOne()
                   .HasForeignKey(uc => uc.UserId)
                   .IsRequired();

            builder.HasMany<IdentityUserLogin<Guid>>()
                   .WithOne()
                   .HasForeignKey(ul => ul.UserId)
                   .IsRequired();

            builder.HasMany<IdentityUserToken<Guid>>()
                   .WithOne()
                   .HasForeignKey(ut => ut.UserId)
                   .IsRequired();

            builder.HasMany<IdentityUserRole<Guid>>()
                   .WithOne()
                   .HasForeignKey(ur => ur.UserId)
                   .IsRequired();
        }
    }
}
