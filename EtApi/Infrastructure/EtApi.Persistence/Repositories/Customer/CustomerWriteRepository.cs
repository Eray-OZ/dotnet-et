using EtApi.Application;
using EtApi.Domain.Entities;
using EtApi.Persistence.Contexts;
using EtApi.Persistence.Repositories;

namespace EtApi.Persistence.Repositories;

public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(EtApiDbContext context) : base(context) {}
}
