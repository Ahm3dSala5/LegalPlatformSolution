using LegalPlatform.Infrastructure.Domain.Entity.Business;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalPlatform.Infrastructure.Persistence.Configurations.Business
{
    internal class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment").HasKey(x => x.Id);

            builder.HasOne(x => x.User)
              .WithMany(x => x.Comments)
              .HasForeignKey(x => x.UserId)
              .OnDelete(DeleteBehavior.Restrict)
              .IsRequired(true);

            builder.HasOne(x => x.Articale)
             .WithMany(x => x.Comments)
             .HasForeignKey(x => x.ArticaleId)
             .OnDelete(DeleteBehavior.Restrict)
             .IsRequired(true);
        }
    }
}
