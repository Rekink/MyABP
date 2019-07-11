using System.Threading.Tasks;
using Abp.Application.Services;
using MyABP.Configuration.Dto;

namespace MyABP.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}