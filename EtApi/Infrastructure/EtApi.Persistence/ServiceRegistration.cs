using EtApi.Application.Abstractions;
using EtApi.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace EtApi.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();
    }
}
