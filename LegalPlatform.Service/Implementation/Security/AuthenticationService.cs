using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Service.Abstraction.Security;
using GraduationProjectStore.Service.Implementation.Business.Helper;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using LegalPlatform.Infrastructure.Persistence.Context;
using LegalPlatform.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class AuthenticationService : MainRepository<LegalUser>, IAuthenticationService
    {
        private readonly IMailService _mail;
        private readonly IConfiguration _config;
        private readonly UserManager<LegalUser> _userManager;
        private readonly SignInManager<LegalUser> _signInManager;

        public AuthenticationService
            (UserManager<LegalUser> user, IMailService mail, SignInManager<LegalUser> signInManager,
            IConfiguration config, LegalPlatformContext context) :base(context)
        {
            this._userManager = user;
            this._mail = mail;
            this._signInManager = signInManager;
            this._config = config;
        }

        public async ValueTask<string> ChangePasswordAsync
            (ChangePassowrdDTO changePassword)
        {
            var user = await _userManager.FindByNameAsync(changePassword.UserName);
            if(user == null)
                return "NotFound";

            var checkPassword = await  _userManager.CheckPasswordAsync(user,changePassword.Password);
            if (!checkPassword)
                return "Invalid Password";

            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var changeProcess = await _userManager.ResetPasswordAsync(user,resetToken,changePassword.Password);
            return changeProcess.Succeeded ? "Successfully" : "Wrong";
        }

        public async ValueTask<object> ConfirmForgetPasswordAsync
            (ConfirmForgotPasswordDTO confirmforgetPassword)
        {
            var user =  await _userManager.FindByNameAsync(confirmforgetPassword.UserName);
            if (user == null)
                return "NotFound";

            var code = await _userManager.GetAuthenticationTokenAsync
                (user, "ConfirmationCode", "ConfirmationCode");
            if(confirmforgetPassword.ConfirmationCode != code)
                return "Invalid";

            return UserHelper.GenerateToken(_config, user, await _userManager.GetRolesAsync(user)); 
        }

        public async ValueTask<object> ConfirmRegisterAsync(string username, string confirmationCode)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return "NotFound";

            var code = await _userManager.GetAuthenticationTokenAsync
                (user, "ConfirmationCode", "ConfirmationCode");

            if(code != confirmationCode)
                return "Invalid";

            await _signInManager.SignInAsync(user,true);
            var roles = await _userManager.GetRolesAsync(user);

            return  UserHelper.GenerateToken(_config, user,roles);
        }

        public async ValueTask<string> DeleteUserAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return "NotFound";

            var deleteResult = await _userManager.DeleteAsync(user);
            return deleteResult.Succeeded ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> ForgetPasswordAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return "NotFound";

            return await UserHelper.GenerateConfirmationCode(user, _mail, _userManager);    
        }

        public async ValueTask<LegalUser> GetUserByNameAsync(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public async ValueTask<object> LoginAsync(LoginDTO user)
        {
            var _user = await _userManager.FindByNameAsync(user.UserName);
            if(_user == null)
                return "NotFound";

            var checkPassword = await _userManager.CheckPasswordAsync(_user, user.Password);
            if (!checkPassword)
                return "Invalid";

            await _signInManager.SignInAsync(_user,user.RememberMe);
            var roles = await _userManager.GetRolesAsync(_user);
            return UserHelper.GenerateToken(_config, _user, roles);
        }

        public async ValueTask<string> RegisterAsync(RegisterDTO user)
        {
            var appUser = new LegalUser()
            {
                UserName = user.UserName,
                Address = user.Address,
                PasswordHash = user.Password,
                Email = user.Email
            };

            var createResult = await _userManager.CreateAsync(appUser, user.Password);
            if (!createResult.Succeeded)
                return "Invalid";

            // afterv this pice user created successfully 
            // then we will send confirmation code for user bny using it email
            return await UserHelper.GenerateConfirmationCode(appUser,_mail,_userManager);
        }
    }
}
