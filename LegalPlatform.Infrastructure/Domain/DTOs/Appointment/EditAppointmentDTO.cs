using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.DTOs.NewFolder
{
    public class EditAppointmentDTO
    {
        public Guid Id { set; get; }
        public DateTime AppointmentAt { set; get; }
        public AppointmentStatus Status { set; get; }
        public string? Note { set; get; }
    }
}
