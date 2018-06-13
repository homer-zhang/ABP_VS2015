using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Template.Dev.Configuration.Dto;

namespace Template.Dev.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DevAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
