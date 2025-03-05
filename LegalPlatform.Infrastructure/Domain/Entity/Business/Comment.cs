using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Comment :BaseEntity<int>
    {
        public DateTime AddedAt { set; get; }
        public string Content { set; get; }
    }
}
