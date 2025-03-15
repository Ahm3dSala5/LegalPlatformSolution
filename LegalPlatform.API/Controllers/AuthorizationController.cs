using Graduation_Project_Store.API.Bases;
using GraduationProjectStore.Core.Feature.Authorization.Command.Request;
using GraduationProjectStore.Service.Abstraction.Security;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Graduation_Project_Store.API.Controllers
{
    [ApiController]
    [Route("api/Authorization")]
    public class AuthorizationController : Base
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(string rolename)
        {
            var createCommand = await Mediator.Send(new CreateRoleCommand(rolename));
            return HandledResult(createCommand);
        }

        [HttpPost("AssignRoleToUser")]
        public async Task<IActionResult> AssignRoleToUser(string username, string rolename)
        {
            var assignRoleToUserCommand = await Mediator.Send(new AssignRoleToUserCommand(rolename,username));
            return HandledResult(assignRoleToUserCommand);
        }

        [HttpPut("RemoveUserFromRole")]
        public async Task<IActionResult> RemoveUserFromRole(string username ,string rolename)
        {
            var removeUserFromRoleCommand = await Mediator.Send(new RemoveUserFromRoleCommand(rolename, username));
            return HandledResult(removeUserFromRoleCommand);
        }

        [HttpDelete("DeleteRole")]
        public async Task<IActionResult> DeleteRole(string rolename)
        {
            var deleteRoleCommand = await Mediator.Send(new DeleteRoleCommand(rolename));
            return HandledResult(deleteRoleCommand);
        }
    }
}
