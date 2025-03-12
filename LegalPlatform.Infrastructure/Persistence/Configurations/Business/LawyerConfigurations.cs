using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class LawyerConfigurations : IEntityTypeConfiguration<Lawyer>
    {
        public void Configure(EntityTypeBuilder<Lawyer> builder)
        {
            builder.ToTable("Lawyer").HasKey(x => x.Id);
        }
    }
}
