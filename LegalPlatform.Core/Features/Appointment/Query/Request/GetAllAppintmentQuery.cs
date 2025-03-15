using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Appointments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Query.Request
{
    public class GetAllAppintmentQuery : IRequest<Result<ICollection<AppointmentModel>>>
    {

    }
}
