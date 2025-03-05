using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraduationProjectStore.Core.Feature.Authentications.Command.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.Abstraction.Security;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authentications.Command.Handler
{
    public class AuthenticationCommandHandler 
       : ResultHandler,
       IRequestHandler<LoginUserCommand, Result<object>> ,
       IRequestHandler<RegisterUserCommand, Result<string>> ,
       IRequestHandler<ForgotPasswordCommand, Result<string>> ,
       IRequestHandler<ChangePasswordCommand, Result<string>>,
       IRequestHandler<DeleteUserCommand, Result<string>>,
       IRequestHandler<ConfirmForgotpasswordCommand, Result<object>> ,
       IRequestHandler<ConfirmRegisterationCommand, Result<object>> 
    {
        private readonly IAuthenticationService _authenticationService;
        public AuthenticationCommandHandler(IAuthenticationService authenticationService)
        {
            this._authenticationService = authenticationService;    
        }

        public async Task<Result<string>> Handle
            (RegisterUserCommand request, CancellationToken cancellationToken)
        {
            if(request.RegisterDTO == null)
                return BadRequest<string>(_message:"Invalid User Data");

            var registerOperations = await _authenticationService.RegisterAsync(request.RegisterDTO);
            return registerOperations == "Successfully" ?
                OK<string>(_message: "Please Check on Your Email Notification To Get Confirmation Code")
                :BadRequest<string>(_message:"Invalid Registration");
        }

        public async Task<Result<object>> Handle
            (ConfirmRegisterationCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return NotFound<object>(_message:"Invalid UserName Or Verification Code");

            var confirmationOperation = await _authenticationService.
                ConfirmRegisterAsync(request.username,request.Code);

            if(confirmationOperation =="NotFound")
                return NotFound<object>(_message: "User Not Found Or Invalid Username");

            if(confirmationOperation == "Invalid")
                return BadRequest<object>(_message: "Invalid Verification Code");

            return OK<object>(_data:confirmationOperation,_message: "Successfully");
        }

        public async Task<Result<object>> Handle
            (LoginUserCommand request, CancellationToken cancellationToken)
        {
            if (request.LoginDTO == null)
                return NotFound<object>(_message: "Invalid UserName Data");

            var token = await _authenticationService.LoginAsync(request.LoginDTO);
            if (token == "NotFound")
                return NotFound<object>(_message:"User Not Found Or Invalid Username");

            if (token == "Invalid")
                return BadRequest<object>(_message: "Invalid Password");

            return OK<object>(_data: token, _message: "Successfully");  
        }

        public async Task<Result<string>> Handle
            (ForgotPasswordCommand request, CancellationToken cancellationToken)
        {
            if (request.UserName == null)
                return BadRequest<string>(_message:"Username Cannt Be null Or Empty");

            var forgotPasswordRequest = await _authenticationService.ForgetPasswordAsync(request.UserName); 
            if(forgotPasswordRequest == "NotFound")
                return NotFound<string>(_message: "User Not Found Or Invalid Username");

            return OK<string>(_data: forgotPasswordRequest,
                _message: "Check Your Email For Get Confrimation Code For Confirm Forgot Password Operations");
        }

        public async Task<Result<object>> Handle
            (ConfirmForgotpasswordCommand request, CancellationToken cancellationToken)
        {
            if (request.ConfirmForgetPasswordDTO == null)
                return BadRequest<object>(_message: "Invalid Forgot Password Data");

            var forgotPasswordRequest = await _authenticationService.
                ConfirmForgetPasswordAsync(request.ConfirmForgetPasswordDTO);

            if (forgotPasswordRequest == "NotFound")
                return NotFound<object>(_message: "User Not Found Or Invalid Username");

            if (forgotPasswordRequest == "Invalid")
                return BadRequest<object>(_message: "Invalid Confirmation Code");

            return OK<object>(_data: forgotPasswordRequest, _message: "Successfully");  
        }

        public async Task<Result<string>> Handle
            (ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            if (request.ChmagePassword == null)
                return BadRequest<string>(_message: "Invalid Data");

            var changePasswordProcess =await  _authenticationService
                .ChangePasswordAsync(request.ChmagePassword);

            if (changePasswordProcess == "NotFound")
                return BadRequest<string>(_message: "User not Found Or Invalid Username");

            if (changePasswordProcess == "Invalid")
                return BadRequest<string>(_message: "Invalid Password");

            return OK<string>(_message:"Password Chnaged Successfully");
        }

        public async Task<Result<string>> Handle
            (DeleteUserCommand request, CancellationToken cancellationToken)
        {
            if (request.Username == null)
                return BadRequest<string>(_message:"Invalid Username");

            var deleteOperation = await _authenticationService.DeleteUserAsync(request.Username);
            if(deleteOperation == "NotFound")
                return NotFound<string>(_message:"User not Found");

            return deleteOperation == "Successfully" ? OK<string>(_message:"User Deleted Successfully")
                : BadRequest<string>(_message: "Invalid Deleting");
        }
    }
}
