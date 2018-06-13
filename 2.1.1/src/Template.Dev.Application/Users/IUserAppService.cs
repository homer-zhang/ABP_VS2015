using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Template.Dev.Roles.Dto;
using Template.Dev.Users.Dto;

namespace Template.Dev.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}