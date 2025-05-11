using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LegalPlatform.Core.Features.Appointments.Query.Model;
using LegalPlatform.Core.Features.Articales.Query.Model;
using LegalPlatform.Infrastructure.Domain.DTOs.Articale;
using LegalPlatform.Infrastructure.Domain.Entity.Business;

namespace LegalPlatform.Core.Mapping.Appointments
{
    public partial class AppointmentProfile
    {
        public void GetArticaleQueryMapping()
        {
            CreateMap<AppointmentModel, Appointment>().
                ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Appointment_Id)).
                ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Appointment_Note)).
                ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.AppointmentAt));
        }
    }
}
