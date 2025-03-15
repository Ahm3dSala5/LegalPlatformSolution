using GraduationProjectStore.Core.ResultHandlers;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Command.Request
{
    public class CancelAppointmentCommand : IRequest<Result<string>>
    {
        public CancelAppointmentCommand(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}
