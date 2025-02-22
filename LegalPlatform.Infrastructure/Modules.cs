using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LegalPlatform.Infrastructure
{
    public static class Modules
    {
        public static void AddInfrastructureModules(this IServiceCollection service)
        {
            service.AddTransient(typeof(IMainRepository<>),typeof(MainRepository<>));
        }
    }
}
