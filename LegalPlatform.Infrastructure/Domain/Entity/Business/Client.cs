using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Client : Consumer<Guid>
    {
        public decimal Balance { set; get; }

        public Guid UserId { set; get; }
        public LegalUser User { get; set; } // Navigation property to the associated LegalUser
    }
}
