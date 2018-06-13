using Abp.Authorization;
using Template.Dev.Authorization.Roles;
using Template.Dev.Authorization.Users;

namespace Template.Dev.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
