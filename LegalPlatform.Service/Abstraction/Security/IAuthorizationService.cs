using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace GraduationProjectStore.Service.Abstraction.Security
{
    public interface IAuthorizationService
    {
        ValueTask<string> CreateRoleAsync(string username);
        ValueTask<string> AssignRoleToUserAsync(string username ,string rolename);
        ValueTask<string> RemoveUserFromRole(string username ,string rolename);
        ValueTask<string> RemoveRoleAsync(string roleName);
    }
}
