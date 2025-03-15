using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Core.Features.Appointments.Query.Model
{
    public class AppointmentModel
    {
        public Guid Appointment_Id { set; get; }
        public DateTime AppointmentAt { set; get; }
        public AppointmentStatus Appointment_Status { set; get; }
        public string? Appointment_Note { set; get; }
    }
}
