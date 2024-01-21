using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GidGroup.Application
{
    public static class GidGroupDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
