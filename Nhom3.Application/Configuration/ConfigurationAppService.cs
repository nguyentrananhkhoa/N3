using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Nhom3.Configuration.Dto;

namespace Nhom3.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Nhom3AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
