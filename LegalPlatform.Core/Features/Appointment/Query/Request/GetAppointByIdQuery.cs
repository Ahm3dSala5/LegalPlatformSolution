using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Appointments.Query.Model;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Query.Request
{
    public class GetAppointByIdQuery : IRequest<Result<AppointmentModel>>
    {
        public GetAppointByIdQuery(Guid id)
        {
            this.Id = id;
        }

        public Guid Id { get; }
    }
}
