using EClinic.Framework.DependencyInjection;
using System.Threading.Tasks;

namespace EClinic.Framework.Data.UoW
{
    public interface IUnitOfWork : IScopedDependency
    {
        ApplicationDbContext GetDbContext();
        void Commit();
        Task CommitAsync();
        void Rollback();
    }
}