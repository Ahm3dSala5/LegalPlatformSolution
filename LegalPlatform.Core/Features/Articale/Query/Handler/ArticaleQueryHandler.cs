using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Articales.Query.Model;
using LegalPlatform.Core.Features.Articales.Query.Request;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Articales.Query.Handler
{
    public class ArticaleQueryHandler :
        ResultHandler,
        IRequestHandler<GetArticaleByIdQuery, Result<ArticaleModel>>,
        IRequestHandler<GetAllArticalesQuery, Result<ICollection<ArticaleModel>>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ArticaleQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Result<ICollection<ArticaleModel>>> Handle
            (GetAllArticalesQuery request, CancellationToken cancellationToken)
        {
            var articales = await _unitOfWork.ArticaleService.GetAllAsync();
            if (articales.Count() == 0)
                return NotFound<ICollection<ArticaleModel>>(_message: "No Articales Found");

            var articalesMapped = _mapper.Map<ICollection<ArticaleModel>>(articales);
            return OK<ICollection<ArticaleModel>>(_data:articalesMapped, 
                _message: $"Articles Number = {articalesMapped.Count()}");
        }

        public async Task<Result<ArticaleModel>> Handle
            (GetArticaleByIdQuery request, CancellationToken cancellationToken)
        {
           if(request.Id == Guid.Empty)
                return BadRequest<ArticaleModel>(_message: "Invalid Articale Id");

            var articale = await _unitOfWork.ArticaleService.GetAsync(request.Id);
            if (articale == null)
                return NotFound<ArticaleModel>(_message: "Articale Not Found or Invalid Articale Id");

            var articaleMapped = _mapper.Map<ArticaleModel>(articale);
            return OK<ArticaleModel>(_data:articaleMapped );
        }
    }
}
