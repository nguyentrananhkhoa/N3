using System.Threading.Tasks;
using Abp.Application.Services;
using Nhom3.Sessions.Dto;

namespace Nhom3.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
