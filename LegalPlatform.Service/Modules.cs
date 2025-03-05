using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Security;
using Microsoft.Extensions.DependencyInjection;

namespace LegalPlatform.Service
{
    public static class Modules
    {
        public static void AddServiceModules(this IServiceCollection service)
        {
            service.AddTransient<IAuthorizationService, AuthorizationService>();
            service.AddTransient<IAuthenticationService, AuthenticationService>();
        }
    }
}
