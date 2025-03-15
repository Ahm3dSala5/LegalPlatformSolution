using AutoMapper;

namespace LegalPlatform.Core.Mapping.Appointments
{
    public partial class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            GetArticaleQueryMapping();
            StartAppointmentCommandMapping();
            EditAppointmentCommandMapping();
        }  
    }
}
