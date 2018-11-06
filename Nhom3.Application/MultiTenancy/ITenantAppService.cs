using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Nhom3.MultiTenancy.Dto;

namespace Nhom3.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
