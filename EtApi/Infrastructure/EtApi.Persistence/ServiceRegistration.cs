using EtApi.Application.Abstractions;
using EtApi.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EtApi.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<EtApiDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
    }
    
}
