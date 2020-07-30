using Microsoft.EntityFrameworkCore;

namespace EClinic.Framework.Data.Extentions
{
    public static class DbContextExtentions
    {
        public static void Rollback(this DbContext dbContext)
        {
            foreach (var entry in dbContext.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                    default: 
                        break;
                }
            }
        }
    }
}
