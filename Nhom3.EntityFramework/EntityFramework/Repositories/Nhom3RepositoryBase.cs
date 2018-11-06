using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Nhom3.EntityFramework.Repositories
{
    public abstract class Nhom3RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<Nhom3DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected Nhom3RepositoryBase(IDbContextProvider<Nhom3DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class Nhom3RepositoryBase<TEntity> : Nhom3RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected Nhom3RepositoryBase(IDbContextProvider<Nhom3DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
