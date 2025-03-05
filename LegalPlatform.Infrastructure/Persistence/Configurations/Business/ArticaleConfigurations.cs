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
        }
    }

}
