using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Contexts;

namespace EtApi.Persistence.Repositories;

public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
{
    public OrderReadRepository(EtApiDbContext context) : base(context) {}
}
