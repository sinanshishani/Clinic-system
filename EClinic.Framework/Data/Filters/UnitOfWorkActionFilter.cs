using Autofac;
using Microsoft.AspNetCore.Mvc.Filters;
using EClinic.Framework.Filters;
using EClinic.Framework.Threading;
using System.Threading.Tasks;

namespace EClinic.Framework.Data.Filters
{
    public class UnitOfWorkActionFilter : IActionFilter, IWebApiFilter
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWorkActionFilter(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception == null)
            {
                _dbContext.Database.CurrentTransaction.Commit();
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _dbContext.Database.BeginTransaction();
        }
    }
}