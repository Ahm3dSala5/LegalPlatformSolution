using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Payments.Query.Model;
using LegalPlatform.Core.Features.Payments.Query.Request;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Payment.Query.Handler
{
    public class PaymentQueryHandler :
        ResultHandler ,
       IRequestHandler<GetPaymentByIdQuery , Result<PaymentModel>> ,
       IRequestHandler<GetAllPaymentQuery , Result<ICollection<PaymentModel>>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public PaymentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Result<ICollection<PaymentModel>>> Handle
            (GetAllPaymentQuery request, CancellationToken cancellationToken)
        {
            var patments = await _unitOfWork.paymentService.GetAllAsync();
            if (patments.Count() == 0)
                return NotFound<ICollection<PaymentModel>>(_message: "No Payments Found");

            var paymentModel = _mapper.Map<ICollection<PaymentModel>>(patments);
            return OK<ICollection<PaymentModel>>
                (_data: paymentModel, _message: $"Payment Count = {paymentModel.Count()}");
        }

        public async Task<Result<PaymentModel>> Handle
            (GetPaymentByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.Id == Guid.Empty)
                return BadRequest<PaymentModel>(_message: "Invalid Data");

            var payment = await _unitOfWork.paymentService.GetAsync(request.Id);
            if (payment == null)
                return NotFound<PaymentModel>(_message: "Comment Not Found");

            var paymentModel = _mapper.Map<PaymentModel>(payment);
            return OK<PaymentModel>(_data: paymentModel);
        }
    }
}
