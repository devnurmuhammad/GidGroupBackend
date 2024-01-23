using GidGroup.Application.Abstractions;
using GidGroup.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GidGroup.Infrastructure
{
    public static class GidGroupDependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IGidGroupApplicationDbContext, ApplicationDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("Postgres"), options => options.EnableRetryOnFailure());
            });

            return services;
        }
    }
}
