using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Nhom3.Roles.Dto;

namespace Nhom3.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
