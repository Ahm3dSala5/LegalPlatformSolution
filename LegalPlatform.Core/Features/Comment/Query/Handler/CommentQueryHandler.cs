using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Comments.Query.Model;
using LegalPlatform.Core.Features.Comments.Query.Request;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Query.Handler
{
    public class CommentQueryHandler : 
        ResultHandler,
        IRequestHandler<GetCommentByIdQuery, Result<CommentModel>>  ,
        IRequestHandler<GetAllCommentQuery, Result<ICollection<CommentModel>>>  
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CommentQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Result<ICollection<CommentModel>>> Handle
            (GetAllCommentQuery request, CancellationToken cancellationToken)
        {
            var comments = await _unitOfWork.CommentService.GetAllAsync();
            if(comments.Count() == 0)
                return NotFound<ICollection<CommentModel>>(_message: "No Comments Found");

            var commentsModel = _mapper.Map<ICollection<CommentModel>>(comments);
            return OK<ICollection<CommentModel>>
                (_data: commentsModel,_message:$"Comment Count = {commentsModel.Count()}");
        }

        public async Task<Result<CommentModel>> Handle
            (GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            if (request.CommentId == Guid.Empty)
                return BadRequest<CommentModel>(_message: "Invalid Data");

            var comment = await _unitOfWork.CommentService.GetAsync(request.CommentId);
            if (comment == null)
                return NotFound<CommentModel>(_message: "Comment Not Found");

            var commentModel = _mapper.Map<CommentModel>(comment);
            return OK<CommentModel>(_data: commentModel);
        }
    }
}
