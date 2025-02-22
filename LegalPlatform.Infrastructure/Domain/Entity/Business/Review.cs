using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    internal sealed class Review : BaseEntity<int>
    {
        public string Content { set; get; }
        public double Rate { set; get; }
        public DateTime AddedAt { set; get; }
    }
}
