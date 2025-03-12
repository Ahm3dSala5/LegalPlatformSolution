using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    public sealed class Appointment : BaseEntity<Guid>
    {
        public DateTime AppointmentAt { set; get; }
        public AppointmentStatus AppointmentStatus { set; get; }
        public string ? Note { set; get; }
        public LegalUser User { set; get; }
        public Guid UserId { set; get; }
    }
}
