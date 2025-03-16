using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LegalPlatform.Core.Features.Articales.Query.Model;
using LegalPlatform.Core.Features.Comments.Query.Model;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Comments
{
    public partial class CommentProfile 
    {
        public void GetCommentQueryMapping()
        {
            CreateMap<CommentModel, Comment>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Comment_Id)).
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Comment_UserId)).
                ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Comment_Text)).
                ForMember(dest => dest.AddedAt, opt => opt.MapFrom(src => src.Comment_AddedAt))
                .ReverseMap();
        }
    }
}
