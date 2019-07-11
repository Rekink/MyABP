using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyABP.EntityFramework.Repositories
{
    public abstract class MyABPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyABPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyABPRepositoryBase(IDbContextProvider<MyABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyABPRepositoryBase<TEntity> : MyABPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyABPRepositoryBase(IDbContextProvider<MyABPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
