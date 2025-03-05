using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class AppointmentConfigurations : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("Appointment").HasKey(x => x.Id);


        }
    }


}
