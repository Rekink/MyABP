using Abp.Application.Services;
using MyABP.Tasks.Dtos;

namespace MyABP.Tasks
{
    /// <summary>
    /// 输入验证
    /// </summary>
    public interface ITaskAppService : IApplicationService
    {
        //定义接口与方法
        void CreateTask(CreateTaskInput input);
         
    }
}
