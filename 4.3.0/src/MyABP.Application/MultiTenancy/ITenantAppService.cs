using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyABP.MultiTenancy.Dto;

namespace MyABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
