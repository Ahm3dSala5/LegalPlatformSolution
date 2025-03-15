using Graduation_Project_Store.API.Bases;
using GraduationProjecrStore.Infrastructure.Domain.DTOs.Authentication;
using GraduationProjectStore.Core.Feature.Authentications.Command.Request;
using GraduationProjectStore.Core.Feature.Authentications.Query.Request;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/authentication")]
    public class AuthenticationController : Base
    {
        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO user)
        {
            var registerCommand = await Mediator.Send(new RegisterUserCommand(user));
            return HandledResult(registerCommand);
        }


        [HttpPost("Confirm-Registration")]
        public async Task<IActionResult> ConfirmRegistration(string username, string confirmationcode)
        {
            var confirmregisterCommand = await Mediator.Send(new ConfirmRegisterationCommand(username,confirmationcode));
            return HandledResult(confirmregisterCommand);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO user)
        {
            var loginCommand = await Mediator.Send(new LoginUserCommand(user));
            return HandledResult(loginCommand);
        }

        [HttpPost("Forgot-Password-Request")]
        public async Task<IActionResult> ForgetPasswordRequest(string username)
        {
            var forgotRequest = await Mediator.Send(new ForgotPasswordCommand(username));
            return HandledResult(forgotRequest);
        }

        [HttpGet("Get/{username}")]
        public async Task<IActionResult> GetOne(string username)
        {
            var getbyUsernameQuery = await Mediator.Send(new GetUserByUsernameQuery(username));
            return HandledResult(getbyUsernameQuery);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var getAllQuery = await Mediator.Send(new GetAllUserQuery());
            return HandledResult(getAllQuery);
        }

        [HttpPut("Forgot-Password-Confirm")]
        public async Task<IActionResult> ForgetPasswordConfirm(ConfirmForgotPasswordDTO username)
        {
            var confirmforgotRequest = await Mediator.Send(new ConfirmForgotpasswordCommand(username));
            return HandledResult(confirmforgotRequest);
        }

        [HttpPut("Change-Password")]
        public async Task<IActionResult> ChnagePassword(ChangePassowrdDTO changePassword)
        {
            var changePasswordCommand = await Mediator.Send(new ChangePasswordCommand(changePassword));
            return HandledResult(changePasswordCommand);
        }

        [HttpDelete("Delete/{username}")]
        public async Task<IActionResult> ChnagePassword(string username)
        {
            var deleteUserCommand = await Mediator.Send(new DeleteUserCommand(username));
            return HandledResult(deleteUserCommand);
        }
    }
}
