using EClinic.Framework.Data.Extentions;
using System.Threading.Tasks;

namespace EClinic.Framework.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public Task CommitAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public ApplicationDbContext GetDbContext()
        {
            return _dbContext;
        }

        public void Rollback()
        {
            _dbContext.Rollback();
        }
    }
}