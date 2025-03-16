using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LegalPlatform.Core.Features.Articales.Command.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Articales
{
    public partial class ArticaleProfile 
    {
        public void WriteArticaleCommandMapping()
        {
            CreateMap<Articale, WriteArticaleDTO>().
                ForMember(dest => dest.Articale_UserId, opt => opt.MapFrom(src => src.UserId)).
                ForMember(dest => dest.TArticale_Title, opt => opt.MapFrom(src => src.Title)).
                ForMember(dest => dest.Articale_Content, opt => opt.MapFrom(src => src.Content)).ReverseMap();
        }

        public void UpdateArticaleCommandMapping()
        {
            CreateMap<Articale, UpdateArticaleDTO>().
                ForMember(dest => dest.Articale_Id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.Articale_UserId, opt => opt.MapFrom(src => src.UserId)).
                ForMember(dest => dest.Articale_Content, opt => opt.MapFrom(src => src.Content)).ReverseMap();
        }
    }
}
