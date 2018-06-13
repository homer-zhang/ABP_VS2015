using System.Threading.Tasks;
using Abp.Application.Services;
using Template.Dev.Authorization.Accounts.Dto;

namespace Template.Dev.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
