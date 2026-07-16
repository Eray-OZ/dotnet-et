using EtApi.Domain.Entities.Common;

namespace EtApi.Domain.Entities;

public class Product : BaseEntity
{
    public required string Name { get; set; }
    public int Stock { get; set; }
    public int Price { get; set; }
}
