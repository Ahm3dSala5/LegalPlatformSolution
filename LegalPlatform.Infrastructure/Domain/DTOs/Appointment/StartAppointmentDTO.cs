using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegalPlatform.Infrastructure.Domain.Enum;

namespace LegalPlatform.Infrastructure.Domain.DTOs.NewFolder
{
    public class StartAppointmentDTO
    {
        public DateTime AppointmentAt { set; get; }
        public AppointmentStatus Status { set; get; }
        public string? Note { set; get; }
    }
}
