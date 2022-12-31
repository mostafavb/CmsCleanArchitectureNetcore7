using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Cms.Core;
public static class ApplicationServicesRegistration
{
    public static IServiceCollection ConfigurationApplicationService(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
