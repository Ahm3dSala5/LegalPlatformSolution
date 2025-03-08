
using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace LegalPlatform.Core
{
    public static class Modules
    {
        public static void AddCoreModules(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(Modules).Assembly);
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            service.Configure<IdentityOptions>(PasswordOptions =>
            {
                PasswordOptions.Password.RequireNonAlphanumeric = false;
                PasswordOptions.Password.RequiredLength = 8;
                PasswordOptions.Password.RequiredUniqueChars = 2;
                PasswordOptions.Password.RequireDigit = false;
                PasswordOptions.Password.RequireUppercase = false;
                PasswordOptions.Password.RequireLowercase = false;
            });

        }
    }
}
