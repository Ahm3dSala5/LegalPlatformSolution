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
            CreateMap<Appointment, StartAppointmentDTO>().
                ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note)).
                ForMember(dest => dest.AppointmentAt, opt => opt.MapFrom(src => src.AppointmentAt)).
                ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status)).ReverseMap();
        }

        public void EditAppointmentCommandMapping()
        {
            CreateMap<Appointment, EditAppointmentDTO>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id)).
                ForMember(dest => dest.Note, opt => opt.MapFrom(src => src.Note)).
                ForMember(dest => dest.AppointmentAt, opt => opt.MapFrom(src => src.AppointmentAt)).
                ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status)).ReverseMap();
        }
    }
}
