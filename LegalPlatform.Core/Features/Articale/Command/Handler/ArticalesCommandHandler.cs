using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Articales.Command.Request;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Command.Handler
{
    public class ArticalesCommandHandler :
        ResultHandler,
        IRequestHandler<WriteArticalesCommand, Result<string>> ,
        IRequestHandler<UpdateArticalesCommand, Result<string>> ,
        IRequestHandler<DeleteArticalesCommand, Result<string>> 
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ArticalesCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (DeleteArticalesCommand request, CancellationToken cancellationToken)
        {
            if(request.Id == Guid.Empty)
                return BadRequest<string>(_message:"Invalid Articale Id");

            var deleteOperation = await _unitOfWork.ArticaleService.DeleteAsync(request.Id);
            if(deleteOperation == "NotFound")
                return NotFound<string>(_message: "Articale Not Found or Invalid Articale Id");

            return deleteOperation == "Successfully" ? OK<string>(_message: "Articale Deleted Successfully") 
                : BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle
            (UpdateArticalesCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return BadRequest<string>(_message: "Invalid Articale Data");

            var articaleMapped = _mapper.Map<Articale>(request.Articale);
            articaleMapped.UploadedAt = DateTime.Now;

            var updateOperation = await _unitOfWork
                .ArticaleService.UpdateAsync(articaleMapped,request.Articale.Articale_Id);

            if (updateOperation == "NotFound")
                return NotFound<string>(_message: "Articale Not Found or Invalid Articale Id");

            return updateOperation == "Successfully" ? OK<string>(_message: "Articale Updated Successfully")
                : BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle
            (WriteArticalesCommand request, CancellationToken cancellationToken)
        {
            if(request == null)
                return BadRequest<string>(_message: "Invalid Articale Data");

            var articaleMapped = _mapper.Map<Articale>(request.Articale);
            articaleMapped.UploadedAt = DateTime.Now;
            var createOperation = await _unitOfWork
                .ArticaleService.CreateAsync(articaleMapped);

            if (createOperation == "NotFound")
                return NotFound<string>(_message: "Articale Not Found or Invalid Articale Id");

            return createOperation == "Successfully" ? OK<string>(_message: "Articale Created Successfully")
                : BadRequest<string>(_message: "Internal Server Error");
        }
    }
}
