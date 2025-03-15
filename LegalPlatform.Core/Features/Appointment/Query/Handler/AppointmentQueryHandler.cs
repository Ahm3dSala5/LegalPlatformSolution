using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Appointments.Query.Model;
using LegalPlatform.Core.Features.Appointments.Query.Request;
using LegalPlatform.Core.Features.Articales.Query.Model;
using LegalPlatform.Core.Features.Articales.Query.Request;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Query.Handler
{
    public class AppointmentQueryHandler
        : ResultHandler ,
        IRequestHandler<GetAppointByIdQuery,Result<AppointmentModel>> ,
        IRequestHandler<GetAllAppintmentQuery,Result<ICollection<AppointmentModel>>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<AppointmentModel>>> Handle
           (GetAllAppintmentQuery request, CancellationToken cancellationToken)
        {
            var appointments = await _unitOfWork.AppointmentService.GetAllAsync();
            if (appointments.Count() == 0)
                return NotFound<ICollection<AppointmentModel>>(_message: "No Appointments Found");

            var appointmentsModel = _mapper.Map<ICollection<AppointmentModel>>(appointments);
            return OK<ICollection<AppointmentModel>>(_data: appointmentsModel,
                _message: $"Appointments Number = {appointmentsModel.Count()}");
        }

        public async Task<Result<AppointmentModel>> Handle
            (GetAppointByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == Guid.Empty)
                return BadRequest<AppointmentModel>(_message: "Invalid Articale Id");

            var appointment = await _unitOfWork.ArticaleService.GetAsync(request.Id);
            if (appointment == null)
                return NotFound<AppointmentModel>(_message: "Appointment Not Found or Invalid Articale Id");

            var appointmentModel = _mapper.Map<AppointmentModel>(appointment);
            return OK<AppointmentModel>(_data: appointmentModel);
        }
    }
}
