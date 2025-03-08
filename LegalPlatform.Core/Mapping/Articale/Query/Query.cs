using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LegalPlatform.Core.Features.Articales.Query.Model;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Articales
{
    public partial class ArticaleProfile
    {
        public void GetArticaleQueryMapping()
        {
            CreateMap<ArticaleModel, Articale>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Articale_Id)).
                ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Articale_UserId)).
                ForMember(dest => dest.Content, opt => opt.MapFrom(src => src.Articale_Content)).
                ForMember(dest => dest.UploadedAt, opt => opt.MapFrom(src => src.Articale_UploadedAt))
                .ReverseMap();
        }
    }
}
