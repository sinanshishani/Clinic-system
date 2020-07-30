using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EClinic.Framework.Data.Extentions
{
    public static class ApplicationBuilderExtentions
    {
        public static void MigrateDatabase(this IApplicationBuilder app)
        {
            using IServiceScope scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using (ApplicationDbContext appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
            {
                appContext.Database.Migrate();
            }
        }
    }
}