using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Comments.Command.Request;
using LegalPlatform.Core.Features.Payments.Command.Request;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Payments.Command.Handler
{
    public class PaymemtCommandHandler : 
        ResultHandler ,
        IRequestHandler<StartPaymentCommand,Result<string>> ,
        IRequestHandler<CancelPaymetCommand,Result<string>> ,
        IRequestHandler<EditPaymentCommand,Result<string>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PaymemtCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (EditPaymentCommand request, CancellationToken cancellationToken)
        {
            if (request.Payment == null)
                return BadRequest<string>(_message: "Invalid Data");

            var startPayOperation = await _unitOfWork.paymentService.EditPaymentAsync(request.Payment);
            if (startPayOperation == "PaymentNotFound")
                return BadRequest<string>(_message: "Payment Not Found Or Invalid Payment Id");

            if (startPayOperation == "SenderNotFound")
                return NotFound<string>(_message: "Sender Not Found");

            if (startPayOperation == "RecieverNotFound")
                return NotFound<string>(_message: "Reciever Not Found");

            if (startPayOperation == "UserNotHaveEnoughMoney")
                return NotFound<string>(_message: "Sender Not Have Enough Money");
            
            return startPayOperation == "Successfully" ? Created<string>(_message: "Payment Successfully") :
                BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle(CancelPaymetCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == null)
                return BadRequest<string>(_message: "Invalid Data");

            var deleteOperation = await _unitOfWork.paymentService.DeleteAsync(request.Id);
            if (deleteOperation == "NotFound")
                return NotFound<string>(_message:"Payment Not Found or Invalid Payment Id");

            return deleteOperation == "Successfully" ?
                OK<string>(_message: "Payment Deleted Successfully") :
                BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle(StartPaymentCommand request, CancellationToken cancellationToken)
        {
            var startPayOperation = await _unitOfWork.paymentService.StartPaymentAsync(request.Payment);
            if (startPayOperation == "PaymentNotFound")
                return BadRequest<string>(_message: "Payment Not Found Or Invalid Payment Id");

            if (startPayOperation == "SenderNotFound")
                return NotFound<string>(_message: "Sender Not Found");

            if (startPayOperation == "RecieverNotFound")
                return NotFound<string>(_message: "Reciever Not Found");

            if (startPayOperation == "UserNotHaveEnoughMoney")
                return NotFound<string>(_message: "Sender Not Have Enough Money");

            return startPayOperation == "Successfully" ? Created<string>(_message: "Payment Successfully") :
                BadRequest<string>(_message: "Internal Server Error");
        }
    }
}
