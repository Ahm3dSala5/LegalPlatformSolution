using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Comment :BaseEntity<Guid>
    {
        public DateTime AddedAt { set; get; }
        public string Text { set; get; }

        public LegalUser User { set; get; }
        public Guid UserId { set; get; }
        public Articale Articale { set; get; }
        public Guid ArticaleId { set; get; }
    }
}
