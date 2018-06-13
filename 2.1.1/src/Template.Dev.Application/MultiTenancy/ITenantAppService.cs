using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Template.Dev.MultiTenancy.Dto;

namespace Template.Dev.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
