using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Contexts;

namespace EtApi.Persistence.Repositories;

public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
{
    public ProductReadRepository(EtApiDbContext context) : base(context) {}
}
