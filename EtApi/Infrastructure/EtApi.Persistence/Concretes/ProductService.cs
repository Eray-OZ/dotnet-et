using EtApi.Application.Abstractions;
using EtApi.Domain.Entities;

namespace EtApi.Persistence.Concretes;

public class ProductService : IProductService
{
    public List<Product> GetProducts() 
    => new()
     {
         new() {Id = Guid.NewGuid(), Name = "Product 1", Price = 300, Stock = 10 },
         new() {Id = Guid.NewGuid(), Name = "Product 2", Price = 400, Stock = 10 },
         new() {Id = Guid.NewGuid(), Name = "Product 3", Price = 500, Stock = 10 },
         new() {Id = Guid.NewGuid(), Name = "Product 4", Price = 600, Stock = 10 },
         new() {Id = Guid.NewGuid(), Name = "Product 5", Price = 700, Stock = 10 },

     };
    
}
