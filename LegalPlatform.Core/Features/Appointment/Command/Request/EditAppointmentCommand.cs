using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Infrastructure.Domain.DTOs.NewFolder;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Command.Request
{
    public class EditAppointmentCommand : IRequest<Result<string>>
    {
        public EditAppointmentCommand(EditAppointmentDTO appointment)
        {
            this.Appointment = appointment;
        }

        public EditAppointmentDTO Appointment { get; }
    }
}
