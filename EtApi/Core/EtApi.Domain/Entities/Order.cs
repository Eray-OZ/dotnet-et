using EtApi.Domain.Entities.Common;

namespace EtApi.Domain.Entities;

public class Order : BaseEntity
{
    public Guid CustomerId { get; set; }
    public required string Description { get; set; }
    public required string Address { get; set; }
    public ICollection<Product> Products { get; set; }
    public Customer Customer { get; set; }
}
