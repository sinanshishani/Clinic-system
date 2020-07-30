using Abp.Domain.Entities;
using EClinic.Framework.Data;
using EClinic.Framework.Repositories;

namespace Abp.EntityFramework.Repositories
{
    public class EfRepositoryBase<TEntity> : EfRepositoryBase<TEntity, long>, IRepository<TEntity>
        where TEntity : class, IEntity<long>
    {
        public EfRepositoryBase(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }
    }
}