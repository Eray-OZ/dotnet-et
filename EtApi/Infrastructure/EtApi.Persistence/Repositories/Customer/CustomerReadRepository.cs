using EtApi.Application.Repositories;
using EtApi.Persistence.Contexts;
using EtApi.Domain.Entities;

namespace EtApi.Persistence.Repositories;

public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
{
    public CustomerReadRepository(EtApiDbContext context) : base(context)
    {}

}
