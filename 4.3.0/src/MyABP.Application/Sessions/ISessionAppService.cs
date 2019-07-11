using System.Threading.Tasks;
using Abp.Application.Services;
using MyABP.Sessions.Dto;

namespace MyABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
