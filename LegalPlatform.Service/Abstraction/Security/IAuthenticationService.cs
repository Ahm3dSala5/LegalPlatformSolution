using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using LegalPlatform.Infrastructure.Repository;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
namespace GraduationProjectStore.Service.Abstraction.Security
{
    public interface IAuthenticationService : IMainRepository<LegalUser>
    {
        ValueTask<object> RegisterAsync(RegisterDTO user);
        ValueTask<object> ConfirmRegisterAsync(string username,string confirmationCode);
        ValueTask<object> LoginAsync(LoginDTO user);
        ValueTask<string> ChangePasswordAsync(ChangePassowrdDTO changePassword);
        ValueTask<string> ForgetPasswordAsync(string username);
        ValueTask<object> ConfirmForgetPasswordAsync(ConfirmForgotPasswordDTO confirmforgetPassword);
        ValueTask<LegalUser> GetUserByNameAsync(string username);
        ValueTask<string> DeleteUserAsync(string username);
    }
}
