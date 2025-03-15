using LegalPlatform.Infrastructure.Domain.Entity.Base;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Client : Consumer<Guid>
    {
        public decimal Balance { set; get; }
    }
}
