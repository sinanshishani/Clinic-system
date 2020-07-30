using EClinic.Framework.Filters;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;
using System.Threading.Tasks;

namespace EClinic.Framework.Data.Filters
{
    public class UnitOfWorkExceptionFilter : IAsyncExceptionFilter, IWebApiFilter
    {
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWorkExceptionFilter(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ILogger Logger { get; set; }

        public Task OnExceptionAsync(ExceptionContext context)
        {
            return _dbContext.Database.CurrentTransaction.RollbackAsync();
        }
    }
}
