using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using Cms.Data.Data;
using Microsoft.EntityFrameworkCore;
using Cms.Core.Interfaces.Repository;
using Cms.Data.Repositories;

namespace Cms.Data;
public static class DataServicesRegistration
{
    public static IServiceCollection ConfigureDataServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CmsDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("CmsConnectinString")));

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        
        //services.AddAutoMapper(typeof(AutomapperConfiguration));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}