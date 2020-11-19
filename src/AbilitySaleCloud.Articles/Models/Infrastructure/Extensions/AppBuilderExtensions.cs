using AbilitySaleCloud.Articles.Models.DatabaseContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AbilitySaleCloud.Articles.Models.Infrastructure.Extensions
{
    public static class AppBuilderExtensions
    {
        public static void ApplyMigrations(this IApplicationBuilder app)
        {
            using var services = app.ApplicationServices.CreateScope();

            var dbContext = services.ServiceProvider.GetService<ArticleContext>();

            dbContext.Database.Migrate();
        }
    }
}
