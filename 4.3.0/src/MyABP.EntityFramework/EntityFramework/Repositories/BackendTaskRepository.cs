using Abp.EntityFramework;
using MyABP.IRepositories;
using MyABP.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyABP.EntityFramework.Repositories
{
    public class BackendTaskRepository : MyABPRepositoryBase<Task>, IBackendTaskRepository
    {
        public BackendTaskRepository(IDbContextProvider<MyABPDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        /// <summary>
        /// 获取某个用户分配了哪些任务
        /// </summary>
        /// <param name="personId">用户Id</param>
        /// <returns>任务列表</returns>
        public List<Task> GetTaskByAssignedPersonId(long personId)
        {
            var query = GetAll();

            if (personId > 0)
            {
                query = query.Where(t => t.AssignedPersonId == personId);
            }

            return query.ToList();
        }
    }
}
