using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class ArticaleConfigurations : IEntityTypeConfiguration<Articale>
    {
        public void Configure(EntityTypeBuilder<Articale> builder)
        {
            builder.ToTable("Articale").HasKey(x => x.Id);

            builder.HasOne(x => x.User)
              .WithMany(x => x.Articales)
              .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired(true);
        }
    }

}
