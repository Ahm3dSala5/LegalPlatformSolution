using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutoMapper;
using LegalPlatform.Core.Features.Articales.Command.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.DTOs.Comments;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Comments
{
    public partial class CommentProfile 
    {
        public void WriteCommentCommandMapping()
        {
            CreateMap<Comment, WriteCommentDTO>().
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId)).
                ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Text)).
                ForMember(dest => dest.ArticleId, opt => opt.MapFrom(src => src.ArticaleId)).ReverseMap();
        }

        public void UpdateCommentCommandMapping()
        {
            CreateMap<Comment, EditCommentDTO>().
                ForMember(dest => dest.Comment_Id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId)).
                ForMember(dest => dest.Commnent_Text, opt => opt.MapFrom(src => src.Text)).ReverseMap();
        }
    }
}
