using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Articale : BaseEntity<Guid>
    {
        public string Content { set; get; }
        public DateTime UploadedAt { set; get; }

        public LegalUser User { set; get; }
        public Guid UserId { set; get; }
        public ICollection<Comment> Comments { set; get; } = new List<Comment>();
    }
}
