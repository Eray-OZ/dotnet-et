using EtApi.Domain.Entities.Common;

namespace EtApi.Domain.Entities;

public class Customer : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}
