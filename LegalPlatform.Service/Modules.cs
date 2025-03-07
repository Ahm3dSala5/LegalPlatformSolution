using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Security;
using LegalPlatform.Service.Abstraction.Business;
using LegalPlatform.Service.Implementation.Business;
using LegalPlatform.Service.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace LegalPlatform.Service
{
    public static class Modules
    {
        public static void AddServiceModules(this IServiceCollection service)
        {
            service.AddTransient<IUnitOfWork, UnitOfWork>();
            service.AddTransient<ICommentService,CommentService>();
            service.AddTransient<IPaymentService,PaymentService>();
            service.AddTransient<IArticaleService,ArticaleService>();
            service.AddTransient<IAppointmentService,AppointmentService>();
            service.AddTransient<IAuthorizationService, AuthorizationService>();
            service.AddTransient<IAuthenticationService, AuthenticationService>();
        }
    }
}
