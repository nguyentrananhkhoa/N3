using Abp.Authorization;
using Nhom3.Authorization.Roles;
using Nhom3.Authorization.Users;

namespace Nhom3.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
