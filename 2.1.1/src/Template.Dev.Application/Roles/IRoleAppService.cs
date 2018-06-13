using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Template.Dev.Roles.Dto;

namespace Template.Dev.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
