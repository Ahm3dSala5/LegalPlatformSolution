using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Comment :BaseEntity<int>
    {
        public DateTime AddedAt { set; get; }
        public string Content { set; get; }

        public LegalUser User { set; get; }
        public Guid UserId { set; get; }
        public Articale Articale { set; get; }
        public int ArticaleId { set; get; }
    }
}
