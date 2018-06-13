using System.Threading.Tasks;
using Abp.Application.Services;
using Template.Dev.Sessions.Dto;

namespace Template.Dev.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
