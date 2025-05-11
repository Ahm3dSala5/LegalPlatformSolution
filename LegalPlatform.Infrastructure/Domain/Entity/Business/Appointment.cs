using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Appointment : BaseEntity<Guid>
    {
        public DateTime Date { set; get; }
        public string Description { set; get; }
        public Client ?Client { set; get; }
        public Guid ?ClientId { set; get; }
        public Guid ?LawerId { set; get; }
        public Lawyer? Lawer {set;get;}
    }
}
