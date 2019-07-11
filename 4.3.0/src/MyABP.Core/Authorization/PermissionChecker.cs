using Abp.Authorization;
using MyABP.Authorization.Roles;
using MyABP.Authorization.Users;

namespace MyABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
