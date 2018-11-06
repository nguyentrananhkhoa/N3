using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Nhom3.Roles.Dto;
using Nhom3.Users.Dto;

namespace Nhom3.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}