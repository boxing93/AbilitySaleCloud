using AbilitySaleCloud.Articles.Models.DatabaseContext;
using AbilitySaleCloud.Articles.Models.Infrastructure.Filters;
using AbilitySaleCloud.Articles.Models.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AbilitySaleCloud.Articles.Models.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddDatabase(
            this IServiceCollection services,
            IConfiguration configuration)
            =>
                services
            .AddDbContext<ArticleContext>(options => options
                .UseSqlServer(configuration.GetDefaultConnectionString()));

        public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
            =>
                serviceCollection
                    .AddTransient<IArticleService, ArticleService>();

        public static void AddApiControllers(this IServiceCollection services)
            => services
                .AddControllers(options => options
                    .Filters
                    .Add<ModelOrNotFoundActionFilter>());
    }
}
