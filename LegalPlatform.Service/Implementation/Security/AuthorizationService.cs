using GraduationProjectStore.Service.Abstraction.Security;
using LegalPlatform.Infrastructure.Domain.Entity.Security;
using Microsoft.AspNetCore.Identity;

namespace GraduationProjectStore.Service.Implementation.Security
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly RoleManager<LegalRole> _roleManager;
        private readonly UserManager<LegalUser> _userManager;
        public AuthorizationService
            (RoleManager<LegalRole> roleManager, UserManager<LegalUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }

        public async ValueTask<string> AssignRoleToUserAsync(string username, string rolename)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return "UserNotFound";

            var role = await _roleManager.FindByNameAsync(rolename);
            if (role == null)
                return "RoleNotFound";

            var inRole = await _userManager.IsInRoleAsync(user,rolename);
            if (inRole)
                return "UserInRole";
          
            var assignToRoleResult =  await _userManager.AddToRoleAsync(user,rolename);
            return assignToRoleResult.Succeeded ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> CreateRoleAsync(string rolename)
        {
            var existedRole = await _roleManager.RoleExistsAsync(rolename);
            if (existedRole)
                return "RoleExisted";

            var role = new LegalRole()
            {
                Name = rolename
            };

            var createResult = await _roleManager.CreateAsync(role);
            return createResult.Succeeded ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> RemoveRoleAsync(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
                return "NotFound";

            var deleteResult = await _roleManager.DeleteAsync(role);
            return deleteResult.Succeeded ? "Successfully" : "Invalid";
        }

        public async ValueTask<string> RemoveUserFromRole(string username, string rolename)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
                return "NotFound";

            var role = await _roleManager.FindByNameAsync(rolename);
            if (role == null)
                return "NotFound";

            var inRole = await _userManager.IsInRoleAsync(user, rolename);
            if (!inRole)
                return "UserNotInRole";

            var removeFromRoleResult = await _userManager.RemoveFromRoleAsync(user, rolename);
            return removeFromRoleResult.Succeeded ? "Successfully" : "Invalid";
        }
    }
}
