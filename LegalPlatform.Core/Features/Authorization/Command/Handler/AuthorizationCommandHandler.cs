using GraduationProjectStore.Core.Feature.Authorization.Command.Request;
using GraduationProjectStore.Core.ResultHandlers;
using GraduationProjectStore.Service.Abstraction.Security;
using MediatR;

namespace GraduationProjectStore.Core.Feature.Authorization.Command.Handler
{
    public class AuthorizationCommandHandler
        : ResultHandler,
        IRequestHandler<AssignRoleToUserCommand,Result<string>> ,
        IRequestHandler<RemoveUserFromRoleCommand,Result<string>> ,
        IRequestHandler<CreateRoleCommand, Result<string>> ,
        IRequestHandler<DeleteRoleCommand,Result<string>>
    {
        private readonly IAuthorizationService _authorizationService;

        public AuthorizationCommandHandler(IAuthorizationService authorizationService)
        {
            this._authorizationService = authorizationService;
        }

        public async Task<Result<string>> Handle
            (CreateRoleCommand request, CancellationToken cancellationToken)
        {
            if (request.rolename == null)
                return BadRequest<string>(_message:"Invalid Role Name");

            var createRoleOperation = await _authorizationService.CreateRoleAsync(request.rolename);
            if (createRoleOperation == "RoleExisted")
                return BadRequest<string>(_message:"User Is Already Existed");

            return createRoleOperation == "Successfully" ?
              OK<string>(_message: "Role Created Successfully") : 
              BadRequest<string>(_message:"Invaid Operations") ;
        }

        public async Task<Result<string>> 
            Handle(AssignRoleToUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return BadRequest<string>(_message: "Invalid Role Name");

            var assignRoleToUseOperation = await _authorizationService.
                AssignRoleToUserAsync(request.Username,request.RoleName);

            if (assignRoleToUseOperation == "UserNotFound")
                return BadRequest<string>(_message: "User Not Found Or Invalid Username");

            if (assignRoleToUseOperation == "RoleNotFound")
                return BadRequest<string>(_message: "Role Not Found Or Invalid Role Name");

            if(assignRoleToUseOperation == "UserInRole")
                return BadRequest<string>(_message: "User Is Already In Role");

            return assignRoleToUseOperation == "Successfully" ?
             OK<string>(_message: "Role Assigned To User Successfully") :
             BadRequest<string>(_message: "Invaid Operations");
        }

        public async Task<Result<string>> Handle
            (RemoveUserFromRoleCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                return BadRequest<string>(_message: "Invalid Role Name");

            var removeUserFromRoleOperation = await _authorizationService.
              RemoveUserFromRole(request.Username, request.Rolename);

            if (removeUserFromRoleOperation == "UserNotFound")
                return BadRequest<string>(_message: "User Not Found Or Invalid Username");

            if (removeUserFromRoleOperation == "RoleNotFound")
                return BadRequest<string>(_message: "Role Not Found Or Invalid Role Name");

            if (removeUserFromRoleOperation == "UserNotInRole")
                return BadRequest<string>(_message: "User Not In Role");

            return removeUserFromRoleOperation == "Successfully" ?
             OK<string>(_message: "User Removed From Role Successfully") :
             BadRequest<string>(_message: "Invaid Operations");
        }

        public async Task<Result<string>> Handle
            (DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            if (request.rolename == null)
                return BadRequest<string>(_message: "Invalid Role Name");

            var deleteRoleOperation = await _authorizationService.RemoveRoleAsync(request.rolename);
            if (deleteRoleOperation == "NotFound")
                return BadRequest<string>(_message: "Role Not Found Or Invalid Role Name");

            return deleteRoleOperation == "Successfully" ?
            OK<string>(_message: "User Removed Successfully") :
            BadRequest<string>(_message: "Invaid Operations");
        }
    }
}
