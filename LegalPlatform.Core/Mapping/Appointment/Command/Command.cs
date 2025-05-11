using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LegalPlatform.Core.Features.Articales.Command.Request;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.DTOs.NewFolder;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Appointments
{
    public partial class AppointmentProfile 
    {
        public void StartAppointmentCommandMapping()
        {
            CreateMap<MakeAppointmentDTO, Appointment>()
             .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
             .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
             .ForMember(dest => dest.ClientId, opt => opt.Ignore()) 
             .ForMember(dest => dest.LawerId, opt => opt.Ignore())  
             .ForMember(dest => dest.Client, opt => opt.Ignore())   
             .ForMember(dest => dest.Lawer, opt => opt.Ignore()); 
        }

        public void EditAppointmentCommandMapping()
        {
            CreateMap<Appointment, EditAppointmentDTO>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Description)).
                ForMember(dest => dest.AppointmentAt, opt => opt.MapFrom(src => src.Date));
        }
    }
}
