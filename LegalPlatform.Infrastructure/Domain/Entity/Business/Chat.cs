using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    internal sealed class Chat : BaseEntity<Guid>
    {
        public string Message { set; get; }
        public string MessageType { set; get; }
        public bool IsRead { set; get; }
        public DateTime senedAt { set; get; }
    }
}
