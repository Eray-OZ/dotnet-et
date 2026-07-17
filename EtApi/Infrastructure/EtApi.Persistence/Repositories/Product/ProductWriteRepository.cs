using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Contexts;

namespace EtApi.Persistence.Repositories;

public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
{
    public ProductWriteRepository(EtApiDbContext context) : base(context) {}
}
