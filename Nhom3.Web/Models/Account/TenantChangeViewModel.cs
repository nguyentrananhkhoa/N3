using Abp.AutoMapper;
using Nhom3.Sessions.Dto;

namespace Nhom3.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}