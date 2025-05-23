﻿using AutoMapper;
using GraduationProjectStore.Core.ResultHandlers;
using LegalPlatform.Core.Features.Comments.Command.Request;
using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Service.UnitOfWorks;
using MediatR;

namespace LegalPlatform.Core.Features.Comments.Command.Handler
{
    public class CommentCommandHandler
        : ResultHandler ,
         IRequestHandler<WriteCommentCommand, Result<string>>,
         IRequestHandler<EditCommentCommand, Result<string>>,
         IRequestHandler<DeleteCommentCommand, Result<string>>
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public CommentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }

        public async Task<Result<string>> Handle
            (EditCommentCommand request, CancellationToken cancellationToken)
        {
           if(request.Comment == null)
                return BadRequest<string>(_message:"Invalid Data");

            var editingOperation = await _unitOfWork.CommentService.EditCommentAsync(request.Comment);
            if(editingOperation == "NotFound")
                return NotFound<string>(_message: "Comment Not Found");

            if (editingOperation == "Unauhorized")
                return BadRequest<string>(_message: "User Unauthorized To Edit Comment");

            return editingOperation == "Successfully" ? OK<string>(_message: "Comment Edited Successfully") : 
                BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle(WriteCommentCommand request, CancellationToken cancellationToken)
        {
            if (request.Comment == null)
                return BadRequest<string>(_message: "Invalid Data");

            var comment = new Comment()
            {
                Text = request.Comment.Content,
                AddedAt = DateTime.UtcNow ,
                ArticaleId = request.Comment.ArticleId,
                UserId = request.Comment.UserId
            };
            var writingOperation = await _unitOfWork.CommentService.CreateAsync(comment);
            return writingOperation == "Successfully" ?
                Created<string>(_message: "Comment Created Successfully") :
                BadRequest<string>(_message: "Internal Server Error");
        }

        public async Task<Result<string>> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            if (request.CommentId == Guid.Empty)
                return BadRequest<string>(_message: "Invalid Comment Id");

            var deletingOperation = await _unitOfWork.CommentService.DeleteAsync(request.CommentId);
            if(deletingOperation == "NotFound")
               return NotFound<string>(_message: "Comment Not Found");

            return deletingOperation == "Successfully" ?
                OK<string>(_message: "Comment Deleted Successfully") :
                BadRequest<string>(_message: "Internal Server Error");  
        }
    }
}
