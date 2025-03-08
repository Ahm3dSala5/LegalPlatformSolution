using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Service.Abstraction.Business;
using Microsoft.Extensions.Configuration;

namespace LegalPlatform.Service.Implementation.Business
{
    public class AppointmentService : MainRepository<Appointment>, IAppointmentService
    {
        public AppointmentService(LegalPlatformContext context,IConfiguration config) : base(context, config)
        {
        }
    } 
}
