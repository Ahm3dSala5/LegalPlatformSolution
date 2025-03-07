using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class PaymentConfigurations : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("Payment").HasKey(x=>x.Id);

            builder.HasOne(x => x.User)
              .WithMany(x => x.Payments)
              .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired(true);
        }
    }

}
