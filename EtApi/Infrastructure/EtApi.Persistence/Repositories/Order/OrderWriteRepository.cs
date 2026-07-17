using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Contexts;

namespace EtApi.Persistence.Repositories;

public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
{
    public OrderWriteRepository(EtApiDbContext context) : base(context) {}
}
