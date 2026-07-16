using EtApi.Domain.Entities;

namespace EtApi.Application.Abstractions;

public interface IProductService
{
    List<Product> GetProducts();
}
