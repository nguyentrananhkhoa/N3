using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Nhom3.MultiTenancy;

namespace Nhom3.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}