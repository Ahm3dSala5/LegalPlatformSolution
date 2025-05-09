using LegalPlatform.Infrastructure.Domain.Entity.Business;
using LegalPlatform.Infrastructure.Repository;

namespace LegalPlatform.Service.Abstraction.Business
{
    public interface IAppointmentService :IMainRepository<Appointment>
    {

    }

    public class App
    {
        static void Main()
        {
            var Payment = new Payment();
        }
    }
}
