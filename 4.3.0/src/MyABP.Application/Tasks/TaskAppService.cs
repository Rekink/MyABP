using Abp.Domain.Repositories;
using MyABP.Tasks.Dtos;

namespace MyABP.Tasks
{
    public class TaskAppService : MyABPAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;
        
        /// <summary>
        /// 依赖注入，使用构造函数注入模式
        /// </summary>
        /// <param name="taskRepository"></param>
        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        // 实现IApplicationService接口方法
        public void CreateTask(CreateTaskInput input)
        {
            // 使用_TaskRepository执行数据库操作
            var task = _taskRepository.FirstOrDefault(p=>p.Description == input.Description);
            if (task!=null)
            {
                //
            }
            task = new Task { Description = input.Description };
            _taskRepository.Insert(task);

            // 记录日志（Logger 定义在 ApplicationService 类中）
            Logger.Info("Creating a new task with description: " + input.Description);

            //获取本地化文本 (L 是LocalizationHelper.GetString(...)的简写, 定义在 ApplicationService类中)
            var text = L("SampleLocalizableTextKey");

            //TODO: Add new task to database...

        }
    }
}
