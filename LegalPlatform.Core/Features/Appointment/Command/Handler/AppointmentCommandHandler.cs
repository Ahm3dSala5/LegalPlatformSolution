using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Appointments.Command.Request;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Appointments.Command.Handler
{
    public class AppointmentCommandHandler
        : ResultHandler,
         IRequestHandler<StartAppintmentCommand, Result<string>> ,
         IRequestHandler<CancelAppointmentCommand, Result<string>> ,
         IRequestHandler<EditAppointmentCommand, Result<string>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (StartAppintmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Appointment == null)
                return BadRequest<string>(_message:"Invalud Appintment Data");

            var appointment = _mapper.Map<Appointment>(request.Appointment);
            var startOperation = await _unitOfWork.AppointmentService.CreateAsync(appointment);

            return startOperation == "Successfully" ?
                Created<string>(_message:"Appointment Added Successfully") :
                BadRequest<string>(_message:"Invalid Added Operation");
        }

        public async Task<Result<string>> Handle
            (CancelAppointmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == Guid.Empty)
                return BadRequest<string>(_message:"Invalid Appointment Id");

            var cancelOperation = await _unitOfWork.AppointmentService.DeleteAsync(request.Id);
            return cancelOperation == "Successfully" ?
               OK<string>(_message: "Appointment Canceled Successfully") :
               BadRequest<string>(_message: "Invalid Cancele Operation");
        }

        public async Task<Result<string>> Handle
            (EditAppointmentCommand request, CancellationToken cancellationToken)
        {
            if (request.Appointment == null)
                return BadRequest<string>(_message: "Invalud Appintment Data");

            var appointment = _mapper.Map<Appointment>(request.Appointment);
            var editOperation = await _unitOfWork.AppointmentService
                .UpdateAsync(appointment,request.Appointment.Id);

            return editOperation == "Successfully" ?
                Created<string>(_message: "Appointment Updated Successfully") :
                BadRequest<string>(_message: "Invalid Update Operation");
        }
    }
}
