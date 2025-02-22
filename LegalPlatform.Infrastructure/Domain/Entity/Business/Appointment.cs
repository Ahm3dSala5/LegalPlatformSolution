using LegalPlatform.Infrastructure.Domain.Entity.Base;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.Entity.Business
{
    internal sealed class Appointment : BaseEntity<int>
    {
        public DateTime AppointmentAt { set; get; }
        public AppointmentStatus AppointmentStatus { set; get; }
        public string ? Note { set; get; }
    }
}
