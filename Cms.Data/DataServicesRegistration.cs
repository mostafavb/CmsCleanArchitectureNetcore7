using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Cms.Data.Configurations;
using Microsoft.Extensions.Configuration;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Cms.Data;
public static class DataServicesRegistration
{
    public static IServiceCollection ConfigureDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CmsDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("CmsConnectinString")));
        //services.AddAutoMapper(typeof(AutomapperConfiguration));

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        //services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}