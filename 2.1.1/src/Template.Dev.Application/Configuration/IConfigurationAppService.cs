using System.Threading.Tasks;
using Abp.Application.Services;
using Template.Dev.Configuration.Dto;

namespace Template.Dev.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}