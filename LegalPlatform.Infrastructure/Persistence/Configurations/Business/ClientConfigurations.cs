using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(x => x.Id);

            builder.HasOne(x => x.User)
            .WithOne(x => x.ClientProfile)
            .HasForeignKey<Client>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade); // or Restrict

        }
    }
}
