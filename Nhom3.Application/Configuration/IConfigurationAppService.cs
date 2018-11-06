using System.Threading.Tasks;
using Abp.Application.Services;
using Nhom3.Configuration.Dto;

namespace Nhom3.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}