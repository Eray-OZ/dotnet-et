using EtApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EtApi.Persistence.Contexts;

public class EtApiDbContext : DbContext
{
    public EtApiDbContext(DbContextOptions<EtApiDbContext> options) : base(options)
    {
    }


    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }

}
