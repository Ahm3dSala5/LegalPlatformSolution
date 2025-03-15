using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.NewFolder;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Command.Request
{
    public class StartAppintmentCommand : IRequest<Result<string>>
    {
        public StartAppintmentCommand(StartAppointmentDTO appointment)
        {
            Appointment = appointment;
        }

        public StartAppointmentDTO Appointment { get; }
    }
}
